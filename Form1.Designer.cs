namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            rdoHamBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkFrenchFri = new CheckBox();
            rdoBulgogiHamBurger = new GroupBox();
            groupBox3 = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnInit = new Button();
            lblWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            rdoBulgogiHamBurger.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.LimeGreen;
            lblAppName.Location = new Point(193, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(595, 86);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "버거 주문 키오스크";
            lblAppName.Click += label1_Click;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(21, 63);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(134, 49);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(21, 300);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(166, 49);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(21, 179);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(198, 49);
            rdoBulgogiBurger.TabIndex = 3;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(225, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(225, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(225, 276);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(104, 73);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkSauce);
            groupBox1.Controls.Add(chkCheese);
            groupBox1.Controls.Add(chkCola);
            groupBox1.Controls.Add(chkFrenchFri);
            groupBox1.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(396, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 380);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "추가 옵션";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(27, 300);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(137, 36);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(27, 223);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(137, 36);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(27, 143);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(81, 36);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chkFrenchFri
            // 
            chkFrenchFri.AutoSize = true;
            chkFrenchFri.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkFrenchFri.ForeColor = Color.Black;
            chkFrenchFri.Location = new Point(27, 63);
            chkFrenchFri.Name = "chkFrenchFri";
            chkFrenchFri.Size = new Size(129, 36);
            chkFrenchFri.TabIndex = 0;
            chkFrenchFri.Text = "감자튀김";
            chkFrenchFri.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiHamBurger
            // 
            rdoBulgogiHamBurger.Controls.Add(pictureBox3);
            rdoBulgogiHamBurger.Controls.Add(pictureBox2);
            rdoBulgogiHamBurger.Controls.Add(pictureBox1);
            rdoBulgogiHamBurger.Controls.Add(rdoBulgogiBurger);
            rdoBulgogiHamBurger.Controls.Add(rdoChickenBurger);
            rdoBulgogiHamBurger.Controls.Add(rdoHamBurger);
            rdoBulgogiHamBurger.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoBulgogiHamBurger.ForeColor = Color.Blue;
            rdoBulgogiHamBurger.Location = new Point(25, 131);
            rdoBulgogiHamBurger.Name = "rdoBulgogiHamBurger";
            rdoBulgogiHamBurger.Size = new Size(355, 380);
            rdoBulgogiHamBurger.TabIndex = 2;
            rdoBulgogiHamBurger.TabStop = false;
            rdoBulgogiHamBurger.Text = "메뉴 선택";
            rdoBulgogiHamBurger.Enter += rdoBulgogiHamBurger_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotalCost);
            groupBox3.Controls.Add(lstOrder);
            groupBox3.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(710, 131);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(299, 286);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTotalCost.ForeColor = Color.Red;
            lblTotalCost.Location = new Point(16, 243);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(152, 32);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            lblTotalCost.Click += lblTotalCost_Click;
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(16, 49);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(267, 179);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.Location = new Point(710, 455);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(145, 56);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnInit.Location = new Point(864, 455);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(145, 56);
            btnInit.TabIndex = 0;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = true;
            btnInit.Click += btnInit_Click;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Location = new Point(710, 431);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 15);
            lblWarning.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 596);
            Controls.Add(lblWarning);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(groupBox3);
            Controls.Add(rdoBulgogiHamBurger);
            Controls.Add(groupBox1);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            rdoBulgogiHamBurger.ResumeLayout(false);
            rdoBulgogiHamBurger.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private RadioButton rdoHamBurger;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private GroupBox rdoBulgogiHamBurger;
        private GroupBox groupBox3;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnInit;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkFrenchFri;
        private Label lblWarning;
    }
}
