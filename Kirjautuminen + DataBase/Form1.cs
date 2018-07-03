using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Kirjautuminen___DataBase.Models;

namespace Kirjautuminen___DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Kirjaudu nappi etusivulla
        private void button1_Click(object sender, EventArgs e)
        {
            YdinvoimalaDBEntities dBEntities = new YdinvoimalaDBEntities();

            var käyttis = dBEntities.Työntekijät.Where(x => x.Käyttäjätunnus == kenttä_kirjautuminen.Text).FirstOrDefault();
            if (käyttis != null && käyttis.Salasana == kenttä_salasana.Text)
            {
                Form2 form2 = new Form2(käyttis);
                kenttä_kirjautuminen.Clear();
                kenttä_salasana.Clear();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Käyttäjää ei löytynyt tietokannasta, tai salasana on väärin");
                kenttä_kirjautuminen.Clear();
                kenttä_salasana.Clear();
            }
        }

        //Lopeta nappi etusivulla
        private void nappiLopeta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
