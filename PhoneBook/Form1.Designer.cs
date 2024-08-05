namespace PhoneBook
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
            grbSavePerson = new GroupBox();
            btnSave = new Button();
            txtMail = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            grbSavePerson.SuspendLayout();
            SuspendLayout();
            // 
            // grbSavePerson
            // 
            grbSavePerson.Controls.Add(btnSave);
            grbSavePerson.Controls.Add(txtMail);
            grbSavePerson.Controls.Add(label4);
            grbSavePerson.Controls.Add(txtPhone);
            grbSavePerson.Controls.Add(label3);
            grbSavePerson.Controls.Add(txtLastName);
            grbSavePerson.Controls.Add(label2);
            grbSavePerson.Controls.Add(txtFirstName);
            grbSavePerson.Controls.Add(label1);
            grbSavePerson.Font = new Font("Segoe UI", 15F);
            grbSavePerson.Location = new Point(23, 76);
            grbSavePerson.Name = "grbSavePerson";
            grbSavePerson.Size = new Size(584, 314);
            grbSavePerson.TabIndex = 0;
            grbSavePerson.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(145, 229);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(416, 59);
            btnSave.TabIndex = 4;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(145, 189);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(416, 34);
            txtMail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 192);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 0;
            label4.Text = "Mail";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(145, 149);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(416, 34);
            txtPhone.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 152);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(145, 109);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(416, 34);
            txtLastName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 112);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 0;
            label2.Text = "Soyadı";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(145, 69);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(416, 34);
            txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 72);
            label1.Name = "label1";
            label1.Size = new Size(47, 28);
            label1.TabIndex = 0;
            label1.Text = "Adı ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 413);
            Controls.Add(grbSavePerson);
            Name = "Form1";
            Text = "Kullanıcı Ekleme Formu";
            FormClosing += Form1_FormClosing;
            grbSavePerson.ResumeLayout(false);
            grbSavePerson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSavePerson;
        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private Button btnSave;
    }
}
