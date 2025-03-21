﻿namespace wpf_in_winforms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblSpeed = new System.Windows.Forms.Label();
            this.cboSpeed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQR1Content = new System.Windows.Forms.TextBox();
            this.txtQR2Content = new System.Windows.Forms.TextBox();
            this.txtQR3Content = new System.Windows.Forms.TextBox();
            this.txtQR4Content = new System.Windows.Forms.TextBox();
            this.txtQR5Content = new System.Windows.Forms.TextBox();
            this.txtQR6Content = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQR1Path = new System.Windows.Forms.Label();
            this.txtQR2Path = new System.Windows.Forms.Label();
            this.txtQR3Path = new System.Windows.Forms.Label();
            this.txtQR4Path = new System.Windows.Forms.Label();
            this.txtQR5Path = new System.Windows.Forms.Label();
            this.txtQR6Path = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(20, 26);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(70, 24);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "Speed";
            // 
            // cboSpeed
            // 
            this.cboSpeed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSpeed.FormattingEnabled = true;
            this.cboSpeed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboSpeed.Location = new System.Drawing.Point(96, 23);
            this.cboSpeed.Name = "cboSpeed";
            this.cboSpeed.Size = new System.Drawing.Size(121, 32);
            this.cboSpeed.TabIndex = 1;
            this.cboSpeed.SelectedValueChanged += new System.EventHandler(this.cboSpeed_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "QR1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "QR2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "QR3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "QR4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "QR5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "QR6";
            // 
            // txtQR1Content
            // 
            this.txtQR1Content.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtQR1Content.Location = new System.Drawing.Point(325, 107);
            this.txtQR1Content.Name = "txtQR1Content";
            this.txtQR1Content.Size = new System.Drawing.Size(155, 32);
            this.txtQR1Content.TabIndex = 3;
            // 
            // txtQR2Content
            // 
            this.txtQR2Content.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtQR2Content.Location = new System.Drawing.Point(325, 149);
            this.txtQR2Content.Name = "txtQR2Content";
            this.txtQR2Content.Size = new System.Drawing.Size(155, 32);
            this.txtQR2Content.TabIndex = 7;
            // 
            // txtQR3Content
            // 
            this.txtQR3Content.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtQR3Content.Location = new System.Drawing.Point(325, 189);
            this.txtQR3Content.Name = "txtQR3Content";
            this.txtQR3Content.Size = new System.Drawing.Size(155, 32);
            this.txtQR3Content.TabIndex = 11;
            // 
            // txtQR4Content
            // 
            this.txtQR4Content.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtQR4Content.Location = new System.Drawing.Point(325, 228);
            this.txtQR4Content.Name = "txtQR4Content";
            this.txtQR4Content.Size = new System.Drawing.Size(155, 32);
            this.txtQR4Content.TabIndex = 15;
            // 
            // txtQR5Content
            // 
            this.txtQR5Content.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtQR5Content.Location = new System.Drawing.Point(325, 269);
            this.txtQR5Content.Name = "txtQR5Content";
            this.txtQR5Content.Size = new System.Drawing.Size(155, 32);
            this.txtQR5Content.TabIndex = 19;
            // 
            // txtQR6Content
            // 
            this.txtQR6Content.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtQR6Content.Location = new System.Drawing.Point(325, 309);
            this.txtQR6Content.Name = "txtQR6Content";
            this.txtQR6Content.Size = new System.Drawing.Size(155, 32);
            this.txtQR6Content.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(147, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Đường dẫn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(357, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Nội dung";
            // 
            // txtQR1Path
            // 
            this.txtQR1Path.BackColor = System.Drawing.SystemColors.Window;
            this.txtQR1Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQR1Path.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtQR1Path.Location = new System.Drawing.Point(92, 107);
            this.txtQR1Path.Name = "txtQR1Path";
            this.txtQR1Path.Size = new System.Drawing.Size(223, 32);
            this.txtQR1Path.TabIndex = 34;
            // 
            // txtQR2Path
            // 
            this.txtQR2Path.BackColor = System.Drawing.SystemColors.Window;
            this.txtQR2Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQR2Path.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtQR2Path.Location = new System.Drawing.Point(92, 148);
            this.txtQR2Path.Name = "txtQR2Path";
            this.txtQR2Path.Size = new System.Drawing.Size(223, 32);
            this.txtQR2Path.TabIndex = 35;
            // 
            // txtQR3Path
            // 
            this.txtQR3Path.BackColor = System.Drawing.SystemColors.Window;
            this.txtQR3Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQR3Path.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtQR3Path.Location = new System.Drawing.Point(92, 188);
            this.txtQR3Path.Name = "txtQR3Path";
            this.txtQR3Path.Size = new System.Drawing.Size(223, 32);
            this.txtQR3Path.TabIndex = 36;
            // 
            // txtQR4Path
            // 
            this.txtQR4Path.BackColor = System.Drawing.SystemColors.Window;
            this.txtQR4Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQR4Path.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtQR4Path.Location = new System.Drawing.Point(92, 227);
            this.txtQR4Path.Name = "txtQR4Path";
            this.txtQR4Path.Size = new System.Drawing.Size(223, 32);
            this.txtQR4Path.TabIndex = 37;
            // 
            // txtQR5Path
            // 
            this.txtQR5Path.BackColor = System.Drawing.SystemColors.Window;
            this.txtQR5Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQR5Path.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtQR5Path.Location = new System.Drawing.Point(92, 268);
            this.txtQR5Path.Name = "txtQR5Path";
            this.txtQR5Path.Size = new System.Drawing.Size(223, 32);
            this.txtQR5Path.TabIndex = 38;
            // 
            // txtQR6Path
            // 
            this.txtQR6Path.BackColor = System.Drawing.SystemColors.Window;
            this.txtQR6Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQR6Path.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtQR6Path.Location = new System.Drawing.Point(92, 309);
            this.txtQR6Path.Name = "txtQR6Path";
            this.txtQR6Path.Size = new System.Drawing.Size(223, 32);
            this.txtQR6Path.TabIndex = 39;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 387);
            this.Controls.Add(this.txtQR6Path);
            this.Controls.Add(this.txtQR5Path);
            this.Controls.Add(this.txtQR4Path);
            this.Controls.Add(this.txtQR3Path);
            this.Controls.Add(this.txtQR2Path);
            this.Controls.Add(this.txtQR1Path);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQR6Content);
            this.Controls.Add(this.txtQR5Content);
            this.Controls.Add(this.txtQR4Content);
            this.Controls.Add(this.txtQR3Content);
            this.Controls.Add(this.txtQR2Content);
            this.Controls.Add(this.txtQR1Content);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.ComboBox cboSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQR1Content;
        private System.Windows.Forms.TextBox txtQR2Content;
        private System.Windows.Forms.TextBox txtQR3Content;
        private System.Windows.Forms.TextBox txtQR4Content;
        private System.Windows.Forms.TextBox txtQR5Content;
        private System.Windows.Forms.TextBox txtQR6Content;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtQR1Path;
        private System.Windows.Forms.Label txtQR2Path;
        private System.Windows.Forms.Label txtQR3Path;
        private System.Windows.Forms.Label txtQR4Path;
        private System.Windows.Forms.Label txtQR5Path;
        private System.Windows.Forms.Label txtQR6Path;
    }
}