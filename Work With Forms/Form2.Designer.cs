namespace Work_With_Forms
{
    partial class Form2
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
            this.TextAddListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TextAddListBox
            // 
            this.TextAddListBox.BackColor = System.Drawing.Color.DarkSalmon;
            this.TextAddListBox.FormattingEnabled = true;
            this.TextAddListBox.Location = new System.Drawing.Point(50, 39);
            this.TextAddListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextAddListBox.Name = "TextAddListBox";
            this.TextAddListBox.Size = new System.Drawing.Size(507, 264);
            this.TextAddListBox.TabIndex = 0;
            this.TextAddListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.TextAddListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TextAddListBox;
    }
}