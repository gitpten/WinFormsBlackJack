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
            this.bHit = new System.Windows.Forms.Button();
            this.lInfo = new System.Windows.Forms.Label();
            this.bPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pPlayer
            // 
            this.pPlayer.Location = new System.Drawing.Point(338, 61);
            this.pPlayer.Name = "pPlayer";
            this.pPlayer.Size = new System.Drawing.Size(340, 125);
            this.pPlayer.TabIndex = 0;
            // 
            // pDealer
            // 
            this.pDealer.Location = new System.Drawing.Point(338, 382);
            this.pDealer.Name = "pDealer";
            this.pDealer.Size = new System.Drawing.Size(250, 125);
            this.pDealer.TabIndex = 1;
            // 
            // pDeck
            // 
            this.pDeck.Location = new System.Drawing.Point(78, 223);
            this.pDeck.Name = "pDeck";
            this.pDeck.Size = new System.Drawing.Size(133, 125);
            this.pDeck.TabIndex = 2;
            // 
            // bHit
            // 
            this.bHit.Location = new System.Drawing.Point(684, 135);
            this.bHit.Name = "bHit";
            this.bHit.Size = new System.Drawing.Size(94, 29);
            this.bHit.TabIndex = 3;
            this.bHit.Text = "hit";
            this.bHit.UseVisualStyleBackColor = true;
            this.bHit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(12, 9);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(50, 20);
            this.lInfo.TabIndex = 4;
            this.lInfo.Text = "label1";
            // 
            // bPass
            // 
            this.bPass.Location = new System.Drawing.Point(684, 198);
            this.bPass.Name = "bPass";
            this.bPass.Size = new System.Drawing.Size(94, 29);
            this.bPass.TabIndex = 5;
            this.bPass.Text = "pass";
            this.bPass.UseVisualStyleBackColor = true;
            this.bPass.Click += new System.EventHandler(this.bPass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 580);
            this.Controls.Add(this.bPass);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.bHit);
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
        private Button bHit;
        private Label lInfo;
        private Button bPass;
    }
}