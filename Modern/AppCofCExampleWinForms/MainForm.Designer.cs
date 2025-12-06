namespace CofCExampleUsageWinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnValidateCustomer = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxTransactionType = new TextBox();
            panelLogin = new Panel();
            numUdLoginId = new NumericUpDown();
            label20 = new Label();
            label19 = new Label();
            label13 = new Label();
            label17 = new Label();
            label16 = new Label();
            txtBoxPassword = new TextBox();
            label10 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            panelAccountTransaction = new Panel();
            label24 = new Label();
            label23 = new Label();
            numUpDownAccountNumber = new NumericUpDown();
            numUpDownAmount = new NumericUpDown();
            label22 = new Label();
            btnProcessTransaction = new Button();
            label18 = new Label();
            label15 = new Label();
            label14 = new Label();
            label11 = new Label();
            label12 = new Label();
            rtb = new RichTextBox();
            label21 = new Label();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUdLoginId).BeginInit();
            panelAccountTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownAccountNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // btnValidateCustomer
            // 
            btnValidateCustomer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValidateCustomer.Location = new Point(17, 182);
            btnValidateCustomer.Margin = new Padding(4, 5, 4, 5);
            btnValidateCustomer.Name = "btnValidateCustomer";
            btnValidateCustomer.Size = new Size(283, 63);
            btnValidateCustomer.TabIndex = 0;
            btnValidateCustomer.Text = "Validate Customer Login";
            btnValidateCustomer.UseVisualStyleBackColor = true;
            btnValidateCustomer.Click += btnValidateLoginData_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(34, 60);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 7;
            label3.Text = "Account Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(34, 94);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 8;
            label4.Text = "Amount :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(34, 135);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(146, 23);
            label5.TabIndex = 10;
            label5.Text = "Transaction Type :";
            // 
            // txtBoxTransactionType
            // 
            txtBoxTransactionType.CharacterCasing = CharacterCasing.Upper;
            txtBoxTransactionType.Location = new Point(189, 135);
            txtBoxTransactionType.Margin = new Padding(4, 5, 4, 5);
            txtBoxTransactionType.MaxLength = 10;
            txtBoxTransactionType.Name = "txtBoxTransactionType";
            txtBoxTransactionType.Size = new Size(120, 27);
            txtBoxTransactionType.TabIndex = 9;
            txtBoxTransactionType.Text = "D";
            // 
            // panelLogin
            // 
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(numUdLoginId);
            panelLogin.Controls.Add(label20);
            panelLogin.Controls.Add(label19);
            panelLogin.Controls.Add(label13);
            panelLogin.Controls.Add(label17);
            panelLogin.Controls.Add(label16);
            panelLogin.Controls.Add(txtBoxPassword);
            panelLogin.Controls.Add(label10);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(label9);
            panelLogin.Controls.Add(label8);
            panelLogin.Controls.Add(btnValidateCustomer);
            panelLogin.Location = new Point(13, 80);
            panelLogin.Margin = new Padding(4, 5, 4, 5);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(473, 617);
            panelLogin.TabIndex = 11;
            // 
            // numUdLoginId
            // 
            numUdLoginId.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numUdLoginId.Location = new Point(141, 56);
            numUdLoginId.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numUdLoginId.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            numUdLoginId.Name = "numUdLoginId";
            numUdLoginId.Size = new Size(150, 27);
            numUdLoginId.TabIndex = 29;
            numUdLoginId.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label20
            // 
            label20.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label20.Location = new Point(17, 424);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(357, 32);
            label20.TabIndex = 23;
            label20.Text = "Valid Login/User Data:";
            // 
            // label19
            // 
            label19.Font = new Font("Segoe UI", 10F);
            label19.Location = new Point(17, 488);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(357, 32);
            label19.TabIndex = 22;
            label19.Text = "Password: password0, password1, password2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(16, 562);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(390, 23);
            label13.TabIndex = 26;
            label13.Text = "Example: User Id '1001', has password 'password0'";
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 10F);
            label17.Location = new Point(17, 520);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(357, 27);
            label17.TabIndex = 21;
            label17.Text = "Valid Account Numbers: 9990, 9991, 9992";
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 10F);
            label16.Location = new Point(17, 456);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(357, 32);
            label16.TabIndex = 20;
            label16.Text = "Login Ids: 1000, 1001, 1002";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(141, 100);
            txtBoxPassword.Margin = new Padding(4, 5, 4, 5);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(159, 27);
            txtBoxPassword.TabIndex = 18;
            txtBoxPassword.Text = "password0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(12, 100);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(89, 23);
            label10.TabIndex = 19;
            label10.Text = "Password :";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(17, 297);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(357, 72);
            label2.TabIndex = 17;
            label2.Text = "Attempt to validate a login combinations of valid data (listed below), and invalid data. Invalid values will be recognized by the handlers in the login validation chain.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(16, 262);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 16;
            label1.Text = "Instructions:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 14);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(339, 29);
            label9.TabIndex = 15;
            label9.Text = "Customer Login Authentication";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(12, 60);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 23);
            label8.TabIndex = 13;
            label8.Text = "Login Id :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 14);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(324, 29);
            label6.TabIndex = 11;
            label6.Text = "Process Account Transaction";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(429, 725);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(191, 29);
            label7.TabIndex = 12;
            label7.Text = "Validation Errors";
            // 
            // panelAccountTransaction
            // 
            panelAccountTransaction.BorderStyle = BorderStyle.FixedSingle;
            panelAccountTransaction.Controls.Add(label24);
            panelAccountTransaction.Controls.Add(label23);
            panelAccountTransaction.Controls.Add(numUpDownAccountNumber);
            panelAccountTransaction.Controls.Add(numUpDownAmount);
            panelAccountTransaction.Controls.Add(label22);
            panelAccountTransaction.Controls.Add(btnProcessTransaction);
            panelAccountTransaction.Controls.Add(label18);
            panelAccountTransaction.Controls.Add(label15);
            panelAccountTransaction.Controls.Add(label14);
            panelAccountTransaction.Controls.Add(label11);
            panelAccountTransaction.Controls.Add(label12);
            panelAccountTransaction.Controls.Add(label6);
            panelAccountTransaction.Controls.Add(label3);
            panelAccountTransaction.Controls.Add(label4);
            panelAccountTransaction.Controls.Add(txtBoxTransactionType);
            panelAccountTransaction.Controls.Add(label5);
            panelAccountTransaction.Location = new Point(539, 80);
            panelAccountTransaction.Margin = new Padding(4, 5, 4, 5);
            panelAccountTransaction.Name = "panelAccountTransaction";
            panelAccountTransaction.Size = new Size(517, 617);
            panelAccountTransaction.TabIndex = 16;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10F);
            label24.Location = new Point(21, 562);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(345, 23);
            label24.TabIndex = 30;
            label24.Text = "Example: User Id '1001' owns account '9990'";
            // 
            // label23
            // 
            label23.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label23.Location = new Point(21, 424);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(357, 32);
            label23.TabIndex = 30;
            label23.Text = "Valid Account Data:";
            // 
            // numUpDownAccountNumber
            // 
            numUpDownAccountNumber.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numUpDownAccountNumber.Location = new Point(189, 56);
            numUpDownAccountNumber.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numUpDownAccountNumber.Name = "numUpDownAccountNumber";
            numUpDownAccountNumber.Size = new Size(150, 27);
            numUpDownAccountNumber.TabIndex = 28;
            numUpDownAccountNumber.Value = new decimal(new int[] { 9990, 0, 0, 0 });
            // 
            // numUpDownAmount
            // 
            numUpDownAmount.DecimalPlaces = 2;
            numUpDownAmount.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numUpDownAmount.Location = new Point(189, 94);
            numUpDownAmount.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numUpDownAmount.Minimum = new decimal(new int[] { 276447232, 23283, 0, int.MinValue });
            numUpDownAmount.Name = "numUpDownAmount";
            numUpDownAmount.Size = new Size(150, 27);
            numUpDownAmount.TabIndex = 27;
            numUpDownAmount.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // label22
            // 
            label22.Font = new Font("Segoe UI", 10F);
            label22.Location = new Point(21, 461);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(357, 27);
            label22.TabIndex = 25;
            label22.Text = "Valid Account Numbers: 9990, 9991, 9992";
            // 
            // btnProcessTransaction
            // 
            btnProcessTransaction.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcessTransaction.Location = new Point(23, 182);
            btnProcessTransaction.Margin = new Padding(4, 5, 4, 5);
            btnProcessTransaction.Name = "btnProcessTransaction";
            btnProcessTransaction.Size = new Size(283, 63);
            btnProcessTransaction.TabIndex = 24;
            btnProcessTransaction.Text = "Process Transaction";
            btnProcessTransaction.UseVisualStyleBackColor = true;
            btnProcessTransaction.Click += btnProcessTransaction_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(165, 97);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(16, 18);
            label18.TabIndex = 23;
            label18.Text = "$";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(21, 501);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(325, 23);
            label15.TabIndex = 22;
            label15.Text = "Valid Amounts: Any Positive Money Value";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.Location = new Point(23, 524);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(447, 23);
            label14.TabIndex = 21;
            label14.Text = "Valid Transaction Type: 'W' for Withdrawal, 'D' for Deposit";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(23, 297);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(357, 127);
            label11.TabIndex = 19;
            label11.Text = resources.GetString("label11.Text");
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.Location = new Point(23, 262);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(123, 25);
            label12.TabIndex = 18;
            label12.Text = "Instructions:";
            // 
            // rtb
            // 
            rtb.Dock = DockStyle.Bottom;
            rtb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtb.Location = new Point(0, 772);
            rtb.Margin = new Padding(4, 5, 4, 5);
            rtb.Name = "rtb";
            rtb.Size = new Size(1091, 434);
            rtb.TabIndex = 17;
            rtb.Text = "";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(317, 9);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(480, 38);
            label21.TabIndex = 18;
            label21.Text = "Chain Of Command Demonstration";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 1206);
            Controls.Add(label21);
            Controls.Add(rtb);
            Controls.Add(panelAccountTransaction);
            Controls.Add(label7);
            Controls.Add(panelLogin);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chain Of Command Concepts Example";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUdLoginId).EndInit();
            panelAccountTransaction.ResumeLayout(false);
            panelAccountTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownAccountNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidateCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxTransactionType;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelAccountTransaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnProcessTransaction;
        private Label label20;
        private Label label19;
        private Label label22;
        private Label label13;
        private NumericUpDown numUpDownAmount;
        private NumericUpDown numUpDownAccountNumber;
        private Label label21;
        private NumericUpDown numUdLoginId;
        private Label label24;
        private Label label23;
    }
}

