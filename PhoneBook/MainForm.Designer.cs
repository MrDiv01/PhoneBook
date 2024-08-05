namespace PhoneBook
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
            btnSave = new Button();
            btnList = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(90, 99, 156);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(23, 78);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(212, 338);
            btnSave.TabIndex = 0;
            btnSave.Text = "Kişi Ekle";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnList
            // 
            btnList.BackColor = Color.FromArgb(255, 64, 125);
            btnList.Cursor = Cursors.SizeAll;
            btnList.Font = new Font("Segoe UI", 20F);
            btnList.ForeColor = SystemColors.ButtonHighlight;
            btnList.Location = new Point(241, 249);
            btnList.Name = "btnList";
            btnList.Size = new Size(328, 165);
            btnList.TabIndex = 1;
            btnList.Text = "Kişi Listesi";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(55, 183, 195);
            btnSearch.Cursor = Cursors.Help;
            btnSearch.Font = new Font("Segoe UI", 20F);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(241, 78);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(328, 165);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Kişi Arama";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            ClientSize = new Size(594, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnList);
            Controls.Add(btnSave);
            Name = "MainForm";
            Text = "Telefon Rehberi";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnList;
        private Button btnSearch;
    }
}