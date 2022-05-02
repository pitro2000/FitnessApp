namespace FitnessApp
{
    partial class Select_FBW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_FBW));
            this.Panel_header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBox_logo_icon = new System.Windows.Forms.PictureBox();
            this.Button_minimize = new System.Windows.Forms.Button();
            this.Button_exit = new System.Windows.Forms.Button();
            this.Panel_body = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logo_icon)).BeginInit();
            this.Panel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_header
            // 
            this.Panel_header.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Panel_header.Controls.Add(this.panel1);
            this.Panel_header.Controls.Add(this.PictureBox_logo_icon);
            this.Panel_header.Controls.Add(this.Button_minimize);
            this.Panel_header.Controls.Add(this.Button_exit);
            this.Panel_header.Location = new System.Drawing.Point(0, 0);
            this.Panel_header.Name = "Panel_header";
            this.Panel_header.Size = new System.Drawing.Size(1024, 100);
            this.Panel_header.TabIndex = 0;
            this.Panel_header.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_header_Paint);
            this.Panel_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_header_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // PictureBox_logo_icon
            // 
            this.PictureBox_logo_icon.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_logo_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox_logo_icon.BackgroundImage")));
            this.PictureBox_logo_icon.Location = new System.Drawing.Point(28, 12);
            this.PictureBox_logo_icon.Name = "PictureBox_logo_icon";
            this.PictureBox_logo_icon.Size = new System.Drawing.Size(64, 64);
            this.PictureBox_logo_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_logo_icon.TabIndex = 2;
            this.PictureBox_logo_icon.TabStop = false;
            // 
            // Button_minimize
            // 
            this.Button_minimize.BackColor = System.Drawing.Color.Transparent;
            this.Button_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_minimize.BackgroundImage")));
            this.Button_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_minimize.FlatAppearance.BorderSize = 0;
            this.Button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_minimize.Location = new System.Drawing.Point(857, 12);
            this.Button_minimize.Name = "Button_minimize";
            this.Button_minimize.Size = new System.Drawing.Size(64, 64);
            this.Button_minimize.TabIndex = 1;
            this.Button_minimize.UseVisualStyleBackColor = false;
            this.Button_minimize.Click += new System.EventHandler(this.Button_minimize_Click);
            // 
            // Button_exit
            // 
            this.Button_exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_exit.BackgroundImage")));
            this.Button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_exit.FlatAppearance.BorderSize = 0;
            this.Button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_exit.Location = new System.Drawing.Point(938, 12);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(64, 64);
            this.Button_exit.TabIndex = 0;
            this.Button_exit.UseVisualStyleBackColor = false;
            this.Button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // Panel_body
            // 
            this.Panel_body.Controls.Add(this.label1);
            this.Panel_body.Controls.Add(this.button2);
            this.Panel_body.Controls.Add(this.button1);
            this.Panel_body.Location = new System.Drawing.Point(0, 98);
            this.Panel_body.Name = "Panel_body";
            this.Panel_body.Size = new System.Drawing.Size(1024, 712);
            this.Panel_body.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(275, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jaki jest Twój poziom zaawansowania?";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(294, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(441, 100);
            this.button2.TabIndex = 7;
            this.button2.Text = "Plan dla zaawansowanych";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(294, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(441, 100);
            this.button1.TabIndex = 6;
            this.button1.Text = "Plan dla początkujących";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Select_FBW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 800);
            this.Controls.Add(this.Panel_body);
            this.Controls.Add(this.Panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Select_FBW";
            this.Text = "X";
            this.Panel_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logo_icon)).EndInit();
            this.Panel_body.ResumeLayout(false);
            this.Panel_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_header;
        private System.Windows.Forms.Button Button_exit;
        private System.Windows.Forms.Button Button_minimize;
        private System.Windows.Forms.PictureBox PictureBox_logo_icon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_body;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

