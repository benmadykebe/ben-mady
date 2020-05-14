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
    public partial class FrmUser : Form
    {

        private GestionComServiceBd service = new GestionComServiceBd();

        public FrmUser()
        {
            InitializeComponent();
            service.listerUser(dtgvUser);
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            service.listerUser(dtgvUser);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Utilisateur user = new Utilisateur()
            {


                Login = txtLogin.Text,
                Pwd = txtPwd.Text,
                Nom = txtNom.Text,
                Prenom = txtPrenom.Text,
                Profil = cboProfil.SelectedItem.ToString()
            };

            service.CreerUser(user);
            service.listerUser(dtgvUser);
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Entrer le login")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.Black;
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Entrer le login";
                txtLogin.ForeColor = Color.Silver;
            }
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {
            if (txtPwd.Text == "Entrer le mot de passe")
            {
                txtPwd.Text = "";
                txtPwd.ForeColor = Color.Black;
            }
        }

        private void txtPwd_Leave(object sender, EventArgs e)
        {
            if (txtPwd.Text == "")
            {
                txtPwd.Text = "Entrer le mot de passe";
                txtPwd.ForeColor = Color.Silver;
            }
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Entrer le nom")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Entrer le nom";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "Entrer le prenom")
            {
                txtPrenom.Text = "";
                txtPrenom.ForeColor = Color.Black;
            }
        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "")
            {
                txtPrenom.Text = "Entrer le prenom";
                txtPrenom.ForeColor = Color.Silver;
            }
        }

        private void cboProfil_Enter(object sender, EventArgs e)
        {
            if (cboProfil.Text == "Selectionner le profil")
            {
                cboProfil.Text = "";
                cboProfil.ForeColor = Color.Black;
            }
        }

        private void cboProfil_Leave(object sender, EventArgs e)
        {
            if (cboProfil.Text == "")
            {
                cboProfil.Text = "Selectionner le profil";
                cboProfil.ForeColor = Color.Silver;
            }
        }

        private void FrmUser_Load_1(object sender, EventArgs e)
        {

        }
    }
}
