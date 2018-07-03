namespace Kirjautuminen___DataBase
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nappiLuo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kirjautunut_käyttäjä = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kenttäEtunimi = new System.Windows.Forms.TextBox();
            this.kenttäSukunimi = new System.Windows.Forms.TextBox();
            this.kenttäKäyttäjätunnus = new System.Windows.Forms.TextBox();
            this.kenttäSalasana = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nappi_ulosKirjautuminen = new System.Windows.Forms.Button();
            this.kenttäPäivä = new System.Windows.Forms.DateTimePicker();
            this.kenttäAloitus = new System.Windows.Forms.DateTimePicker();
            this.kenttäLopetus = new System.Windows.Forms.DateTimePicker();
            this.pvm = new System.Windows.Forms.Label();
            this.klo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.kenttäLisätiedot = new System.Windows.Forms.TextBox();
            this.nappiAdminTrue = new System.Windows.Forms.RadioButton();
            this.nappiAdminFalse = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.nappiTallenna = new System.Windows.Forms.Button();
            this.adminToiminnot = new System.Windows.Forms.GroupBox();
            this.kenttäId = new System.Windows.Forms.NumericUpDown();
            this.nappiPäivitä = new System.Windows.Forms.Button();
            this.nappiEtsi = new System.Windows.Forms.Button();
            this.kenttäUseampiLöytyi = new System.Windows.Forms.ComboBox();
            this.nappiTulosta = new System.Windows.Forms.Button();
            this.nappiPoista = new System.Windows.Forms.Button();
            this.kenttäTulostaAloitusPäivä = new System.Windows.Forms.DateTimePicker();
            this.kenttäTulostaLopetusPäivä = new System.Windows.Forms.DateTimePicker();
            this.kenttäKaikkiTyöntekijät = new System.Windows.Forms.ComboBox();
            this.adminToiminnot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kenttäId)).BeginInit();
            this.SuspendLayout();
            // 
            // nappiLuo
            // 
            this.nappiLuo.Location = new System.Drawing.Point(99, 186);
            this.nappiLuo.Name = "nappiLuo";
            this.nappiLuo.Size = new System.Drawing.Size(75, 23);
            this.nappiLuo.TabIndex = 0;
            this.nappiLuo.Text = "Luo";
            this.nappiLuo.UseVisualStyleBackColor = true;
            this.nappiLuo.Click += new System.EventHandler(this.nappiLuo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kirjautunut:";
            // 
            // kirjautunut_käyttäjä
            // 
            this.kirjautunut_käyttäjä.AutoSize = true;
            this.kirjautunut_käyttäjä.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.kirjautunut_käyttäjä.Location = new System.Drawing.Point(78, 9);
            this.kirjautunut_käyttäjä.Name = "kirjautunut_käyttäjä";
            this.kirjautunut_käyttäjä.Size = new System.Drawing.Size(89, 16);
            this.kirjautunut_käyttäjä.TabIndex = 2;
            this.kirjautunut_käyttäjä.Text = "käyttäjän nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Etunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sukunimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Käyttäjätunnus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Salasana";
            // 
            // kenttäEtunimi
            // 
            this.kenttäEtunimi.Location = new System.Drawing.Point(110, 45);
            this.kenttäEtunimi.MaxLength = 30;
            this.kenttäEtunimi.Name = "kenttäEtunimi";
            this.kenttäEtunimi.Size = new System.Drawing.Size(151, 21);
            this.kenttäEtunimi.TabIndex = 9;
            // 
            // kenttäSukunimi
            // 
            this.kenttäSukunimi.Location = new System.Drawing.Point(110, 71);
            this.kenttäSukunimi.MaxLength = 30;
            this.kenttäSukunimi.Name = "kenttäSukunimi";
            this.kenttäSukunimi.Size = new System.Drawing.Size(151, 21);
            this.kenttäSukunimi.TabIndex = 10;
            // 
            // kenttäKäyttäjätunnus
            // 
            this.kenttäKäyttäjätunnus.BackColor = System.Drawing.SystemColors.Window;
            this.kenttäKäyttäjätunnus.Location = new System.Drawing.Point(110, 97);
            this.kenttäKäyttäjätunnus.MaxLength = 20;
            this.kenttäKäyttäjätunnus.Name = "kenttäKäyttäjätunnus";
            this.kenttäKäyttäjätunnus.Size = new System.Drawing.Size(151, 21);
            this.kenttäKäyttäjätunnus.TabIndex = 11;
            // 
            // kenttäSalasana
            // 
            this.kenttäSalasana.Location = new System.Drawing.Point(110, 123);
            this.kenttäSalasana.MaxLength = 50;
            this.kenttäSalasana.Name = "kenttäSalasana";
            this.kenttäSalasana.PasswordChar = '*';
            this.kenttäSalasana.Size = new System.Drawing.Size(151, 21);
            this.kenttäSalasana.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(607, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tuntien kirjaus";
            // 
            // nappi_ulosKirjautuminen
            // 
            this.nappi_ulosKirjautuminen.Location = new System.Drawing.Point(696, 9);
            this.nappi_ulosKirjautuminen.Name = "nappi_ulosKirjautuminen";
            this.nappi_ulosKirjautuminen.Size = new System.Drawing.Size(75, 23);
            this.nappi_ulosKirjautuminen.TabIndex = 14;
            this.nappi_ulosKirjautuminen.Text = "Kirjaudu ulos";
            this.nappi_ulosKirjautuminen.UseVisualStyleBackColor = true;
            this.nappi_ulosKirjautuminen.Click += new System.EventHandler(this.nappi_ulosKirjautuminen_Click);
            // 
            // kenttäPäivä
            // 
            this.kenttäPäivä.CustomFormat = "ddmmyyyy";
            this.kenttäPäivä.Location = new System.Drawing.Point(556, 105);
            this.kenttäPäivä.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.kenttäPäivä.Name = "kenttäPäivä";
            this.kenttäPäivä.Size = new System.Drawing.Size(200, 20);
            this.kenttäPäivä.TabIndex = 16;
            this.kenttäPäivä.Value = new System.DateTime(2018, 7, 3, 0, 0, 0, 0);
            // 
            // kenttäAloitus
            // 
            this.kenttäAloitus.CustomFormat = "HH:mm";
            this.kenttäAloitus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kenttäAloitus.Location = new System.Drawing.Point(556, 149);
            this.kenttäAloitus.Name = "kenttäAloitus";
            this.kenttäAloitus.ShowUpDown = true;
            this.kenttäAloitus.Size = new System.Drawing.Size(200, 20);
            this.kenttäAloitus.TabIndex = 17;
            // 
            // kenttäLopetus
            // 
            this.kenttäLopetus.CustomFormat = "HH:mm";
            this.kenttäLopetus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kenttäLopetus.Location = new System.Drawing.Point(556, 191);
            this.kenttäLopetus.Name = "kenttäLopetus";
            this.kenttäLopetus.ShowUpDown = true;
            this.kenttäLopetus.Size = new System.Drawing.Size(200, 20);
            this.kenttäLopetus.TabIndex = 18;
            // 
            // pvm
            // 
            this.pvm.AutoSize = true;
            this.pvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.pvm.Location = new System.Drawing.Point(332, 9);
            this.pvm.Name = "pvm";
            this.pvm.Size = new System.Drawing.Size(43, 16);
            this.pvm.TabIndex = 19;
            this.pvm.Text = "Päivä";
            // 
            // klo
            // 
            this.klo.AutoSize = true;
            this.klo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.klo.Location = new System.Drawing.Point(388, 9);
            this.klo.Name = "klo";
            this.klo.Size = new System.Drawing.Size(35, 16);
            this.klo.TabIndex = 20;
            this.klo.Text = "Aika";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(475, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Lisätiedot";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label9.Location = new System.Drawing.Point(487, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Aloitus";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.Location = new System.Drawing.Point(479, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Lopetus";
            // 
            // kenttäLisätiedot
            // 
            this.kenttäLisätiedot.Location = new System.Drawing.Point(556, 231);
            this.kenttäLisätiedot.MaxLength = 100;
            this.kenttäLisätiedot.Multiline = true;
            this.kenttäLisätiedot.Name = "kenttäLisätiedot";
            this.kenttäLisätiedot.Size = new System.Drawing.Size(200, 118);
            this.kenttäLisätiedot.TabIndex = 24;
            // 
            // nappiAdminTrue
            // 
            this.nappiAdminTrue.AutoSize = true;
            this.nappiAdminTrue.Location = new System.Drawing.Point(110, 154);
            this.nappiAdminTrue.Name = "nappiAdminTrue";
            this.nappiAdminTrue.Size = new System.Drawing.Size(55, 20);
            this.nappiAdminTrue.TabIndex = 25;
            this.nappiAdminTrue.TabStop = true;
            this.nappiAdminTrue.Text = "Kyllä";
            this.nappiAdminTrue.UseVisualStyleBackColor = true;
            // 
            // nappiAdminFalse
            // 
            this.nappiAdminFalse.AutoSize = true;
            this.nappiAdminFalse.Location = new System.Drawing.Point(163, 154);
            this.nappiAdminFalse.Name = "nappiAdminFalse";
            this.nappiAdminFalse.Size = new System.Drawing.Size(38, 20);
            this.nappiAdminFalse.TabIndex = 26;
            this.nappiAdminFalse.TabStop = true;
            this.nappiAdminFalse.Text = "Ei";
            this.nappiAdminFalse.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Admin oikeus";
            // 
            // nappiTallenna
            // 
            this.nappiTallenna.Location = new System.Drawing.Point(619, 355);
            this.nappiTallenna.Name = "nappiTallenna";
            this.nappiTallenna.Size = new System.Drawing.Size(75, 23);
            this.nappiTallenna.TabIndex = 28;
            this.nappiTallenna.Text = "Tallenna";
            this.nappiTallenna.UseVisualStyleBackColor = true;
            this.nappiTallenna.Click += new System.EventHandler(this.nappiTallenna_Click);
            // 
            // adminToiminnot
            // 
            this.adminToiminnot.AccessibleDescription = "";
            this.adminToiminnot.AccessibleName = "";
            this.adminToiminnot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminToiminnot.Controls.Add(this.kenttäKaikkiTyöntekijät);
            this.adminToiminnot.Controls.Add(this.kenttäTulostaLopetusPäivä);
            this.adminToiminnot.Controls.Add(this.kenttäTulostaAloitusPäivä);
            this.adminToiminnot.Controls.Add(this.nappiPoista);
            this.adminToiminnot.Controls.Add(this.nappiTulosta);
            this.adminToiminnot.Controls.Add(this.kenttäId);
            this.adminToiminnot.Controls.Add(this.nappiPäivitä);
            this.adminToiminnot.Controls.Add(this.nappiEtsi);
            this.adminToiminnot.Controls.Add(this.label5);
            this.adminToiminnot.Controls.Add(this.nappiAdminFalse);
            this.adminToiminnot.Controls.Add(this.nappiAdminTrue);
            this.adminToiminnot.Controls.Add(this.label11);
            this.adminToiminnot.Controls.Add(this.kenttäEtunimi);
            this.adminToiminnot.Controls.Add(this.label2);
            this.adminToiminnot.Controls.Add(this.kenttäSukunimi);
            this.adminToiminnot.Controls.Add(this.kenttäKäyttäjätunnus);
            this.adminToiminnot.Controls.Add(this.kenttäSalasana);
            this.adminToiminnot.Controls.Add(this.label3);
            this.adminToiminnot.Controls.Add(this.label4);
            this.adminToiminnot.Controls.Add(this.label6);
            this.adminToiminnot.Controls.Add(this.nappiLuo);
            this.adminToiminnot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.adminToiminnot.Location = new System.Drawing.Point(8, 105);
            this.adminToiminnot.Name = "adminToiminnot";
            this.adminToiminnot.Size = new System.Drawing.Size(461, 233);
            this.adminToiminnot.TabIndex = 29;
            this.adminToiminnot.TabStop = false;
            this.adminToiminnot.Text = "Admin";
            // 
            // kenttäId
            // 
            this.kenttäId.Location = new System.Drawing.Point(110, 17);
            this.kenttäId.Name = "kenttäId";
            this.kenttäId.Size = new System.Drawing.Size(151, 21);
            this.kenttäId.TabIndex = 30;
            this.kenttäId.ThousandsSeparator = true;
            // 
            // nappiPäivitä
            // 
            this.nappiPäivitä.Location = new System.Drawing.Point(186, 186);
            this.nappiPäivitä.Name = "nappiPäivitä";
            this.nappiPäivitä.Size = new System.Drawing.Size(75, 23);
            this.nappiPäivitä.TabIndex = 29;
            this.nappiPäivitä.Text = "Päivitä";
            this.nappiPäivitä.UseVisualStyleBackColor = true;
            this.nappiPäivitä.Click += new System.EventHandler(this.nappiPäivitä_Click);
            // 
            // nappiEtsi
            // 
            this.nappiEtsi.Location = new System.Drawing.Point(9, 186);
            this.nappiEtsi.Name = "nappiEtsi";
            this.nappiEtsi.Size = new System.Drawing.Size(75, 23);
            this.nappiEtsi.TabIndex = 28;
            this.nappiEtsi.Text = "Etsi";
            this.nappiEtsi.UseVisualStyleBackColor = true;
            this.nappiEtsi.Click += new System.EventHandler(this.nappiEtsi_Click);
            // 
            // kenttäUseampiLöytyi
            // 
            this.kenttäUseampiLöytyi.FormattingEnabled = true;
            this.kenttäUseampiLöytyi.Location = new System.Drawing.Point(8, 344);
            this.kenttäUseampiLöytyi.Name = "kenttäUseampiLöytyi";
            this.kenttäUseampiLöytyi.Size = new System.Drawing.Size(137, 21);
            this.kenttäUseampiLöytyi.TabIndex = 30;
            this.kenttäUseampiLöytyi.Visible = false;
            this.kenttäUseampiLöytyi.SelectionChangeCommitted += new System.EventHandler(this.kenttäUseampiLöytyi_SelectionChangeCommitted);
            this.kenttäUseampiLöytyi.Leave += new System.EventHandler(this.kenttäUseampiLöytyi_Leave);
            // 
            // nappiTulosta
            // 
            this.nappiTulosta.Location = new System.Drawing.Point(291, 186);
            this.nappiTulosta.Name = "nappiTulosta";
            this.nappiTulosta.Size = new System.Drawing.Size(75, 23);
            this.nappiTulosta.TabIndex = 31;
            this.nappiTulosta.Text = "Tulosta";
            this.nappiTulosta.UseVisualStyleBackColor = true;
            this.nappiTulosta.Click += new System.EventHandler(this.nappiTulosta_Click);
            // 
            // nappiPoista
            // 
            this.nappiPoista.Location = new System.Drawing.Point(373, 186);
            this.nappiPoista.Name = "nappiPoista";
            this.nappiPoista.Size = new System.Drawing.Size(75, 23);
            this.nappiPoista.TabIndex = 32;
            this.nappiPoista.Text = "Poista kir.";
            this.nappiPoista.UseVisualStyleBackColor = true;
            this.nappiPoista.Click += new System.EventHandler(this.nappiPoista_Click);
            // 
            // kenttäTulostaAloitusPäivä
            // 
            this.kenttäTulostaAloitusPäivä.CustomFormat = "dd.MM.yyyy";
            this.kenttäTulostaAloitusPäivä.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kenttäTulostaAloitusPäivä.Location = new System.Drawing.Point(291, 17);
            this.kenttäTulostaAloitusPäivä.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.kenttäTulostaAloitusPäivä.Name = "kenttäTulostaAloitusPäivä";
            this.kenttäTulostaAloitusPäivä.Size = new System.Drawing.Size(157, 21);
            this.kenttäTulostaAloitusPäivä.TabIndex = 31;
            this.kenttäTulostaAloitusPäivä.Value = new System.DateTime(2018, 7, 3, 0, 0, 0, 0);
            // 
            // kenttäTulostaLopetusPäivä
            // 
            this.kenttäTulostaLopetusPäivä.CustomFormat = "dd.MM.yyyy";
            this.kenttäTulostaLopetusPäivä.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kenttäTulostaLopetusPäivä.Location = new System.Drawing.Point(291, 45);
            this.kenttäTulostaLopetusPäivä.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.kenttäTulostaLopetusPäivä.Name = "kenttäTulostaLopetusPäivä";
            this.kenttäTulostaLopetusPäivä.Size = new System.Drawing.Size(157, 21);
            this.kenttäTulostaLopetusPäivä.TabIndex = 33;
            this.kenttäTulostaLopetusPäivä.Value = new System.DateTime(2018, 7, 3, 0, 0, 0, 0);
            // 
            // kenttäKaikkiTyöntekijät
            // 
            this.kenttäKaikkiTyöntekijät.FormattingEnabled = true;
            this.kenttäKaikkiTyöntekijät.Location = new System.Drawing.Point(291, 74);
            this.kenttäKaikkiTyöntekijät.Name = "kenttäKaikkiTyöntekijät";
            this.kenttäKaikkiTyöntekijät.Size = new System.Drawing.Size(157, 23);
            this.kenttäKaikkiTyöntekijät.TabIndex = 31;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kenttäUseampiLöytyi);
            this.Controls.Add(this.adminToiminnot);
            this.Controls.Add(this.nappiTallenna);
            this.Controls.Add(this.kenttäLisätiedot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.klo);
            this.Controls.Add(this.pvm);
            this.Controls.Add(this.kenttäLopetus);
            this.Controls.Add(this.kenttäAloitus);
            this.Controls.Add(this.kenttäPäivä);
            this.Controls.Add(this.nappi_ulosKirjautuminen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kirjautunut_käyttäjä);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.adminToiminnot.ResumeLayout(false);
            this.adminToiminnot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kenttäId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nappiLuo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kirjautunut_käyttäjä;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kenttäSukunimi;
        private System.Windows.Forms.TextBox kenttäKäyttäjätunnus;
        private System.Windows.Forms.TextBox kenttäSalasana;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button nappi_ulosKirjautuminen;
        private System.Windows.Forms.DateTimePicker kenttäPäivä;
        private System.Windows.Forms.DateTimePicker kenttäAloitus;
        private System.Windows.Forms.DateTimePicker kenttäLopetus;
        private System.Windows.Forms.Label pvm;
        private System.Windows.Forms.Label klo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox kenttäLisätiedot;
        private System.Windows.Forms.RadioButton nappiAdminTrue;
        private System.Windows.Forms.RadioButton nappiAdminFalse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button nappiTallenna;
        private System.Windows.Forms.GroupBox adminToiminnot;
        private System.Windows.Forms.Button nappiPäivitä;
        private System.Windows.Forms.Button nappiEtsi;
        private System.Windows.Forms.NumericUpDown kenttäId;
        private System.Windows.Forms.ComboBox kenttäUseampiLöytyi;
        private System.Windows.Forms.TextBox kenttäEtunimi;
        private System.Windows.Forms.ComboBox kenttäKaikkiTyöntekijät;
        private System.Windows.Forms.DateTimePicker kenttäTulostaLopetusPäivä;
        private System.Windows.Forms.DateTimePicker kenttäTulostaAloitusPäivä;
        private System.Windows.Forms.Button nappiPoista;
        private System.Windows.Forms.Button nappiTulosta;
    }
}