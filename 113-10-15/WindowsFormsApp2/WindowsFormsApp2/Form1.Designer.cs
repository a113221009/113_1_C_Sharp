﻿namespace WindowsFormsApp2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txbKM = new System.Windows.Forms.TextBox();
            this.txbLiter = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F);
            this.label1.Location = new System.Drawing.Point(94, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "公里數";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 24F);
            this.label2.Location = new System.Drawing.Point(72, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "使用油耗";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 24F);
            this.label3.Location = new System.Drawing.Point(32, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "公里/每公升";
            // 
            // txbKM
            // 
            this.txbKM.Font = new System.Drawing.Font("新細明體", 16F);
            this.txbKM.Location = new System.Drawing.Point(287, 57);
            this.txbKM.Name = "txbKM";
            this.txbKM.Size = new System.Drawing.Size(243, 33);
            this.txbKM.TabIndex = 3;
            this.txbKM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbLiter
            // 
            this.txbLiter.Font = new System.Drawing.Font("新細明體", 16F);
            this.txbLiter.Location = new System.Drawing.Point(287, 157);
            this.txbLiter.Name = "txbLiter";
            this.txbLiter.Size = new System.Drawing.Size(243, 33);
            this.txbLiter.TabIndex = 4;
            this.txbLiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Font = new System.Drawing.Font("新細明體", 16F);
            this.lblShow.Location = new System.Drawing.Point(287, 261);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(243, 43);
            this.lblShow.TabIndex = 5;
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnCalculate.Location = new System.Drawing.Point(113, 358);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(145, 44);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnExit.Location = new System.Drawing.Point(457, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txbLiter);
            this.Controls.Add(this.txbKM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbKM;
        private System.Windows.Forms.TextBox txbLiter;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

