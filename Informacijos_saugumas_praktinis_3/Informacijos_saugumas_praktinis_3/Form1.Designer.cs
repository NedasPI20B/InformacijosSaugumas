
namespace Informacijos_saugumas_praktinis_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.encryptTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.encryptedTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.decryptedTxt = new System.Windows.Forms.TextBox();
            this.nTxt = new System.Windows.Forms.TextBox();
            this.pTxt = new System.Windows.Forms.TextBox();
            this.qTxt = new System.Windows.Forms.TextBox();
            this.eTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text to cypher:";
            // 
            // encryptTxt
            // 
            this.encryptTxt.Location = new System.Drawing.Point(38, 41);
            this.encryptTxt.Multiline = true;
            this.encryptTxt.Name = "encryptTxt";
            this.encryptTxt.Size = new System.Drawing.Size(721, 153);
            this.encryptTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(300, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted text:";
            // 
            // encryptedTxt
            // 
            this.encryptedTxt.Location = new System.Drawing.Point(38, 239);
            this.encryptedTxt.Multiline = true;
            this.encryptedTxt.Name = "encryptedTxt";
            this.encryptedTxt.ReadOnly = true;
            this.encryptedTxt.Size = new System.Drawing.Size(721, 153);
            this.encryptedTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(300, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Decrypted text:";
            // 
            // decryptedTxt
            // 
            this.decryptedTxt.Location = new System.Drawing.Point(38, 427);
            this.decryptedTxt.Multiline = true;
            this.decryptedTxt.Name = "decryptedTxt";
            this.decryptedTxt.ReadOnly = true;
            this.decryptedTxt.Size = new System.Drawing.Size(721, 153);
            this.decryptedTxt.TabIndex = 5;
            // 
            // nTxt
            // 
            this.nTxt.Location = new System.Drawing.Point(1013, 41);
            this.nTxt.Name = "nTxt";
            this.nTxt.Size = new System.Drawing.Size(100, 26);
            this.nTxt.TabIndex = 6;
            // 
            // pTxt
            // 
            this.pTxt.Location = new System.Drawing.Point(836, 41);
            this.pTxt.Name = "pTxt";
            this.pTxt.Size = new System.Drawing.Size(100, 26);
            this.pTxt.TabIndex = 7;
            // 
            // qTxt
            // 
            this.qTxt.Location = new System.Drawing.Point(836, 123);
            this.qTxt.Name = "qTxt";
            this.qTxt.Size = new System.Drawing.Size(100, 26);
            this.qTxt.TabIndex = 8;
            // 
            // eTxt
            // 
            this.eTxt.Location = new System.Drawing.Point(1013, 123);
            this.eTxt.Name = "eTxt";
            this.eTxt.Size = new System.Drawing.Size(100, 26);
            this.eTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(797, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "p:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(797, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "q:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(974, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "n:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(974, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "e:";
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(846, 199);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(110, 51);
            this.encryptBtn.TabIndex = 14;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(992, 199);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(110, 51);
            this.decryptBtn.TabIndex = 15;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 593);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eTxt);
            this.Controls.Add(this.qTxt);
            this.Controls.Add(this.pTxt);
            this.Controls.Add(this.nTxt);
            this.Controls.Add(this.decryptedTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptedTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptTxt;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox encryptedTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decryptedTxt;
        private System.Windows.Forms.TextBox nTxt;
        private System.Windows.Forms.TextBox pTxt;
        private System.Windows.Forms.TextBox qTxt;
        private System.Windows.Forms.TextBox eTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
    }
}

