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
    public partial class Advanced_Plan : UserControl
    {
        private Advanced_Plan _instance;

        public Advanced_Plan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Advanced_Plan();
                return _instance;
            }
        }

        public Advanced_Plan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Select_FBW Form = (Select_FBW)Application.OpenForms["Select_FBW"];
            Form.Close();
            Select_FBW form_new = new Select_FBW();
            form_new.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Martwy_Ciag form = new Martwy_Ciag();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prostowanie_nog form = new Prostowanie_nog();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wyciskanie_sztangi_nad_glowe form = new Wyciskanie_sztangi_nad_glowe();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Wyciskanie_na_modlitewniku form = new Wyciskanie_na_modlitewniku();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Triceps_linki form = new Triceps_linki();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Przysiad_suwnica form = new Przysiad_suwnica();
            form.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Przysiad_sztanga form = new Przysiad_sztanga();
            form.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Prostowanie_nog form = new Prostowanie_nog();
            form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Wspiecia_lydek form = new Wspiecia_lydek();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Wioslowanie form = new Wioslowanie();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Wyciskanie_poziom form = new Wyciskanie_poziom();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sciaganie_drazka form = new Sciaganie_drazka();
            form.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Arnoldki form = new Arnoldki();
            form.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Podciaganie_nachwytem form = new Podciaganie_nachwytem();
            form.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Wyciskanie_dodatni form = new Wyciskanie_dodatni();
            form.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Wioslowanie_hantle form = new Wioslowanie_hantle();
            form.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Wykroki form = new Wykroki();
            form.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Rozpietki form = new Rozpietki();
            form.Show();
        }
    }
}
