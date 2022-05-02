namespace FitnessApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Panel_header = new System.Windows.Forms.Panel();
            this.PictureBox_logo_icon = new System.Windows.Forms.PictureBox();
            this.Button_minimize = new System.Windows.Forms.Button();
            this.Button_exit = new System.Windows.Forms.Button();
            this.Panel_body = new System.Windows.Forms.Panel();
            this.Panel_navigate = new System.Windows.Forms.Panel();
            this.label_mass = new System.Windows.Forms.Label();
            this.label_reduction = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_home = new System.Windows.Forms.Label();
            this.Button_fat_reduction = new System.Windows.Forms.Button();
            this.Button_home = new System.Windows.Forms.Button();
            this.Panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logo_icon)).BeginInit();
            this.Panel_navigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_header
            // 
            this.Panel_header.BackColor = System.Drawing.Color.CornflowerBlue;
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
            // PictureBox_logo_icon
            // 
            this.PictureBox_logo_icon.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_logo_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox_logo_icon.BackgroundImage")));
            this.PictureBox_logo_icon.Location = new System.Drawing.Point(43, 12);
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
            this.Panel_body.BackColor = System.Drawing.Color.Brown;
            this.Panel_body.Location = new System.Drawing.Point(164, 100);
            this.Panel_body.Name = "Panel_body";
            this.Panel_body.Size = new System.Drawing.Size(860, 700);
            this.Panel_body.TabIndex = 1;
            // 
            // Panel_navigate
            // 
            this.Panel_navigate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Panel_navigate.Controls.Add(this.label_mass);
            this.Panel_navigate.Controls.Add(this.label_reduction);
            this.Panel_navigate.Controls.Add(this.button1);
            this.Panel_navigate.Controls.Add(this.label_home);
            this.Panel_navigate.Controls.Add(this.Button_fat_reduction);
            this.Panel_navigate.Controls.Add(this.Button_home);
            this.Panel_navigate.Location = new System.Drawing.Point(0, 100);
            this.Panel_navigate.Name = "Panel_navigate";
            this.Panel_navigate.Size = new System.Drawing.Size(164, 700);
            this.Panel_navigate.TabIndex = 2;
            this.Panel_navigate.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_navigate_Paint);
            // 
            // label_mass
            // 
            this.label_mass.AutoSize = true;
            this.label_mass.BackColor = System.Drawing.Color.Transparent;
            this.label_mass.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold);
            this.label_mass.Location = new System.Drawing.Point(21, 344);
            this.label_mass.Name = "label_mass";
            this.label_mass.Size = new System.Drawing.Size(122, 21);
            this.label_mass.TabIndex = 7;
            this.label_mass.Text = "Budowa masy";
            // 
            // label_reduction
            // 
            this.label_reduction.AutoSize = true;
            this.label_reduction.BackColor = System.Drawing.Color.Transparent;
            this.label_reduction.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold);
            this.label_reduction.Location = new System.Drawing.Point(17, 229);
            this.label_reduction.Name = "label_reduction";
            this.label_reduction.Size = new System.Drawing.Size(132, 21);
            this.label_reduction.TabIndex = 6;
            this.label_reduction.Text = "Redukcja masy";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(43, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.BackColor = System.Drawing.Color.Transparent;
            this.label_home.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold);
            this.label_home.Location = new System.Drawing.Point(21, 113);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(125, 21);
            this.label_home.TabIndex = 0;
            this.label_home.Text = "Strona główna";
            // 
            // Button_fat_reduction
            // 
            this.Button_fat_reduction.BackColor = System.Drawing.Color.Transparent;
            this.Button_fat_reduction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_fat_reduction.BackgroundImage")));
            this.Button_fat_reduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_fat_reduction.FlatAppearance.BorderSize = 0;
            this.Button_fat_reduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_fat_reduction.Location = new System.Drawing.Point(52, 162);
            this.Button_fat_reduction.Name = "Button_fat_reduction";
            this.Button_fat_reduction.Size = new System.Drawing.Size(64, 64);
            this.Button_fat_reduction.TabIndex = 4;
            this.Button_fat_reduction.UseVisualStyleBackColor = false;
            this.Button_fat_reduction.Click += new System.EventHandler(this.Button_fat_reduction_Click);
            // 
            // Button_home
            // 
            this.Button_home.BackColor = System.Drawing.Color.Transparent;
            this.Button_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_home.BackgroundImage")));
            this.Button_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_home.FlatAppearance.BorderSize = 0;
            this.Button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_home.Location = new System.Drawing.Point(52, 46);
            this.Button_home.Name = "Button_home";
            this.Button_home.Size = new System.Drawing.Size(64, 64);
            this.Button_home.TabIndex = 3;
            this.Button_home.UseVisualStyleBackColor = false;
            this.Button_home.Click += new System.EventHandler(this.Button_home_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 800);
            this.Controls.Add(this.Panel_navigate);
            this.Controls.Add(this.Panel_body);
            this.Controls.Add(this.Panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "X";
            this.Panel_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logo_icon)).EndInit();
            this.Panel_navigate.ResumeLayout(false);
            this.Panel_navigate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_header;
        private System.Windows.Forms.Button Button_exit;
        private System.Windows.Forms.Button Button_minimize;
        private System.Windows.Forms.PictureBox PictureBox_logo_icon;
        private System.Windows.Forms.Panel Panel_body;
        private System.Windows.Forms.Panel Panel_navigate;
        private System.Windows.Forms.Button Button_home;
        private System.Windows.Forms.Button Button_fat_reduction;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_mass;
        private System.Windows.Forms.Label label_reduction;
    }
}

