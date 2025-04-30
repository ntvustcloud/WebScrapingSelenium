
namespace WebScrapingSelenium
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
            label1 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            lblInstruction = new Label();
            btnExit = new Button();
            label4 = new Label();
            txtNumOfItem = new TextBox();
            btnReset = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 84);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Search Term";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(433, 81);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(127, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(124, 28);
            label2.Name = "label2";
            label2.Size = new Size(303, 21);
            label2.TabIndex = 4;
            label2.Text = "Pick for you at https://www.ebay.com/";
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstruction.Location = new Point(24, 150);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(0, 15);
            lblInstruction.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(438, 132);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 112);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 0;
            label4.Text = "Number of Items";
            // 
            // txtNumOfItem
            // 
            txtNumOfItem.Location = new Point(127, 110);
            txtNumOfItem.Name = "txtNumOfItem";
            txtNumOfItem.Size = new Size(100, 23);
            txtNumOfItem.TabIndex = 2;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(357, 132);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(24, 161);
            listView1.Name = "listView1";
            listView1.Size = new Size(489, 469);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 642);
            Controls.Add(listView1);
            Controls.Add(btnReset);
            Controls.Add(txtNumOfItem);
            Controls.Add(btnExit);
            Controls.Add(lblInstruction);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ebay craping item Bot";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private Label lblInstruction;
        private Button btnExit;
        private Label label4;
        private TextBox txtNumOfItem;
        private Button btnReset;
        private ListView listView1;
    }
}
