
namespace LEARNING_DESIGN_PATTERN.Observer
{
    partial class MediatorForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(19, 160);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(581, 42);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(19, 44);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 27);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(127, 41);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(473, 35);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(127, 91);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(473, 35);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name";
            // 
            // MediatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 233);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.submitButton);
            this.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MediatorForm";
            this.Text = "MediatorForm";
            this.Load += new System.EventHandler(this.MediatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}