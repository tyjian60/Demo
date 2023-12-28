namespace BorrowAndRepay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myNameTextBox = new System.Windows.Forms.TextBox();
            this.friendNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.myNameLebel = new System.Windows.Forms.Label();
            this.myMoneyLebel = new System.Windows.Forms.Label();
            this.friendNameLebel = new System.Windows.Forms.Label();
            this.friendMoneyLebel = new System.Windows.Forms.Label();
            this.borrowButton = new System.Windows.Forms.Button();
            this.repayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入我的名字：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "請輸入朋友的名字：";
            // 
            // myNameTextBox
            // 
            this.myNameTextBox.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myNameTextBox.Location = new System.Drawing.Point(307, 32);
            this.myNameTextBox.Name = "myNameTextBox";
            this.myNameTextBox.Size = new System.Drawing.Size(167, 43);
            this.myNameTextBox.TabIndex = 1;
            // 
            // friendNameTextBox
            // 
            this.friendNameTextBox.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendNameTextBox.Location = new System.Drawing.Point(307, 95);
            this.friendNameTextBox.Name = "friendNameTextBox";
            this.friendNameTextBox.Size = new System.Drawing.Size(167, 43);
            this.friendNameTextBox.TabIndex = 1;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.confirmButton.Location = new System.Drawing.Point(524, 36);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(172, 94);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "確認";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(34, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "我的名字：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(34, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "我的$$：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(360, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "朋友的名字：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(360, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 35);
            this.label6.TabIndex = 3;
            this.label6.Text = "朋友的$$：";
            // 
            // myNameLebel
            // 
            this.myNameLebel.AutoSize = true;
            this.myNameLebel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myNameLebel.Location = new System.Drawing.Point(195, 183);
            this.myNameLebel.Name = "myNameLebel";
            this.myNameLebel.Size = new System.Drawing.Size(71, 35);
            this.myNameLebel.TabIndex = 3;
            this.myNameLebel.Text = "小王";
            // 
            // myMoneyLebel
            // 
            this.myMoneyLebel.AutoSize = true;
            this.myMoneyLebel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myMoneyLebel.Location = new System.Drawing.Point(195, 247);
            this.myMoneyLebel.Name = "myMoneyLebel";
            this.myMoneyLebel.Size = new System.Drawing.Size(79, 35);
            this.myMoneyLebel.TabIndex = 3;
            this.myMoneyLebel.Text = "2000";
            // 
            // friendNameLebel
            // 
            this.friendNameLebel.AutoSize = true;
            this.friendNameLebel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendNameLebel.Location = new System.Drawing.Point(549, 183);
            this.friendNameLebel.Name = "friendNameLebel";
            this.friendNameLebel.Size = new System.Drawing.Size(71, 35);
            this.friendNameLebel.TabIndex = 3;
            this.friendNameLebel.Text = "小三";
            // 
            // friendMoneyLebel
            // 
            this.friendMoneyLebel.AutoSize = true;
            this.friendMoneyLebel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendMoneyLebel.Location = new System.Drawing.Point(549, 247);
            this.friendMoneyLebel.Name = "friendMoneyLebel";
            this.friendMoneyLebel.Size = new System.Drawing.Size(95, 35);
            this.friendMoneyLebel.TabIndex = 3;
            this.friendMoneyLebel.Text = "10000";
            // 
            // borrowButton
            // 
            this.borrowButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.borrowButton.Location = new System.Drawing.Point(40, 303);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(656, 59);
            this.borrowButton.TabIndex = 4;
            this.borrowButton.Text = "跟 XXX 借 1000$";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // repayButton
            // 
            this.repayButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.repayButton.Location = new System.Drawing.Point(40, 368);
            this.repayButton.Name = "repayButton";
            this.repayButton.Size = new System.Drawing.Size(656, 59);
            this.repayButton.TabIndex = 4;
            this.repayButton.Text = "還給 XXX 1000$";
            this.repayButton.UseVisualStyleBackColor = true;
            this.repayButton.Click += new System.EventHandler(this.repayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 449);
            this.Controls.Add(this.repayButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.friendMoneyLebel);
            this.Controls.Add(this.friendNameLebel);
            this.Controls.Add(this.myMoneyLebel);
            this.Controls.Add(this.myNameLebel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.friendNameTextBox);
            this.Controls.Add(this.myNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "借還錢程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox myNameTextBox;
        private System.Windows.Forms.TextBox friendNameTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label myNameLebel;
        private System.Windows.Forms.Label myMoneyLebel;
        private System.Windows.Forms.Label friendNameLebel;
        private System.Windows.Forms.Label friendMoneyLebel;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button repayButton;
    }
}

