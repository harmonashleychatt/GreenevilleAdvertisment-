
namespace GreenvilleAdvertisment
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_fee = new System.Windows.Forms.CheckBox();
            this.checkBox_age = new System.Windows.Forms.CheckBox();
            this.checkBox_talent = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Greeneville Talent Competition";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBox_fee);
            this.panel1.Controls.Add(this.checkBox_age);
            this.panel1.Controls.Add(this.checkBox_talent);
            this.panel1.Location = new System.Drawing.Point(510, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 401);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a Checkbox For More Info\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox_fee
            // 
            this.checkBox_fee.AutoSize = true;
            this.checkBox_fee.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_fee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_fee.Location = new System.Drawing.Point(46, 144);
            this.checkBox_fee.Name = "checkBox_fee";
            this.checkBox_fee.Size = new System.Drawing.Size(66, 21);
            this.checkBox_fee.TabIndex = 2;
            this.checkBox_fee.Text = "Fees";
            this.checkBox_fee.UseVisualStyleBackColor = true;
            this.checkBox_fee.CheckedChanged += new System.EventHandler(this.checkBox_fee_CheckChanged);
            this.checkBox_fee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idk_KeyPress);
            // 
            // checkBox_age
            // 
            this.checkBox_age.AccessibleName = "checkBox_age";
            this.checkBox_age.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_age.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_age.Location = new System.Drawing.Point(46, 56);
            this.checkBox_age.Name = "checkBox_age";
            this.checkBox_age.Size = new System.Drawing.Size(104, 24);
            this.checkBox_age.TabIndex = 4;
            this.checkBox_age.Text = "Age Groups";
            this.checkBox_age.CheckedChanged += new System.EventHandler(this.checkBox_age_CheckedChanged);
            this.checkBox_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idk_KeyPress);
            // 
            // checkBox_talent
            // 
            this.checkBox_talent.AutoSize = true;
            this.checkBox_talent.Font = new System.Drawing.Font("Broadway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_talent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_talent.Location = new System.Drawing.Point(44, 249);
            this.checkBox_talent.Name = "checkBox_talent";
            this.checkBox_talent.Size = new System.Drawing.Size(184, 21);
            this.checkBox_talent.TabIndex = 0;
            this.checkBox_talent.Text = "Talent Categories";
            this.checkBox_talent.UseVisualStyleBackColor = true;
            this.checkBox_talent.CheckedChanged += new System.EventHandler(this.checkBox_talent_CheckChanged);
            this.checkBox_talent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idk_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_fee;
        private System.Windows.Forms.CheckBox checkBox_age;
        private System.Windows.Forms.CheckBox checkBox_talent;
        private System.Windows.Forms.Label label2;
    }
}

