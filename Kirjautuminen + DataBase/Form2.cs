using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kirjautuminen___DataBase.Models;

namespace Kirjautuminen___DataBase
{
    public partial class Form2 : Form
    {
        Työntekijät kirjautunutTyöntekijä;

        //Form2 luominen - konstruktori
        public Form2(Työntekijät työntekijä)
        {
            InitializeComponent();
            kirjautunutTyöntekijä = työntekijä;
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
            YdinvoimalaDBEntities dBEntities = new YdinvoimalaDBEntities();
            kenttäKaikkiTyöntekijät.Items.AddRange(dBEntities.Työntekijät.Select(x => x.Käyttäjä_id.ToString() + " " + x.Käyttäjätunnus.ToString()).ToArray());
        }

        //Kellon juoksemis Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            klo.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        //Etsi käyttäjiä tietokannasta
        private void nappiEtsi_Click(object sender, EventArgs e) //Validointia pitää lisätä!
        {
            YdinvoimalaDBEntities dBEntities = new YdinvoimalaDBEntities();

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

            //Etsitään käyttäjätunnuksen mukaan
            var käyttäjä2 = dBEntities.Työntekijät.Where(x => x.Käyttäjätunnus == kenttäKäyttäjätunnus.Text).FirstOrDefault();
            if (käyttäjä2 != null)
            {
                kenttäId.Value = käyttäjä2.Käyttäjä_id;
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

            //Etsitään etunimen ja sukunimen mukaan
            var käyttäjä1 = dBEntities.Työntekijät.Where(x => x.Etunimi == kenttäEtunimi.Text && x.Sukunimi == kenttäSukunimi.Text).ToList();
            if (käyttäjä1.Count == 1)
            {
                kenttäId.Value = käyttäjä1.FirstOrDefault().Käyttäjä_id;
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
            else if (käyttäjä1.Count > 1)
            {
                kenttäUseampiLöytyi.Show();
                kenttäUseampiLöytyi.Items.AddRange(käyttäjä1.Select(x => x.Käyttäjätunnus.ToString()).ToArray());
            }
        }

        //Valitaan oikea henkilö useammasta löydetystä käyttäjästä
        private void kenttäUseampiLöytyi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            YdinvoimalaDBEntities dBEntities = new YdinvoimalaDBEntities();
            var a = kenttäUseampiLöytyi.SelectedItem.ToString();
            var b = dBEntities.Työntekijät.Where(x => x.Käyttäjätunnus == a).FirstOrDefault();

            kenttäId.Value = b.Käyttäjä_id;
            kenttäEtunimi.Text = b.Etunimi;
            kenttäSukunimi.Text = b.Sukunimi;
            kenttäKäyttäjätunnus.Text = b.Käyttäjätunnus;
            kenttäSalasana.Text = b.Salasana;
            if (b.Admin)
                nappiAdminTrue.Checked = true;
            else
                nappiAdminFalse.Checked = true;
            b = null;
        }

        //Useampikenttä katoaa kun valittu oikea henkilö
        private void kenttäUseampiLöytyi_Leave(object sender, EventArgs e)
        {
            kenttäUseampiLöytyi.Items.Clear();
            kenttäUseampiLöytyi.Visible = false;
        }

        //Uuden käyttäjän luominen
        private void nappiLuo_Click(object sender, EventArgs e)
        {
            YdinvoimalaDBEntities dBEntities = new YdinvoimalaDBEntities();
            var onkoKäyttäjätunnustaOlemassa = dBEntities.Työntekijät.Where(x => x.Käyttäjätunnus == kenttäKäyttäjätunnus.Text).FirstOrDefault();

            if (kenttäEtunimi.TextLength == 0 || kenttäSukunimi.TextLength == 0 || kenttäKäyttäjätunnus.TextLength == 0 ||
                kenttäSalasana.TextLength == 0 || nappiAdminTrue.Checked == false && nappiAdminFalse.Checked == false)
            {
                MessageBox.Show("Täytä kaikki kentät");
                return;
            }
            else if (onkoKäyttäjätunnustaOlemassa != null)
            {
                MessageBox.Show("Käyttäjätunnus on olemassa");
                return;
            }
            else
            {
                bool onkoAdmin;
                if (nappiAdminTrue.Checked)
                    onkoAdmin = true;
                else
                    onkoAdmin = false;

                dBEntities.Työntekijät.Add(new Työntekijät()
                {
                    Etunimi = kenttäEtunimi.Text,
                    Sukunimi = kenttäSukunimi.Text,
                    Käyttäjätunnus = kenttäKäyttäjätunnus.Text,
                    Salasana = kenttäSalasana.Text,
                    Luomispäivä = DateTime.Now.Date,
                    Admin = onkoAdmin
                });
                dBEntities.SaveChanges();
                TyhjennäKaikkiKentät();
            }
        }

        //Apumetodi - kenttien tyhjennyt
        public void TyhjennäKaikkiKentät()
        {
            kenttäId.Value = 0;
            kenttäEtunimi.ResetText();
            kenttäSukunimi.ResetText();
            kenttäKäyttäjätunnus.ResetText();
            kenttäSalasana.ResetText();
            nappiAdminTrue.Checked = false;
            nappiAdminFalse.Checked = false;
            kenttäLisätiedot.ResetText();
        }

        //Tietojen päivitys nappi
        private void nappiPäivitä_Click(object sender, EventArgs e)
        {
            YdinvoimalaDBEntities dBEntities = new YdinvoimalaDBEntities();
            var käyttäjä = dBEntities.Työntekijät.Where(x => x.Käyttäjätunnus == kenttäKäyttäjätunnus.Text).FirstOrDefault();

            if (kenttäId.Value == 0 || kenttäEtunimi.TextLength == 0 || kenttäSukunimi.TextLength == 0 || kenttäKäyttäjätunnus.TextLength == 0 ||
                kenttäSalasana.TextLength == 0 || nappiAdminTrue.Checked == false && nappiAdminFalse.Checked == false)
            {
                MessageBox.Show("Puuttuu tietoja, täytä kaikki kentät");
                return;
            }
            else if (käyttäjä == null)
            {
                MessageBox.Show("Käyttäjää ei löytynyt käyttäjätunnuksella");
                return;
            }
            else if (kenttäId.Value != käyttäjä.Käyttäjä_id || kenttäKäyttäjätunnus.Text != käyttäjä.Käyttäjätunnus)
            {
                MessageBox.Show("ID ja Käyttäjätunnus eivät täsmää, päivitys ei onnistu");
                return;
            }
            else if (kenttäId.Value == käyttäjä.Käyttäjä_id && kenttäKäyttäjätunnus.Text == käyttäjä.Käyttäjätunnus)
            {
                käyttäjä.Etunimi = kenttäEtunimi.Text;
                käyttäjä.Sukunimi = kenttäSukunimi.Text;
                käyttäjä.Salasana = kenttäSalasana.Text;
                käyttäjä.Admin = nappiAdminTrue.Checked;
                MessageBox.Show("Käyttäjätiedot päivitetty");
                dBEntities.SaveChanges();
                TyhjennäKaikkiKentät();
            }
        }

        //Kirjaudu ulos nappi
        private void nappi_ulosKirjautuminen_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Tallenna tuntikirjaus nappi
        private void nappiTallenna_Click(object sender, EventArgs e)
        {
            YdinvoimalaDBEntities dBEntities = new YdinvoimalaDBEntities();
            var onkoKirjaustaSamallePäivälle = kirjautunutTyöntekijä.Kirjaukset.Where(x => x.Päivä.Date == kenttäPäivä.Value.Date).FirstOrDefault();

            if (kenttäAloitus.Value >= kenttäLopetus.Value)
            {
                MessageBox.Show("Lopetusaika ei voi olla ennen aloitusaikaa");
                return;
            }
            else if (onkoKirjaustaSamallePäivälle != null)
            {
                MessageBox.Show("Käyttäjällä on jo tuntikirjaus merkittynä tuolle päivälle, kirjaus ei onnistu");
                return;
            }

            var uusiKirjaus = new Kirjaukset
            {
                Käyttäjä_id = kirjautunutTyöntekijä.Käyttäjä_id,
                Kirjauspäivä = DateTime.Now.Date,
                Päivä = kenttäPäivä.Value.Date,
                Aloitusaika = TimeSpan.Parse(kenttäAloitus.Value.TimeOfDay.ToString().Substring(0, 6) + "00"),
                Lopetusaika = TimeSpan.Parse(kenttäLopetus.Value.TimeOfDay.ToString().Substring(0, 6) + "00"),
                Lisätiedot = kenttäLisätiedot.Text
            };

            dBEntities.Kirjaukset.Add(uusiKirjaus);
            //kirjautunutTyöntekijä.Kirjaukset.Add(uusiKirjaus); - tämä ei toiminut, miksi?
            dBEntities.SaveChanges();
            TyhjennäKaikkiKentät();
            MessageBox.Show("Kirjaus onnistui tietokantaan");
        }

        //Kirjoita työntekijät tunnit tiedostoon nappi
        private void nappiTulosta_Click(object sender, EventArgs e)
        {
            if (kenttäKaikkiTyöntekijät.Text.Length == 0)
            {
                MessageBox.Show("Valitse työntekijä listasta");
                return;
            }

            YdinvoimalaDBEntities dBEntities = new YdinvoimalaDBEntities();
            var valittuID = int.Parse(kenttäKaikkiTyöntekijät.SelectedItem.ToString().Split(' ').FirstOrDefault());
            var kaikkiKirjaukset = dBEntities.Kirjaukset.Where(x => x.Käyttäjä_id == valittuID).ToList();
            var työntekijä = dBEntities.Työntekijät.Where(x => x.Käyttäjä_id == valittuID).FirstOrDefault();
            var vainOikeatKirjaukset = kaikkiKirjaukset.Where(x => x.Päivä >= kenttäTulostaAloitusPäivä.Value.Date && x.Päivä <= kenttäTulostaLopetusPäivä.Value.Date).ToList();

            if (vainOikeatKirjaukset.Count != 0)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text File|*.txt";
                saveFile.FileName = "Tuntikirjaukset";

                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = saveFile.FileName;
                    StreamWriter sw = new StreamWriter(File.Create(path));

                    sw.WriteLine("ID {0}, {1} {2}, käyttäjätunnus: {3}", työntekijä.Käyttäjä_id, työntekijä.Etunimi, työntekijä.Sukunimi, työntekijä.Käyttäjätunnus);
                    sw.WriteLine();
                    foreach (var item in vainOikeatKirjaukset)
                    {
                        sw.WriteLine(item.Päivä.ToShortDateString() + " " + item.Aloitusaika.ToString().Substring(0,5) + " " +
                            item.Lopetusaika.ToString().Substring(0, 5) + " " + item.Lisätiedot);
                    }
                    sw.Close();
                }
            }
            else
            {
                MessageBox.Show("Työntekijällä ei ole kirjauksia");
            }
        }

