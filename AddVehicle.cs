using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PusulaRAC
{
    public partial class AddVehicle : MetroFramework.Forms.MetroForm
    {

        public AddVehicle()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            VehicleOperations vehicleOperations1 = new VehicleOperations();
            this.Hide();
            vehicleOperations1.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbPlate.Text == "" || tbBrand.Text == "" || tbModel.Text == "" || tbYear.Text == "" || tbColor.Text == "" || tbClass.Text == "" || tbInspDate.Text == "" || tbLicence.Text == "" || tbBP.Text == "" || tbBD.Text == "")
            {
                MessageBox.Show("Gerekli alanlari Doldurunuz !!!");

            }
            else
            {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

                SqlCommand scmd = new SqlCommand("INSERT INTO tblVehicles(Plate,Brand,Model,Year,Color,Class,InspDate,Licence,BuyingPrice,SellingPrice,BuyingDate,SellingDate ) VALUES ('" + tbPlate.Text + "' ,'" + tbBrand.Text + "' ,'" + tbModel.Text + "' ,'" + tbYear.Text + "' ,'" + tbColor.Text + "' ,'" + tbClass.Text + "' ,'" + tbInspDate.Text + "' ,'" + tbLicence.Text + "' ,'" + tbBP.Text + "' ,'" + tbSP.Text + "','" + tbBD.Text + "' ,'" + tbSD.Text + "');", con);
                con.Open();
                scmd.ExecuteNonQuery();

                VehicleOperations vehicleOperations1 = new VehicleOperations();
                this.Hide();
                vehicleOperations1.ShowDialog();
            }

        }
    }
}
