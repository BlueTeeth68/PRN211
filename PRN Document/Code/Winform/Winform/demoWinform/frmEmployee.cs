namespace demoWinform
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tao cac hanh dong truoc khi load form
            //Thuong thi ta se load database o buoc nay
            string[] arrDegree = new string[] {
                "Officer",
                "Fresher",
                "Junior",
                "Senior",
                "Major",
                "Manager"
            };

            this.cboDegree.Items.AddRange(arrDegree);
            this.cboDegree.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lbEmployeeID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtEmployeeID.Text = null;
            this.txtName.Text = null;
            this.mtxtPhoneNumber.Text = null;
            this.rdMale.Checked = true;
            this.cboDegree.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.dispose();
            //this.Hide();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int employeeID = int.Parse(txtEmployeeID.Text); //get value of txtEmployeeID element and convert to int
            string name = this.txtName.Text; // we can use this keyword to get this property.
            string phoneNumber = mtxtPhoneNumber.Text;
            Boolean gender = rdMale.Checked ? true : false; //if rdMale is checked then return true
            string degree = cboDegree.Text;
            MessageBox.Show($"ID: {employeeID}, Name: {name}, Phone number: {phoneNumber}, " +
                $"Gender: {(gender ? "Male" : "Female")}, Degree: {degree}"); //toan tu 3 ngoi trong string interpolation

        }
    }
}