        private void nappiPoista_Click(object sender, EventArgs e)
        {
            if (kenttäKaikkiTyöntekijät.Text.Length == 0)
            {
                MessageBox.Show("Valitse työntekijä keneltä poistetaan kirjauksia");
                return;
            }

            YdinvoimalaDBEntities dBEntities = new YdinvoimalaDBEntities();
            var valittuID = int.Parse(kenttäKaikkiTyöntekijät.SelectedItem.ToString().Split(' ').FirstOrDefault());
            var kaikkiKirjaukset = dBEntities.Kirjaukset.Where(x => x.Käyttäjä_id == valittuID).ToList();
            var työntekijä = dBEntities.Työntekijät.Where(x => x.Käyttäjä_id == valittuID).FirstOrDefault();
            var vainOikeatKirjaukset = kaikkiKirjaukset.Where(x => x.Päivä >= kenttäTulostaAloitusPäivä.Value.Date && x.Päivä <= kenttäTulostaLopetusPäivä.Value.Date).ToList();

            if (vainOikeatKirjaukset.Count != 0)
            {
                foreach (var item in vainOikeatKirjaukset)
                {
                    dBEntities.Kirjaukset.Remove(item);
                }
                dBEntities.SaveChanges();
                MessageBox.Show("Valitut kirjaukset ovat poistettu");
            }
            else
            {
                MessageBox.Show("Työntekijällä ei ole kirjauksia");
            }

        }
    }
}

