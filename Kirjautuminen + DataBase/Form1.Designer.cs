namespace Kirjautuminen___DataBase
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kenttä_kirjautuminen = new System.Windows.Forms.TextBox();
            this.kenttä_salasana = new System.Windows.Forms.TextBox();
            this.nappiLopeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Ravie", 13.74545F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ydinlaitos superjärjestelmä";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Käyttäjätunnus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salasana";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(294, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kirjaudu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kenttä_kirjautuminen
            // 
            this.kenttä_kirjautuminen.BackColor = System.Drawing.SystemColors.Window;
            this.kenttä_kirjautuminen.Location = new System.Drawing.Point(294, 190);
            this.kenttä_kirjautuminen.Name = "kenttä_kirjautuminen";
            this.kenttä_kirjautuminen.Size = new System.Drawing.Size(169, 20);
            this.kenttä_kirjautuminen.TabIndex = 4;
            this.kenttä_kirjautuminen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kenttä_salasana
            // 
            this.kenttä_salasana.Location = new System.Drawing.Point(294, 235);
            this.kenttä_salasana.Name = "kenttä_salasana";
            this.kenttä_salasana.PasswordChar = '*';
            this.kenttä_salasana.Size = new System.Drawing.Size(169, 20);
            this.kenttä_salasana.TabIndex = 5;
            this.kenttä_salasana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nappiLopeta
            // 
            this.nappiLopeta.Location = new System.Drawing.Point(388, 275);
            this.nappiLopeta.Name = "nappiLopeta";
            this.nappiLopeta.Size = new System.Drawing.Size(75, 23);
            this.nappiLopeta.TabIndex = 6;
            this.nappiLopeta.Text = "Lopeta";
            this.nappiLopeta.UseVisualStyleBackColor = true;
            this.nappiLopeta.Click += new System.EventHandler(this.nappiLopeta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kirjautuminen___DataBase.Properties.Resources.Nuclear_pic;
            this.ClientSize = new System.Drawing.Size(636, 475);
            this.Controls.Add(this.nappiLopeta);
            this.Controls.Add(this.kenttä_salasana);
            this.Controls.Add(this.kenttä_kirjautuminen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Superjärjestelmä";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kenttä_kirjautuminen;
        private System.Windows.Forms.TextBox kenttä_salasana;
        private System.Windows.Forms.Button nappiLopeta;
    }
}

