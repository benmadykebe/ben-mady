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
    public partial class FrmArticle : Form
    {
        private GestionComServiceBd service = new GestionComServiceBd();

        public FrmArticle()
        {
            InitializeComponent();
            service.listerArticle(dtgvArticle);
        }

        private void FrmArticle_Load(object sender, EventArgs e)
        {
            service.listerArticle(dtgvArticle);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Article article = new Article()
            {


                Reference = txtReference.Text,
                Libelle = txtLibelle.Text,
                Stock = float.Parse(txtStock.Text),
                Prix = float.Parse(txtPrix.Text),
                Categorie = cboCategorie.SelectedItem.ToString()
            };

            service.CreerArticle(article);
            service.listerUser(dtgvArticle);
        }

        private void FrmArticle_Load_1(object sender, EventArgs e)
        {

        }
    }
}
