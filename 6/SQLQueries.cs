using Npgsql;
using System.Data;
using System.Net;

namespace _6
{
    internal static class SQLQueries
    {
        static NpgsqlConnection conn;
        static string connString = "Host=127.0.0.1;Port=5432;Username=postgres;Password=123;Database=preschool";
        static NpgsqlCommand cmd;
        static NpgsqlDataAdapter adap;
        static NpgsqlDataReader reader;

        static SQLQueries()
        {
            conn = new NpgsqlConnection(connString);
            conn.Open();
        }

        internal static void AddChild(string lastName, string firstName, string middleName, string gender, string birthday, string address, string info)
        {
            cmd = new NpgsqlCommand("INSERT INTO children (first_name, last_name, middle_name, gender, birthday, address, information) " +
                                    "VALUES (@first_name, @last_name, @middle_name, @gender, @birthday, @address, @information)", conn);
            cmd.Parameters.AddWithValue("first_name", firstName);
            cmd.Parameters.AddWithValue("last_name", lastName);
            cmd.Parameters.AddWithValue("middle_name", middleName);
            cmd.Parameters.AddWithValue("gender", gender);
            cmd.Parameters.AddWithValue("birthday", DateTime.Parse(birthday));
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("information", info);
            cmd.ExecuteNonQuery();

            AddEnrollment(GetLastChild());
        }

        internal static void AddEnrollment(int childID)
        {
            cmd = new NpgsqlCommand("INSERT INTO enrollments (childID, enrollment_date) " +
                                    "VALUES (@childID, NOW())", conn);
            cmd.Parameters.AddWithValue("childID", childID);
            cmd.ExecuteNonQuery();
        }

        internal static void AddChildInGroup(int childID, int num)
        {
            cmd = new NpgsqlCommand("INSERT INTO grouplists (groupID, childID) " +
                                    "VALUES ((SELECT groupID FROM groupsdata WHERE num = @num), @childID)", conn);
            cmd.Parameters.AddWithValue("num", num);
            cmd.Parameters.AddWithValue("childID", childID);
            cmd.ExecuteNonQuery();
        }

        internal static void AddParent(string lastName, string firstName, string middleName, string phone, string email)
        {
            cmd = new NpgsqlCommand("INSERT INTO parents (first_name, last_name, middle_name, phone, email) " +
                                    "VALUES (@first_name, @last_name, @middle_name, @phone, @email)", conn);
            cmd.Parameters.AddWithValue("first_name", firstName);
            cmd.Parameters.AddWithValue("last_name", lastName);
            cmd.Parameters.AddWithValue("middle_name", middleName);
            cmd.Parameters.AddWithValue("phone", phone);
            cmd.Parameters.AddWithValue("email", email);
            cmd.ExecuteNonQuery();
        }

        internal static void AddRelationship(int childID, int parentID)
        {
            cmd = new NpgsqlCommand("INSERT INTO relationships (childID, parentID) " +
                                    "VALUES (@childID, @parentID)", conn);
            cmd.Parameters.AddWithValue("childID", childID);
            cmd.Parameters.AddWithValue("parentID", parentID);
            cmd.ExecuteNonQuery();
        }

        internal static void AddGroup(int num, int room)
        {
            cmd = new NpgsqlCommand("INSERT INTO groupsdata (num, room) " +
                                    "VALUES (@num, @room)", conn);
            cmd.Parameters.AddWithValue("num", num);
            cmd.Parameters.AddWithValue("room", room);
            cmd.ExecuteNonQuery();
        }

        internal static void UpdateChild(int childID, string lastName, string firstName, string middleName, string gender, string birthday, string address, string info)
        {
            cmd = new NpgsqlCommand("UPDATE children SET first_name = @first_name, last_name = @last_name, middle_name = @middle_name, " +
                                    "gender = @gender, birthday = @birthday, address = @address, information = @information " +
                                    "WHERE childID = @childID", conn);
            cmd.Parameters.AddWithValue("first_name", firstName);
            cmd.Parameters.AddWithValue("last_name", lastName);
            cmd.Parameters.AddWithValue("middle_name", middleName);
            cmd.Parameters.AddWithValue("gender", gender);
            cmd.Parameters.AddWithValue("birthday", DateTime.Parse(birthday));
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("information", info);
            cmd.Parameters.AddWithValue("childID", childID);
            cmd.ExecuteNonQuery();
        }

