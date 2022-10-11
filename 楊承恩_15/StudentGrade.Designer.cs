namespace StudentGrade
{
    partial class studentGrade
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRand1 = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRand20 = new System.Windows.Forms.Button();
            this.listshow = new System.Windows.Forms.ListBox();
            this.listshow2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(28, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(96, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(84, 30);
            this.txtName.TabIndex = 6;
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChi.Location = new System.Drawing.Point(96, 95);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(84, 30);
            this.txtChi.TabIndex = 7;
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(96, 159);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(84, 30);
            this.txtEng.TabIndex = 8;
            // 
            // txtMat
            // 
            this.txtMat.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMat.Location = new System.Drawing.Point(96, 220);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(84, 30);
            this.txtMat.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 40);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRand1
            // 
            this.btnRand1.Location = new System.Drawing.Point(34, 376);
            this.btnRand1.Name = "btnRand1";
            this.btnRand1.Size = new System.Drawing.Size(145, 40);
            this.btnRand1.TabIndex = 11;
            this.btnRand1.Text = "隨機加入資料";
            this.btnRand1.UseVisualStyleBackColor = true;
            this.btnRand1.Click += new System.EventHandler(this.btnRand1_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(35, 442);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(145, 40);
            this.btnStatistics.TabIndex = 12;
            this.btnStatistics.Text = "各科統計";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(32, 557);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 40);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "重設資料";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRand20
            // 
            this.btnRand20.Location = new System.Drawing.Point(32, 616);
            this.btnRand20.Name = "btnRand20";
            this.btnRand20.Size = new System.Drawing.Size(145, 40);
            this.btnRand20.TabIndex = 14;
            this.btnRand20.Text = "隨機加入20筆";
            this.btnRand20.UseVisualStyleBackColor = true;
            this.btnRand20.Click += new System.EventHandler(this.btnRand20_Click);
            // 
            // listshow
            // 
            this.listshow.FormattingEnabled = true;
            this.listshow.ItemHeight = 12;
            this.listshow.Location = new System.Drawing.Point(247, 41);
            this.listshow.Name = "listshow";
            this.listshow.Size = new System.Drawing.Size(527, 508);
            this.listshow.TabIndex = 15;
            // 
            // listshow2
            // 
            this.listshow2.FormattingEnabled = true;
            this.listshow2.ItemHeight = 12;
            this.listshow2.Location = new System.Drawing.Point(247, 557);
            this.listshow2.Name = "listshow2";
            this.listshow2.Size = new System.Drawing.Size(527, 172);
            this.listshow2.TabIndex = 16;
            // 
            // studentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 744);
            this.Controls.Add(this.listshow2);
            this.Controls.Add(this.listshow);
            this.Controls.Add(this.btnRand20);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnRand1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "studentGrade";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRand1;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRand20;
        private System.Windows.Forms.ListBox listshow;
        private System.Windows.Forms.ListBox listshow2;
    }
}

