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
    public partial class Food_mass : UserControl
    {
        private Food_mass _instance;

        public Food_mass Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Food_mass();
                return _instance;
            }
        }
        public Food_mass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Schedule_mass Form = (Schedule_mass)Application.OpenForms["Schedule_mass"];
            Form.Close();
            Schedule_mass form_new = new Schedule_mass();
            form_new.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Select_FBW form = new Select_FBW();
            form.Show();
        }
    }
}
