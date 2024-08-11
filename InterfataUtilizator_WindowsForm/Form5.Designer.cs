
namespace InterfataUtilizator_WindowsForm
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewBilete = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.Buton_Reset = new System.Windows.Forms.Button();
            this.Buton_Stergere = new System.Windows.Forms.Button();
            this.Buton_Cautare = new System.Windows.Forms.Button();
            this.Buton_Adauga = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.X);
            this.panel1.Location = new System.Drawing.Point(-14, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 77);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(228, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "  ADMINISTRARE BILETE";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(-11, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 77);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 312);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(302, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID Pasager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(570, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "ID Calatorie";
            // 
            // dataGridViewBilete
            // 
            this.dataGridViewBilete.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridViewBilete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBilete.Location = new System.Drawing.Point(280, 220);
            this.dataGridViewBilete.Name = "dataGridViewBilete";
            this.dataGridViewBilete.Size = new System.Drawing.Size(391, 152);
            this.dataGridViewBilete.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(430, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Lista bilete";
            // 
            // Buton_Reset
            // 
            this.Buton_Reset.BackColor = System.Drawing.Color.MidnightBlue;
            this.Buton_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Reset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Reset.ForeColor = System.Drawing.Color.LightGray;
            this.Buton_Reset.Location = new System.Drawing.Point(666, 140);
            this.Buton_Reset.Name = "Buton_Reset";
            this.Buton_Reset.Size = new System.Drawing.Size(84, 30);
            this.Buton_Reset.TabIndex = 41;
            this.Buton_Reset.Text = "Reseteaza";
            this.Buton_Reset.UseVisualStyleBackColor = false;
            this.Buton_Reset.Click += new System.EventHandler(this.Buton_Reset_Click);
            // 
            // Buton_Stergere
            // 
            this.Buton_Stergere.BackColor = System.Drawing.Color.Yellow;
            this.Buton_Stergere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Stergere.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Stergere.Location = new System.Drawing.Point(526, 140);
            this.Buton_Stergere.Name = "Buton_Stergere";
            this.Buton_Stergere.Size = new System.Drawing.Size(84, 30);
            this.Buton_Stergere.TabIndex = 40;
            this.Buton_Stergere.Text = "Sterge";
            this.Buton_Stergere.UseVisualStyleBackColor = false;
            // 
            // Buton_Cautare
            // 
            this.Buton_Cautare.BackColor = System.Drawing.Color.MidnightBlue;
            this.Buton_Cautare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Cautare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Cautare.ForeColor = System.Drawing.Color.LightGray;
            this.Buton_Cautare.Location = new System.Drawing.Point(370, 140);
            this.Buton_Cautare.Name = "Buton_Cautare";
            this.Buton_Cautare.Size = new System.Drawing.Size(84, 30);
            this.Buton_Cautare.TabIndex = 39;
            this.Buton_Cautare.Text = "Cauta";
            this.Buton_Cautare.UseVisualStyleBackColor = false;
            this.Buton_Cautare.Click += new System.EventHandler(this.Buton_Cautare_Click);
            // 
            // Buton_Adauga
            // 
            this.Buton_Adauga.BackColor = System.Drawing.Color.Yellow;
            this.Buton_Adauga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Adauga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Adauga.Location = new System.Drawing.Point(226, 140);
            this.Buton_Adauga.Name = "Buton_Adauga";
            this.Buton_Adauga.Size = new System.Drawing.Size(84, 30);
            this.Buton_Adauga.TabIndex = 38;
            this.Buton_Adauga.Text = "Adauga";
            this.Buton_Adauga.UseVisualStyleBackColor = false;
            this.Buton_Adauga.Click += new System.EventHandler(this.Buton_Adauga_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Buton_Reset);
            this.Controls.Add(this.Buton_Stergere);
            this.Controls.Add(this.Buton_Cautare);
            this.Controls.Add(this.Buton_Adauga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewBilete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewBilete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Buton_Reset;
        private System.Windows.Forms.Button Buton_Stergere;
        private System.Windows.Forms.Button Buton_Cautare;
        private System.Windows.Forms.Button Buton_Adauga;
    }
}