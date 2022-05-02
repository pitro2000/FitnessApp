using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class Wyciskanie_na_modlitewniku : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1; // tworzenie uchwytu do panelu tzw. header'a ktorego sami projektujemy po wyrzuceniu domyślnego widoku typu Windows
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams //usunięcie migania panelów
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                CreateParams handleParam = base.CreateParams; // this and one below row is turning on double buffered and 
                //cp.ExStyle |= 0x02000000; // the panel isnt flashing but use it in user controls
                return cp;
            }
        }

      

        public Wyciskanie_na_modlitewniku()
        {
            InitializeComponent();
            
        }

        private void Panel_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // czy lewy przycisk myszy jest kliknięty na panelu Panel_header - jeśli tak to inicjujemy uchwyt i otrzymujemy możliwość "chwycenia apki"
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel_header_Paint(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(0, 0);
            Point endPoint = new Point(150, 150);

            LinearGradientBrush lgb =
                new LinearGradientBrush(startPoint, endPoint, Color.FromArgb(255, 100, 0, 0), Color.FromArgb(255, 20, 15, 0));
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, 0, 0, Panel_header.Width, Panel_header.Height);
        }

        private void Panel_navigate_Paint(object sender, PaintEventArgs e)
        {
            /*Point startPoint = new Point(0, 0);
            Point endPoint = new Point(150, 150);

            LinearGradientBrush lgb =
                new LinearGradientBrush(startPoint, endPoint, Color.FromArgb(255, 100, 0, 0), Color.FromArgb(255, 20, 15, 0));
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, 0, 0, Panel_navigate.Width, Panel_navigate.Height);*/
        }

    }
}
