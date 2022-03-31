
namespace InfoSaugumasPD2
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
            this.encryptTxt = new System.Windows.Forms.TextBox();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.decryptTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptedTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.decryptedTxt = new System.Windows.Forms.TextBox();
            this.De = new System.Windows.Forms.Label();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.modeList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.keyTxt = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fileNameTxt = new System.Windows.Forms.TextBox();
            this.ivTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cleardecBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encryptTxt
            // 
            this.encryptTxt.Location = new System.Drawing.Point(513, 805);
            this.encryptTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.encryptTxt.Multiline = true;
            this.encryptTxt.Name = "encryptTxt";
            this.encryptTxt.Size = new System.Drawing.Size(380, 29);
            this.encryptTxt.TabIndex = 0;
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(444, 457);
            this.EncryptBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(112, 35);
            this.EncryptBtn.TabIndex = 1;
            this.EncryptBtn.Text = "Encrypt";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // decryptTxt
            // 
            this.decryptTxt.Location = new System.Drawing.Point(513, 869);
            this.decryptTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decryptTxt.Name = "decryptTxt";
            this.decryptTxt.Size = new System.Drawing.Size(380, 26);
            this.decryptTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 805);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Encrypt your Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 866);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Decrypt your Text:";
            // 
            // encryptedTxt
            // 
            this.encryptedTxt.Location = new System.Drawing.Point(162, 569);
            this.encryptedTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.encryptedTxt.Multiline = true;
            this.encryptedTxt.Name = "encryptedTxt";
            this.encryptedTxt.ReadOnly = true;
            this.encryptedTxt.Size = new System.Drawing.Size(392, 167);
            this.encryptedTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 517);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Encrypted:";
            // 
            // decryptedTxt
            // 
            this.decryptedTxt.Location = new System.Drawing.Point(656, 566);
            this.decryptedTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decryptedTxt.Multiline = true;
            this.decryptedTxt.Name = "decryptedTxt";
            this.decryptedTxt.ReadOnly = true;
            this.decryptedTxt.Size = new System.Drawing.Size(392, 170);
            this.decryptedTxt.TabIndex = 8;
            // 
            // De
            // 
            this.De.AutoSize = true;
            this.De.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.De.Location = new System.Drawing.Point(766, 517);
            this.De.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.De.Name = "De";
            this.De.Size = new System.Drawing.Size(129, 29);
            this.De.TabIndex = 9;
            this.De.Text = "Decrypted:";
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(656, 457);
            this.DecryptBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(112, 35);
            this.DecryptBtn.TabIndex = 10;
            this.DecryptBtn.Text = "Decrypt";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // modeList
            // 
            this.modeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeList.FormattingEnabled = true;
            this.modeList.ItemHeight = 33;
            this.modeList.Items.AddRange(new object[] {
            "CBC",
            "ECB"});
            this.modeList.Location = new System.Drawing.Point(656, 318);
            this.modeList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modeList.MultiColumn = true;
            this.modeList.Name = "modeList";
            this.modeList.Size = new System.Drawing.Size(70, 103);
            this.modeList.Sorted = true;
            this.modeList.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(228, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select cipher mode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Insert cryption Key:";
            // 
            // keyTxt
            // 
            this.keyTxt.Location = new System.Drawing.Point(444, 137);
            this.keyTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.keyTxt.Name = "keyTxt";
            this.keyTxt.Size = new System.Drawing.Size(502, 26);
            this.keyTxt.TabIndex = 14;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(608, 18);
            this.browseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(160, 35);
            this.browseBtn.TabIndex = 15;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Select file:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Selected file Name:";
            // 
            // fileNameTxt
            // 
            this.fileNameTxt.Location = new System.Drawing.Point(444, 78);
            this.fileNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileNameTxt.Multiline = true;
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.ReadOnly = true;
            this.fileNameTxt.Size = new System.Drawing.Size(502, 29);
            this.fileNameTxt.TabIndex = 18;
            // 
            // ivTxt
            // 
            this.ivTxt.Location = new System.Drawing.Point(444, 191);
            this.ivTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ivTxt.MaxLength = 32;
            this.ivTxt.Name = "ivTxt";
            this.ivTxt.Size = new System.Drawing.Size(502, 26);
            this.ivTxt.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Insert cryption IV (32):";
            // 
            // cleardecBtn
            // 
            this.cleardecBtn.Location = new System.Drawing.Point(772, 748);
            this.cleardecBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cleardecBtn.Name = "cleardecBtn";
            this.cleardecBtn.Size = new System.Drawing.Size(188, 35);
            this.cleardecBtn.TabIndex = 21;
            this.cleardecBtn.Text = "Clear Decryption";
            this.cleardecBtn.UseVisualStyleBackColor = true;
            this.cleardecBtn.Click += new System.EventHandler(this.cleardecBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 934);
            this.Controls.Add(this.cleardecBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ivTxt);
            this.Controls.Add(this.fileNameTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.keyTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modeList);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.De);
            this.Controls.Add(this.decryptedTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptedTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decryptTxt);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.encryptTxt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox encryptTxt;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.TextBox decryptTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encryptedTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decryptedTxt;
        private System.Windows.Forms.Label De;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox keyTxt;
        public System.Windows.Forms.ListBox modeList;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fileNameTxt;
        private System.Windows.Forms.TextBox ivTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cleardecBtn;
    }
}

