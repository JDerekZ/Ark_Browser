using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkBrowser
{
    public partial class FrmArkBrowser : Form
    {

        List<string> Favorites = new List<string>();

        public FrmArkBrowser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            tbxUrl.Text = "https://www.msn.com/es-xl/";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (tbxUrl.Text=="")
            {
                MessageBox.Show("Procura primero introducir una URL");
            }
            else
            {
                webBrowser1.Navigate(tbxUrl.Text);
            }
            
        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            Favorites.Add(webBrowser1.Url.ToString());
            cargando_Fav();
            MessageBox.Show("Se ha añadido la página \na favoritos exitosamente");
        }
    

        private void cargando_Fav()
        {
            foreach (string direction in Favorites)
            {
                cbxFavorites.Items.Add(direction);
            }
        }

        private void cbxFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cbxFavorites.SelectedItem.ToString());
        }

    }
}
