using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calculator_math
{
    public partial class Form1 : Form
    {
        public Form1() //initializarea calculatorului
        {
            InitializeComponent();
            simpleCalculatorToolStripMenuItem.Checked = true;
            advancedCalculatorToolStripMenuItem.Checked = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            textBox1.Text = "0";
            this.Width = 397;
            this.Height = 380;
            label1.Text = "0";
           
         
        }
        public const double PI =  3.14159265358979323846; //constanta pi
        public const double E = 2.7182818284590452354; //constanta e
        double a = 0;

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "("+textBox1.Text+")";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        bool zero = false;
        private void button1_Click(object sender, EventArgs e) //butoanele 1->9 au rolul de a adauga cifre la numarul din textbox
        {
            if (kek == true)
                textBox1.Clear();
            kek = false;
            if (((zero == false) && (textBox1.Text == "0")) || (textBox1.Text == " "))
                textBox1.Text = "1";
            else
                if ((zero == true) && (textBox1.Text == "0"))
                    textBox1.Text = textBox1.Text + ",1";
                else
                    if (textBox1.Text != "0")
                        textBox1.Text = textBox1.Text + '1';
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kek == true)
                textBox1.Clear();
            kek = false;
            if (((zero == false) && (textBox1.Text == "0")) || (textBox1.Text == " "))
                textBox1.Text = "2";
            else
                if ((zero == true) && (textBox1.Text == "0"))
                    textBox1.Text = textBox1.Text + ",2";
                else
                    if (textBox1.Text != "0")
                        textBox1.Text = textBox1.Text + '2';
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kek == true)
                textBox1.Clear();
            kek = false;
            if (((zero == false) && (textBox1.Text == "0")) || (textBox1.Text == " "))
                textBox1.Text = "3";
            else
                if ((zero == true) && (textBox1.Text == "0"))
                    textBox1.Text = textBox1.Text + ",3";
                else
                    if (textBox1.Text != "0")
                        textBox1.Text = textBox1.Text + '3';
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kek == true)
                textBox1.Clear();
            kek = false;
            if (((zero == false) && (textBox1.Text == "0")) || (textBox1.Text == " "))
                textBox1.Text = "4";
            else
                if ((zero == true) && (textBox1.Text == "0"))
                    textBox1.Text = textBox1.Text + ",4";
               else
                    if (textBox1.Text != "0")
                        textBox1.Text = textBox1.Text + '4';
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (kek == true)
                textBox1.Clear();
            kek = false;

            if (((zero == false) && (textBox1.Text == "0")) || (textBox1.Text == " "))
                textBox1.Text = "5";
            else
                if ((zero == true) && (textBox1.Text == "0"))
                    textBox1.Text = textBox1.Text + ",5";
                else
                    if (textBox1.Text != "0")
                        textBox1.Text = textBox1.Text + '5';
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (kek == true)
                textBox1.Clear();
            kek = false;

            if (((zero == false) && (textBox1.Text == "0")) || (textBox1.Text == " "))
                textBox1.Text = "6";
            else
                if ((zero == true) && (textBox1.Text == "0"))
                    textBox1.Text = textBox1.Text + ",6";
                else
                    if (textBox1.Text != "0")
                        textBox1.Text = textBox1.Text + '6';
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (kek == true)
                textBox1.Clear();
            kek = false;

            if (((zero == false) && (textBox1.Text == "0")) || (textBox1.Text == " "))
                textBox1.Text = "7";
            else
                if ((zero == true) && (textBox1.Text == "0"))
                    textBox1.Text = textBox1.Text + ",7";
                else
                    if (textBox1.Text != "0")
                        textBox1.Text = textBox1.Text + '7';
           
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (kek == true)
                textBox1.Clear();
            kek = false;
            if (((zero == false) && (textBox1.Text == "0")) || (textBox1.Text == " "))
                textBox1.Text = "8";
            else
                if ((zero == true) && (textBox1.Text == "0"))
                    textBox1.Text = textBox1.Text + ",8";
                else
                    if (textBox1.Text != "0")
                        textBox1.Text = textBox1.Text + '8';
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (kek == true)
                textBox1.Clear();
            kek = false;

            if (((zero == false) && (textBox1.Text == "0")) || (textBox1.Text == " "))
                textBox1.Text = "9";
            else
                if ((zero == true) && (textBox1.Text == "0"))
                    textBox1.Text = textBox1.Text + ",9";
                else
                    if (textBox1.Text != "0")
                        textBox1.Text = textBox1.Text + '9';
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (kek == true)
                textBox1.Clear();
            kek = false;
            zero = true; //variabila in caz ca am apasat 0 sau nu, atunci cand deschidem calculatorul si afiseaza in textbox 0
            if (((zero == false) && (textBox1.Text == "0")) || (textBox1.Text == " "))
                textBox1.Text = "0";
            else
                if ((zero == true) && (textBox1.Text == "0"))
                    textBox1.Text = textBox1.Text + ",0";
                else
                    if (textBox1.Text != "0")
                        textBox1.Text = textBox1.Text + '0';
            
        }

        private void button20_Click(object sender, EventArgs e) //sinus
        {   if (button30.Text == "Radians")
            textBox1.Text = "sin("+textBox1.Text+")=" + Convert.ToString(Math.Sin(Double.Parse(textBox1.Text)));
        else
            if (button30.Text == "Degrees")
                textBox1.Text = "sin(" + textBox1.Text + ")=" + Convert.ToString(Math.Sin((180/PI)*Double.Parse(textBox1.Text)));
        }

        private void button21_Click(object sender, EventArgs e) //cosinus
        {
            if (button30.Text == "Radians")
                textBox1.Text = "cos(" + textBox1.Text + ")=" + Convert.ToString(Math.Cos(Double.Parse(textBox1.Text)));
            else
                if (button30.Text == "Degrees")
                    textBox1.Text = "cos(" + textBox1.Text + ")=" + Convert.ToString(Math.Cos((180 / PI) * Double.Parse(textBox1.Text)));
        }

        private void button22_Click(object sender, EventArgs e) //tangenta
        {

            if (button30.Text == "Radians")
                textBox1.Text = "tg(" + textBox1.Text + ")=" + Convert.ToString(Math.Tan(Double.Parse(textBox1.Text)));
            else
                if (button30.Text == "Degrees")
                    textBox1.Text = "tg(" + textBox1.Text + ")=" + Convert.ToString(Math.Tan((180 / PI) * Double.Parse(textBox1.Text)));
            
        }

        private void button18_Click(object sender, EventArgs e) //radacina patrata
        {
            textBox1.Text = "rad(" + textBox1.Text + ")=" + Convert.ToString(Math.Sqrt(Double.Parse(textBox1.Text)));
            
        }

        private void button23_Click(object sender, EventArgs e)  //cotangenta
        {
            if (button30.Text == "Radians")
                textBox1.Text = "ctg(" + textBox1.Text + ")=" + Convert.ToString(1/Math.Tan(Double.Parse(textBox1.Text)));
            else
                if (button30.Text == "Degrees")
                    textBox1.Text = "ctg(" + textBox1.Text + ")=" + Convert.ToString(1/Math.Tan((180 / PI) * Double.Parse(textBox1.Text)));
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = "arcsin(" + textBox1.Text + ")=" + Convert.ToString(Math.Asin(Double.Parse(textBox1.Text))); //arcsin
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = "arccos(" + textBox1.Text + ")=" + Convert.ToString(Math.Acos(Double.Parse(textBox1.Text))); //arcosin
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = "arctg(" + textBox1.Text + ")=" + Convert.ToString(Math.Atan(Double.Parse(textBox1.Text))); //arctg
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = "arcctg(" + textBox1.Text + ")=" + Convert.ToString((3.14159265359 / 2) - Math.Asin(Double.Parse(textBox1.Text))); //arcctg
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = "ln(" + textBox1.Text +  ")=" + Convert.ToString(Math.Log(Double.Parse(textBox1.Text))); //logaritm natural (ln)
        }
        
        private void button19_Click(object sender, EventArgs e)
        {

           


        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {  
            
            

        }


        bool kek = false; bool ok = false;
        private void button30_Click(object sender, EventArgs e) //calculam functia trigonometrica in radiani sau grade
        {
            if (button30.Text == "Radians")
            {
                ok = false;
                button30.Text = "Degrees";
            }
            else

            { ok = true; button30.Text = "Radians"; }
            

        }

        private void button31_Click(object sender, EventArgs e) // factorialul unui numar
        {
            int i, p = 1; double n = Double.Parse(textBox1.Text);
            if ((n < 0)||(Math.Round(n)!=n))
                textBox1.Text = "Error";
            else
                if (n == 0)
                    textBox1.Text = Convert.ToString(1);
                else
                    if ((n > 0)&&(Math.Round(n)==n))
                    {
                        for (i = 1; i <= n; i++)
                            p = p * i;
                        textBox1.Text = Convert.ToString(n) + "!=" + Convert.ToString(p);
                    }
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }
        
        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Convert.ToString(E);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Convert.ToString(PI);
        }

        private void simpleCalculatorToolStripMenuItem_Click(object sender, EventArgs e) //functii simple / de baza
        {
            simpleCalculatorToolStripMenuItem.Checked = true;
            advancedCalculatorToolStripMenuItem.Checked = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            this.Width = 397;
            this.Height = 380;
        }

        private void advancedCalculatorToolStripMenuItem_Click(object sender, EventArgs e) //functii mai avansate (inclusiv trigonometrice)
        {   advancedCalculatorToolStripMenuItem.Checked = true;
        simpleCalculatorToolStripMenuItem.Checked = false;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
            button30.Visible = true;
            button31.Visible = true;
            button32.Visible = true;
            button33.Visible = true;
            this.Width = 600;
            this.Height = 380;
        }
        char operation; // variabila pentru semnele de operatie
        private void button17_click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text); operation = '/';
             label1.Text = textBox1.Text + " " + operation;
             textBox1.Text = "/";
            
            
            kek = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
             
            switch (operation)
            {
                case '+':
                    {
                        label1.Text = Convert.ToString(a) + "+" + textBox1.Text + "=   ";
                        textBox1.Text = Convert.ToString(a + Double.Parse(textBox1.Text));
                    } //adunare
                    break;
                case '-':
                    { label1.Text = Convert.ToString(a) + "-" + textBox1.Text + "=   ";
                        textBox1.Text = Convert.ToString(a - Double.Parse(textBox1.Text)); }//impartire
                    break;
                case '/':
                    {
                        label1.Text = Convert.ToString(a) + "/" + textBox1.Text + "=   ";
                        textBox1.Text = Convert.ToString(a / Double.Parse(textBox1.Text));
                    } // scadere
                    break;
                case '*':
                    {
                        label1.Text = Convert.ToString(a) + "*" + textBox1.Text + "=   ";
                        textBox1.Text = Convert.ToString(a * Double.Parse(textBox1.Text));
                    } //inmultire
                    break;
                case '^':
                    {
                        label1.Text = Convert.ToString(a) + "^" + textBox1.Text + "=   ";
                        textBox1.Text = Convert.ToString(Math.Pow(a, Double.Parse(textBox1.Text)));
                    }//puteri
                    break;
                default:
            break;
            
            
            
            }
        }

        private void button14_click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text); operation = '+';
            label1.Text = textBox1.Text + " " + operation;
            textBox1.Text = "+";
            kek = true;
        }

        private void button15_click(object sender, EventArgs e)
        {  
            a = Double.Parse(textBox1.Text); operation = '-';
            label1.Text = textBox1.Text + " " + operation;
            textBox1.Text = "-";
           kek = true;
        }

        private void button16_click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text); operation = '*';
            label1.Text = textBox1.Text + " " + operation;
            textBox1.Text = "*";
            kek = true;
        }

        private void button19_click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text); operation = '^';
            label1.Text = textBox1.Text + " " + operation;
            textBox1.Text = "^";
            kek = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        public void delete_first(string a)
        {
            char[] trim = {'+', '-', '/', '*' };
            a = a.Trim(trim);
          

              

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //deoarece cand tastam de exemplu sin(3,14) afiseaza valoarea matematica convenita
        // insa cand facem sin(3.14) afiseaza alta valoare, de aceea am recurs la acest procedeu
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (e.KeyChar == '+')
            {
                a = Double.Parse(textBox1.Text);
                string b = textBox1.Text;
                //delete_first(b);
                label1.Text = b + " ";
                textBox1.Clear();
                operation = '+';




            }
            if (e.KeyChar == '-')
            {
                a = Double.Parse(textBox1.Text);
                string b = textBox1.Text;
                //delete_first(b);
                label1.Text = b + " ";
                textBox1.Clear();
                operation = '-';




            }

            if (e.KeyChar == '=')
            {
                switch (operation)
                {
                    case '+':
                        {
                            label1.Text = Convert.ToString(a) + "+" + textBox1.Text + "=   ";
                       
                            textBox1.Text = Convert.ToString(a + Double.Parse(textBox1.Text));
                        } //adunare
                        break;
                    case '-':
                        {
                            label1.Text = Convert.ToString(a) + "-" + textBox1.Text + "=   ";
                            textBox1.Text = Convert.ToString(a - Double.Parse(textBox1.Text));
                        }//impartire
                        break;
                    case '/':
                        {
                            label1.Text = Convert.ToString(a) + "/" + textBox1.Text + "=   ";
                            textBox1.Text = Convert.ToString(a / Double.Parse(textBox1.Text));
                        } // scadere
                        break;
                    case '*':
                        {
                            label1.Text = Convert.ToString(a) + "*" + textBox1.Text + "=   ";
                            textBox1.Text = Convert.ToString(a * Double.Parse(textBox1.Text));
                        } //inmultire
                        break;
                    case '^':
                        {
                            label1.Text = Convert.ToString(a) + "^" + textBox1.Text + "=   ";
                            textBox1.Text = Convert.ToString(Math.Pow(a, Double.Parse(textBox1.Text)));
                        }//puteri
                        break;
                    default:
                        break;







                }






            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (((zero == false) && (textBox1.Text == "0")) || (textBox1.Text == " "))
                textBox1.Text = Convert.ToString(Double.PositiveInfinity);
            
        }

        
    }
}
