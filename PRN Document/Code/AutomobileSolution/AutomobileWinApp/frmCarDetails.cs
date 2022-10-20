using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.Repository;

namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {

        //-----------------------------------------------------------------
        public Boolean UpdateOrInsert { get; set; } //false: insert, true: update
        public Car CarInfor { get; set; }

        public ICarRepository CarRepository { get; set; }

        //-----------------------------------------------------------------
        public frmCarDetails()
        {
            InitializeComponent();
        }




        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !UpdateOrInsert;
            if (UpdateOrInsert)
            {
                if (CarInfor != null)
                {
                    this.txtCarID.Text = CarInfor.CarID.ToString();
                    //to convert int to string,  use int.ToString() method
                    this.txtCarName.Text = CarInfor.CarName;
                    this.cboManufacturer.Text = CarInfor.Manufacturer;
                    this.mtxtPrice.Text = CarInfor.Price.ToString();
                    this.mtxtReleasedYear.Text = CarInfor.ReleaseYear.ToString();
                }


            }
        }


        private void lbPrice_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int carID = int.Parse(txtCarID.Text);
                string carName = txtCarName.Text;
                string manufacturer = cboManufacturer.Text;
                decimal price = decimal.Parse(mtxtPrice.Text);
                int year = int.Parse(mtxtReleasedYear.Text);
                Car car = new Car(carID, carName, manufacturer, price, year);
                if (UpdateOrInsert)
                {
                    CarRepository.Update(car);
                }
                else
                {
                    CarRepository.Add(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, UpdateOrInsert ? "Add a Car" : "Insert a Car");
            }
        }

        private void txtCarID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
