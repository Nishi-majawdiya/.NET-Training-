using System;
using System.Web.UI;

namespace Registration_Form
{
    public partial class Registration_Form : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RunAllExamples();
            }
        }

        // ===============================
        // BUTTON CLICK
        // ===============================
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Registration Successful!";
            lblMessage.CssClass = "text-success";
        }

        // ===============================
        // MAIN DEMO METHOD
        // ===============================
        private void RunAllExamples()
        {
            IfElseExample();
            WhileExample();
            DoWhileExample();
            ForExample();
            ContinueExample();
            BreakExample();
            SwitchExample();

            GetSum(8, 9);

            int result = Multiply(8, 9);
            lblResult.Text = "1. Multiply = " + result;

            Op(9, 10);
        }

        // ===============================
        // IF ELSE
        // ===============================
        private void IfElseExample()
        {
            int age = 9;

            if (age < 18)
                lblResult1.Text = "2. If-Else: You can't vote";
            else
                lblResult1.Text = "2. If-Else: You can vote";
        }

        // ===============================
        // WHILE LOOP
        // ===============================
        private void WhileExample()
        {
            int i = 0;
            lblResult5.Text = "3. While Loop:<br/>";

            while (i <= 5)
            {
                lblResult5.Text += "Number: " + i + "<br/>";
                i++;
            }
        }

        // ===============================
        // DO WHILE LOOP
        // ===============================
        private void DoWhileExample()
        {
            int j = 0;
            lblResult6.Text = "4. Do-While Loop:<br/>";

            do
            {
                lblResult6.Text += "Number: " + j + "<br/>";
                j++;
            }
            while (j <= 5);
        }

        // ===============================
        // FOR LOOP
        // ===============================
        private void ForExample()
        {
            lblForLoop.Text = "5. For Loop:<br/>";

            for (int k = 0; k <= 5; k++)
            {
                lblForLoop.Text += "Number: " + k + "<br/>";
            }
        }

        // ===============================
        // CONTINUE
        // ===============================
        private void ContinueExample()
        {
            lblContinue.Text = "6. Continue Example:<br/>";

            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    continue;

                lblContinue.Text += "Number: " + i + "<br/>";
            }
        }

        // ===============================
        // BREAK
        // ===============================
        private void BreakExample()
        {
            lblBreak.Text = "7. Break Example:<br/>";

            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    break;

                lblBreak.Text += "Number: " + i + "<br/>";
            }
        }

        // ===============================
        // SWITCH CASE
        // ===============================
        private void SwitchExample()
        {
            int day = 2;

            lblSwitch.Text = "8. Switch Case: ";

            switch (day)
            {
                case 1:
                    lblSwitch.Text += "Monday";
                    break;
                case 2:
                    lblSwitch.Text += "Tuesday";
                    break;
                case 3:
                    lblSwitch.Text += "Wednesday";
                    break;
                default:
                    lblSwitch.Text += "Other Day";
                    break;
            }
        }

        // ===============================
        // ADDITION
        // ===============================
        private void GetSum(int a, int b)
        {
            lblSolution.Text = "9. Addition: 8 + 9 = " + (a + b);
        }

        // ===============================
        // MULTIPLY
        // ===============================
        private int Multiply(int x, int y)
        {
            return x * y;
        }

        // ===============================
        // LOGICAL OPERATOR
        // ===============================
        private void Op(int a, int b)
        {
            lblLogical.Text =
                "10. 9 > 10 = " + (a > b) + "<br/>" +
                "11. 10 > 9 = " + (b > a);
        }
    }
}
