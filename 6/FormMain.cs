namespace _6
{
    public enum StatusType
    {
        Default,
        Enrollments,
        Children,
        Parents,
        Groups
    }

    public partial class FormMain : Form
    {
        StatusType status = StatusType.Default;

        public FormMain()
        {
            InitializeComponent();

            dataGridView.Visible = false;
            btnAddChild.Visible = false;
            btnAddGroup.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnMore.Visible = false;
        }

        private void lbEnrollments_Click(object sender, EventArgs e)
        {
            status = StatusType.Enrollments;
            lbHelloText.Visible = false;
            dataGridView.Visible = true;
            btnAddChild.Visible = true;
            btnAddGroup.Visible = false;
            btnMore.Visible = false;
            btnEdit.Visible = true;
            btnDelete.Visible = true;

            ShowEnrollments();
        }

        void ShowEnrollments()
        {
            dataGridView.DataSource = SQLQueries.GetEnrollments();
            dataGridView.Columns[0].Visible = false;
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            FormAddChild form = new FormAddChild();
            form.ShowDialog();

            ShowEnrollments();
        }

        private void lbChildrens_Click(object sender, EventArgs e)
        {
            status = StatusType.Children;
            lbHelloText.Visible = false;
            dataGridView.Visible = true;
            btnAddChild.Visible = false;
            btnAddGroup.Visible = false;
            btnEdit.Visible = false;
            btnMore.Visible = true;
            btnMore.Location = new Point(btnDelete.Location.X, btnDelete.Location.Y);
            btnDelete.Visible = false;

            ShowChildren();
        }

        void ShowChildren()
        {
            dataGridView.DataSource = SQLQueries.GetChildren();
            dataGridView.Columns[0].Visible = false;
        }

        private void lbParents_Click(object sender, EventArgs e)
        {
            status = StatusType.Parents;
            lbHelloText.Visible = false;
            dataGridView.Visible = true;
            btnAddChild.Visible = false;
            btnAddGroup.Visible = false;
            btnEdit.Visible = false;
            btnMore.Visible = true;
            btnMore.Location = new Point(btnDelete.Location.X, btnDelete.Location.Y);
            btnDelete.Visible = false;

            ShowParents();
        }

        void ShowParents()
        {
            dataGridView.DataSource = SQLQueries.GetParents();
            dataGridView.Columns[0].Visible = false;
        }

        private void lbGroups_Click(object sender, EventArgs e)
        {
            status = StatusType.Groups;
            lbHelloText.Visible = false;
            dataGridView.Visible = true;
            btnAddChild.Visible = false;
            btnAddGroup.Visible = true;
            btnEdit.Visible = true;
            btnMore.Visible = true;
            btnMore.Location = new Point(btnEdit.Location.X - btnMore.Size.Width - 6, btnDelete.Location.Y);
            btnDelete.Visible = true;

            ShowGroups();
        }

        void ShowGroups()
        {
            dataGridView.DataSource = SQLQueries.GetGroups();
            dataGridView.Columns[0].Visible = false;
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            FormAddGroup form = new FormAddGroup();
            form.ShowDialog();

            ShowGroups();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                FormMore form = new FormMore();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                form.Status = status;
                form.Show();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                switch (status)
                {
                    case StatusType.Enrollments:
                        FormEditEnrollment enrollment = new FormEditEnrollment();
                        enrollment.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                        enrollment.ShowDialog();
                        ShowEnrollments();
                        break;

                    case StatusType.Groups:
                        FormEditGroup group = new FormEditGroup();
                        group.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                        group.ShowDialog();
                        ShowGroups();
                        break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                {
                    string message = string.Empty;
                    int id = Convert.ToInt32(dataGridView.SelectedRows[i].Cells[0].Value);
                    DialogResult res;

                    switch (status)
                    {
                        case StatusType.Enrollments:
                            string child = SQLQueries.GetChildFromID(id);
                            message = $"Вы уверены, что хотите удалить всю информацию о ребенке {child}?";
                            res = MessageBox.Show(message, "Подтверждение удаления", MessageBoxButtons.OKCancel);
                            if (res == DialogResult.OK)
                                SQLQueries.DeleteChild(SQLQueries.GetChildFromEnrollment(id));
                            break;

                        case StatusType.Groups:
                            int num = SQLQueries.GetGroupFromID(id);
                            if (!SQLQueries.IsGroupEmpty(id))
                                MessageBox.Show($"В группе №{num} числятся воспитанники, для начала переопределите их в другую группу.", "Ошибка");
                            else
                            {
                                message = $"Вы уверены, что хотите удалить группу №{num}?";
                                res = MessageBox.Show(message, "Подтверждение удаления", MessageBoxButtons.OKCancel);
                                if (res == DialogResult.OK)
                                    SQLQueries.DeleteGroup(id);
                            }
                            break;
                    }
                }

                switch (status)
                {
                    case StatusType.Enrollments:
                        ShowEnrollments();
                        break;
                    case StatusType.Groups:
                        ShowGroups();
                        break;
                }
            }
        }
    }
}