namespace WeightHeightCLC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "";
        }

        private void buttoncalculate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                try
                {

                    double weight = Convert.ToDouble(textBox1.Text);
                    double height = Convert.ToDouble(textBox2.Text);
                    double result = 0.0;

                    result = weight / (height * height);
                    textBox3.Text = "Your BMI is : " + result.ToString("#.##") + "\n";
                    if (result < 18.5)
                    {
                        textBox3.Text += "You are under normal weight.";
                    }
                    else if (result < 25)
                    {
                        textBox3.Text += "You have normal weight.";
                    }
                    else if (result > 26)
                    {
                        textBox3.Text += "You are above normal weight.";
                    }
                    else if (result > 30)
                    {
                        textBox3.Text += "You are obese. Please be careful about your health!";
                    }

                }
                catch
                {
                    MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Some Input. Error!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only numeric characters");
                textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only numeric characters");
                textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }
    }
}