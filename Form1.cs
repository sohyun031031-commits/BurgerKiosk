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
            // 버거 선택 확인
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblWarning.Text = "버거를 선택해주세요!";
                return;
            }

            lblWarning.Text = "";

            // 초기화
            totalCost = 0;
            lstOrder.Items.Clear();

            // 버거 종류
            if (rdoHamBurger.Checked)
            {
                lstOrder.Items.Add("햄버거 - 5,000원");
                totalCost += 5000;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                lstOrder.Items.Add("불고기버거 - 4,000원");
                totalCost += 4000;
            }
            else if (rdoChickenBurger.Checked)
            {
                lstOrder.Items.Add("치킨버거 - 3,000원");
                totalCost += 3000;
            }

            // 추가 옵션
            if (chkFrenchFri.Checked) { lstOrder.Items.Add("감자튀김 - 3,500원"); totalCost += 3500; }
            if (chkCola.Checked) { lstOrder.Items.Add("콜라 - 2,500원"); totalCost += 2500; }
            if (chkCheese.Checked) { lstOrder.Items.Add("치즈 - 1,500원"); totalCost += 1500; }
            if (chkSauce.Checked) { lstOrder.Items.Add("소스 - 500원"); totalCost += 500; }

            // 총 금액 표시
            lblTotalCost.Text = $"총 금액 : {totalCost:N0}원";

        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            // 라디오버튼 초기화
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            // 체크박스 초기화
            chkFrenchFri.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 주문 내역 초기화
            lstOrder.Items.Clear();

            // 총 금액 초기화
            totalCost = 0;
            lblTotalCost.Text = "총 금액 : 0원";

            // 포커스를 메뉴선택 그룹박스로 이동
            rdoHamBurger.Focus();
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
