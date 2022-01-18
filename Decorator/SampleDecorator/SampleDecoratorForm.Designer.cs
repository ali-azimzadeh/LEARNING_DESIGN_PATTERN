
namespace LEARNING_DESIGN_PATTERN.Decorator.SampleDecorator
{
    partial class SampleDecoratorForm
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
            this.testButton = new System.Windows.Forms.Button();
            this.TextDecorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(12, 312);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(496, 64);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Button with border";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // TextDecorButton
            // 
            this.TextDecorButton.Location = new System.Drawing.Point(12, 233);
            this.TextDecorButton.Name = "TextDecorButton";
            this.TextDecorButton.Size = new System.Drawing.Size(496, 64);
            this.TextDecorButton.TabIndex = 1;
            this.TextDecorButton.UseVisualStyleBackColor = true;
            // 
            // SampleDecoratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 384);
            this.Controls.Add(this.TextDecorButton);
            this.Controls.Add(this.testButton);
            this.Name = "SampleDecoratorForm";
            this.Text = "SampleDecoratorForm";
            this.Load += new System.EventHandler(this.SampleDecoratorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button TextDecorButton;
    }
}