        internal static void UpdateChildGroup(int childID, int num)
        {
            cmd = new NpgsqlCommand("UPDATE grouplists SET groupID = (SELECT groupID FROM groupsdata WHERE num = @num) " +
                                    "WHERE childID = @childID", conn);
            cmd.Parameters.AddWithValue("num", num);
            cmd.Parameters.AddWithValue("childID", childID);
            cmd.ExecuteNonQuery();
        }

        internal static void UpdateParent(int parentID, string lastName, string firstName, string middleName, string phone, string email)
        {
            cmd = new NpgsqlCommand("UPDATE parents SET first_name = @first_name, last_name = @last_name, " +
                                    "middle_name = @middle_name, phone = @phone, email = @email " +
                                    "WHERE parentID = @parentID", conn);
            cmd.Parameters.AddWithValue("first_name", firstName);
            cmd.Parameters.AddWithValue("last_name", lastName);
            cmd.Parameters.AddWithValue("middle_name", middleName);
            cmd.Parameters.AddWithValue("phone", phone);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("parentID", parentID);
            cmd.ExecuteNonQuery();
        }

        internal static void UpdateRelationship(int childID, int parentID)
        {
            cmd = new NpgsqlCommand("UPDATE relationships SET parentID = @parentID " +
                                    "WHERE childID = @childID", conn);
            cmd.Parameters.AddWithValue("childID", childID);
            cmd.Parameters.AddWithValue("parentID", parentID);
            cmd.ExecuteNonQuery();

            DeleteEmptyParents();
        }

        internal static void UpdateGroup(int groupID, int room)
        {
            cmd = new NpgsqlCommand("UPDATE groupsdata SET room = @room " +
                                    "WHERE groupID = @groupID", conn);
            cmd.Parameters.AddWithValue("room", room);
            cmd.Parameters.AddWithValue("groupID", groupID);
            cmd.ExecuteNonQuery();

            DeleteEmptyParents();
        }

        internal static void DeleteEmptyParents()
        {
            cmd = new NpgsqlCommand("DELETE FROM parents WHERE parentID != ALL " +
                                    "(SELECT parentID FROM relationships)", conn);
            cmd.ExecuteNonQuery();
        }

        internal static void DeleteChild(int childID)
        {
            cmd = new NpgsqlCommand("DELETE FROM children " +
                                    "WHERE childID = @childID", conn);
            cmd.Parameters.AddWithValue("childID", childID);
            cmd.ExecuteNonQuery();

            DeleteEmptyParents();
        }

        internal static void DeleteGroup(int groupID)
        {
            cmd = new NpgsqlCommand("DELETE FROM groupsdata " +
                                    "WHERE groupID = @groupID", conn);
            cmd.Parameters.AddWithValue("groupID", groupID);
            cmd.ExecuteNonQuery();
        }

        internal static DataTable GetEnrollments()
        {
            DataTable dt = new DataTable();
            adap = new NpgsqlDataAdapter("SELECT enrollments.enrollmentID AS ID, enrollments.enrollment_date AS Дата, " +
                                         "children.last_name AS Фамилия, children.first_name AS Имя, children.middle_name AS Отчество " +
                                         "FROM enrollments, children " +
                                         "WHERE enrollments.childID = children.childID", conn);
            adap.Fill(dt);

            return dt;
        }

        internal static DataTable GetChildren()
        {
            DataTable dt = new DataTable();
            adap = new NpgsqlDataAdapter("SELECT childID AS ID, last_name AS Фамилия, first_name AS Имя, middle_name AS Отчество " +
                                         "FROM children", conn);
            adap.Fill(dt);

            return dt;
        }

        internal static DataTable GetParents()
        {
            DataTable dt = new DataTable();
            adap = new NpgsqlDataAdapter("SELECT parentID AS ID, last_name AS Фамилия, first_name AS Имя, middle_name AS Отчество " +
                                         "FROM parents", conn);
            adap.Fill(dt);

            return dt;
        }

