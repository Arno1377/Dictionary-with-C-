namespace Dictionary
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
            lblenglishword = new Label();
            txtenglishword = new TextBox();
            txttranslate = new TextBox();
            lbltarjomefarsi = new Label();
            dataGridView1 = new DataGridView();
            btnedit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblenglishword
            // 
            lblenglishword.AutoSize = true;
            lblenglishword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblenglishword.Location = new Point(642, 9);
            lblenglishword.Name = "lblenglishword";
            lblenglishword.RightToLeft = RightToLeft.No;
            lblenglishword.Size = new Size(157, 28);
            lblenglishword.TabIndex = 0;
            lblenglishword.Text = "English Words :";
            // 
            // txtenglishword
            // 
            txtenglishword.Location = new Point(442, 40);
            txtenglishword.Name = "txtenglishword";
            txtenglishword.RightToLeft = RightToLeft.No;
            txtenglishword.Size = new Size(346, 27);
            txtenglishword.TabIndex = 1;
            txtenglishword.TextChanged += txtenglishword_TextChanged;
            // 
            // txttranslate
            // 
            txttranslate.Location = new Point(12, 73);
            txttranslate.Multiline = true;
            txttranslate.Name = "txttranslate";
            txttranslate.Size = new Size(387, 365);
            txttranslate.TabIndex = 2;
            // 
            // lbltarjomefarsi
            // 
            lbltarjomefarsi.AutoSize = true;
            lbltarjomefarsi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltarjomefarsi.Location = new Point(12, 36);
            lbltarjomefarsi.Name = "lbltarjomefarsi";
            lbltarjomefarsi.Size = new Size(127, 28);
            lbltarjomefarsi.TabIndex = 3;
            lbltarjomefarsi.Text = "ترجمه فارسی :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(442, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(346, 354);
            dataGridView1.TabIndex = 4;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(642, 454);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(146, 53);
            btnedit.TabIndex = 5;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(btnedit);
            Controls.Add(dataGridView1);
            Controls.Add(lbltarjomefarsi);
            Controls.Add(txttranslate);
            Controls.Add(txtenglishword);
            Controls.Add(lblenglishword);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblenglishword;
        private TextBox txtenglishword;
        private TextBox txttranslate;
        private Label lbltarjomefarsi;
        private DataGridView dataGridView1;
        private Button btnedit;
    }
}