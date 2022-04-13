using System;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
namespace calculadora
{
    public partial class Calculadora : Form
    {
        #region Movendo_o_Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);
        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        public Calculadora()
        {
            InitializeComponent();
        }

      

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 97)
            {
               
                timer1.Start();
                btn_7_MouseUp();



                //fafaasf









                btn_7_Click(sender, e);
                e.Handled = true;
            }
            //e.Handled = true;
            
        }

        #region Adicionando_valores
        private void btn_1_Click(object sender, EventArgs e)
        {
            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
            {
                textBox_operation.Text = "1";
            }
            else
            {
                if (textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "+" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "-" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "x"||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "÷")
                {
                    textBox_operation.Text += " 1";
                }
                else
                    textBox_operation.Text += "1";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_operation.Text = "0";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {

            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
            {
                textBox_operation.Text = "2";

            }
            else
            {
                if (textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "+" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "-" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "x" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "÷")
                {
                    textBox_operation.Text += " 2";
                }
                else
                    textBox_operation.Text += "2";
            }

        }

        private void btn_3_Click(object sender, EventArgs e)
        {

            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
            {
                textBox_operation.Text = "3";

            }
            else
            {
                if (textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "+" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "-" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "x" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "÷")
                {
                    textBox_operation.Text += " 3";
                }
                else
                    textBox_operation.Text += "3";
            }

        }

        private void btn_4_Click(object sender, EventArgs e)
        {

            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
            {
                textBox_operation.Text = "4";

            }
            else
            {
                if (textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "+" ||
                     textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "-" ||
                     textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "x" ||
                     textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "÷")
                {
                    textBox_operation.Text += " 4";
                }
                else
                    textBox_operation.Text += "4";
            }

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
            {
                textBox_operation.Text = "5";

            }
            else
            {
                if (textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "+" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "-" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "x" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "÷")
                {
                    textBox_operation.Text += " 5";
                }
                else
                    textBox_operation.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
            {
                textBox_operation.Text = "6";
            }
            else
            {
                if (textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "+" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "-" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "x" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "÷")
                {
                    textBox_operation.Text += " 6";
                }
                else
                    textBox_operation.Text += "6";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
            {
                textBox_operation.Text = "8";
            }
            else
            {
                if (textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "+" ||
                     textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "-" ||
                     textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "x" ||
                     textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "÷")
                {
                    textBox_operation.Text += " 8";
                }
                else
                    textBox_operation.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
            {
                textBox_operation.Text = "9";
            }
            else
            {
                if (textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "+" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "-" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "x" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "÷")
                {
                    textBox_operation.Text += " 9";
                }
                else
                    textBox_operation.Text += "9";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
                textBox_operation.Text = "7";
            else
            {
                if (textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "+" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "-" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "x" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "÷")
                {
                    textBox_operation.Text += " 7";
                }
                else
                    textBox_operation.Text += "7";
            }
        }

        private void btn_null_Click(object sender, EventArgs e)
        {
            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
                textBox_operation.Text = "0";
            else
            {
                if (textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "+" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "-" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "x" ||
                    textBox_operation.Text[textBox_operation.Text.Length - 1].ToString() == "÷")
                {
                    textBox_operation.Text += " 0";
                }
                else
                    textBox_operation.Text += "0";
            }
        }
        #endregion
        #region Atalhos
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (!(textBox_operation.Text == "0" && textBox_operation.Text.Length == 1))
                if (textBox_operation.Text.Length - 1 > 0)
                {
                    textBox_operation.Text = textBox_operation.Text.Remove(textBox_operation.Text.Length - 1);
                    if (textBox_operation.Text[textBox_operation.Text.Length-1].ToString() == " ")
                    {
                        textBox_operation.Text = textBox_operation.Text.Remove(textBox_operation.Text.Length - 1);
                    }
                }
                    
                else
                    textBox_operation.Text = "0";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            string[] valores = textBox_operation.Text.Split(' ');
            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
                textBox_operation.Text += ".";

            else
            {
                if (!(textBox_operation.Text.Contains(".")))
                {
                    textBox_operation.Text += ".";
                }
                if (valores.Length >= 3)
                {
                    if (!(valores[2].Contains(".")))
                    {
                        textBox_operation.Text += ".";
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_operation.Text = "0";
            textBox_res.Text = "";
        }
        #endregion
        #region Adicionando_Operations
        private bool VerificaOperation()
        {
            string[] operations = new string[] { "+", "X", "-", "÷" };
            bool ver = false;
            foreach (var item in operations)
            {
                if (textBox_operation.Text.Contains(item))
                {
                    ver = true;
                    break;
                }
            }
            return ver;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
                textBox_operation.Text += " ÷ ";

            else
            {

                if (!VerificaOperation())
                {
                    textBox_operation.Text += " ÷ ";
                }

            }
        }

        private void btn_men_Click(object sender, EventArgs e)
        {
            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
                textBox_operation.Text += " - ";

            else
            {

                if (!VerificaOperation())
                {
                    textBox_operation.Text += " - ";
                }

            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {

            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
                textBox_operation.Text += " + ";

            else
            {

                if (!VerificaOperation())
                {
                    textBox_operation.Text +=  " + ";
                }

            }
        }
        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (textBox_operation.Text == "0" && textBox_operation.Text.Length == 1)
                textBox_operation.Text += " x ";

            else
            {

                if (!VerificaOperation())
                {
                    textBox_operation.Text += " x ";
                }

            }
        }
        #endregion
        #region Efetuando_Calculos
        private void btn_equals_Click(object sender, EventArgs e)
        {
            textBox_res.BackColor = Color.White;
            string[] valores;
            double valor_1, valor_2;
            string operation;
            if (!(textBox_operation.Text.Length < 4))
            {
                valores = textBox_operation.Text.Split(' ');
                valor_1 = Convert.ToDouble(valores[0], CultureInfo.InvariantCulture);
                valor_2 = Convert.ToDouble(valores[2], CultureInfo.InvariantCulture);
                operation = valores[1];
                switch (operation)
                {
                    case "+": textBox_res.Text = $"{valor_1 + valor_2}".ToString(CultureInfo.InstalledUICulture); break;
                    case "-": textBox_res.Text = $"{valor_1 - valor_2}".ToString(CultureInfo.InstalledUICulture); break;
                    case "x": textBox_res.Text = $"{valor_1 * valor_2}".ToString(CultureInfo.InstalledUICulture); break;
                    case "÷":
                        if (!(valor_2 == 0))
                            textBox_res.Text = $"{valor_1 / valor_2}".ToString(CultureInfo.InstalledUICulture);
                        else
                        {
                            
                            textBox_res.BackColor = Color.Red;
                            textBox_res.Text = "Impossivel";
                           
                        }
                            
                        break;
                    default:
                        break;
                }
            }
        }



        #endregion

        private void btn_7_MouseDown()
        {
            btn_7.BackColor = Color.FromArgb(93, 93, 93);
        }

        private void btn_7_MouseUp()
        {
            btn_7.BackColor = Color.FromArgb(6, 6, 6);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btn_7.BackColor = Color.FromArgb(93, 93, 93);
           // btn_7.BackColor = Color.FromArgb(6, 6, 6);
        }
    }
}
