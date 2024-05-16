namespace PingTest
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
            btnRun = new Button();
            txtIP = new TextBox();
            lbl_success = new Label();
            lbl_Unsucess = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(110, 133);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(129, 29);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(110, 71);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(129, 27);
            txtIP.TabIndex = 1;
            txtIP.Text = "8.8.8.8";
            txtIP.TextChanged += txtIP_TextChanged;
            // 
            // lbl_success
            // 
            lbl_success.AutoSize = true;
            lbl_success.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_success.ForeColor = Color.FromArgb(0, 192, 0);
            lbl_success.Location = new Point(40, 21);
            lbl_success.Name = "lbl_success";
            lbl_success.Size = new Size(105, 28);
            lbl_success.TabIndex = 4;
            lbl_success.Text = "Successfull";
            // 
            // lbl_Unsucess
            // 
            lbl_Unsucess.AutoSize = true;
            lbl_Unsucess.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Unsucess.ForeColor = Color.Red;
            lbl_Unsucess.Location = new Point(181, 21);
            lbl_Unsucess.Name = "lbl_Unsucess";
            lbl_Unsucess.Size = new Size(69, 28);
            lbl_Unsucess.TabIndex = 5;
            lbl_Unsucess.Text = "Failure";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 6;
            label1.Text = "Ip Address:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 211);
            Controls.Add(label1);
            Controls.Add(lbl_Unsucess);
            Controls.Add(lbl_success);
            Controls.Add(txtIP);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "PingTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private TextBox txtIP;
        private Label lbl_success;
        private Label lbl_Unsucess;
        private Label label1;
    }
}