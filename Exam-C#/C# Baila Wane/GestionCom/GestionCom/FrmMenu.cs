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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void clearChild()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

        }


        FrmArticle f1;
        private void btnFrmArticleGo_Click(object sender, EventArgs e)
        {
            clearChild();
            f1 = new FrmArticle();
            f1.MdiParent = this;
            f1.Show();
        }

        
        private void btnFrmCategorieGo_Click(object sender, EventArgs e)
        {
            btnFrmCategorieGo.Enabled = false;
        }

        FrmCommande f2;
        private void btnFrmCommandeGo_Click(object sender, EventArgs e)
        {
            clearChild();
            f2 = new FrmCommande();
            f2.MdiParent = this;
            f2.Show();
        }

        FrmUser f3;
        private void btnFrmUserGo_Click(object sender, EventArgs e)
        {
            clearChild();
            f3 = new FrmUser();
            f3.MdiParent = this;
            f3.Show();
        }

        private void btnFrmProfilGo_Click(object sender, EventArgs e)
        {
            btnFrmProfilGo.Enabled = false;
        }
    }
}
