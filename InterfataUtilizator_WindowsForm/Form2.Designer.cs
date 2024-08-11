
namespace InterfataUtilizator_WindowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Trenuri = new System.Windows.Forms.Button();
            this.PASAGERI = new System.Windows.Forms.Button();
            this.CALATORII = new System.Windows.Forms.Button();
            this.BILETE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.X);
            this.panel1.Location = new System.Drawing.Point(-8, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 77);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Silver;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(752, 27);
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
            this.panel2.Location = new System.Drawing.Point(-8, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 77);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(63, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 112);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(620, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 112);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(250, 141);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 112);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(442, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 112);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // Trenuri
            // 
            this.Trenuri.BackColor = System.Drawing.Color.Yellow;
            this.Trenuri.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Trenuri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Trenuri.Location = new System.Drawing.Point(81, 276);
            this.Trenuri.Name = "Trenuri";
            this.Trenuri.Size = new System.Drawing.Size(103, 47);
            this.Trenuri.TabIndex = 7;
            this.Trenuri.Text = "TRENURI";
            this.Trenuri.UseVisualStyleBackColor = false;
            this.Trenuri.Click += new System.EventHandler(this.Trenuri_Click);
            // 
            // PASAGERI
            // 
            this.PASAGERI.BackColor = System.Drawing.Color.MidnightBlue;
            this.PASAGERI.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PASAGERI.ForeColor = System.Drawing.Color.LightGray;
            this.PASAGERI.Location = new System.Drawing.Point(267, 276);
            this.PASAGERI.Name = "PASAGERI";
            this.PASAGERI.Size = new System.Drawing.Size(103, 47);
            this.PASAGERI.TabIndex = 8;
            this.PASAGERI.Text = "PASAGERI";
            this.PASAGERI.UseVisualStyleBackColor = false;
            this.PASAGERI.Click += new System.EventHandler(this.PASAGERI_Click);
            // 
            // CALATORII
            // 
            this.CALATORII.BackColor = System.Drawing.Color.Yellow;
            this.CALATORII.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CALATORII.Location = new System.Drawing.Point(456, 276);
            this.CALATORII.Name = "CALATORII";
            this.CALATORII.Size = new System.Drawing.Size(103, 47);
            this.CALATORII.TabIndex = 9;
            this.CALATORII.Text = "CALATORII";
            this.CALATORII.UseVisualStyleBackColor = false;
            this.CALATORII.Click += new System.EventHandler(this.CALATORII_Click);
            // 
            // BILETE
            // 
            this.BILETE.BackColor = System.Drawing.Color.MidnightBlue;
            this.BILETE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BILETE.ForeColor = System.Drawing.Color.LightGray;
            this.BILETE.Location = new System.Drawing.Point(633, 276);
            this.BILETE.Name = "BILETE";
            this.BILETE.Size = new System.Drawing.Size(103, 47);
            this.BILETE.TabIndex = 10;
            this.BILETE.Text = "BILETE";
            this.BILETE.UseVisualStyleBackColor = false;
            this.BILETE.Click += new System.EventHandler(this.BILETE_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(199, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 58);
            this.label1.TabIndex = 11;
            this.label1.Text = "             CFR SUCEAVA";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BILETE);
            this.Controls.Add(this.CALATORII);
            this.Controls.Add(this.PASAGERI);
            this.Controls.Add(this.Trenuri);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Trenuri;
        private System.Windows.Forms.Button PASAGERI;
        private System.Windows.Forms.Button CALATORII;
        private System.Windows.Forms.Button BILETE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button X;
    }
}