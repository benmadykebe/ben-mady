using Monprojet.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monprojet
{
    public partial class FrmConnexion : Form
    {
        private ArticleService service = new ArticleService();
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {

        }
        frmMenu frmMenu;
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            //Validation
            User user = service.SeConnecter(txtLogin.Text.Trim(), txtPwd.Text.Trim());
            if (user == null)
            {
                labelError.Visible = true;
            }
            else
            {
                frmMenu = new FrmMenu(user);
                frmMenu.Show();
                this.Hide();

            }
        }
    }

    internal class FrmMenu : frmMenu
    {
        private User user;

        public FrmMenu(User user)
        {
            this.user = user;
        }
    }
}
