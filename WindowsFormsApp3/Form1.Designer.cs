namespace WindowsFormsApp3
{
    partial class Form1
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
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.QTYLabel = new System.Windows.Forms.Label();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            this.TotalButton = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.PayMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PayAmountLabel = new System.Windows.Forms.Label();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(18, 24);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(72, 13);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Type (R,G,B):";
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(100, 21);
            this.TypeTextBox.MaxLength = 1;
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TypeTextBox.TabIndex = 1;
            // 
            // QTYLabel
            // 
            this.QTYLabel.AutoSize = true;
            this.QTYLabel.Location = new System.Drawing.Point(61, 50);
            this.QTYLabel.Name = "QTYLabel";
            this.QTYLabel.Size = new System.Drawing.Size(26, 13);
            this.QTYLabel.TabIndex = 2;
            this.QTYLabel.Text = "Qty:";
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.Location = new System.Drawing.Point(100, 47);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.QtyTextBox.TabIndex = 3;
            // 
            // TotalButton
            // 
            this.TotalButton.Location = new System.Drawing.Point(15, 71);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(75, 23);
            this.TotalButton.TabIndex = 6;
            this.TotalButton.Text = "Total";
            this.TotalButton.UseVisualStyleBackColor = true;
            this.TotalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(100, 73);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 7;
            // 
            // PayButton
            // 
            this.PayButton.Enabled = false;
            this.PayButton.Location = new System.Drawing.Point(26, 155);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(75, 23);
            this.PayButton.TabIndex = 8;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // PayMaskedTextBox
            // 
            this.PayMaskedTextBox.Location = new System.Drawing.Point(100, 115);
            this.PayMaskedTextBox.Mask = "99999.00";
            this.PayMaskedTextBox.Name = "PayMaskedTextBox";
            this.PayMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.PayMaskedTextBox.TabIndex = 9;
            // 
            // PayAmountLabel
            // 
            this.PayAmountLabel.AutoSize = true;
            this.PayAmountLabel.Location = new System.Drawing.Point(23, 118);
            this.PayAmountLabel.Name = "PayAmountLabel";
            this.PayAmountLabel.Size = new System.Drawing.Size(64, 13);
            this.PayAmountLabel.TabIndex = 10;
            this.PayAmountLabel.Text = "Pay Amount";
            this.PayAmountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Location = new System.Drawing.Point(121, 160);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(0, 13);
            this.ChangeLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.PayAmountLabel);
            this.Controls.Add(this.PayMaskedTextBox);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TotalButton);
            this.Controls.Add(this.QtyTextBox);
            this.Controls.Add(this.QTYLabel);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.TypeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Label QTYLabel;
        private System.Windows.Forms.TextBox QtyTextBox;
        private System.Windows.Forms.Button TotalButton;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.MaskedTextBox PayMaskedTextBox;
        private System.Windows.Forms.Label PayAmountLabel;
        private System.Windows.Forms.Label ChangeLabel;
    }
}

