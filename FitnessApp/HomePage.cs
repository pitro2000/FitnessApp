using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class HomePage : UserControl
    {

        private HomePage _instance;

        public HomePage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomePage();
                return _instance;
            }
        }

        public HomePage()
        {
            InitializeComponent();
           
            panel_body_home.Refresh();
            richTextBox_home.BackColor = Color.White;
        }

        private void panel_body_home_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Purple, 10);
            Graphics graphics = panel_body_home.CreateGraphics();
            graphics.DrawRectangle(pen, richTextBox_home.Location.X, richTextBox_home.Location.Y, richTextBox_home.Width, richTextBox_home.Height);
        }
    }
}
