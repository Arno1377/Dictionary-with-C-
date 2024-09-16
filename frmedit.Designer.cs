namespace Dictionary
{
    partial class frmedit
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
            btnclose = new Button();
            btnapply = new Button();
            txtenglishword = new TextBox();
            txtfarsiword = new TextBox();
            lblenglishword = new Label();
            lblfarsiword = new Label();
            SuspendLayout();
            // 
            // btnclose
            // 
            btnclose.Location = new Point(114, 209);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(94, 29);
            btnclose.TabIndex = 0;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // btnapply
            // 
            btnapply.Location = new Point(268, 209);
            btnapply.Name = "btnapply";
            btnapply.Size = new Size(94, 29);
            btnapply.TabIndex = 1;
            btnapply.Text = "Apply";
            btnapply.UseVisualStyleBackColor = true;
            btnapply.Click += btnapply_Click;
            // 
            // txtenglishword
            // 
            txtenglishword.Enabled = false;
            txtenglishword.Location = new Point(114, 30);
            txtenglishword.Name = "txtenglishword";
            txtenglishword.Size = new Size(248, 27);
            txtenglishword.TabIndex = 2;
            // 
            // txtfarsiword
            // 
            txtfarsiword.Location = new Point(114, 75);
            txtfarsiword.Multiline = true;
            txtfarsiword.Name = "txtfarsiword";
            txtfarsiword.RightToLeft = RightToLeft.Yes;
            txtfarsiword.Size = new Size(248, 128);
            txtfarsiword.TabIndex = 3;
            // 
            // lblenglishword
            // 
            lblenglishword.AutoSize = true;
            lblenglishword.Location = new Point(12, 30);
            lblenglishword.Name = "lblenglishword";
            lblenglishword.Size = new Size(96, 20);
            lblenglishword.TabIndex = 4;
            lblenglishword.Text = "English Word";
            // 
            // lblfarsiword
            // 
            lblfarsiword.AutoSize = true;
            lblfarsiword.Location = new Point(12, 75);
            lblfarsiword.Name = "lblfarsiword";
            lblfarsiword.Size = new Size(78, 20);
            lblfarsiword.TabIndex = 5;
            lblfarsiword.Text = "Farsi Word";
            // 
            // frmedit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 250);
            Controls.Add(lblfarsiword);
            Controls.Add(lblenglishword);
            Controls.Add(txtfarsiword);
            Controls.Add(txtenglishword);
            Controls.Add(btnapply);
            Controls.Add(btnclose);
            Name = "frmedit";
            Text = "frmedit";
            Load += frmedit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnclose;
        private Button btnapply;
        private TextBox txtenglishword;
        private TextBox txtfarsiword;
        private Label lblenglishword;
        private Label lblfarsiword;
    }
}