namespace _6
{
    public partial class FormEditEnrollment : Form
    {
        int id;

        public int Id
        {
            set
            {
                id = value;
                FillTextBoxes();
            }
        }

        public FormEditEnrollment()
        {
            InitializeComponent();

            List<int> groups = SQLQueries.GetGroupsList();
            foreach (int group in groups)
                cbGroup.Items.Add(group);

            List<string> parents = SQLQueries.GetParentsList();
            foreach (string parent in parents)
                cbParent.Items.Add(parent);
        }

        private void FillTextBoxes()
        {
            List<string> child = SQLQueries.GetChildToEdit(id);
            tbChildLastName.Text = child[0];
            tbChildFirstName.Text = child[1];
            tbChildMiddleName.Text = child[2];
            cbGender.Text = child[3];
            dtpBirthday.Value = DateTime.Parse(child[4]);
            tbAddress.Text = child[5];
            rtbInfo.Text = child[6];
            cbGroup.Text = child[7];
            cbParent.Text = child[8];
        }

        private void FillParent()
        {
            List<string> parent = SQLQueries.GetParentToEdit(Convert.ToInt32(cbParent.Text.Split(" ")[^1].Substring(2)));
            tbParentLastName.Text = parent[0];
            tbParentFirstName.Text = parent[1];
            tbParentMiddleName.Text = parent[2];
            tbPhone.Text = parent[3];
            tbEmail.Text = parent[4];
        }

        private void cbParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillParent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbChildLastName.Text == "")
                MessageBox.Show("Введите фамилию ребенка", "Ошибка");
            else
            {
                if (tbChildFirstName.Text == "")
                    MessageBox.Show("Введите имя ребенка", "Ошибка");
                else
                {
                    if (tbAddress.Text == "")
                        MessageBox.Show("Введите адрес", "Ошибка");
                    else
                    {
                        if (tbParentLastName.Text == "")
                            MessageBox.Show("Введите фамилию родителя", "Ошибка");
                        else
                        {
                            if (tbParentFirstName.Text == "")
                                MessageBox.Show("Введите имя родителя", "Ошибка");
                            else
                            {
                                if (SQLQueries.IsParentExist(tbParentFirstName.Text, tbParentLastName.Text, tbParentMiddleName.Text, tbPhone.Text, Convert.ToInt32(cbParent.Text.Split(" ")[^1].Substring(2))))
                                {
                                    MessageBox.Show("Родитель с таким именем и номером телефона уже существует", "Ошибка");
                                    return;
                                }
                                int childID = SQLQueries.GetChildFromEnrollment(id);
                                int parentID = Convert.ToInt32(cbParent.Text.Split(" ")[^1].Substring(2));
                                SQLQueries.UpdateChild(childID, tbChildLastName.Text, tbChildFirstName.Text, tbChildMiddleName.Text, cbGender.Text, dtpBirthday.Text, tbAddress.Text, rtbInfo.Text);
                                SQLQueries.UpdateChildGroup(childID, Convert.ToInt32(cbGroup.Text));
                                SQLQueries.UpdateParent(parentID, tbParentLastName.Text, tbParentFirstName.Text, tbParentMiddleName.Text, tbPhone.Text, tbEmail.Text);
                                SQLQueries.UpdateRelationship(childID, parentID);
                                Close();
                            }
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
