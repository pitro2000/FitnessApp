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
    public partial class Plan_for_beginner : UserControl
    {
        private Plan_for_beginner _instance;

        public Plan_for_beginner Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Plan_for_beginner();
                return _instance;
            }
        }

        public Plan_for_beginner()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Select_FBW Form = (Select_FBW)Application.OpenForms["Select_FBW"];
            Form.Close();
            Select_FBW form_new = new Select_FBW();
            form_new.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Wykroki form = new Wykroki();
            form.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Wyciskanie_poziom form = new Wyciskanie_poziom();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Przysiad_sztanga form = new Przysiad_sztanga();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sciaganie_drazka form = new Sciaganie_drazka();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wyciskanie_dodatni form = new Wyciskanie_dodatni();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Wyciskanie_na_modlitewniku form = new Wyciskanie_na_modlitewniku();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pompki_porecze form = new Pompki_porecze();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Wspiecia_lydek form = new Wspiecia_lydek();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unoszenie_nog form = new Unoszenie_nog();
            form.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Martwy_Ciag form = new Martwy_Ciag();
            form.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Broda form = new Broda();
            form.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Wioslowanie_hantle form = new Wioslowanie_hantle();
            form.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Biceps form = new Biceps();
            form.Show();
        }
    }
}
