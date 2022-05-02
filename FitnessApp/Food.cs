using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class Food : UserControl
    {
        private Food _instance;

        public Food Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Food();
                return _instance;
            }
        }

        public Food()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Schedule Form = (Schedule)Application.OpenForms["Schedule"];
            Form.Close();
            Schedule form_new = new Schedule();
            form_new.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Select_FBW form = new Select_FBW();
            form.Show();
        }
    }
}
