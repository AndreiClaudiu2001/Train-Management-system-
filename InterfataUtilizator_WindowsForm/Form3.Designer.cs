
namespace InterfataUtilizator_WindowsForm
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.X = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNume = new System.Windows.Forms.TextBox();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.TxtAdresa = new System.Windows.Forms.TextBox();
            this.TxtPrenume = new System.Windows.Forms.TextBox();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.Buton_Adauga = new System.Windows.Forms.Button();
            this.Buton_Stergere = new System.Windows.Forms.Button();
            this.Buton_Reset = new System.Windows.Forms.Button();
            this.dataGridPasageri = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboNationalitate = new System.Windows.Forms.ComboBox();
            this.ButtonCautare = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasageri)).BeginInit();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Silver;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(755, 15);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(43, 37);
            this.X.TabIndex = 0;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.X);
            this.panel1.Location = new System.Drawing.Point(-10, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 77);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(219, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "  ADMINISTRARE PASAGERI";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Silver;
            this.back_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_button.BackgroundImage")));
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(22, 15);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(43, 37);
            this.back_button.TabIndex = 3;
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 312);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(-7, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 77);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(191, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(282, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(394, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(493, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nationalitate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(720, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sex";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(614, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefon";
            // 
            // TxtNume
            // 
            this.TxtNume.BackColor = System.Drawing.Color.White;
            this.TxtNume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNume.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNume.Location = new System.Drawing.Point(187, 115);
            this.TxtNume.Multiline = true;
            this.TxtNume.Name = "TxtNume";
            this.TxtNume.Size = new System.Drawing.Size(73, 20);
            this.TxtNume.TabIndex = 20;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.BackColor = System.Drawing.Color.White;
            this.TxtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTelefon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefon.Location = new System.Drawing.Point(605, 114);
            this.TxtTelefon.Multiline = true;
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(73, 20);
            this.TxtTelefon.TabIndex = 21;
            // 
            // TxtAdresa
            // 
            this.TxtAdresa.BackColor = System.Drawing.Color.White;
            this.TxtAdresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAdresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdresa.Location = new System.Drawing.Point(397, 115);
            this.TxtAdresa.Multiline = true;
            this.TxtAdresa.Name = "TxtAdresa";
            this.TxtAdresa.Size = new System.Drawing.Size(73, 20);
            this.TxtAdresa.TabIndex = 22;
            // 
            // TxtPrenume
            // 
            this.TxtPrenume.BackColor = System.Drawing.Color.White;
            this.TxtPrenume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrenume.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrenume.Location = new System.Drawing.Point(285, 115);
            this.TxtPrenume.Multiline = true;
            this.TxtPrenume.Name = "TxtPrenume";
            this.TxtPrenume.Size = new System.Drawing.Size(73, 20);
            this.TxtPrenume.TabIndex = 24;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(705, 119);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(34, 17);
            this.radioButtonM.TabIndex = 25;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(745, 119);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(31, 17);
            this.radioButtonF.TabIndex = 26;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "F";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // Buton_Adauga
            // 
            this.Buton_Adauga.BackColor = System.Drawing.Color.Yellow;
            this.Buton_Adauga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Adauga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Adauga.Location = new System.Drawing.Point(215, 174);
            this.Buton_Adauga.Name = "Buton_Adauga";
            this.Buton_Adauga.Size = new System.Drawing.Size(84, 30);
            this.Buton_Adauga.TabIndex = 27;
            this.Buton_Adauga.Text = "Adauga";
            this.Buton_Adauga.UseVisualStyleBackColor = false;
            this.Buton_Adauga.Click += new System.EventHandler(this.Buton_Adauga_Click);
            // 
            // Buton_Stergere
            // 
            this.Buton_Stergere.BackColor = System.Drawing.Color.Yellow;
            this.Buton_Stergere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Stergere.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Stergere.Location = new System.Drawing.Point(515, 174);
            this.Buton_Stergere.Name = "Buton_Stergere";
            this.Buton_Stergere.Size = new System.Drawing.Size(84, 30);
            this.Buton_Stergere.TabIndex = 29;
            this.Buton_Stergere.Text = "Sterge";
            this.Buton_Stergere.UseVisualStyleBackColor = false;
            // 
            // Buton_Reset
            // 
            this.Buton_Reset.BackColor = System.Drawing.Color.MidnightBlue;
            this.Buton_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Reset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Reset.ForeColor = System.Drawing.Color.LightGray;
            this.Buton_Reset.Location = new System.Drawing.Point(655, 174);
            this.Buton_Reset.Name = "Buton_Reset";
            this.Buton_Reset.Size = new System.Drawing.Size(84, 30);
            this.Buton_Reset.TabIndex = 30;
            this.Buton_Reset.Text = "Reseteaza";
            this.Buton_Reset.UseVisualStyleBackColor = false;
            this.Buton_Reset.Click += new System.EventHandler(this.Buton_Reset_Click);
            // 
            // dataGridPasageri
            // 
            this.dataGridPasageri.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridPasageri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPasageri.Location = new System.Drawing.Point(187, 232);
            this.dataGridPasageri.Name = "dataGridPasageri";
            this.dataGridPasageri.Size = new System.Drawing.Size(601, 142);
            this.dataGridPasageri.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(437, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Lista pasageri";
            // 
            // ComboNationalitate
            // 
            this.ComboNationalitate.FormattingEnabled = true;
            this.ComboNationalitate.Items.AddRange(new object[] {
            "Afghan",
            "Albanian",
            "Algerian",
            "American",
            "Andorran",
            "Angolan",
            "Antiguans",
            "Argentinean",
            "Armenian",
            "Australian",
            "Austrian",
            "Azerbaijani",
            "Bahamian",
            "Bahraini",
            "Bangladeshi",
            "Barbadian",
            "Barbudans",
            "Batswana",
            "Belarusian",
            "Belgian",
            "Belizean",
            "Beninese",
            "Bhutanese",
            "Bolivian",
            "Bosnian",
            "Brazilian",
            "British",
            "Bruneian",
            "Bulgarian",
            "Burkinabe",
            "Burmese",
            "Burundian",
            "Cambodian",
            "Cameroonian",
            "Canadian",
            "Cape Verdean",
            "Central African",
            "Chadian",
            "Chilean",
            "Chinese",
            "Colombian",
            "Comoran",
            "Congolese",
            "Costa Rican",
            "Croatian",
            "Cuban",
            "Cypriot",
            "Czech",
            "Danish",
            "Djibouti",
            "Dominican",
            "Dutch",
            "East Timorese",
            "Ecuadorean",
            "Egyptian",
            "Emirian",
            "Equatorial Guinean",
            "Eritrean",
            "Estonian",
            "Ethiopian",
            "Fijian",
            "Filipino",
            "Finnish",
            "French",
            "Gabonese",
            "Gambian",
            "Georgian",
            "German",
            "Ghanaian",
            "Greek",
            "Grenadian",
            "Guatemalan",
            "Guinea-Bissauan",
            "Guinean",
            "Guyanese",
            "Haitian",
            "Herzegovinian",
            "Honduran",
            "Hungarian",
            "I-Kiribati",
            "Icelander",
            "Indian",
            "Indonesian",
            "Iranian",
            "Iraqi",
            "Irish",
            "Israeli",
            "Italian",
            "Ivorian",
            "Jamaican",
            "Japanese",
            "Jordanian",
            "Kazakhstani",
            "Kenyan",
            "Kittian and Nevisian",
            "Kuwaiti",
            "Kyrgyz",
            "Laotian",
            "Latvian",
            "Lebanese",
            "Liberian",
            "Libyan",
            "Liechtensteiner",
            "Lithuanian",
            "Luxembourger",
            "Macedonian",
            "Malagasy",
            "Malawian",
            "Malaysian",
            "Maldivian",
            "Malian",
            "Maltese",
            "Marshallese",
            "Mauritanian",
            "Mauritian",
            "Mexican",
            "Micronesian",
            "Moldovan",
            "Monacan",
            "Mongolian",
            "Moroccan",
            "Mosotho",
            "Motswana",
            "Mozambican",
            "Namibian",
            "Nauruan",
            "Nepalese",
            "New Zealander",
            "Ni-Vanuatu",
            "Nicaraguan",
            "Nigerian",
            "Nigerien",
            "North Korean",
            "Northern Irish",
            "Norwegian",
            "Omani",
            "Pakistani",
            "Palauan",
            "Panamanian",
            "Papua New Guinean",
            "Paraguayan",
            "Peruvian",
            "Polish",
            "Portuguese",
            "Qatari",
            "Romanian",
            "Russian",
            "Rwandan",
            "Saint Lucian",
            "Salvadoran",
            "Samoan",
            "San Marinese",
            "Sao Tomean",
            "Saudi",
            "Scottish",
            "Senegalese",
            "Serbian",
            "Seychellois",
            "Sierra Leonean",
            "Singaporean",
            "Slovakian",
            "Slovenian",
            "Solomon Islander",
            "Somali",
            "South African",
            "South Korean",
            "Spanish",
            "Sri Lankan",
            "Sudanese",
            "Surinamer",
            "Swazi",
            "Swedish",
            "Swiss",
            "Syrian",
            "Taiwanese",
            "Tajik",
            "Tanzanian",
            "Thai",
            "Togolese",
            "Tongan",
            "Trinidadian or Tobagonian",
            "Tunisian",
            "Turkish",
            "Tuvaluan",
            "Ugandan",
            "Ukrainian",
            "Uruguayan",
            "Uzbekistani",
            "Venezuelan",
            "Vietnamese",
            "Welsh",
            "Yemenite",
            "Zambian",
            "Zimbabwean"});
            this.ComboNationalitate.Location = new System.Drawing.Point(486, 114);
            this.ComboNationalitate.Name = "ComboNationalitate";
            this.ComboNationalitate.Size = new System.Drawing.Size(99, 21);
            this.ComboNationalitate.TabIndex = 33;
            // 
            // ButtonCautare
            // 
            this.ButtonCautare.BackColor = System.Drawing.Color.MidnightBlue;
            this.ButtonCautare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCautare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCautare.ForeColor = System.Drawing.Color.LightGray;
            this.ButtonCautare.Location = new System.Drawing.Point(359, 174);
            this.ButtonCautare.Name = "ButtonCautare";
            this.ButtonCautare.Size = new System.Drawing.Size(84, 30);
            this.ButtonCautare.TabIndex = 34;
            this.ButtonCautare.Text = "Cauta";
            this.ButtonCautare.UseVisualStyleBackColor = false;
            this.ButtonCautare.Click += new System.EventHandler(this.ButtonCautare_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonCautare);
            this.Controls.Add(this.ComboNationalitate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridPasageri);
            this.Controls.Add(this.Buton_Reset);
            this.Controls.Add(this.Buton_Stergere);
            this.Controls.Add(this.Buton_Adauga);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.TxtPrenume);
            this.Controls.Add(this.TxtAdresa);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.TxtNume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasageri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNume;
        private System.Windows.Forms.TextBox TxtTelefon;
        private System.Windows.Forms.TextBox TxtAdresa;
        private System.Windows.Forms.TextBox TxtPrenume;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.Button Buton_Adauga;
        private System.Windows.Forms.Button Buton_Stergere;
        private System.Windows.Forms.Button Buton_Reset;
        private System.Windows.Forms.DataGridView dataGridPasageri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboNationalitate;
        private System.Windows.Forms.Button ButtonCautare;
    }
}