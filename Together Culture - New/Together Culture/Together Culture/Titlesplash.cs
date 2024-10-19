using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Together_Culture
{
    public partial class Titlesplash : Form
    {
        public Titlesplash()
        {
            InitializeComponent();
        }

        private void Titlesplash_on_Load(object sender, EventArgs e)
        {
            Timer splash = new Timer();
            splash.Interval = 2000;
            splash.Tick += (source, e) =>
            {
                this.Hide();
                //this.Close();
                
            };
            splash.Start();
        }
    }
}
