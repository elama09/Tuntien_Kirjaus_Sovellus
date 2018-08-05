using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Kirjautuminen___DataBase.Models;
using System.Security.Cryptography;
using System.Text;

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
            if (käyttis != null && Form1.Encrypt(kenttä_salasana.Text) == käyttis.Salasana)
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

        //Salasanan Hashaus
        internal static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5= new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
    }
}
