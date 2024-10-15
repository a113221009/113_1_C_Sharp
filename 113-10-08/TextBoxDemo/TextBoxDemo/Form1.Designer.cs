namespace TextBoxDemo
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblFullName = new Label();
            txbFirstName = new TextBox();
            txbLastName = new TextBox();
            btnConfirm = new Button();
            lblShow = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 18F);
            lblFirstName.Location = new Point(140, 53);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(134, 32);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 18F);
            lblLastName.Location = new Point(140, 149);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(131, 32);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 18F);
            lblFullName.Location = new Point(140, 246);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(128, 32);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name:";
            // 
            // txbFirstName
            // 
            txbFirstName.Font = new Font("Segoe UI", 18F);
            txbFirstName.Location = new Point(294, 53);
            txbFirstName.Name = "txbFirstName";
            txbFirstName.Size = new Size(241, 39);
            txbFirstName.TabIndex = 3;
            // 
            // txbLastName
            // 
            txbLastName.Font = new Font("Segoe UI", 18F);
            txbLastName.Location = new Point(293, 149);
            txbLastName.Name = "txbLastName";
            txbLastName.Size = new Size(241, 39);
            txbLastName.TabIndex = 4;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 18F);
            btnConfirm.Location = new Point(206, 334);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(142, 50);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblShow
            // 
            lblShow.BackColor = SystemColors.ControlLight;
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 20F);
            lblShow.Location = new Point(294, 246);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(241, 40);
            lblShow.TabIndex = 7;
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 18F);
            btnExit.Location = new Point(444, 334);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 50);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(lblShow);
            Controls.Add(btnConfirm);
            Controls.Add(txbLastName);
            Controls.Add(txbFirstName);
            Controls.Add(lblFullName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblFullName;
        private TextBox txbFirstName;
        private TextBox txbLastName;
        private Button btnConfirm;
        private Label lblShow;
        private Button btnExit;
    }
}
