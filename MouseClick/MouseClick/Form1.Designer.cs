namespace MouseClick
{
    partial class Form1
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
            this.clickButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickButton
            // 
            this.clickButton.Location = new System.Drawing.Point(282, 194);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(205, 86);
            this.clickButton.TabIndex = 0;
            this.clickButton.Text = "點擊";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(282, 300);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(205, 86);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "重設";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countLabel.Location = new System.Drawing.Point(254, 91);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(277, 34);
            this.countLabel.TabIndex = 1;
            this.countLabel.Text = "你已經點了... 0 下";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.clickButton);
            this.Name = "Form1";
            this.Text = "按鈕點擊紀錄程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label countLabel;
    }
}

