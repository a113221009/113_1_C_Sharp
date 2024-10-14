namespace w5_homework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_8_Diamonds = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.ptb_2_Clubs = new System.Windows.Forms.PictureBox();
            this.ptb_King_Clubs = new System.Windows.Forms.PictureBox();
            this.ptb_Ace_Spades = new System.Windows.Forms.PictureBox();
            this.ptb_Joker_Black = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_8_Diamonds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_2_Clubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_King_Clubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Ace_Spades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Joker_Black)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(221, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a card to see it\'s name";
            // 
            // ptb_8_Diamonds
            // 
            this.ptb_8_Diamonds.Image = ((System.Drawing.Image)(resources.GetObject("ptb_8_Diamonds.Image")));
            this.ptb_8_Diamonds.Location = new System.Drawing.Point(74, 110);
            this.ptb_8_Diamonds.Name = "ptb_8_Diamonds";
            this.ptb_8_Diamonds.Size = new System.Drawing.Size(110, 155);
            this.ptb_8_Diamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_8_Diamonds.TabIndex = 1;
            this.ptb_8_Diamonds.TabStop = false;
            this.ptb_8_Diamonds.Click += new System.EventHandler(this.ptb_8_Diamonds_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 22F);
            this.textBox1.Location = new System.Drawing.Point(74, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(669, 43);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("新細明體", 20F);
            this.btn_Exit.Location = new System.Drawing.Point(313, 363);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(169, 58);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ptb_2_Clubs
            // 
            this.ptb_2_Clubs.Image = ((System.Drawing.Image)(resources.GetObject("ptb_2_Clubs.Image")));
            this.ptb_2_Clubs.Location = new System.Drawing.Point(202, 110);
            this.ptb_2_Clubs.Name = "ptb_2_Clubs";
            this.ptb_2_Clubs.Size = new System.Drawing.Size(110, 155);
            this.ptb_2_Clubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_2_Clubs.TabIndex = 4;
            this.ptb_2_Clubs.TabStop = false;
            this.ptb_2_Clubs.Click += new System.EventHandler(this.ptb_2_Clubs_Click);
            // 
            // ptb_King_Clubs
            // 
            this.ptb_King_Clubs.Image = ((System.Drawing.Image)(resources.GetObject("ptb_King_Clubs.Image")));
            this.ptb_King_Clubs.Location = new System.Drawing.Point(338, 110);
            this.ptb_King_Clubs.Name = "ptb_King_Clubs";
            this.ptb_King_Clubs.Size = new System.Drawing.Size(110, 155);
            this.ptb_King_Clubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_King_Clubs.TabIndex = 5;
            this.ptb_King_Clubs.TabStop = false;
            this.ptb_King_Clubs.Click += new System.EventHandler(this.ptb_King_Clubs_Click);
            // 
            // ptb_Ace_Spades
            // 
            this.ptb_Ace_Spades.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Ace_Spades.Image")));
            this.ptb_Ace_Spades.Location = new System.Drawing.Point(481, 110);
            this.ptb_Ace_Spades.Name = "ptb_Ace_Spades";
            this.ptb_Ace_Spades.Size = new System.Drawing.Size(110, 155);
            this.ptb_Ace_Spades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Ace_Spades.TabIndex = 6;
            this.ptb_Ace_Spades.TabStop = false;
            this.ptb_Ace_Spades.Click += new System.EventHandler(this.ptb_Ace_Spades_Click);
            // 
            // ptb_Joker_Black
            // 
            this.ptb_Joker_Black.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Joker_Black.Image")));
            this.ptb_Joker_Black.Location = new System.Drawing.Point(633, 110);
            this.ptb_Joker_Black.Name = "ptb_Joker_Black";
            this.ptb_Joker_Black.Size = new System.Drawing.Size(110, 155);
            this.ptb_Joker_Black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Joker_Black.TabIndex = 7;
            this.ptb_Joker_Black.TabStop = false;
            this.ptb_Joker_Black.Click += new System.EventHandler(this.ptb_Joker_Black_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptb_Joker_Black);
            this.Controls.Add(this.ptb_Ace_Spades);
            this.Controls.Add(this.ptb_King_Clubs);
            this.Controls.Add(this.ptb_2_Clubs);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ptb_8_Diamonds);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_8_Diamonds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_2_Clubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_King_Clubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Ace_Spades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Joker_Black)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptb_8_Diamonds;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox ptb_2_Clubs;
        private System.Windows.Forms.PictureBox ptb_King_Clubs;
        private System.Windows.Forms.PictureBox ptb_Ace_Spades;
        private System.Windows.Forms.PictureBox ptb_Joker_Black;
    }
}

