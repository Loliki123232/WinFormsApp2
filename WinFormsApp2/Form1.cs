namespace WinFormsApp2
{
    public partial class Form1 : Form

    {
        string chislo;
        string znak;
        bool perekluchatel = false;
        string num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            chislo = "0";
            chislo1 = 0;
            chislo2 = 0;
            otwet = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            num2 = "0";
            perekluchatel = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                chislo += "8";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "8";
                textBox1.Text = chislo;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                chislo += "9";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "9";
                textBox1.Text = chislo;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            znak = "*";
            perekluchatel = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                chislo += "5";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "5";
                textBox1.Text = chislo;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                chislo += "6";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "6";
                textBox1.Text = chislo;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            znak = "/";
            perekluchatel = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                chislo += "2";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "2";
                textBox1.Text = chislo;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                chislo += "3";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "3";
                textBox1.Text = chislo;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            znak = "-";
            perekluchatel = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (perekluchatel == false)
            {
                chislo += "0";
                textBox1.Text = chislo;
            }
            else
            {
                num2 += "0";
                textBox1.Text = chislo;
            }
        }
        int chislo1;
        int chislo2;
        int otwet;

        private void button18_Click(object sender, EventArgs e)
        {
            switch (znak)
            {
                case "+":
                    chislo1 = int.Parse(textBox1.Text);
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        chislo2 = Convert.ToInt32(textBox2.Text);
                        otwet = chislo1 + chislo2;
                        textBox3.Text = otwet.ToString();

                    }
                    break;
                case "-":
                    chislo1 = int.Parse(textBox1.Text);
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        chislo2 = Convert.ToInt32(textBox2.Text);
                        otwet = chislo1 - chislo2;
                        textBox3.Text = otwet.ToString();
                    }

                    break;
                case "/":
                    chislo1 = int.Parse(textBox1.Text);
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        chislo2 = Convert.ToInt32(textBox2.Text);
                        otwet = chislo1 / chislo2;
                        textBox3.Text = otwet.ToString();
                    }
                    break;
                case "*":
                    chislo1 = int.Parse(textBox1.Text);
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        chislo2 = Convert.ToInt32(textBox2.Text);
                        otwet = chislo1 * chislo2;
                        textBox3.Text = otwet.ToString();
                    }
                    break;
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            znak = "+";
            perekluchatel = true;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