        internal static DataTable GetGroups()
        {
            DataTable dt = new DataTable();
            adap = new NpgsqlDataAdapter("SELECT groupID AS ID, num AS Номер " +
                                         "FROM groupsdata", conn);
            adap.Fill(dt);

            return dt;
        }

        internal static string GetChildFromID(int childID)
        {
            string child;

            cmd = new NpgsqlCommand("SELECT last_name, first_name, middle_name FROM children " +
                                    "WHERE childID = @childID", conn);
            cmd.Parameters.AddWithValue("childID", childID);
            reader = cmd.ExecuteReader();
            reader.Read();
            child = $"{reader.GetValue(0)} {reader.GetValue(1)} {reader.GetValue(2)}";
            reader.Close();

            return child;
        }
        internal static string GetParentFromID(int parentID)
        {
            string parent;

            cmd = new NpgsqlCommand("SELECT last_name, first_name, middle_name FROM parents " +
                                    "WHERE parentID = @parentID", conn);
            cmd.Parameters.AddWithValue("parentID", parentID);
            reader = cmd.ExecuteReader();
            reader.Read();
            parent = $"{reader.GetValue(0)} {reader.GetValue(1)} {reader.GetValue(2)}";
            reader.Close();

            return parent;
        }
        internal static int GetGroupFromID(int groupID)
        {
            int num;

            cmd = new NpgsqlCommand("SELECT num FROM groupsdata " +
                                    "WHERE groupID = @groupID", conn);
            cmd.Parameters.AddWithValue("groupID", groupID);
            num = Convert.ToInt32(cmd.ExecuteScalar());

            return num;
        }

        internal static bool IsParentExist(string lastName, string firstName, string middleName, string phone, int parentID = 0)
        {
            cmd = new NpgsqlCommand("SELECT COUNT(*) FROM parents " +
                                    "WHERE first_name = @first_name AND last_name = @last_name AND middle_name = @middle_name AND phone = @phone " +
                                    "AND parentID != @parentID", conn);
            cmd.Parameters.AddWithValue("first_name", firstName);
            cmd.Parameters.AddWithValue("last_name", lastName);
            cmd.Parameters.AddWithValue("middle_name", middleName);
            cmd.Parameters.AddWithValue("phone", phone);
            cmd.Parameters.AddWithValue("parentID", parentID);

            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                return false;
            return true;
        }

        internal static bool IsRoomFree(int room)
        {
            cmd = new NpgsqlCommand("SELECT COUNT(*) FROM groupsdata " +
                                    "WHERE room = @room", conn);
            cmd.Parameters.AddWithValue("room", room);
            bool free = Convert.ToInt32(cmd.ExecuteScalar()) == 0;

            return free;
        }

        internal static bool IsGroupEmpty(int groupID)
        {
            bool empty;

            cmd = new NpgsqlCommand("SELECT COUNT(*) FROM grouplists " +
                                    "WHERE groupID = @groupID", conn);
            cmd.Parameters.AddWithValue("groupID", groupID);
            empty = Convert.ToInt32(cmd.ExecuteScalar()) == 0;

            return empty;
        }

        internal static int GetLastChild()
        {
            cmd = new NpgsqlCommand("SELECT childID FROM children ORDER BY childID DESC LIMIT 1", conn);
            int childID = Convert.ToInt32(cmd.ExecuteScalar());

            return childID;
        }

        internal static int GetLastParent()
        {
            cmd = new NpgsqlCommand("SELECT parentID FROM parents ORDER BY parentID DESC LIMIT 1", conn);
            int parentID = Convert.ToInt32(cmd.ExecuteScalar());

            return parentID;
        }

        internal static int GetLastGroupNum()
        {
            int num;
            cmd = new NpgsqlCommand("SELECT num FROM groupsdata ORDER BY groupID DESC LIMIT 1", conn);
            num = Convert.ToInt32(cmd.ExecuteScalar());

            return num;
        }

