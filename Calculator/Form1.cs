using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.IO;


namespace Calculator
{
    public partial class Form1 : Form
    {

        int sign_Indicator = 0;
        double variable1;
        double variable2;
        int addBit = 0;
        int subBit = 0;
        int multBit = 0;
        int divBit = 0;
        int modBit = 0;
        int powerBit = 0;
        Boolean fl = false;
        String s, x;

        private void reset_SignBits()
        {
            addBit = 0;
            subBit = 0;
            multBit = 0;
            divBit = 0;
            modBit = 0;
            powerBit = 0;
            fl = false;
        }

        private void voiceoff()
        {
            voice.SpeakAsyncCancelAll();
        }

        private void calculate()
        {
            if (textBox1.Text != ".")
            {
                variable2 = Convert.ToDouble(textBox1.Text);
                if (fl == false)
                {
                    variable1 = variable2;
                }
                else if (addBit == 1)
                {
                    variable1 = variable1 + variable2;
                }
                else if (subBit == 1)
                {
                    variable1 = variable1 - variable2;
                }
                else if (multBit == 1)
                {
                    variable1 = variable1 * variable2;
                }
                else if (divBit == 1)
                {
                    variable1 = variable1 / variable2;
                }
                else if (modBit == 1)
                {

                    variable2 = Convert.ToInt32(textBox1.Text);
                    variable1 = Convert.ToInt32(variable1 % variable2);
                }

                else
                {
                    variable1 = variable2;
                }
                textBox1.Text = Convert.ToString(variable1);

            }
        }


        SpeechSynthesizer voice = new SpeechSynthesizer();
        int rate = 0;

        public Point mL;

       

