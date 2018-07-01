using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirjautuminen___DataBase
{
    public partial class Form2 : Form
    {
        public Form2(string käyttäjä)
        {
            InitializeComponent();
            kirjautunut_käyttäjä.Text = käyttäjä;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pvm.Text = DateTime.Now.ToShortDateString();
            klo.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            klo.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
