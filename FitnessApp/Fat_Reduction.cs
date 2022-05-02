using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FitnessApp
{
    public partial class Fat_Reduction : UserControl
    { 
        private Fat_Reduction _instance;

        public Fat_Reduction Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Fat_Reduction();
                return _instance;
            }
        }

        int Active_control = 0;
        int x_position = 0;
        bool is_clicked = false;
        int somatype = 0;
        bool Next = false;
              
            public Fat_Reduction()
        {
            InitializeComponent();
            //Change_window();
            comboBox_sex.Items.Add("Mężczyzna");
            comboBox_sex.Items.Add("Kobieta");

            // ----------------------------------- //

            comboBox_move.Items.Add("1.0 - brak aktywności fizycznej");
            comboBox_move.Items.Add("1.2 - praca siedząca, niski poziom aktywności");
            comboBox_move.Items.Add("1.4 - praca nie fizyczna, trening 2 razy w tygodniu");
            comboBox_move.Items.Add("1.6 - lekka praca fizyczna, trening 3-4 razy w tygodniu");
            comboBox_move.Items.Add("1.8 - praca fizyczna, trening 5 razy w tygodniu");
            comboBox_move.Items.Add("2.0 - ciężka praca fizyczna, codzienny trening");

            for (int i = 0; i <= 10; i++)
            {
                string name = "button_" + i.ToString();
                Button b = (Button) panel_body_reduction.Controls[name];
                b.Click += new EventHandler(button_Click);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (Active_control == 1)
            {
                textBox_weight.Text += button.Text;
            }
            else if (Active_control == 2)
            {
                textBox_height.Text += button.Text;
            }
            else if (Active_control == 3)
            {
                textBox_age.Text += button.Text;
            }
        }
        /*private double count_of_protein()
        {
            double protein = double.Parse(textBox_weight.Text, CultureInfo.InvariantCulture);
            return protein;
        }*/

        private void comboBox_sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveControl = panel_body_reduction;
        }

        private void comboBox_move_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveControl = panel_body_reduction;
        }

        private bool validation(List<string> text)
        {
            bool is_okay = true;
            foreach (var item in text)
            {
                if(item == string.Empty)
                {
                    is_okay = false;
                }
            }

            if(comboBox_sex.GetItemText(comboBox_sex.SelectedItem) == string.Empty || comboBox_move.GetItemText(comboBox_move.SelectedItem) == string.Empty)
            {
                is_okay = false;
            }

            if(somatype == 0)
            {
                is_okay = false;
            }

            return is_okay;
        }

        private void button_count_Click(object sender, EventArgs e)
        {
            List<string> objects = new List<string>();
            objects.Add(textBox_age.Text);
            objects.Add(textBox_height.Text);
            objects.Add(textBox_weight.Text);

            if (validation(objects))
            {
                if (comboBox_sex.GetItemText(comboBox_sex.SelectedItem) == "Kobieta")
                {
                    double a = 655 + (9.6 * double.Parse(textBox_weight.Text, CultureInfo.InvariantCulture) + (1.85 * double.Parse(textBox_height.Text, CultureInfo.InvariantCulture)) - (4.7 * double.Parse(textBox_age.Text, CultureInfo.InvariantCulture)));
                    textBox_result.Text = A_Ratio(a).ToString();
                }
                else
                {
                    double a = 66.5 + (13.7 * double.Parse(textBox_weight.Text, CultureInfo.InvariantCulture) + (5 * double.Parse(textBox_height.Text, CultureInfo.InvariantCulture)) - (6.8 * double.Parse(textBox_age.Text, CultureInfo.InvariantCulture)));
                    textBox_result.Text = A_Ratio(a).ToString();
                }
                Next = true;
            }
            else
                MessageBox.Show("Uzupełnij wszystkie dane!");
        }

        private double A_Ratio(double a)
        {
            
            double result = 0;

            switch (comboBox_move.GetItemText(comboBox_move.SelectedItem).Substring(0, 3))
            {
                case "1.0":
                    result = a * 1.0;
                    break;

                case "1.2":
                    result = a * 1.2;
                    break;

                case "1.4":
                    result = a * 1.4;
                    break;

                case "1.6":
                    result = a * 1.6;
                    break;

                case "1.8":
                    result = a * 1.8;
                    break;

                case "2.0":
                    result = a * 2.0;
                    break;
            }
            if (somatype == 1)
            {
                result *= 0.9;
            }
            else if (somatype == 2)
            {
                result *= 0.85;
            }
            else if(somatype == 3)
            {
                result *= 0.8;
            }
            return Math.Round(result, 2);
        }

        private void textBox_weight_MouseClick(object sender, MouseEventArgs e)
        {
            Active_control = 1;
        }

        private void textBox_height_MouseClick(object sender, MouseEventArgs e)
        {
            Active_control = 2;
        }

        private void textBox_age_MouseClick(object sender, MouseEventArgs e)
        {
            Active_control = 3;
        }

        private void pictureBox_type_MouseClick(object sender, MouseEventArgs e)
        {
            is_clicked = true;
            pictureBox_type.Refresh();
        }

        private void pictureBox_type_Paint(object sender, PaintEventArgs e)
        {
            if (is_clicked)
            {
                Pen pen = new Pen(Color.Black, 6);
                Graphics g = e.Graphics;

                if (x_position < 131)
                {
                    g.DrawRectangle(pen, 0, 0, 130, pictureBox_type.Size.Height);
                    somatype = 1;
                }
                else if (x_position > 130 && x_position < 261)
                {
                    g.DrawRectangle(pen, 131, 0, 130, pictureBox_type.Size.Height);
                    somatype = 2;
                }
                else
                {
                    g.DrawRectangle(pen, 261, 0, pictureBox_type.Size.Width - 261, pictureBox_type.Size.Height);
                    somatype = 3;
                }
            }
        }

        private void pictureBox_type_MouseMove(object sender, MouseEventArgs e)
        {
            x_position = e.X;
        }

      
        private void Button_move_Click(object sender, EventArgs e)
        {
            if (Next)
            {
                Data_Container.result_ = double.Parse(textBox_result.Text);
                Data_Container.protein_ = double.Parse(textBox_weight.Text);
                Schedule form = new Schedule();
                form.Show();
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (Active_control == 1)
                {
                    textBox_weight.Text = textBox_weight.Text.Remove(textBox_weight.Text.Length - 1, 1);
                }
                else if (Active_control == 2)
                {
                    textBox_height.Text = textBox_height.Text.Remove(textBox_height.Text.Length - 1, 1);
                }
                else if (Active_control == 3)
                {
                    textBox_age.Text = textBox_age.Text.Remove(textBox_age.Text.Length - 1, 1);
                }
            }
            catch
            {
                MessageBox.Show("Brak wartości do skasowania");
            }
        }

    }
}
