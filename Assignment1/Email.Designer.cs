namespace Assignment1
{
    partial class Email
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.locationLbl = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bodyTextB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.titleTxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toTxtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.fromTxtBox = new System.Windows.Forms.TextBox();
            this.fromLbl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.locationLbl);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.bodyTextB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sendBtn);
            this.groupBox2.Controls.Add(this.titleTxtB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.toTxtB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(103, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 299);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Location = new System.Drawing.Point(315, 240);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(0, 13);
            this.locationLbl.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(187, 235);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 24);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Attach file";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bodyTextB
            // 
            this.bodyTextB.Location = new System.Drawing.Point(96, 93);
            this.bodyTextB.Multiline = true;
            this.bodyTextB.Name = "bodyTextB";
            this.bodyTextB.Size = new System.Drawing.Size(480, 131);
            this.bodyTextB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Text :";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(96, 235);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // titleTxtB
            // 
            this.titleTxtB.Location = new System.Drawing.Point(96, 67);
            this.titleTxtB.Name = "titleTxtB";
            this.titleTxtB.Size = new System.Drawing.Size(480, 20);
            this.titleTxtB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title :";
            // 
            // toTxtB
            // 
            this.toTxtB.Location = new System.Drawing.Point(96, 39);
            this.toTxtB.Name = "toTxtB";
            this.toTxtB.Size = new System.Drawing.Size(480, 20);
            this.toTxtB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passTxtBox);
            this.groupBox1.Controls.Add(this.passLbl);
            this.groupBox1.Controls.Add(this.fromTxtBox);
            this.groupBox1.Controls.Add(this.fromLbl);
            this.groupBox1.Location = new System.Drawing.Point(103, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // passTxtBox
            // 
            this.passTxtBox.Location = new System.Drawing.Point(96, 67);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.PasswordChar = '•';
            this.passTxtBox.Size = new System.Drawing.Size(480, 20);
            this.passTxtBox.TabIndex = 8;
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(31, 74);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(59, 13);
            this.passLbl.TabIndex = 7;
            this.passLbl.Text = "Password :";
            // 
            // fromTxtBox
            // 
            this.fromTxtBox.Location = new System.Drawing.Point(96, 39);
            this.fromTxtBox.Name = "fromTxtBox";
            this.fromTxtBox.Size = new System.Drawing.Size(480, 20);
            this.fromTxtBox.TabIndex = 6;
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(31, 46);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(36, 13);
            this.fromLbl.TabIndex = 5;
            this.fromLbl.Text = "From :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(832, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Email";
            this.Text = "Email";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox bodyTextB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox titleTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toTxtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox fromTxtBox;
        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}