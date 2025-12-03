namespace ChainOfCommandExample
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
            this.btnValidateCustomer = new System.Windows.Forms.Button();
            this.txtBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxTransactionType = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxLoginId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnValidateTransaction = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btnProcessTransaction = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValidateCustomer
            // 
            this.btnValidateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateCustomer.Location = new System.Drawing.Point(35, 118);
            this.btnValidateCustomer.Name = "btnValidateCustomer";
            this.btnValidateCustomer.Size = new System.Drawing.Size(230, 41);
            this.btnValidateCustomer.TabIndex = 0;
            this.btnValidateCustomer.Text = "Validate Customer Login";
            this.btnValidateCustomer.UseVisualStyleBackColor = true;
            this.btnValidateCustomer.Click += new System.EventHandler(this.btnValidateLoginData_Click);
            // 
            // txtBoxAccountNumber
            // 
            this.txtBoxAccountNumber.Location = new System.Drawing.Point(110, 36);
            this.txtBoxAccountNumber.Name = "txtBoxAccountNumber";
            this.txtBoxAccountNumber.Size = new System.Drawing.Size(120, 20);
            this.txtBoxAccountNumber.TabIndex = 3;
            this.txtBoxAccountNumber.Text = "997";
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Location = new System.Drawing.Point(110, 62);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(120, 20);
            this.txtBoxAmount.TabIndex = 4;
            this.txtBoxAmount.Text = "120.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Transaction Type";
            // 
            // txtBoxTransactionType
            // 
            this.txtBoxTransactionType.Location = new System.Drawing.Point(110, 88);
            this.txtBoxTransactionType.MaxLength = 1;
            this.txtBoxTransactionType.Name = "txtBoxTransactionType";
            this.txtBoxTransactionType.Size = new System.Drawing.Size(91, 20);
            this.txtBoxTransactionType.TabIndex = 9;
            this.txtBoxTransactionType.Text = "D";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtBoxPassword);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtBoxLoginId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnValidateCustomer);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 402);
            this.panel1.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(9, 330);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(268, 50);
            this.label17.TabIndex = 21;
            this.label17.Text = "Valid Password Strings: \"password_ zero\"  (for id 1000),  \"password_one\"  (for id" +
                " 1001),  \"password_two\"  (for id 1002)";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(13, 296);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(268, 21);
            this.label16.TabIndex = 20;
            this.label16.Text = "Valid Login Ids: 1000, 1001, 1002";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(106, 65);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(120, 20);
            this.txtBoxPassword.TabIndex = 18;
            this.txtBoxPassword.Text = "password_zero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Password:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 47);
            this.label2.TabIndex = 17;
            this.label2.Text = "Attempt to validate a login combinations of valid data (listed below), and invali" +
                "d data. Invalid values will be recognized by the handlers in the login validatio" +
                "n chain.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Instructions:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Customer Login";
            // 
            // txtBoxLoginId
            // 
            this.txtBoxLoginId.Location = new System.Drawing.Point(106, 39);
            this.txtBoxLoginId.Name = "txtBoxLoginId";
            this.txtBoxLoginId.Size = new System.Drawing.Size(120, 20);
            this.txtBoxLoginId.TabIndex = 12;
            this.txtBoxLoginId.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Login Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account Transaction Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Validation Errors";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnProcessTransaction);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnValidateTransaction);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBoxAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBoxAccountNumber);
            this.panel2.Controls.Add(this.txtBoxTransactionType);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(346, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 402);
            this.panel2.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(94, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 15);
            this.label18.TabIndex = 23;
            this.label18.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(203, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Valid Amounts: Any Positive Money Value";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(280, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Valid Transaction Type: \'W\' for Withdrawal, \'D\' for Deposit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(262, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Valid Account Numbers In Data Store: : 997, 998, 999";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(17, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(268, 68);
            this.label11.TabIndex = 19;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Instructions:";
            // 
            // btnValidateTransaction
            // 
            this.btnValidateTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateTransaction.Location = new System.Drawing.Point(71, 118);
            this.btnValidateTransaction.Name = "btnValidateTransaction";
            this.btnValidateTransaction.Size = new System.Drawing.Size(175, 27);
            this.btnValidateTransaction.TabIndex = 12;
            this.btnValidateTransaction.Text = "Validate Transaction";
            this.btnValidateTransaction.UseVisualStyleBackColor = true;
            this.btnValidateTransaction.Click += new System.EventHandler(this.btnValidateTransaction_Click);
            // 
            // rtb
            // 
            this.rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb.Location = new System.Drawing.Point(12, 458);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(659, 192);
            this.rtb.TabIndex = 17;
            this.rtb.Text = "";
            // 
            // btnProcessTransaction
            // 
            this.btnProcessTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessTransaction.Location = new System.Drawing.Point(71, 151);
            this.btnProcessTransaction.Name = "btnProcessTransaction";
            this.btnProcessTransaction.Size = new System.Drawing.Size(175, 27);
            this.btnProcessTransaction.TabIndex = 24;
            this.btnProcessTransaction.Text = "Process Transaction";
            this.btnProcessTransaction.UseVisualStyleBackColor = true;
            this.btnProcessTransaction.Click += new System.EventHandler(this.btnProcessTransaction_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 662);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Example Form - Chain Of Command Concepts  Used To Validate Data";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnValidateTransaction;
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

