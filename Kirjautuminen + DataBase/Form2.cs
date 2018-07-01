using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kirjautuminen___DataBase.Models;

namespace Kirjautuminen___DataBase
{
    public partial class Form2 : Form
    {
        public Form2(Työntekijät työntekijä)
        {
            InitializeComponent();
            kirjautunut_käyttäjä.Text = työntekijä.Etunimi;
            if (työntekijä.Admin == false)
            {
                adminToiminnot.Hide();
            }

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

        private void nappiEtsi_Click(object sender, EventArgs e)
        {
            YdinvoimalaDBEntities dBEntities = new YdinvoimalaDBEntities();
            //Kesken!!
            if (kenttäId.Value == 0 || kenttäEtunimi.Text.Length == 0 && kenttäSukunimi.Text.Length == 0)

            //Etsitään ID:n mukaan
            var käyttäjä = dBEntities.Työntekijät.Where(x => x.Käyttäjä_id == kenttäId.Value).FirstOrDefault();
            if (käyttäjä != null)
            {
                kenttäEtunimi.Text = käyttäjä.Etunimi;
                kenttäSukunimi.Text = käyttäjä.Sukunimi;
                kenttäKäyttäjätunnus.Text = käyttäjä.Käyttäjätunnus;
                kenttäSalasana.Text = käyttäjä.Salasana;
                if (käyttäjä.Admin)
                    nappiAdminTrue.Checked = true;
                else
                    nappiAdminFalse.Checked = true;
                käyttäjä = null;
                return;
            }

            //Etsitään etunimen ja sukunimen mukaan
            var käyttäjä1 = dBEntities.Työntekijät.Where(x => x.Etunimi == kenttäEtunimi.Text && x.Sukunimi == kenttäSukunimi.Text).ToList();
            if (käyttäjä1.Count == 1)
            {
                kenttäEtunimi.Text = käyttäjä1.FirstOrDefault().Etunimi;
                kenttäSukunimi.Text = käyttäjä1.FirstOrDefault().Sukunimi;
                kenttäKäyttäjätunnus.Text = käyttäjä1.FirstOrDefault().Käyttäjätunnus;
                kenttäSalasana.Text = käyttäjä1.FirstOrDefault().Salasana;
                if (käyttäjä1.FirstOrDefault().Admin)
                    nappiAdminTrue.Checked = true;
                else
                    nappiAdminFalse.Checked = true;
                käyttäjä1 = null;
                return;
            }

            //Etsitään käyttäjätunnuksen mukaan
            var käyttäjä2 = dBEntities.Työntekijät.Where(x => x.Käyttäjätunnus == kenttäKäyttäjätunnus.Text).FirstOrDefault();
            if (käyttäjä2 != null)
            {
                kenttäEtunimi.Text = käyttäjä2.Etunimi;
                kenttäSukunimi.Text = käyttäjä2.Sukunimi;
                kenttäKäyttäjätunnus.Text = käyttäjä2.Käyttäjätunnus;
                kenttäSalasana.Text = käyttäjä2.Salasana;
                if (käyttäjä2.Admin)
                    nappiAdminTrue.Checked = true;
                else
                    nappiAdminFalse.Checked = true;
                käyttäjä2 = null;
                return;
            }
            
            //Etsimis validointia pitää lisätä

        }
    }
}
