namespace Tutorial_2_5
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
            ptxBack = new PictureBox();
            ptxFront = new PictureBox();
            btnShowBack = new Button();
            btnShowFront = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxFront).BeginInit();
            SuspendLayout();
            // 
            // ptxBack
            // 
            ptxBack.Image = (Image)resources.GetObject("ptxBack.Image");
            ptxBack.Location = new Point(76, 52);
            ptxBack.Name = "ptxBack";
            ptxBack.Size = new Size(125, 175);
            ptxBack.SizeMode = PictureBoxSizeMode.Zoom;
            ptxBack.TabIndex = 0;
            ptxBack.TabStop = false;
            ptxBack.Visible = false;
            // 
            // ptxFront
            // 
            ptxFront.Image = (Image)resources.GetObject("ptxFront.Image");
            ptxFront.Location = new Point(293, 52);
            ptxFront.Name = "ptxFront";
            ptxFront.Size = new Size(125, 175);
            ptxFront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxFront.TabIndex = 1;
            ptxFront.TabStop = false;
            ptxFront.Visible = false;
            // 
            // btnShowBack
            // 
            btnShowBack.Font = new Font("Segoe UI", 18F);
            btnShowBack.Location = new Point(91, 307);
            btnShowBack.Name = "btnShowBack";
            btnShowBack.Size = new Size(110, 65);
            btnShowBack.TabIndex = 2;
            btnShowBack.Text = "背面";
            btnShowBack.UseVisualStyleBackColor = true;
            btnShowBack.Click += btnShowBack_Click;
            // 
            // btnShowFront
            // 
            btnShowFront.Font = new Font("Segoe UI", 18F);
            btnShowFront.Location = new Point(293, 307);
            btnShowFront.Name = "btnShowFront";
            btnShowFront.Size = new Size(110, 65);
            btnShowFront.TabIndex = 3;
            btnShowFront.Text = "正面";
            btnShowFront.UseVisualStyleBackColor = true;
            btnShowFront.Click += btnShowFront_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14F);
            btnExit.Location = new Point(192, 425);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 44);
            btnExit.TabIndex = 4;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 515);
            Controls.Add(btnExit);
            Controls.Add(btnShowFront);
            Controls.Add(btnShowBack);
            Controls.Add(ptxFront);
            Controls.Add(ptxBack);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ptxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxFront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxBack;
        private PictureBox ptxFront;
        private Button btnShowBack;
        private Button btnShowFront;
        private Button btnExit;
    }
}
