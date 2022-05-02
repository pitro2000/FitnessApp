namespace FitnessApp
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.Panel_header = new System.Windows.Forms.Panel();
            this.PictureBox_logo_icon = new System.Windows.Forms.PictureBox();
            this.Button_minimize = new System.Windows.Forms.Button();
            this.Button_exit = new System.Windows.Forms.Button();
            this.Panel_body = new System.Windows.Forms.Panel();
            this.Button_move_source = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_weglowodany = new System.Windows.Forms.TextBox();
            this.textBox_tluszcze = new System.Windows.Forms.TextBox();
            this.textBox_bialko = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_result_schedule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_title_schedule = new System.Windows.Forms.Label();
            this.Panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_logo_icon)).BeginInit();
            this.Panel_body.SuspendLayout();
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
            this.Panel_body.BackColor = System.Drawing.Color.White;
            this.Panel_body.Controls.Add(this.Button_move_source);
            this.Panel_body.Controls.Add(this.label6);
            this.Panel_body.Controls.Add(this.textBox_weglowodany);
            this.Panel_body.Controls.Add(this.textBox_tluszcze);
            this.Panel_body.Controls.Add(this.textBox_bialko);
            this.Panel_body.Controls.Add(this.label5);
            this.Panel_body.Controls.Add(this.label4);
            this.Panel_body.Controls.Add(this.label3);
            this.Panel_body.Controls.Add(this.textBox_result_schedule);
            this.Panel_body.Controls.Add(this.label2);
            this.Panel_body.Controls.Add(this.label1);
            this.Panel_body.Controls.Add(this.label_title_schedule);
            this.Panel_body.Location = new System.Drawing.Point(0, 100);
            this.Panel_body.Name = "Panel_body";
            this.Panel_body.Size = new System.Drawing.Size(1024, 700);
            this.Panel_body.TabIndex = 1;
            this.Panel_body.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_body_Paint_1);
            // 
            // Button_move_source
            // 
            this.Button_move_source.BackColor = System.Drawing.Color.Silver;
            this.Button_move_source.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_move_source.FlatAppearance.BorderSize = 0;
            this.Button_move_source.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_move_source.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_move_source.ForeColor = System.Drawing.Color.Black;
            this.Button_move_source.Location = new System.Drawing.Point(226, 450);
            this.Button_move_source.Name = "Button_move_source";
            this.Button_move_source.Size = new System.Drawing.Size(207, 71);
            this.Button_move_source.TabIndex = 37;
            this.Button_move_source.Text = "Rozpiska produktów -->";
            this.Button_move_source.UseVisualStyleBackColor = false;
            this.Button_move_source.Click += new System.EventHandler(this.Button_move_source_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(351, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Wartości w g/kg masy ciała";
            // 
            // textBox_weglowodany
            // 
            this.textBox_weglowodany.BackColor = System.Drawing.Color.White;
            this.textBox_weglowodany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_weglowodany.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_weglowodany.Location = new System.Drawing.Point(705, 334);
            this.textBox_weglowodany.Name = "textBox_weglowodany";
            this.textBox_weglowodany.ReadOnly = true;
            this.textBox_weglowodany.Size = new System.Drawing.Size(135, 22);
            this.textBox_weglowodany.TabIndex = 25;
            // 
            // textBox_tluszcze
            // 
            this.textBox_tluszcze.BackColor = System.Drawing.Color.White;
            this.textBox_tluszcze.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_tluszcze.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_tluszcze.Location = new System.Drawing.Point(705, 277);
            this.textBox_tluszcze.Name = "textBox_tluszcze";
            this.textBox_tluszcze.ReadOnly = true;
            this.textBox_tluszcze.Size = new System.Drawing.Size(135, 22);
            this.textBox_tluszcze.TabIndex = 24;
            // 
            // textBox_bialko
            // 
            this.textBox_bialko.BackColor = System.Drawing.Color.White;
            this.textBox_bialko.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_bialko.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_bialko.Location = new System.Drawing.Point(705, 212);
            this.textBox_bialko.Name = "textBox_bialko";
            this.textBox_bialko.ReadOnly = true;
            this.textBox_bialko.Size = new System.Drawing.Size(150, 22);
            this.textBox_bialko.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(113, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ilość spożywanych węglowodanów:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(113, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ilość spożywanych tłuszczy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(113, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ilość spożywanego białka:";
            // 
            // textBox_result_schedule
            // 
            this.textBox_result_schedule.BackColor = System.Drawing.Color.White;
            this.textBox_result_schedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_result_schedule.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_result_schedule.Location = new System.Drawing.Point(387, 105);
            this.textBox_result_schedule.Name = "textBox_result_schedule";
            this.textBox_result_schedule.ReadOnly = true;
            this.textBox_result_schedule.Size = new System.Drawing.Size(135, 22);
            this.textBox_result_schedule.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Twoje zapotrzebowanie wyniosło: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 3;
            // 
            // label_title_schedule
            // 
            this.label_title_schedule.AutoSize = true;
            this.label_title_schedule.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title_schedule.Location = new System.Drawing.Point(139, 36);
            this.label_title_schedule.Name = "label_title_schedule";
            this.label_title_schedule.Size = new System.Drawing.Size(745, 28);
            this.label_title_schedule.TabIndex = 2;
            this.label_title_schedule.Text = "Rozpiska makroskładników w zależności od Twojego zapotrzebowania";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 800);
            this.Controls.Add(this.Panel_body);
            this.Controls.Add(this.Panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Schedule";
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
        private System.Windows.Forms.Panel Panel_body;
        private System.Windows.Forms.PictureBox PictureBox_logo_icon;
        private System.Windows.Forms.Button Button_minimize;
        private System.Windows.Forms.Label label_title_schedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_weglowodany;
        private System.Windows.Forms.TextBox textBox_tluszcze;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_result_schedule;
        private System.Windows.Forms.TextBox textBox_bialko;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button_move_source;
    }
}

