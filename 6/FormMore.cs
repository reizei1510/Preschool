namespace _6
{
    public partial class FormMore : Form
    {
        StatusType status;
        int id;

        public StatusType Status
        {
            set
            {
                status = value;
                ShowInfo();
            }
        }
        public int Id
        {
            set
            {
                id = value;
            }
        }

        public FormMore()
        {
            InitializeComponent();
        }

        void ShowInfo()
        {
            switch (status)
            {
                case StatusType.Children:
                    Text = $"Информация о ребенке {SQLQueries.GetChildFromID(id)}";
                    rtbInfo.Text = SQLQueries.GetChildInfo(id);
                    break;
                case StatusType.Parents:
                    Text = $"Информация о родителе {SQLQueries.GetParentFromID(id)}";
                    rtbInfo.Text = SQLQueries.GetParentInfo(id);
                    break;
                case StatusType.Groups:
                    Text = $"Информация о группе №{SQLQueries.GetGroupFromID(id)}";
                    rtbInfo.Text = SQLQueries.GetGroupInfo(id);
                    break;
            }
        }
    }
}
