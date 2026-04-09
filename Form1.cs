namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        private int totalCost = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnInit_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdoBulgogiHamBurger_Enter(object sender, EventArgs e)
        {
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (chkFrenchFri.Checked)
            {
                totalCost += 3500;
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
            }
        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {
            string details = "=== 주문 내역 ===\n";

            if (rdoHamBurger.Checked) details += "햄버거: 5,000원\n";
            else if (rdoBulgogiBurger.Checked) details += "불고기버거: 4,000원\n";
            else if (rdoChickenBurger.Checked) details += "치킨버거: 3,000원\n";

            if (chkFrenchFri.Checked) details += "감자튀김: 3,500원\n";
            if (chkCola.Checked) details += "콜라: 2,500원\n";
            if (chkCheese.Checked) details += "치즈: 1,500원\n";
            if (chkSauce.Checked) details += "소스: 500원\n";

            details += $"\n합계: {totalCost:N0}원";

            MessageBox.Show(details, "계산 내역", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
