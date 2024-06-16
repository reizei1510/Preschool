namespace _6
{
    public partial class FormAddChild : Form
    {
        public FormAddChild()
        {
            InitializeComponent();

            List<int> groups = SQLQueries.GetGroupsList();
            foreach (int group in groups)
                cbGroup.Items.Add(group);

            gbParent.Size = new Size(506, 56);
            cbParent.Items.Add("Добавить родителя...");
            List<string> parents = SQLQueries.GetParentsList();
            foreach (string parent in parents)
                cbParent.Items.Add(parent);
        }

        private void cbParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbParent.SelectedIndex == 0)
                gbParent.Size = new Size(506, 161);
            else
                gbParent.Size = new Size(506, 56);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbChildLastName.Text == "")
                MessageBox.Show("Введите фамилию ребенка", "Ошибка");
            else
            {
                if (tbChildFirstName.Text == "")
                    MessageBox.Show("Введите имя ребенка", "Ошибка");
                else
                {
                    if (cbGender.SelectedItem == null)
                        MessageBox.Show("Выберите пол", "Ошибка");
                    else
                    {
                        if (cbGroup.SelectedItem == null)
                            MessageBox.Show("Выберите группу", "Ошибка");
                        else
                        {
                            if (tbAddress.Text == "")
                                MessageBox.Show("Введите адрес", "Ошибка");
                            else
                            {
                                if (cbParent.SelectedItem == null)
                                    MessageBox.Show("Выберите или добавьте родителя", "Ошибка");
                                else
                                {
                                    if (cbParent.SelectedIndex == 0 && tbParentLastName.Text == "")
                                        MessageBox.Show("Введите фамилию родителя", "Ошибка");
                                    else
                                    {
                                        if (cbParent.SelectedIndex == 0 && tbParentFirstName.Text == "")
                                            MessageBox.Show("Введите имя родителя", "Ошибка");
                                        else
                                        {
                                            if (cbParent.SelectedIndex == 0)
                                            {
                                                if (SQLQueries.IsParentExist(tbParentFirstName.Text, tbParentLastName.Text, tbParentMiddleName.Text, tbPhone.Text))
                                                {
                                                    MessageBox.Show("Родитель с таким именем и номером телефона уже существует", "Ошибка");
                                                    return;
                                                }
                                                SQLQueries.AddChild(tbChildLastName.Text, tbChildFirstName.Text, tbChildMiddleName.Text, cbGender.Text, dtpBirthday.Text, tbAddress.Text, rtbInfo.Text);
                                                SQLQueries.AddParent(tbParentFirstName.Text, tbParentLastName.Text, tbParentMiddleName.Text, tbPhone.Text, tbEmail.Text);
                                                SQLQueries.AddRelationship(SQLQueries.GetLastChild(), SQLQueries.GetLastParent());
                                            }
                                            else
                                            {
                                                SQLQueries.AddChild(tbChildLastName.Text, tbChildFirstName.Text, tbChildMiddleName.Text, cbGender.Text, dtpBirthday.Text, tbAddress.Text, rtbInfo.Text);
                                                SQLQueries.AddRelationship(SQLQueries.GetLastChild(), Convert.ToInt32(cbParent.Text.Split(' ')[^1].Substring(2)));
                                            }
                                            SQLQueries.AddChildInGroup(SQLQueries.GetLastChild(), Convert.ToInt32(cbGroup.Text));
                                            Close();
                                        }
                                    }
                                }
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
