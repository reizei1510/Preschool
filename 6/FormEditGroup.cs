using System;

namespace _6
{
    public partial class FormEditGroup : Form
    {
        int id;

        public int Id
        {
            set
            {
                id = value;
                FillTextBox();
            }
        }

        public FormEditGroup()
        {
            InitializeComponent();
        }

        private void FillTextBox()
        {
            string room = SQLQueries.GetRoomToEdit(id);
            tbRoom.Text = room;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbRoom.Text == "")
                MessageBox.Show("Введите комнату для группы", "Ошибка");
            else
            {
                if (SQLQueries.IsRoomFree(Convert.ToInt32(tbRoom.Text)))
                {
                    SQLQueries.UpdateGroup(id, Convert.ToInt32(tbRoom.Text));
                    Close();
                }
                else
                {
                    DialogResult res = MessageBox.Show("Комната уже занята, все равно определить туда группу?", "Подтверждение", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.OK)
                    {
                        SQLQueries.UpdateGroup(id, Convert.ToInt32(tbRoom.Text));
                        Close();
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
