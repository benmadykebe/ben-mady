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
    public partial class FrmCommande : Form
    {
        public FrmCommande()
        {
            InitializeComponent();
        }

        private void FrmCommande_Load(object sender, EventArgs e)
        {
            EnableControl();
        }

        private void EnableControl()
        {
            foreach (var control in pnelNewClient.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Enabled=false;
                }
                bntEnregistrer.Enabled = false;

            }

        }

        private void bntEnregistrer_Click(object sender, EventArgs e)
        {

        }
    //


        private void txtNomSearch_Enter(object sender, EventArgs e)
        {
            if (txtNomSearch.Text == "Nom")
            {
                txtNomSearch.Text = "";
                txtNomSearch.ForeColor = Color.Black;
            }
        }

        private void txtNomSearch_Leave(object sender, EventArgs e)
        {
            if (txtNomSearch.Text == "")
            {
                txtNomSearch.Text = "Nom";
                txtNomSearch.ForeColor = Color.Silver;
            }
        }

        private void txtPrenomSearch_Enter(object sender, EventArgs e)
        {
            if (txtPrenomSearch.Text == "Prenom")
            {
                txtPrenomSearch.Text = "";
                txtPrenomSearch.ForeColor = Color.Black;
            }
        }

        private void txtPrenomSearch_Leave(object sender, EventArgs e)
        {
            if (txtPrenomSearch.Text == "")
            {
                txtPrenomSearch.Text = "Prenom";
                txtPrenomSearch.ForeColor = Color.Silver;
            }
        }

        private void txtAdresseSearch_Enter(object sender, EventArgs e)
        {
            if (txtAdresseSearch.Text == "Adresse")
            {
                txtAdresseSearch.Text = "";
                txtAdresseSearch.ForeColor = Color.Black;
            }
        }

        private void txtAdresseSearch_Leave(object sender, EventArgs e)
        {
            if (txtAdresseSearch.Text == "")
            {
                txtAdresseSearch.Text = "Adresse";
                txtAdresseSearch.ForeColor = Color.Silver;
            }
        }

        private void txtArticleLibelle_Enter(object sender, EventArgs e)
        {
            if (txtArticleLibelle.Text == "Libelle")
            {
                txtArticleLibelle.Text = "";
                txtArticleLibelle.ForeColor = Color.Black;
            }
        }

        private void txtArticleLibelle_Leave(object sender, EventArgs e)
        {
            if (txtArticleLibelle.Text == "")
            {
                txtArticleLibelle.Text = "Libelle";
                txtArticleLibelle.ForeColor = Color.Silver;
            }
        }

        private void txtArticleStock_Enter(object sender, EventArgs e)
        {
            if (txtArticleStock.Text == "Qte Stock")
            {
                txtArticleStock.Text = "";
                txtArticleStock.ForeColor = Color.Black;
            }
        }

        private void txtArticleStock_Leave(object sender, EventArgs e)
        {
            if (txtArticleStock.Text == "")
            {
                txtArticleStock.Text = "Qte Stock";
                txtArticleStock.ForeColor = Color.Silver;
            }
        }

        private void txtQteCommander_Enter(object sender, EventArgs e)
        {
            if (txtQteCommander.Text == "Qte Commande")
            {
                txtQteCommander.Text = "";
                txtQteCommander.ForeColor = Color.Black;
            }
        }

        private void txtQteCommander_Leave(object sender, EventArgs e)
        {
            if (txtQteCommander.Text == "")
            {
                txtQteCommander.Text = "Qte Commande";
                txtQteCommander.ForeColor = Color.Silver;
            }
        }
    }
}
