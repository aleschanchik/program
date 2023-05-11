namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public bool flag;
        public string tempParametr;
        public string act;
        public Main()
        {
            InitializeComponent();
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {

            Button numButton = (Button)sender;
            int tempNumber;
            bool isNum = int.TryParse(numButton.Text, out tempNumber);

            if (flag)
            {
                flag = false;
                TextBox.Text = "0";
            }
            if (TextBox.Text == "0" && isNum)
            {
                TextBox.Text = numButton.Text;
            }
            else
            {
                if (!numButton.Text.Contains(","))
                {
                    TextBox.Text = TextBox.Text + numButton.Text;
                }
                else
                {
                    TextBox.Text = TextBox.Text + numButton.Text;
                }
            }

        }

        private void ButtonPoint_Click_1(object sender, EventArgs e)
        {
            if (TextBox.Text.Contains(","))
            {
                return;
            }
            if (TextBox.Text == "")
            {
                TextBox.Text = "0,";
            }
            else
            {
                TextBox.Text += ",";
            }
        }
        private void ButtonClearE_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
            }
            else
            {
                TextBox.Text = "0";
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void ButtonProcent_Click(object sender, EventArgs e)
        {
            Button buttonAct = (Button)sender;
            act = buttonAct.Text;
            tempParametr = TextBox.Text;
            flag = true;
        }

        private void ButtonEqually_Click(object sender, EventArgs e)
        {
            double firstVar, secondVar, result = 0;
            Double.TryParse(tempParametr, out firstVar);
            Double.TryParse(TextBox.Text, out secondVar);
            if (act == "+")
            {
                result = firstVar + secondVar;
            }
            if (act == "-")
            {
                result = firstVar - secondVar;
            }
            if (act == "*")
            {
                result = firstVar * secondVar;
            }
            if (act == "/")
            {
                result = firstVar / secondVar;
            }
            if (act == "%")
            {
                result = (firstVar * secondVar) / 100;
            }
            TextBox.Text = result.ToString();
            flag = true;
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            if (TextBox.Text !="")
            {
                if (TextBox.Text[0]=='-')
                {
                    TextBox.Text = TextBox.Text.Remove(0, 1);
                }
                else
                {
                    TextBox.Text = '-' + TextBox.Text;
                }
            }
        }
    }
}