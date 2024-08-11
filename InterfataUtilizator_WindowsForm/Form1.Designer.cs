
namespace InterfataUtilizator_WindowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.textNumeTr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonLiber = new System.Windows.Forms.RadioButton();
            this.radioButtonOcupat = new System.Windows.Forms.RadioButton();
            this.Buton_Reset = new System.Windows.Forms.Button();
            this.Buton_Stergere = new System.Windows.Forms.Button();
            this.Buton_Adauga = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridTrenuri = new System.Windows.Forms.DataGridView();
            this.Disponibile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTrenuri)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 320);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(-10, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 77);
            this.panel2.TabIndex = 12;
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
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(197, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "       ADMINISTRARE TRENURI";
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
            this.back_button.TabIndex = 1;
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
            // textBoxCapacity
            // 
            this.textBoxCapacity.BackColor = System.Drawing.Color.White;
            this.textBoxCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCapacity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCapacity.Location = new System.Drawing.Point(412, 116);
            this.textBoxCapacity.Multiline = true;
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(125, 20);
            this.textBoxCapacity.TabIndex = 27;
            // 
            // textNumeTr
            // 
            this.textNumeTr.BackColor = System.Drawing.Color.White;
            this.textNumeTr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumeTr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeTr.Location = new System.Drawing.Point(234, 116);
            this.textNumeTr.Multiline = true;
            this.textNumeTr.Name = "textNumeTr";
            this.textNumeTr.Size = new System.Drawing.Size(119, 20);
            this.textNumeTr.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(655, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(441, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Capacitate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(231, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nume tren";
            // 
            // radioButtonLiber
            // 
            this.radioButtonLiber.AutoSize = true;
            this.radioButtonLiber.Location = new System.Drawing.Point(599, 119);
            this.radioButtonLiber.Name = "radioButtonLiber";
            this.radioButtonLiber.Size = new System.Drawing.Size(48, 17);
            this.radioButtonLiber.TabIndex = 31;
            this.radioButtonLiber.TabStop = true;
            this.radioButtonLiber.Text = "Liber";
            this.radioButtonLiber.UseVisualStyleBackColor = true;
            // 
            // radioButtonOcupat
            // 
            this.radioButtonOcupat.AutoSize = true;
            this.radioButtonOcupat.Location = new System.Drawing.Point(690, 119);
            this.radioButtonOcupat.Name = "radioButtonOcupat";
            this.radioButtonOcupat.Size = new System.Drawing.Size(60, 17);
            this.radioButtonOcupat.TabIndex = 32;
            this.radioButtonOcupat.TabStop = true;
            this.radioButtonOcupat.Text = "Ocupat";
            this.radioButtonOcupat.UseVisualStyleBackColor = true;
            // 
            // Buton_Reset
            // 
            this.Buton_Reset.BackColor = System.Drawing.Color.MidnightBlue;
            this.Buton_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Reset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Reset.ForeColor = System.Drawing.Color.LightGray;
            this.Buton_Reset.Location = new System.Drawing.Point(674, 163);
            this.Buton_Reset.Name = "Buton_Reset";
            this.Buton_Reset.Size = new System.Drawing.Size(84, 30);
            this.Buton_Reset.TabIndex = 36;
            this.Buton_Reset.Text = "Reseteaza";
            this.Buton_Reset.UseVisualStyleBackColor = false;
            this.Buton_Reset.Click += new System.EventHandler(this.Buton_Reset_Click);
            // 
            // Buton_Stergere
            // 
            this.Buton_Stergere.BackColor = System.Drawing.Color.Yellow;
            this.Buton_Stergere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Stergere.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Stergere.Location = new System.Drawing.Point(534, 163);
            this.Buton_Stergere.Name = "Buton_Stergere";
            this.Buton_Stergere.Size = new System.Drawing.Size(84, 30);
            this.Buton_Stergere.TabIndex = 35;
            this.Buton_Stergere.Text = "Sterge";
            this.Buton_Stergere.UseVisualStyleBackColor = false;
            this.Buton_Stergere.Click += new System.EventHandler(this.Buton_Stergere_Click);
            // 
            // Buton_Adauga
            // 
            this.Buton_Adauga.BackColor = System.Drawing.Color.Yellow;
            this.Buton_Adauga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Adauga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Adauga.Location = new System.Drawing.Point(234, 163);
            this.Buton_Adauga.Name = "Buton_Adauga";
            this.Buton_Adauga.Size = new System.Drawing.Size(84, 30);
            this.Buton_Adauga.TabIndex = 33;
            this.Buton_Adauga.Text = "Adauga";
            this.Buton_Adauga.UseVisualStyleBackColor = false;
            this.Buton_Adauga.Click += new System.EventHandler(this.Buton_Adauga_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(437, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Lista trenuri";
            // 
            // dataGridTrenuri
            // 
            this.dataGridTrenuri.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridTrenuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTrenuri.Location = new System.Drawing.Point(266, 228);
            this.dataGridTrenuri.Name = "dataGridTrenuri";
            this.dataGridTrenuri.Size = new System.Drawing.Size(435, 142);
            this.dataGridTrenuri.TabIndex = 37;
            // 
            // Disponibile
            // 
            this.Disponibile.BackColor = System.Drawing.Color.MidnightBlue;
            this.Disponibile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Disponibile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Disponibile.ForeColor = System.Drawing.Color.LightGray;
            this.Disponibile.Location = new System.Drawing.Point(387, 163);
            this.Disponibile.Name = "Disponibile";
            this.Disponibile.Size = new System.Drawing.Size(84, 30);
            this.Disponibile.TabIndex = 39;
            this.Disponibile.Text = "Libere";
            this.Disponibile.UseVisualStyleBackColor = false;
            this.Disponibile.Click += new System.EventHandler(this.Disponibile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Disponibile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridTrenuri);
            this.Controls.Add(this.Buton_Reset);
            this.Controls.Add(this.Buton_Stergere);
            this.Controls.Add(this.Buton_Adauga);
            this.Controls.Add(this.radioButtonOcupat);
            this.Controls.Add(this.radioButtonLiber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textNumeTr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTrenuri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.TextBox textNumeTr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonLiber;
        private System.Windows.Forms.RadioButton radioButtonOcupat;
        private System.Windows.Forms.Button Buton_Reset;
        private System.Windows.Forms.Button Buton_Stergere;
        private System.Windows.Forms.Button Buton_Adauga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridTrenuri;
        private System.Windows.Forms.Button Disponibile;
    }
}

