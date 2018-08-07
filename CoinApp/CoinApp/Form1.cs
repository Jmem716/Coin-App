using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinApp
{
    public partial class CoinApp : Form
    {
        public CoinApp()
        {
            InitializeComponent();
        }

        private void heads_Click(object sender, EventArgs e)
        {
            headsPictureBox.Visible = true;
            tailsPictureBox.Visible = false;
        }

        private void headsPictureBox_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tails_Click(object sender, EventArgs e)
        {
            tailsPictureBox.Visible = true;
            headsPictureBox.Visible = false;
        }
    }
}
