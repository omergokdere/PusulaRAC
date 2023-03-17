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
    public partial class ClientOperations : MetroFramework.Forms.MetroForm
    {
        AddClient addClient = new AddClient();
        DeletedClients deletedClients = new DeletedClients();
        CompanyHistory companyHistory = new CompanyHistory();
        public ClientOperations()
        {
            InitializeComponent();
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            addClient.Show();
            this.Hide();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btnDeletedC_Click(object sender, EventArgs e)
        {
            deletedClients.Show();
            this.Hide();
        }

        private void btnClientHistory_Click(object sender, EventArgs e)
        {
            companyHistory.Show();
            this.Hide();
        }
    }
}
