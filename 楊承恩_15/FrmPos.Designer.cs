namespace POS1
{
    partial class FrmPos
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWsk = new System.Windows.Forms.Button();
            this.btnTql = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.txtList);
            this.groupBox3.Location = new System.Drawing.Point(824, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 461);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(198, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 37);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(33, 32);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(277, 347);
            this.txtList.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnCard);
            this.groupBox2.Controls.Add(this.btnCash);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(359, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 331);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(214, 161);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(113, 74);
            this.btnCard.TabIndex = 3;
            this.btnCard.Text = "信用卡";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(50, 161);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(113, 74);
            this.btnCash.TabIndex = 2;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(57, 69);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(298, 30);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Text = "NT 0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "總金額";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWine);
            this.groupBox1.Controls.Add(this.btnWsk);
            this.groupBox1.Controls.Add(this.btnTql);
            this.groupBox1.Controls.Add(this.btnBeer);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 472);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnWine
            // 
            this.btnWine.Location = new System.Drawing.Point(174, 205);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(111, 127);
            this.btnWine.TabIndex = 3;
            this.btnWine.Text = "Wine\r\nNT320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWsk
            // 
            this.btnWsk.Location = new System.Drawing.Point(33, 205);
            this.btnWsk.Name = "btnWsk";
            this.btnWsk.Size = new System.Drawing.Size(111, 127);
            this.btnWsk.TabIndex = 2;
            this.btnWsk.Text = "Whisken\r\nNT350";
            this.btnWsk.UseVisualStyleBackColor = true;
            this.btnWsk.Click += new System.EventHandler(this.btnWsk_Click);
            // 
            // btnTql
            // 
            this.btnTql.Location = new System.Drawing.Point(174, 56);
            this.btnTql.Name = "btnTql";
            this.btnTql.Size = new System.Drawing.Size(111, 127);
            this.btnTql.TabIndex = 1;
            this.btnTql.Text = "Tequila\r\nNT180";
            this.btnTql.UseVisualStyleBackColor = true;
            this.btnTql.Click += new System.EventHandler(this.btnTql_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.Location = new System.Drawing.Point(33, 56);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(111, 127);
            this.btnBeer.TabIndex = 0;
            this.btnBeer.Text = "Beer\r\nNT120";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // FrmPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 784);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPos";
            this.Text = "POS";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWsk;
        private System.Windows.Forms.Button btnTql;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnClear;
    }
}

