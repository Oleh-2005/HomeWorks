
namespace HomeW_14._07._2021_WorkPart
{
    partial class PStation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAuthoZap = new System.Windows.Forms.GroupBox();
            this.rbNumber = new System.Windows.Forms.RadioButton();
            this.rbPrice = new System.Windows.Forms.RadioButton();
            this.lblPetrolPay = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrise = new System.Windows.Forms.Label();
            this.TypeOfPetrol = new System.Windows.Forms.ComboBox();
            this.gbShop = new System.Windows.Forms.GroupBox();
            this.lblSumPayShop = new System.Windows.Forms.Label();
            this.tbPriceBlackTea = new System.Windows.Forms.TextBox();
            this.tbBlackTea = new System.Windows.Forms.TextBox();
            this.tbPricePepsi = new System.Windows.Forms.TextBox();
            this.tbPriceSprite = new System.Windows.Forms.TextBox();
            this.tbPriceLitHD = new System.Windows.Forms.TextBox();
            this.tbPriceMidHD = new System.Windows.Forms.TextBox();
            this.tbPriceBigHD = new System.Windows.Forms.TextBox();
            this.tbPepsi = new System.Windows.Forms.TextBox();
            this.tbSprite = new System.Windows.Forms.TextBox();
            this.tbLitHD = new System.Windows.Forms.TextBox();
            this.tbMidHD = new System.Windows.Forms.TextBox();
            this.tbBigHD = new System.Windows.Forms.TextBox();
            this.cbShopBlackTea = new System.Windows.Forms.CheckBox();
            this.cbShopPepsi = new System.Windows.Forms.CheckBox();
            this.cbShopSprite = new System.Windows.Forms.CheckBox();
            this.cbShopLitHD = new System.Windows.Forms.CheckBox();
            this.cbShopMidHD = new System.Windows.Forms.CheckBox();
            this.cbShopBigHD = new System.Windows.Forms.CheckBox();
            this.lblShopPay = new System.Windows.Forms.Label();
            this.gbPay = new System.Windows.Forms.GroupBox();
            this.lblGRN = new System.Windows.Forms.Label();
            this.lblSumPay = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.gbAuthoZap.SuspendLayout();
            this.gbShop.SuspendLayout();
            this.gbPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAuthoZap
            // 
            this.gbAuthoZap.Controls.Add(this.rbNumber);
            this.gbAuthoZap.Controls.Add(this.rbPrice);
            this.gbAuthoZap.Controls.Add(this.lblPetrolPay);
            this.gbAuthoZap.Controls.Add(this.tbNumber);
            this.gbAuthoZap.Controls.Add(this.tbPrice);
            this.gbAuthoZap.Controls.Add(this.lblPrise);
            this.gbAuthoZap.Controls.Add(this.TypeOfPetrol);
            this.gbAuthoZap.Location = new System.Drawing.Point(13, 13);
            this.gbAuthoZap.Name = "gbAuthoZap";
            this.gbAuthoZap.Size = new System.Drawing.Size(349, 267);
            this.gbAuthoZap.TabIndex = 0;
            this.gbAuthoZap.TabStop = false;
            this.gbAuthoZap.Text = "Petrol Station";
            // 
            // rbNumber
            // 
            this.rbNumber.AutoSize = true;
            this.rbNumber.Location = new System.Drawing.Point(10, 119);
            this.rbNumber.Name = "rbNumber";
            this.rbNumber.Size = new System.Drawing.Size(79, 21);
            this.rbNumber.TabIndex = 6;
            this.rbNumber.TabStop = true;
            this.rbNumber.Text = "Number";
            this.rbNumber.UseVisualStyleBackColor = true;
            this.rbNumber.CheckedChanged += new System.EventHandler(this.rbPrice_CheckedChanged);
            // 
            // rbPrice
            // 
            this.rbPrice.AutoSize = true;
            this.rbPrice.Location = new System.Drawing.Point(10, 91);
            this.rbPrice.Name = "rbPrice";
            this.rbPrice.Size = new System.Drawing.Size(61, 21);
            this.rbPrice.TabIndex = 3;
            this.rbPrice.TabStop = true;
            this.rbPrice.Text = "Price";
            this.rbPrice.UseVisualStyleBackColor = true;
            this.rbPrice.CheckedChanged += new System.EventHandler(this.rbPrice_CheckedChanged);
            // 
            // lblPetrolPay
            // 
            this.lblPetrolPay.Location = new System.Drawing.Point(7, 199);
            this.lblPetrolPay.Name = "lblPetrolPay";
            this.lblPetrolPay.Size = new System.Drawing.Size(316, 49);
            this.lblPetrolPay.TabIndex = 5;
            this.lblPetrolPay.Text = "You must pay :";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(196, 119);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.ReadOnly = true;
            this.tbNumber.Size = new System.Drawing.Size(100, 22);
            this.tbNumber.TabIndex = 4;
            this.tbNumber.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(196, 91);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(100, 22);
            this.tbPrice.TabIndex = 3;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged_1);
            // 
            // lblPrise
            // 
            this.lblPrise.Location = new System.Drawing.Point(7, 65);
            this.lblPrise.Name = "lblPrise";
            this.lblPrise.Size = new System.Drawing.Size(246, 23);
            this.lblPrise.TabIndex = 1;
            this.lblPrise.Text = "Price";
            // 
            // TypeOfPetrol
            // 
            this.TypeOfPetrol.FormattingEnabled = true;
            this.TypeOfPetrol.Location = new System.Drawing.Point(7, 22);
            this.TypeOfPetrol.Name = "TypeOfPetrol";
            this.TypeOfPetrol.Size = new System.Drawing.Size(246, 24);
            this.TypeOfPetrol.TabIndex = 0;
            this.TypeOfPetrol.SelectedIndexChanged += new System.EventHandler(this.TypeOfPetrol_SelectedIndexChanged);
            // 
            // gbShop
            // 
            this.gbShop.Controls.Add(this.lblSumPayShop);
            this.gbShop.Controls.Add(this.tbPriceBlackTea);
            this.gbShop.Controls.Add(this.tbBlackTea);
            this.gbShop.Controls.Add(this.tbPricePepsi);
            this.gbShop.Controls.Add(this.tbPriceSprite);
            this.gbShop.Controls.Add(this.tbPriceLitHD);
            this.gbShop.Controls.Add(this.tbPriceMidHD);
            this.gbShop.Controls.Add(this.tbPriceBigHD);
            this.gbShop.Controls.Add(this.tbPepsi);
            this.gbShop.Controls.Add(this.tbSprite);
            this.gbShop.Controls.Add(this.tbLitHD);
            this.gbShop.Controls.Add(this.tbMidHD);
            this.gbShop.Controls.Add(this.tbBigHD);
            this.gbShop.Controls.Add(this.cbShopBlackTea);
            this.gbShop.Controls.Add(this.cbShopPepsi);
            this.gbShop.Controls.Add(this.cbShopSprite);
            this.gbShop.Controls.Add(this.cbShopLitHD);
            this.gbShop.Controls.Add(this.cbShopMidHD);
            this.gbShop.Controls.Add(this.cbShopBigHD);
            this.gbShop.Controls.Add(this.lblShopPay);
            this.gbShop.Location = new System.Drawing.Point(414, 13);
            this.gbShop.Name = "gbShop";
            this.gbShop.Size = new System.Drawing.Size(349, 267);
            this.gbShop.TabIndex = 1;
            this.gbShop.TabStop = false;
            this.gbShop.Text = "Mini Shop";
            // 
            // lblSumPayShop
            // 
            this.lblSumPayShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumPayShop.Location = new System.Drawing.Point(163, 199);
            this.lblSumPayShop.Name = "lblSumPayShop";
            this.lblSumPayShop.Size = new System.Drawing.Size(141, 49);
            this.lblSumPayShop.TabIndex = 26;
            this.lblSumPayShop.Text = "0";
            // 
            // tbPriceBlackTea
            // 
            this.tbPriceBlackTea.Location = new System.Drawing.Point(245, 158);
            this.tbPriceBlackTea.Name = "tbPriceBlackTea";
            this.tbPriceBlackTea.ReadOnly = true;
            this.tbPriceBlackTea.Size = new System.Drawing.Size(92, 22);
            this.tbPriceBlackTea.TabIndex = 25;
            this.tbPriceBlackTea.Text = "0";
            this.tbPriceBlackTea.TextChanged += new System.EventHandler(this.tbPriceBigHD_TextChanged);
            // 
            // tbBlackTea
            // 
            this.tbBlackTea.Location = new System.Drawing.Point(147, 158);
            this.tbBlackTea.Name = "tbBlackTea";
            this.tbBlackTea.ReadOnly = true;
            this.tbBlackTea.Size = new System.Drawing.Size(92, 22);
            this.tbBlackTea.TabIndex = 24;
            this.tbBlackTea.Text = "18";
            // 
            // tbPricePepsi
            // 
            this.tbPricePepsi.Location = new System.Drawing.Point(245, 131);
            this.tbPricePepsi.Name = "tbPricePepsi";
            this.tbPricePepsi.ReadOnly = true;
            this.tbPricePepsi.Size = new System.Drawing.Size(92, 22);
            this.tbPricePepsi.TabIndex = 23;
            this.tbPricePepsi.Text = "0";
            this.tbPricePepsi.TextChanged += new System.EventHandler(this.tbPriceBigHD_TextChanged);
            // 
            // tbPriceSprite
            // 
            this.tbPriceSprite.Location = new System.Drawing.Point(245, 104);
            this.tbPriceSprite.Name = "tbPriceSprite";
            this.tbPriceSprite.ReadOnly = true;
            this.tbPriceSprite.Size = new System.Drawing.Size(92, 22);
            this.tbPriceSprite.TabIndex = 22;
            this.tbPriceSprite.Text = "0";
            this.tbPriceSprite.TextChanged += new System.EventHandler(this.tbPriceBigHD_TextChanged);
            // 
            // tbPriceLitHD
            // 
            this.tbPriceLitHD.Location = new System.Drawing.Point(245, 78);
            this.tbPriceLitHD.Name = "tbPriceLitHD";
            this.tbPriceLitHD.ReadOnly = true;
            this.tbPriceLitHD.Size = new System.Drawing.Size(92, 22);
            this.tbPriceLitHD.TabIndex = 21;
            this.tbPriceLitHD.Text = "0";
            this.tbPriceLitHD.TextChanged += new System.EventHandler(this.tbPriceBigHD_TextChanged);
            // 
            // tbPriceMidHD
            // 
            this.tbPriceMidHD.Location = new System.Drawing.Point(245, 51);
            this.tbPriceMidHD.Name = "tbPriceMidHD";
            this.tbPriceMidHD.ReadOnly = true;
            this.tbPriceMidHD.Size = new System.Drawing.Size(92, 22);
            this.tbPriceMidHD.TabIndex = 20;
            this.tbPriceMidHD.Text = "0";
            this.tbPriceMidHD.TextChanged += new System.EventHandler(this.tbPriceBigHD_TextChanged);
            // 
            // tbPriceBigHD
            // 
            this.tbPriceBigHD.Location = new System.Drawing.Point(245, 24);
            this.tbPriceBigHD.Name = "tbPriceBigHD";
            this.tbPriceBigHD.ReadOnly = true;
            this.tbPriceBigHD.Size = new System.Drawing.Size(92, 22);
            this.tbPriceBigHD.TabIndex = 19;
            this.tbPriceBigHD.Text = "0";
            this.tbPriceBigHD.TextChanged += new System.EventHandler(this.tbPriceBigHD_TextChanged);
            // 
            // tbPepsi
            // 
            this.tbPepsi.Location = new System.Drawing.Point(147, 131);
            this.tbPepsi.Name = "tbPepsi";
            this.tbPepsi.ReadOnly = true;
            this.tbPepsi.Size = new System.Drawing.Size(92, 22);
            this.tbPepsi.TabIndex = 18;
            this.tbPepsi.Text = "28";
            // 
            // tbSprite
            // 
            this.tbSprite.Location = new System.Drawing.Point(147, 104);
            this.tbSprite.Name = "tbSprite";
            this.tbSprite.ReadOnly = true;
            this.tbSprite.Size = new System.Drawing.Size(92, 22);
            this.tbSprite.TabIndex = 17;
            this.tbSprite.Text = "23";
            // 
            // tbLitHD
            // 
            this.tbLitHD.Location = new System.Drawing.Point(147, 78);
            this.tbLitHD.Name = "tbLitHD";
            this.tbLitHD.ReadOnly = true;
            this.tbLitHD.Size = new System.Drawing.Size(92, 22);
            this.tbLitHD.TabIndex = 16;
            this.tbLitHD.Text = "38";
            // 
            // tbMidHD
            // 
            this.tbMidHD.Location = new System.Drawing.Point(147, 50);
            this.tbMidHD.Name = "tbMidHD";
            this.tbMidHD.ReadOnly = true;
            this.tbMidHD.Size = new System.Drawing.Size(92, 22);
            this.tbMidHD.TabIndex = 15;
            this.tbMidHD.Text = "54";
            // 
            // tbBigHD
            // 
            this.tbBigHD.Location = new System.Drawing.Point(147, 23);
            this.tbBigHD.Name = "tbBigHD";
            this.tbBigHD.ReadOnly = true;
            this.tbBigHD.Size = new System.Drawing.Size(92, 22);
            this.tbBigHD.TabIndex = 14;
            this.tbBigHD.Text = "68";
            // 
            // cbShopBlackTea
            // 
            this.cbShopBlackTea.AutoSize = true;
            this.cbShopBlackTea.Location = new System.Drawing.Point(9, 160);
            this.cbShopBlackTea.Name = "cbShopBlackTea";
            this.cbShopBlackTea.Size = new System.Drawing.Size(88, 21);
            this.cbShopBlackTea.TabIndex = 13;
            this.cbShopBlackTea.Text = "Black tea";
            this.cbShopBlackTea.UseVisualStyleBackColor = true;
            this.cbShopBlackTea.CheckedChanged += new System.EventHandler(this.cbShopBlackTea_CheckedChanged);
            // 
            // cbShopPepsi
            // 
            this.cbShopPepsi.AutoSize = true;
            this.cbShopPepsi.Location = new System.Drawing.Point(9, 133);
            this.cbShopPepsi.Name = "cbShopPepsi";
            this.cbShopPepsi.Size = new System.Drawing.Size(65, 21);
            this.cbShopPepsi.TabIndex = 12;
            this.cbShopPepsi.Text = "Pepsi";
            this.cbShopPepsi.UseVisualStyleBackColor = true;
            this.cbShopPepsi.CheckedChanged += new System.EventHandler(this.cbShopPepsi_CheckedChanged);
            // 
            // cbShopSprite
            // 
            this.cbShopSprite.AutoSize = true;
            this.cbShopSprite.Location = new System.Drawing.Point(9, 106);
            this.cbShopSprite.Name = "cbShopSprite";
            this.cbShopSprite.Size = new System.Drawing.Size(67, 21);
            this.cbShopSprite.TabIndex = 11;
            this.cbShopSprite.Text = "Sprite";
            this.cbShopSprite.UseVisualStyleBackColor = true;
            this.cbShopSprite.CheckedChanged += new System.EventHandler(this.cbShopSprite_CheckedChanged);
            // 
            // cbShopLitHD
            // 
            this.cbShopLitHD.AutoSize = true;
            this.cbShopLitHD.Location = new System.Drawing.Point(9, 79);
            this.cbShopLitHD.Name = "cbShopLitHD";
            this.cbShopLitHD.Size = new System.Drawing.Size(117, 21);
            this.cbShopLitHD.TabIndex = 10;
            this.cbShopLitHD.Text = "Little Hot-Dog";
            this.cbShopLitHD.UseVisualStyleBackColor = true;
            this.cbShopLitHD.CheckedChanged += new System.EventHandler(this.cbShopLitHD_CheckedChanged);
            // 
            // cbShopMidHD
            // 
            this.cbShopMidHD.AutoSize = true;
            this.cbShopMidHD.Location = new System.Drawing.Point(9, 52);
            this.cbShopMidHD.Name = "cbShopMidHD";
            this.cbShopMidHD.Size = new System.Drawing.Size(128, 21);
            this.cbShopMidHD.TabIndex = 9;
            this.cbShopMidHD.Text = "Middle Hot-Dog";
            this.cbShopMidHD.UseVisualStyleBackColor = true;
            this.cbShopMidHD.CheckedChanged += new System.EventHandler(this.cbShopMidHD_CheckedChanged);
            // 
            // cbShopBigHD
            // 
            this.cbShopBigHD.AutoSize = true;
            this.cbShopBigHD.Location = new System.Drawing.Point(9, 25);
            this.cbShopBigHD.Name = "cbShopBigHD";
            this.cbShopBigHD.Size = new System.Drawing.Size(107, 21);
            this.cbShopBigHD.TabIndex = 8;
            this.cbShopBigHD.Text = "Big Hot-Dog";
            this.cbShopBigHD.UseVisualStyleBackColor = true;
            this.cbShopBigHD.CheckedChanged += new System.EventHandler(this.cbShopBigHD_CheckedChanged);
            // 
            // lblShopPay
            // 
            this.lblShopPay.Location = new System.Drawing.Point(6, 199);
            this.lblShopPay.Name = "lblShopPay";
            this.lblShopPay.Size = new System.Drawing.Size(131, 49);
            this.lblShopPay.TabIndex = 7;
            this.lblShopPay.Text = "You must pay :";
            // 
            // gbPay
            // 
            this.gbPay.Controls.Add(this.lblGRN);
            this.gbPay.Controls.Add(this.lblSumPay);
            this.gbPay.Controls.Add(this.btnPay);
            this.gbPay.Location = new System.Drawing.Point(13, 286);
            this.gbPay.Name = "gbPay";
            this.gbPay.Size = new System.Drawing.Size(749, 138);
            this.gbPay.TabIndex = 2;
            this.gbPay.TabStop = false;
            this.gbPay.Text = "You must pay";
            // 
            // lblGRN
            // 
            this.lblGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGRN.Location = new System.Drawing.Point(668, 68);
            this.lblGRN.Name = "lblGRN";
            this.lblGRN.Size = new System.Drawing.Size(70, 46);
            this.lblGRN.TabIndex = 2;
            this.lblGRN.Text = "grn";
            // 
            // lblSumPay
            // 
            this.lblSumPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumPay.Location = new System.Drawing.Point(429, 41);
            this.lblSumPay.Name = "lblSumPay";
            this.lblSumPay.Size = new System.Drawing.Size(199, 91);
            this.lblSumPay.TabIndex = 1;
            this.lblSumPay.Text = "0";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(142, 21);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(207, 93);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // PStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbPay);
            this.Controls.Add(this.gbShop);
            this.Controls.Add(this.gbAuthoZap);
            this.Name = "PStation";
            this.Text = "Petrol Station";
            this.gbAuthoZap.ResumeLayout(false);
            this.gbAuthoZap.PerformLayout();
            this.gbShop.ResumeLayout(false);
            this.gbShop.PerformLayout();
            this.gbPay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAuthoZap;
        private System.Windows.Forms.GroupBox gbShop;
        private System.Windows.Forms.GroupBox gbPay;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrise;
        private System.Windows.Forms.ComboBox TypeOfPetrol;
        private System.Windows.Forms.RadioButton rbNumber;
        private System.Windows.Forms.RadioButton rbPrice;
        private System.Windows.Forms.Label lblPetrolPay;
        private System.Windows.Forms.TextBox tbPepsi;
        private System.Windows.Forms.TextBox tbSprite;
        private System.Windows.Forms.TextBox tbLitHD;
        private System.Windows.Forms.TextBox tbMidHD;
        private System.Windows.Forms.TextBox tbBigHD;
        private System.Windows.Forms.CheckBox cbShopBlackTea;
        private System.Windows.Forms.CheckBox cbShopPepsi;
        private System.Windows.Forms.CheckBox cbShopSprite;
        private System.Windows.Forms.CheckBox cbShopLitHD;
        private System.Windows.Forms.CheckBox cbShopMidHD;
        private System.Windows.Forms.CheckBox cbShopBigHD;
        private System.Windows.Forms.Label lblShopPay;
        private System.Windows.Forms.TextBox tbPricePepsi;
        private System.Windows.Forms.TextBox tbPriceSprite;
        private System.Windows.Forms.TextBox tbPriceLitHD;
        private System.Windows.Forms.TextBox tbPriceMidHD;
        private System.Windows.Forms.TextBox tbPriceBigHD;
        private System.Windows.Forms.TextBox tbPriceBlackTea;
        private System.Windows.Forms.TextBox tbBlackTea;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblGRN;
        private System.Windows.Forms.Label lblSumPay;
        private System.Windows.Forms.Label lblSumPayShop;
    }
}

