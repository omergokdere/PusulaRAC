using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PusulaRAC
{
    public partial class CarInspectionInfo : MetroFramework.Forms.MetroForm
    {
        public CarInspectionInfo()
        {
            InitializeComponent();
        }

        private void CarInspectionInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnListV_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
            {
                ConnectionString = @"Data Source=OG-PC;Initial Catalog=PusulaDB;Integrated Security=True"
            };
            string scmd = "select Plate,Brand,Model,Year,InspDate from tblVehicles where  ID > 0 ";



            using (SqlCommand cmdSQL = new SqlCommand())
            {
                if (!string.IsNullOrEmpty(tbSearchP.Text))
                {
                    scmd += " AND Plate Like @Plate";
                    cmdSQL.Parameters.Add("@Plate", SqlDbType.VarChar).Value = "%" + tbSearchP.Text + "%";
                }

                if (!string.IsNullOrEmpty(tbSearchB.Text))
                {
                    scmd += " AND Brand Like @Brand";
                    cmdSQL.Parameters.Add("@Brand", SqlDbType.VarChar).Value = "%" + tbSearchB.Text + "%";
                }

                if (!string.IsNullOrEmpty(tbSearchM.Text))
                {
                    scmd += " AND Model Like @Model";
                    cmdSQL.Parameters.Add("@Model", SqlDbType.VarChar).Value = "%" + tbSearchM.Text + "%";
                }

                if (!string.IsNullOrEmpty(tbSearchY.Text))
                {
                    scmd += " AND Year Like @Year";
                    cmdSQL.Parameters.Add("@Year", SqlDbType.VarChar).Value = "%" + tbSearchY.Text + "%";
                }
                // Add rest of conditions here like this

                cmdSQL.CommandText = scmd;
                cmdSQL.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmdSQL);
                SqlCommandBuilder cb = new SqlCommandBuilder();
                DataSet ds = new DataSet();
                da.Fill(ds);

                gvListV.DataSource = ds.Tables[0];
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            VehicleOperations vop = new VehicleOperations();
            vop.ShowDialog();
            this.Hide();
        }
    }
}
