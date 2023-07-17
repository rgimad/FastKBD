using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastKBD
{
    public partial class MainForm : Form
    {
        public static bool isCaps = false;

        public MainForm()
        {
            InitializeComponent();
            var h = new EventHandler(buttonClicked);
            button1.Click += h;
            button2.Click += h;
            button3.Click += h;
            button4.Click += h;
            button5.Click += h;
            button6.Click += h;
            button7.Click += h;
            button8.Click += h;
            button9.Click += h;
            button10.Click += h;
            button11.Click += h;
            button12.Click += h;
            button13.Click += h;
            button14.Click += h;
            button15.Click += h;
            button16.Click += h;
            button17.Click += h;
            button18.Click += h;
            button19.Click += h;
            button20.Click += h;
            button21.Click += h;
            button22.Click += h;
            button23.Click += h;
            button24.Click += h;
            button25.Click += h;
            button26.Click += h;
            button27.Click += h;
            button28.Click += h;
            button29.Click += h;
            button30.Click += h;
            button31.Click += h;

            // Cyrillic
            button1.Text = "\u04D9";
            button2.Text = "\u04E9";
            button3.Text = "\u04AF";
            button4.Text = "\u0497";
            button5.Text = "\u04A3";
            button6.Text = "\u04BB";
            button19.Text = "\u049B";
            button20.Text = "\u0493";
            button21.Text = "\u04B1";
            button22.Text = "\u0456";
            button23.Text = "\u0495";
            button24.Text = "\u048B";
            button25.Text = "\u04A5";
            button26.Text = "\u04D1";
            button27.Text = "\u04D7";
            button28.Text = "\u04F3";
            button29.Text = "\u04AB";
            button30.Text = "\u0499";
            button31.Text = "\u04A1";

            // Latin Turkish
            button7.Text = "\u00F6";
            button8.Text = "\u00FC";
            button9.Text = "\u00E7";
            button10.Text = "\u015F";
            button11.Text = "\u011F";
            button12.Text = "\u0069";
            button13.Text = "\u0131";

            // Other Latin
            button14.Text = "\u00E4";
            button15.Text = "\u00F1";
            button16.Text = "\u017E";
            button17.Text = "\u00FD";
            button18.Text = "\u0148";

            

            isCaps = false;
        }

        // We need to inactivate this application always.
        // If we do so, we can type the letters in active windows
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // toggle letters case
        void buttonsToUpperCase()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (!button.Name.StartsWith("button"))
                {
                    continue;
                }
                // workaround for Turkish i leters
                if (button.Name == "button12" || button.Name == "button13")
                {
                    if (!isCaps)
                    {
                        button.Text = button.Text.ToUpper(new CultureInfo("tr-TR"));
                    } else
                    {
                        button.Text = button.Text.ToLower(new CultureInfo("tr-TR"));
                    }
                } else // common:
                {
                    if (!isCaps)
                    {
                        button.Text = button.Text.ToUpper();
                    }
                    else
                    {
                        button.Text = button.Text.ToLower();
                    }
                }
            }
            isCaps = !isCaps;
        }

        void buttonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;            
            SendKeys.Send(button.Text);
        }

        private void btnCaps_Click(object sender, EventArgs e)
        {
            buttonsToUpperCase();
        }
    }
}
