namespace AnimalShelter
{
    public partial class Form1 : Form   // 다른 namespace에서도 사용 가능
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer("Ian", "Na", new DateTime(2000, 1, 1));
            cus.Address = "123 Wilshire Blvd.";

            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAdress.Text = cus.Address;
            CusIsQualified.Text = cus.IsQualified.ToString();
            CusDescription.Text = cus.Description;
        }
    }
}