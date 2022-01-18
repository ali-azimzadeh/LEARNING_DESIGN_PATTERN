
namespace LEARNING_DESIGN_PATTERN.Decorator.Philosophy
{
    partial class DecoratorPhilosophyForm
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
            this.componentButton = new System.Windows.Forms.Button();
            this.myDecoratorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // componentButton
            // 
            this.componentButton.Location = new System.Drawing.Point(12, 24);
            this.componentButton.Name = "componentButton";
            this.componentButton.Size = new System.Drawing.Size(475, 42);
            this.componentButton.TabIndex = 0;
            this.componentButton.Text = "Component";
            this.componentButton.UseVisualStyleBackColor = true;
            this.componentButton.Click += new System.EventHandler(this.componentButton_Click);
            // 
            // myDecoratorButton
            // 
            this.myDecoratorButton.Location = new System.Drawing.Point(12, 86);
            this.myDecoratorButton.Name = "myDecoratorButton";
            this.myDecoratorButton.Size = new System.Drawing.Size(475, 42);
            this.myDecoratorButton.TabIndex = 1;
            this.myDecoratorButton.Text = "MyDecorator";
            this.myDecoratorButton.UseVisualStyleBackColor = true;
            this.myDecoratorButton.Click += new System.EventHandler(this.myDecoratorButton_Click);
            // 
            // DecoratorPhilosophyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 157);
            this.Controls.Add(this.myDecoratorButton);
            this.Controls.Add(this.componentButton);
            this.Name = "DecoratorPhilosophyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DecoratorPhilosophyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button componentButton;
        private System.Windows.Forms.Button myDecoratorButton;
    }
}