namespace Stadium_Seating
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassA = new System.Windows.Forms.TextBox();
            this.txtClassB = new System.Windows.Forms.TextBox();
            this.txtClassC = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblClassA = new System.Windows.Forms.Label();
            this.lblClassB = new System.Windows.Forms.Label();
            this.lblClassC = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClassC);
            this.groupBox1.Controls.Add(this.txtClassB);
            this.groupBox1.Controls.Add(this.txtClassA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox1.Location = new System.Drawing.Point(52, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiickets Sold";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold for eaach class of seats.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class C:";
            // 
            // txtClassA
            // 
            this.txtClassA.Location = new System.Drawing.Point(109, 93);
            this.txtClassA.Name = "txtClassA";
            this.txtClassA.Size = new System.Drawing.Size(94, 27);
            this.txtClassA.TabIndex = 4;
            // 
            // txtClassB
            // 
            this.txtClassB.Location = new System.Drawing.Point(109, 156);
            this.txtClassB.Name = "txtClassB";
            this.txtClassB.Size = new System.Drawing.Size(94, 27);
            this.txtClassB.TabIndex = 5;
            // 
            // txtClassC
            // 
            this.txtClassC.Location = new System.Drawing.Point(109, 217);
            this.txtClassC.Name = "txtClassC";
            this.txtClassC.Size = new System.Drawing.Size(94, 27);
            this.txtClassC.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.lblClassC);
            this.groupBox2.Controls.Add(this.lblClassB);
            this.groupBox2.Controls.Add(this.lblClassA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox2.Location = new System.Drawing.Point(404, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Class C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Class B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Class A:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F);
            this.button1.Location = new System.Drawing.Point(128, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Caculate Revenue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F);
            this.button2.Location = new System.Drawing.Point(309, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 12F);
            this.button3.Location = new System.Drawing.Point(473, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 65);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblClassA
            // 
            this.lblClassA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassA.Location = new System.Drawing.Point(131, 37);
            this.lblClassA.Name = "lblClassA";
            this.lblClassA.Size = new System.Drawing.Size(105, 27);
            this.lblClassA.TabIndex = 8;
            // 
            // lblClassB
            // 
            this.lblClassB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassB.Location = new System.Drawing.Point(131, 96);
            this.lblClassB.Name = "lblClassB";
            this.lblClassB.Size = new System.Drawing.Size(105, 27);
            this.lblClassB.TabIndex = 9;
            // 
            // lblClassC
            // 
            this.lblClassC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassC.Location = new System.Drawing.Point(131, 159);
            this.lblClassC.Name = "lblClassC";
            this.lblClassC.Size = new System.Drawing.Size(105, 27);
            this.lblClassC.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(131, 220);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 27);
            this.lblTotal.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClassA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassC;
        private System.Windows.Forms.TextBox txtClassB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblClassC;
        private System.Windows.Forms.Label lblClassB;
        private System.Windows.Forms.Label lblClassA;
    }
}

