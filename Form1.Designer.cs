
namespace WFGetEmail
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
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.headingListBox = new System.Windows.Forms.ListBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(12, 201);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTextBox.Size = new System.Drawing.Size(776, 237);
            this.contentTextBox.TabIndex = 1;
            // 
            // headingListBox
            // 
            this.headingListBox.FormattingEnabled = true;
            this.headingListBox.ItemHeight = 15;
            this.headingListBox.Location = new System.Drawing.Point(12, 12);
            this.headingListBox.Name = "headingListBox";
            this.headingListBox.Size = new System.Drawing.Size(776, 139);
            this.headingListBox.TabIndex = 2;
            this.headingListBox.SelectedValueChanged += new System.EventHandler(this.headingListBox_SelectedIndexChanged);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(12, 157);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(255, 38);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.headingListBox);
            this.Controls.Add(this.contentTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.ListBox headingListBox;
        private System.Windows.Forms.Button showButton;
    }
}

