using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PusulaRAC
{
    public partial class CompanyHistory : MetroFramework.Forms.MetroForm
    { 
        public CompanyHistory()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClientOperations clientOperations = new ClientOperations();
            clientOperations.Show();
            this.Hide();

        }
    }
}
