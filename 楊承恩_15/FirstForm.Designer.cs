namespace Form0919
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.btn_Hi = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName_Eng = new System.Windows.Forms.TextBox();
            this.btn_Hallo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Hi
            // 
            this.btn_Hi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Hi.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hi.Location = new System.Drawing.Point(364, 89);
            this.btn_Hi.Name = "btn_Hi";
            this.btn_Hi.Size = new System.Drawing.Size(89, 30);
            this.btn_Hi.TabIndex = 0;
            this.btn_Hi.Text = "Say Hi";
            this.btn_Hi.UseVisualStyleBackColor = true;
            this.btn_Hi.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(236, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 30);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.Transparent;
            this.lab.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab.Location = new System.Drawing.Point(40, 87);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(166, 29);
            this.lab.TabIndex = 2;
            this.lab.Text = "請輸入姓名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(14, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "請輸入英文姓名:";
            // 
            // txtName_Eng
            // 
            this.txtName_Eng.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName_Eng.Location = new System.Drawing.Point(236, 141);
            this.txtName_Eng.Name = "txtName_Eng";
            this.txtName_Eng.Size = new System.Drawing.Size(122, 30);
            this.txtName_Eng.TabIndex = 4;
            // 
            // btn_Hallo
            // 
            this.btn_Hallo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Hallo.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hallo.Location = new System.Drawing.Point(364, 141);
            this.btn_Hallo.Name = "btn_Hallo";
            this.btn_Hallo.Size = new System.Drawing.Size(89, 30);
            this.btn_Hallo.TabIndex = 3;
            this.btn_Hallo.Text = "Say Hallo";
            this.btn_Hallo.UseVisualStyleBackColor = true;
            this.btn_Hallo.Click += new System.EventHandler(this.btn_Hallo_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName_Eng);
            this.Controls.Add(this.btn_Hallo);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btn_Hi);
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Hi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName_Eng;
        private System.Windows.Forms.Button btn_Hallo;
    }
}

