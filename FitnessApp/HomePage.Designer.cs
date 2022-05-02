namespace FitnessApp
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel_body_home = new System.Windows.Forms.Panel();
            this.richTextBox_home = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_body_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home - Witam w mojej aplikacji";
            // 
            // panel_body_home
            // 
            this.panel_body_home.Controls.Add(this.pictureBox2);
            this.panel_body_home.Controls.Add(this.pictureBox1);
            this.panel_body_home.Controls.Add(this.richTextBox_home);
            this.panel_body_home.Controls.Add(this.label1);
            this.panel_body_home.Location = new System.Drawing.Point(0, 0);
            this.panel_body_home.Name = "panel_body_home";
            this.panel_body_home.Size = new System.Drawing.Size(860, 700);
            this.panel_body_home.TabIndex = 1;
            this.panel_body_home.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_body_home_Paint);
            // 
            // richTextBox_home
            // 
            this.richTextBox_home.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_home.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox_home.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.richTextBox_home.Location = new System.Drawing.Point(33, 62);
            this.richTextBox_home.Name = "richTextBox_home";
            this.richTextBox_home.ReadOnly = true;
            this.richTextBox_home.Size = new System.Drawing.Size(793, 552);
            this.richTextBox_home.TabIndex = 1;
            this.richTextBox_home.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 58);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(52, 283);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(774, 56);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_body_home);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(860, 700);
            this.panel_body_home.ResumeLayout(false);
            this.panel_body_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_body_home;
        private System.Windows.Forms.RichTextBox richTextBox_home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
