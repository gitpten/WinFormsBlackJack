namespace WinFormsBlackJack
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
            this.pPlayer = new System.Windows.Forms.Panel();
            this.pDealer = new System.Windows.Forms.Panel();
            this.pDeck = new System.Windows.Forms.Panel();
            this.lInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pPlayer
            // 
            this.pPlayer.Location = new System.Drawing.Point(251, 26);
            this.pPlayer.Name = "pPlayer";
            this.pPlayer.Size = new System.Drawing.Size(573, 192);
            this.pPlayer.TabIndex = 0;
            // 
            // pDealer
            // 
            this.pDealer.Location = new System.Drawing.Point(251, 346);
            this.pDealer.Name = "pDealer";
            this.pDealer.Size = new System.Drawing.Size(573, 192);
            this.pDealer.TabIndex = 1;
            // 
            // pDeck
            // 
            this.pDeck.Location = new System.Drawing.Point(35, 154);
            this.pDeck.Name = "pDeck";
            this.pDeck.Size = new System.Drawing.Size(147, 192);
            this.pDeck.TabIndex = 1;
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(262, 259);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(50, 20);
            this.lInfo.TabIndex = 2;
            this.lInfo.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pass";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 580);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.pDeck);
            this.Controls.Add(this.pDealer);
            this.Controls.Add(this.pPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pPlayer;
        private Panel pDealer;
        private Panel pDeck;
        private Label lInfo;
        private Button button1;
        private Button button2;
    }
}