using System;
using System.Windows.Forms;

/**
 * @author Aaron Mullan
 * Email: aaronjmullan@gmail.com
 * GitHub: github.com/aaronjmullan
 * LinkedIn: https://www.linkedin.com/in/aaronjmullan/
 */

namespace Calculator
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        float number, result; // values to store the value pre operation and post
        int counter; // value to correspond to each operation

        private void CalculatorUI_Load(object sender, EventArgs e)
        {

        }

        // on click add value '0' to both textbox and label
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResult.Text += 0; 
            lblResult.Text += 0;
        }

        // on click add '=' to label and call equals method passing counter
        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblResult.Text += "=";
            equals(counter);

        }

        // on click clear both textbox and label, counter to 0
        private void btnOn_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            lblResult.Text = "";
            counter = 0;
        }

        // on click remove the last input into the textbox
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtResult.TextLength > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, (txtResult.TextLength - 1));
            }
        }

        // on click check if textbox is empty, if not clear textbox and add '-' to label, set counter to 4
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                number = float.Parse(txtResult.Text);
                lblResult.Text += "-";
                txtResult.Clear();
                txtResult.Focus();
                counter = 4;
            }
        }

        // on click check if textbox is empty, if not clear textbox and add '+' to label, set counter to 3
        private void btnAdd_Click(object sender, EventArgs e)
        {
            number = float.Parse(txtResult.Text);
            lblResult.Text += "+";
            txtResult.Clear();
            txtResult.Focus();
            counter = 3;
        }

        // on click check if textbox is empty, if not clear textbox and add '*' to label, set counter to 2
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            number = float.Parse(txtResult.Text);
            lblResult.Text += "*";
            txtResult.Clear();
            txtResult.Focus();
            counter = 2;
        }

        // on click check if textbox is empty, if not clear textbox and add '/' to label, set counter to 1
        private void btnDivide_Click(object sender, EventArgs e)
        {
            number = float.Parse(txtResult.Text);
            lblResult.Text += "/";
            txtResult.Clear();
            txtResult.Focus();
            counter = 1;
        }

        // on click add value '1' to both textbox and label
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtResult.Text += 1;
            lblResult.Text += 1;
        }

        // on click add value '2' to both textbox and label
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtResult.Text += 2;
            lblResult.Text += 2;
        }

        // on click add value '3' to both textbox and label
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtResult.Text += 3;
            lblResult.Text += 3;
        }

        // on click add value '4' to both textbox and label
        private void btnFour_Click(object sender, EventArgs e)
        {
            txtResult.Text += 4;
            lblResult.Text += 4;
        }

        // on click add value '5' to both textbox and label
        private void btnFive_Click(object sender, EventArgs e)
        {
            txtResult.Text += 5;
            lblResult.Text += 5;
        }

        // on click add value '6' to both textbox and label
        private void btnSix_Click(object sender, EventArgs e)
        {
            txtResult.Text += 6;
            lblResult.Text += 6;
        }

        // on click add value '7' to both textbox and label
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtResult.Text += 7;
            lblResult.Text += 7;
        }

        // on click add value '8' to both textbox and label
        private void btnEight_Click(object sender, EventArgs e)
        {
            txtResult.Text += 8;
            lblResult.Text += 8;
        }

        // on click add value '9' to both textbox and label
        private void btnNine_Click(object sender, EventArgs e)
        {
            txtResult.Text += 9;
            lblResult.Text += 9;
        }

        // on click check if a dot already exists - if yes break loop if not add dot to both textbox and label
        private void btnDot_Click(object sender, EventArgs e)
        {
            int len = txtResult.TextLength;
            int flag = 0;
            string txt = txtResult.Text;
            for (int i = 0; i < len; i++) {
                if (txt[i].ToString() == ".") {
                    flag = 1;
                    break;
                } else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtResult.Text += ".";
                lblResult.Text += ".";
            }

        }

        // equals method, switches through counter and has a case for each operation, displays result in both textbox and label
        public void equals(int counter)
        {
            switch (counter)
            {
                case 1:
                    result = number / float.Parse(txtResult.Text);
                    txtResult.Text = result.ToString();
                    lblResult.Text = result.ToString();
                    break;
                case 2:
                    result = number * float.Parse(txtResult.Text);
                    txtResult.Text = result.ToString();
                    lblResult.Text = result.ToString();
                    break;
                case 3:
                    result = number + float.Parse(txtResult.Text);
                    txtResult.Text = result.ToString();
                    lblResult.Text = result.ToString();
                    break;
                case 4:
                    result = number - float.Parse(txtResult.Text);
                    txtResult.Text = result.ToString();
                    lblResult.Text = result.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
