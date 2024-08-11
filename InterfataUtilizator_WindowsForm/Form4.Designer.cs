
namespace InterfataUtilizator_WindowsForm
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxOra = new System.Windows.Forms.TextBox();
            this.textBoxSosire = new System.Windows.Forms.TextBox();
            this.textBoxPlecare = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Buton_Reset = new System.Windows.Forms.Button();
            this.Buton_Stergere = new System.Windows.Forms.Button();
            this.Buton_Adauga = new System.Windows.Forms.Button();
            this.dataGridCalatorii = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.trainBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.trainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ButonCautaare = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCalatorii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource4)).BeginInit();
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
            this.panel1.TabIndex = 14;
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
            this.label1.Text = "  ADMINISTRARE CALATORII";
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
            this.panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 312);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxOra
            // 
            this.textBoxOra.Location = new System.Drawing.Point(301, 106);
            this.textBoxOra.Name = "textBoxOra";
            this.textBoxOra.Size = new System.Drawing.Size(100, 20);
            this.textBoxOra.TabIndex = 18;
            // 
            // textBoxSosire
            // 
            this.textBoxSosire.Location = new System.Drawing.Point(617, 106);
            this.textBoxSosire.Name = "textBoxSosire";
            this.textBoxSosire.Size = new System.Drawing.Size(81, 20);
            this.textBoxSosire.TabIndex = 19;
            // 
            // textBoxPlecare
            // 
            this.textBoxPlecare.Location = new System.Drawing.Point(521, 106);
            this.textBoxPlecare.Name = "textBoxPlecare";
            this.textBoxPlecare.Size = new System.Drawing.Size(90, 20);
            this.textBoxPlecare.TabIndex = 20;
            this.textBoxPlecare.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(704, 106);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(84, 20);
            this.textBoxCost.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(217, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(339, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ora";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(537, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Plecare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(633, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Sosire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(711, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cost bilet";
            // 
            // Buton_Reset
            // 
            this.Buton_Reset.BackColor = System.Drawing.Color.MidnightBlue;
            this.Buton_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Reset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Reset.ForeColor = System.Drawing.Color.LightGray;
            this.Buton_Reset.Location = new System.Drawing.Point(666, 148);
            this.Buton_Reset.Name = "Buton_Reset";
            this.Buton_Reset.Size = new System.Drawing.Size(84, 30);
            this.Buton_Reset.TabIndex = 34;
            this.Buton_Reset.Text = "Reseteaza";
            this.Buton_Reset.UseVisualStyleBackColor = false;
            this.Buton_Reset.Click += new System.EventHandler(this.Buton_Reset_Click);
            // 
            // Buton_Stergere
            // 
            this.Buton_Stergere.BackColor = System.Drawing.Color.Yellow;
            this.Buton_Stergere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Stergere.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Stergere.Location = new System.Drawing.Point(526, 148);
            this.Buton_Stergere.Name = "Buton_Stergere";
            this.Buton_Stergere.Size = new System.Drawing.Size(84, 30);
            this.Buton_Stergere.TabIndex = 33;
            this.Buton_Stergere.Text = "Sterge";
            this.Buton_Stergere.UseVisualStyleBackColor = false;
            // 
            // Buton_Adauga
            // 
            this.Buton_Adauga.BackColor = System.Drawing.Color.Yellow;
            this.Buton_Adauga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buton_Adauga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Buton_Adauga.Location = new System.Drawing.Point(226, 148);
            this.Buton_Adauga.Name = "Buton_Adauga";
            this.Buton_Adauga.Size = new System.Drawing.Size(84, 30);
            this.Buton_Adauga.TabIndex = 31;
            this.Buton_Adauga.Text = "Adauga";
            this.Buton_Adauga.UseVisualStyleBackColor = false;
            this.Buton_Adauga.Click += new System.EventHandler(this.Buton_Adauga_Click);
            // 
            // dataGridCalatorii
            // 
            this.dataGridCalatorii.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridCalatorii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCalatorii.Location = new System.Drawing.Point(192, 220);
            this.dataGridCalatorii.Name = "dataGridCalatorii";
            this.dataGridCalatorii.Size = new System.Drawing.Size(596, 152);
            this.dataGridCalatorii.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(446, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Lista calatorii";
            // 
            // trainBindingSource6
            // 
            this.trainBindingSource6.DataSource = typeof(Clase_Tren.Train);
            // 
            // trainBindingSource5
            // 
            this.trainBindingSource5.DataSource = typeof(Clase_Tren.Train);
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataSource = typeof(Clase_Tren.Train);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(434, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "ID tren";
            // 
            // trainBindingSource1
            // 
            this.trainBindingSource1.DataSource = typeof(Clase_Tren.Train);
            // 
            // trainBindingSource2
            // 
            this.trainBindingSource2.DataSource = typeof(Clase_Tren.Train);
            // 
            // trainBindingSource3
            // 
            this.trainBindingSource3.DataSource = typeof(Clase_Tren.Train);
            // 
            // trainBindingSource4
            // 
            this.trainBindingSource4.DataSource = typeof(Clase_Tren.Train);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(202, 106);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker.TabIndex = 39;
            // 
            // ButonCautaare
            // 
            this.ButonCautaare.BackColor = System.Drawing.Color.MidnightBlue;
            this.ButonCautaare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButonCautaare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButonCautaare.ForeColor = System.Drawing.Color.LightGray;
            this.ButonCautaare.Location = new System.Drawing.Point(381, 148);
            this.ButonCautaare.Name = "ButonCautaare";
            this.ButonCautaare.Size = new System.Drawing.Size(84, 30);
            this.ButonCautaare.TabIndex = 40;
            this.ButonCautaare.Text = "Cauta";
            this.ButonCautaare.UseVisualStyleBackColor = false;
            this.ButonCautaare.Click += new System.EventHandler(this.ButonCautaare_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButonCautaare);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridCalatorii);
            this.Controls.Add(this.Buton_Reset);
            this.Controls.Add(this.Buton_Stergere);
            this.Controls.Add(this.Buton_Adauga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxPlecare);
            this.Controls.Add(this.textBoxSosire);
            this.Controls.Add(this.textBoxOra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCalatorii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource4)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxOra;
        private System.Windows.Forms.TextBox textBoxSosire;
        private System.Windows.Forms.TextBox textBoxPlecare;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Buton_Reset;
        private System.Windows.Forms.Button Buton_Stergere;
        private System.Windows.Forms.Button Buton_Adauga;
        private System.Windows.Forms.DataGridView dataGridCalatorii;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource trainBindingSource2;
        private System.Windows.Forms.BindingSource trainBindingSource3;
        private System.Windows.Forms.BindingSource trainBindingSource1;
        private System.Windows.Forms.BindingSource trainBindingSource4;
        private System.Windows.Forms.BindingSource trainBindingSource5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.BindingSource trainBindingSource6;
        private System.Windows.Forms.Button ButonCautaare;
    }
}