namespace _6
{
    public partial class FormAddGroup : Form
    {

        int num;

        public FormAddGroup()
        {
            InitializeComponent();

            num = SQLQueries.GetLastGroupNum() + 1;
            Text = "Создание группы №" + num;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbRoom.Text == "")
                MessageBox.Show("Введите комнату для группы", "Ошибка");
            else
            {
                if (SQLQueries.IsRoomFree(Convert.ToInt32(tbRoom.Text)))
                {
                    SQLQueries.AddGroup(num, Convert.ToInt32(tbRoom.Text));
                    Close();
                }
                else
                {
                    DialogResult res = MessageBox.Show("Комната уже занята, все равно определить туда группу?", "Подтверждение", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.OK)
                    {
                        SQLQueries.AddGroup(num, Convert.ToInt32(tbRoom.Text));
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
