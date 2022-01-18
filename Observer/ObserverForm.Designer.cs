
namespace LEARNING_DESIGN_PATTERN.Observer
{
    partial class ObserverForm
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
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // messageListBox
            // 
            this.messageListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 27;
            this.messageListBox.Location = new System.Drawing.Point(0, 0);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(575, 372);
            this.messageListBox.TabIndex = 0;
            // 
            // ObserverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 372);
            this.Controls.Add(this.messageListBox);
            this.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ObserverForm";
            this.Text = "ObserverForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ObserverForm_FormClosed);
            this.Load += new System.EventHandler(this.ObserverForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox messageListBox;
    }
}