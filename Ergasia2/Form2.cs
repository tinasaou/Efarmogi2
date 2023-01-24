using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia2
{
    public partial class Form2 : Form
    {
        int scor = 0;
        Random rand = new Random();
        List<PictureBox> list = new List<PictureBox>();
        private object items;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox temPic = sender as PictureBox;
            items.Remove(temPic);
            this.Controls.Remove(temPic);
            }
    }
}