        public Form1()
        {
            InitializeComponent();
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mL = new Point(-e.X, -e.Y);
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                Point mP = Control.MousePosition;
                mP.Offset(mL.X, mL.Y);
                Location = mP;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            mL = new Point(-e.X, -e.Y);
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mP = Control.MousePosition;
                mP.Offset(mL.X, mL.Y);
                Location = mP;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(1);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(1);
                sign_Indicator = 0;
            }
            fl = true;
            voice.SpeakAsyncCancelAll();
            string adad = textBox1.Text;
            voice.Volume = 100;
            voice.Rate = rate;
            voice.SpeakAsync(adad);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(2);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(2);
                sign_Indicator = 0;
            }
            fl = true;
            voice.SpeakAsyncCancelAll();
            string adad = textBox1.Text;
            voice.Volume = 100;
            voice.Rate = rate;
            voice.SpeakAsync(adad);


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(3);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(3);
                sign_Indicator = 0;
            }
            fl = true;
            voice.SpeakAsyncCancelAll();
            string adad = textBox1.Text;
            voice.Volume = 100;
            voice.Rate = rate;
            voice.SpeakAsync(adad);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(4);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(4);
                sign_Indicator = 0;
            }
            fl = true;
            voice.SpeakAsyncCancelAll();
            string adad = textBox1.Text;
            voice.Volume = 100;
            voice.Rate = rate;
            voice.SpeakAsync(adad);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(5);
               
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(5);
                sign_Indicator = 0;
                
            }
            fl = true;
            voice.SpeakAsyncCancelAll();
            string adad = textBox1.Text;
            voice.Volume = 100;
            voice.Rate = rate;
            voice.SpeakAsync(adad);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(6);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(6);
                sign_Indicator = 0;
            }
            fl = true;
            voice.SpeakAsyncCancelAll();
            string adad = textBox1.Text;
            voice.Volume = 100;
            voice.Rate = rate;
            voice.SpeakAsync(adad);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(7);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(7);
                sign_Indicator = 0;
            }
            fl = true;
            voice.SpeakAsyncCancelAll();
            string adad = textBox1.Text;
            voice.Volume = 100;
            voice.Rate = rate;
            voice.SpeakAsync(adad);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(8);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(8);
                sign_Indicator = 0;
            }
            fl = true;
            voice.SpeakAsyncCancelAll();
            string adad = textBox1.Text;
            voice.Volume = 100;
            voice.Rate = rate;
            voice.SpeakAsync(adad);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(9);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(9);
                sign_Indicator = 0;
            }
            fl = true;
            voice.SpeakAsyncCancelAll();
            string adad = textBox1.Text;
            voice.Volume = 100;
            voice.Rate = rate;
            voice.SpeakAsync(adad);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(0);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(0);
                sign_Indicator = 0;
            }
            fl = true;
            voice.SpeakAsyncCancelAll();
            string adad = textBox1.Text;
            voice.Volume = 100;
            voice.Rate = rate;
            voice.SpeakAsync(adad);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            int i = 0;
            char chr = '\0';
            int decimal_Indicator = 0;
            int l = textBox1.Text.Length - 1;
            if (sign_Indicator != 1)
            {
                for (i = 0; i <= l; i++)
                {
                    chr = textBox1.Text[i];
                    if (chr == '.')
                    {
                        decimal_Indicator = 1;
                    }
                }
                

                if (decimal_Indicator != 1)
                {
                    textBox1.Text = textBox1.Text + Convert.ToString(".");
                }
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                addBit = 1;
                sign_Indicator = 1;
                textBox1.Text = textBox1.Text + " + ";
                label2.Text = textBox1.Text;
                textBox1.Clear();
                voice.SpeakAsyncCancelAll();
                string adad = "Plus";
                voice.Volume = 100;
                voice.Rate = rate;
                voice.SpeakAsync(adad);
            }
            
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length != 0)
            {
                
                label2.Text = label2.Text + textBox1.Text;
                calculate();
                reset_SignBits();
                voice.SpeakAsyncCancelAll();
                string adad = "equals to" + textBox1.Text;
                voice.Volume = 100;
                voice.Rate = rate;
                voice.SpeakAsync(adad);
            }
            sign_Indicator = 1;
            //label2.Text = label2.Text + " = " + textBox1.Text;
            //textBox1.Clear();
            

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                variable2 = Convert.ToDouble(textBox1.Text);
                calculate();
                reset_SignBits();
                subBit = 1;
                sign_Indicator = 1;
                textBox1.Text = textBox1.Text + " - ";
                label2.Text = textBox1.Text;
                textBox1.Clear();
                voice.SpeakAsyncCancelAll();
                string adad = "Minus";
                voice.Volume = 100;
                voice.Rate = rate;
                voice.SpeakAsync(adad);
            }
            
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                divBit = 1;
                sign_Indicator = 1;
                textBox1.Text = textBox1.Text + " ÷ ";
                label2.Text = textBox1.Text;
                textBox1.Clear();
                voice.SpeakAsyncCancelAll();
                string adad = "Division";
                voice.Volume = 100;
                voice.Rate = rate;
                voice.SpeakAsync(adad);

            }
           
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                multBit = 1;
                sign_Indicator = 1;
                textBox1.Text = textBox1.Text + " × ";
                label2.Text = textBox1.Text;
                textBox1.Clear();
                voice.SpeakAsyncCancelAll();
                string adad = "Multiplication";
                voice.Volume = 100;
                voice.Rate = rate;
                voice.SpeakAsync(adad);

            }
            
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    label2.Text = "Sin" + textBox1.Text;
                    voice.SpeakAsyncCancelAll();
                    string adad = "sinus" + textBox1.Text;
                    voice.Volume = 100;
                    voice.Rate = rate;
                    voice.SpeakAsync(adad);
                    l = Math.Sin(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                    string sin = "equals to" + textBox1.Text;
                    voice.Volume = 100;
                    voice.Rate = rate;
                    voice.SpeakAsync(sin);
                }
                sign_Indicator = 1;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            label2.Text = "Cleared!";
            sign_Indicator = 0;
            variable1 = 0;
            variable2 = 0;
            reset_SignBits();
            voice.SpeakAsyncCancelAll();
            string adad = "Cleared!";
            voice.Volume = 100;
            voice.Rate = rate;
            voice.SpeakAsync(adad);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    label2.Text = "Cos" + textBox1.Text;
                    voice.SpeakAsyncCancelAll();
                    string adad = "Cosine" + textBox1.Text;
                    voice.Volume = 100;
                    voice.Rate = rate;
                    voice.SpeakAsync(adad);
                    l = Math.Cos(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                    string cos = "equals to" + textBox1.Text;
                    voice.Volume = 100;
                    voice.Rate = rate;
                    voice.SpeakAsync(cos);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    label2.Text = "Tan" + textBox1.Text;
                    voice.SpeakAsyncCancelAll();
                    string adad = "Tangent" + textBox1.Text;
                    voice.Volume = 100;
                    voice.Rate = rate;
                    voice.SpeakAsync(adad);
                    l = Math.Tan(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                    string tan = "equals to" + textBox1.Text;
                    voice.Volume = 100;
                    voice.Rate = rate;
                    voice.SpeakAsync(tan);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            try
            {
                double s, l;
                label2.Text = "Sqrt " + textBox1.Text;
                l = Convert.ToDouble(textBox1.Text);
                s = Math.Sqrt(l);
                textBox1.Text = Convert.ToString(s);
                voice.SpeakAsyncCancelAll();
                string adad = label2.Text + "equals to" + textBox1.Text;
                voice.Volume = 100;
                voice.Rate = rate;
                voice.SpeakAsync(adad);
            }
            catch
            {
                label2.Text = "Wrong!";
                voice.SpeakAsyncCancelAll();
                string adad = label2.Text;
                voice.Volume = 100;
                voice.Rate = rate;
                voice.SpeakAsync(adad);
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
            string hello = "Hello";
            voice.Volume = 100;
            voice.Rate = rate;
            voice.SpeakAsync(hello);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button21.Enabled = false;
            }
            else
            {
                button21.Enabled = true;
            }
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(100);
            pictureBox1.Image = Calculator.Properties.Resources.close;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
           //System.Threading.Thread.Sleep(100);
            pictureBox1.Image = Calculator.Properties.Resources._1200px_Breezeicons_actions_22_window_close_svg;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled == false)
            {
                pictureBox2.Image = Calculator.Properties.Resources.mute;
                timer2.Enabled = true;
            }
            else
            {
                pictureBox2.Image = Calculator.Properties.Resources._13_133213_big_image_mute_and_unmute_icon_clipart;
                timer2.Enabled = false;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            voiceoff();
        }

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
                
            
           
        }

        private void PictureBox2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox2.Image = Calculator.Properties.Resources._13_133213_big_image_mute_and_unmute_icon_clipart;
            timer2.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
            this.Close();
        }
    }
}
