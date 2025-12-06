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
            txtBoxAccountNumber = new TextBox();
            txtBoxAmount = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxTransactionType = new TextBox();
            panel1 = new Panel();
            label17 = new Label();
            label16 = new Label();
            txtBoxPassword = new TextBox();
            label10 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            txtBoxLoginId = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            btnProcessTransaction = new Button();
            label18 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            label12 = new Label();
            rtb = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // txtBoxAccountNumber
            // 
            txtBoxAccountNumber.Location = new Point(147, 55);
            txtBoxAccountNumber.Margin = new Padding(4, 5, 4, 5);
            txtBoxAccountNumber.Name = "txtBoxAccountNumber";
            txtBoxAccountNumber.Size = new Size(159, 27);
            txtBoxAccountNumber.TabIndex = 3;
            txtBoxAccountNumber.Text = "997";
            // 
            // txtBoxAmount
            // 
            txtBoxAmount.Location = new Point(147, 95);
            txtBoxAmount.Margin = new Padding(4, 5, 4, 5);
            txtBoxAmount.Name = "txtBoxAmount";
            txtBoxAmount.Size = new Size(159, 27);
            txtBoxAmount.TabIndex = 4;
            txtBoxAmount.Text = "120.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 60);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 7;
            label3.Text = "Account Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 100);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 8;
            label4.Text = "Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 140);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 10;
            label5.Text = "Transaction Type";
            // 
            // txtBoxTransactionType
            // 
            txtBoxTransactionType.Location = new Point(147, 135);
            txtBoxTransactionType.Margin = new Padding(4, 5, 4, 5);
            txtBoxTransactionType.MaxLength = 1;
            txtBoxTransactionType.Name = "txtBoxTransactionType";
            txtBoxTransactionType.Size = new Size(120, 27);
            txtBoxTransactionType.TabIndex = 9;
            txtBoxTransactionType.Text = "D";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(txtBoxPassword);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtBoxLoginId);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnValidateCustomer);
            panel1.Location = new Point(31, 18);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 617);
            panel1.TabIndex = 11;
            // 
            // label17
            // 
            label17.Location = new Point(12, 508);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(357, 77);
            label17.TabIndex = 21;
            label17.Text = "Valid Password Strings: \"password_ zero\"  (for id 1000),  \"password_one\"  (for id 1001),  \"password_two\"  (for id 1002)";
            // 
            // label16
            // 
            label16.Location = new Point(17, 455);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(357, 32);
            label16.TabIndex = 20;
            label16.Text = "Valid Login Ids: 1000, 1001, 1002";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(141, 100);
            txtBoxPassword.Margin = new Padding(4, 5, 4, 5);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(159, 27);
            txtBoxPassword.TabIndex = 18;
            txtBoxPassword.Text = "password_zero";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 100);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 19;
            label10.Text = "Password:";
            // 
            // label2
            // 
            label2.Location = new Point(17, 346);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(357, 72);
            label2.TabIndex = 17;
            label2.Text = "Attempt to validate a login combinations of valid data (listed below), and invalid data. Invalid values will be recognized by the handlers in the login validation chain.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 300);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
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
            label9.Size = new Size(183, 29);
            label9.TabIndex = 15;
            label9.Text = "Customer Login";
            // 
            // txtBoxLoginId
            // 
            txtBoxLoginId.Location = new Point(141, 60);
            txtBoxLoginId.Margin = new Padding(4, 5, 4, 5);
            txtBoxLoginId.Name = "txtBoxLoginId";
            txtBoxLoginId.Size = new Size(159, 27);
            txtBoxLoginId.TabIndex = 12;
            txtBoxLoginId.Text = "1000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 60);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 13;
            label8.Text = "Login Id:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 14);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(310, 29);
            label6.TabIndex = 11;
            label6.Text = "Account Transaction Details";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(325, 642);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(191, 29);
            label7.TabIndex = 12;
            label7.Text = "Validation Errors";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnProcessTransaction);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtBoxAmount);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtBoxAccountNumber);
            panel2.Controls.Add(txtBoxTransactionType);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(461, 18);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 617);
            panel2.TabIndex = 16;
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
            label18.Location = new Point(125, 97);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(16, 18);
            label18.TabIndex = 23;
            label18.Text = "$";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(23, 488);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(280, 20);
            label15.TabIndex = 22;
            label15.Text = "Valid Amounts: Any Positive Money Value";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 508);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(389, 20);
            label14.TabIndex = 21;
            label14.Text = "Valid Transaction Type: 'W' for Withdrawal, 'D' for Deposit";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 468);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(355, 20);
            label13.TabIndex = 20;
            label13.Text = "Valid Account Numbers In Data Store: : 997, 998, 999";
            // 
            // label11
            // 
            label11.Location = new Point(23, 346);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(357, 105);
            label11.TabIndex = 19;
            label11.Text = resources.GetString("label11.Text");
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 300);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 18;
            label12.Text = "Instructions:";
            // 
            // rtb
            // 
            rtb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtb.Location = new Point(16, 705);
            rtb.Margin = new Padding(4, 5, 4, 5);
            rtb.Name = "rtb";
            rtb.Size = new Size(877, 293);
            rtb.TabIndex = 17;
            rtb.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 1018);
            Controls.Add(rtb);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Example Form - Chain Of Command Concepts  Used To Validate Data";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidateCustomer;
        private System.Windows.Forms.TextBox txtBoxAccountNumber;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxTransactionType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxLoginId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
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
    }
}