        internal static List<int> GetGroupsList()
        {
            List<int> groups = new List<int>();
            cmd = new NpgsqlCommand("SELECT num FROM groupsdata", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                groups.Add(Convert.ToInt32(reader.GetValue(0)));
            reader.Close();

            return groups;
        }

        internal static List<string> GetParentsList()
        {
            List<string> parents = new List<string>();
            cmd = new NpgsqlCommand("SELECT parentID, last_name, first_name, middle_name, phone FROM parents", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                parents.Add($"{reader.GetValue(1)} {reader.GetValue(2)} {reader.GetValue(3)} {reader.GetValue(4)} id{reader.GetValue(0)}");
            reader.Close();

            return parents;
        }

        internal static List<string> GetChildrenListOfParent(int parentID)
        {
            List<int> childrenID = new List<int>();
            cmd = new NpgsqlCommand("SELECT childID FROM grouplists " +
                                    "WHERE groupID = @groupID", conn);
            cmd.Parameters.AddWithValue("groupID", parentID);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                childrenID.Add(Convert.ToInt32(reader[0]));
            reader.Close();

            List<string> children = new List<string>();
            foreach (int childID in childrenID)
            {
                cmd = new NpgsqlCommand("SELECT last_name, first_name, middle_name FROM children " +
                                        "WHERE childID = @childID", conn);
                cmd.Parameters.AddWithValue("childID", childID);
                reader = cmd.ExecuteReader();
                reader.Read();
                children.Add($"{reader[0]} {reader[1]} {reader[2]}");
                reader.Close();
            }

            return children;
        }

        internal static List<string> GetChildrenListOfGroup(int groupID)
        {
            List<int> childrenID = new List<int>();
            cmd = new NpgsqlCommand("SELECT childID FROM grouplists " +
                                    "WHERE groupID = @groupID", conn);
            cmd.Parameters.AddWithValue("groupID", groupID);
            reader = cmd.ExecuteReader();
            while (reader.Read())
                childrenID.Add(Convert.ToInt32(reader[0]));
            reader.Close();

            List<string> children = new List<string>();
            foreach (int childID in childrenID)
            {
                cmd = new NpgsqlCommand("SELECT last_name, first_name, middle_name FROM children " +
                                        "WHERE childID = @childID", conn);
                cmd.Parameters.AddWithValue("childID", childID);
                reader = cmd.ExecuteReader();
                reader.Read();
                children.Add($"{reader[0]} {reader[1]} {reader[2]}");
                reader.Close();
            }

            return children;
        }

        internal static string GetChildInfo(int childID)
        {
            string info = string.Empty;
            cmd = new NpgsqlCommand("SELECT groupsdata.num, children.gender, children.birthday, children.address, " +
                                    "children.information, parents.last_name, parents.first_name, parents.middle_name, " +
                                    "parents.phone, parents.email, enrollments.enrollment_date " +
                                    "FROM children, groupsdata, parents, enrollments " +
                                    "WHERE children.childID = @childID AND enrollments.childID = @childID AND " +
                                    "groupsdata.groupID = (SELECT groupID FROM grouplists WHERE childID = @childID) AND " +
                                    "parents.parentID = (SELECT parentID FROM relationships WHERE childID = @childID)", conn);
            cmd.Parameters.AddWithValue("childID", childID);
            reader = cmd.ExecuteReader();
            reader.Read();
            info += $"Группа: {reader[0]}\nПол: {reader[1]}\nДень рождения: {reader[2].ToString().Remove(10)}\nАдрес: {reader[3]}\nИнформация: {reader[4]}";
            info += $"\nИмя родителя: {reader[5]} {reader[6]} {reader[7]}\nТелефон: {reader[8]}\nЭлектронная почта: {reader[9]}";
            info += $"\nЗачислен: {reader[10].ToString().Remove(10)}";
            reader.Close();

            return info;
        }

        internal static string GetParentInfo(int parentID)
        {
            string info = string.Empty;

            cmd = new NpgsqlCommand("SELECT phone, email " +
                                    "FROM parents WHERE parentID = @parentID", conn);
            cmd.Parameters.AddWithValue("parentID", parentID);
            reader = cmd.ExecuteReader();
            reader.Read();
            info += $"Телефон: {reader[0]}\nЭлектронная почта: {reader[1]}";
            reader.Close();

            info += $"\nДети:";
            List<string> children = GetChildrenListOfParent(parentID);
            foreach (string child in children)
                info += $"\n{child}";

            return info;
        }

        internal static string GetGroupInfo(int groupID)
        {
            string info = string.Empty;

            cmd = new NpgsqlCommand("SELECT room FROM groupsdata WHERE groupID = @groupID", conn);
            cmd.Parameters.AddWithValue("groupID", groupID);
            int room = Convert.ToInt32(cmd.ExecuteScalar());
            info += $"Комната: {room}";

            cmd = new NpgsqlCommand("SELECT COUNT(*) FROM grouplists WHERE groupID = @groupID", conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            info += $"\nКоличество детей: {count}";

            info += $"\nСостав:";
            List<string> children = GetChildrenListOfGroup(groupID);
            foreach (string child in children)
                info += $"\n{child}";

            return info;
        }

        internal static int GetChildFromEnrollment(int enrollmentID)
        {
            cmd = new NpgsqlCommand("SELECT childID FROM enrollments WHERE enrollmentID = @enrollmentID", conn);
            cmd.Parameters.AddWithValue("enrollmentID", enrollmentID);
            int childID = Convert.ToInt32(cmd.ExecuteScalar());

            return childID;
        }

        internal static int GetParentFromChild(int childID)
        {
            cmd = new NpgsqlCommand("SELECT parentID FROM relationships WHERE childID = @childID", conn);
            cmd.Parameters.AddWithValue("childID", childID);
            int parentID = Convert.ToInt32(cmd.ExecuteScalar());

            return parentID;
        }

        internal static List<string> GetChildToEdit(int childID)
        {
            List<string> child = new List<string>();
            cmd = new NpgsqlCommand("SELECT children.last_name, children.first_name, children.middle_name," +
                                    "children.gender, children.birthday, children.address, children.information, groupsdata.num, " +
                                    "parents.parentID, parents.last_name, parents.first_name, parents.middle_name, parents.phone " +
                                    "FROM children, groupsdata, parents, enrollments " +
                                    "WHERE children.childID = @childID " +
                                    "AND groupsdata.groupID = (SELECT groupID FROM grouplists WHERE childID = @childID) " +
                                    "AND parents.parentID = (SELECT parentID FROM relationships WHERE childID = @childID)", conn);
            cmd.Parameters.AddWithValue("childID", childID);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                child.Add(reader.GetValue(0).ToString());
                child.Add(reader.GetValue(1).ToString());
                child.Add(reader.GetValue(2).ToString());
                child.Add(reader.GetValue(3).ToString());
                child.Add(reader.GetValue(4).ToString());
                child.Add(reader.GetValue(5).ToString());
                child.Add(reader.GetValue(6).ToString());
                child.Add(reader.GetValue(7).ToString());
                child.Add($"{reader.GetValue(9)} {reader.GetValue(10)} {reader.GetValue(11)} {reader.GetValue(12)} id{reader.GetValue(8)}");
            }
            reader.Close();

            return child;
        }

        internal static List<string> GetParentToEdit(int parentID)
        {
            List<string> parent = new List<string>();
            cmd = new NpgsqlCommand("SELECT last_name, first_name, middle_name, phone, email FROM parents " +
                                    "WHERE parentID = @parentID", conn);
            cmd.Parameters.AddWithValue("parentID", parentID);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                parent.Add(reader.GetValue(0).ToString());
                parent.Add(reader.GetValue(1).ToString());
                parent.Add(reader.GetValue(2).ToString());
                parent.Add(reader.GetValue(3).ToString());
                parent.Add(reader.GetValue(4).ToString());
            }
            reader.Close();

            return parent;
        }

        internal static string GetRoomToEdit(int groupID)
        {
            string room;
            cmd = new NpgsqlCommand("SELECT room FROM groupsdata " +
                                    "WHERE groupID = @groupID", conn);
            cmd.Parameters.AddWithValue("groupID", groupID);
            room = cmd.ExecuteScalar().ToString();

            return room;
        }
    }
}
