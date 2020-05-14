using GestionCom.entity;
using GestionCom.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCom
{
    public partial class FrmConnexion : Form
    {
        private GestionComServiceBd service = new GestionComServiceBd();
        public FrmConnexion()
        {
            InitializeComponent();
        }

        FrmMenu frmMenu;
        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            
        }
       
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            //Validation
            Utilisateur user = service.SeConnecter(txtLogin.Text.Trim(), txtPwd.Text.Trim());
            if (user == null)
            {
                labelError.Visible = true;
            }
            else
            {
                frmMenu = new FrmMenu();
                frmMenu.Show();
                this.Hide();

            }
        }

        private void FrmConnexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
