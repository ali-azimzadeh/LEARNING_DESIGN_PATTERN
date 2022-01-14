
namespace LEARNING_DESIGN_PATTERN.Singletone
{
    partial class SingletoneForm
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
            this.utilites1Button = new System.Windows.Forms.Button();
            this.utilites2Button = new System.Windows.Forms.Button();
            this.utilites3Button = new System.Windows.Forms.Button();
            this.utilites4Button = new System.Windows.Forms.Button();
            this.manager1Button = new System.Windows.Forms.Button();
            this.manager2Button = new System.Windows.Forms.Button();
            this.manager3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // utilites1Button
            // 
            this.utilites1Button.Location = new System.Drawing.Point(12, 21);
            this.utilites1Button.Name = "utilites1Button";
            this.utilites1Button.Size = new System.Drawing.Size(890, 52);
            this.utilites1Button.TabIndex = 0;
            this.utilites1Button.Text = "Utilites1 Button";
            this.utilites1Button.UseVisualStyleBackColor = true;
            this.utilites1Button.Click += new System.EventHandler(this.utilites1Button_Click);
            // 
            // utilites2Button
            // 
            this.utilites2Button.Location = new System.Drawing.Point(12, 89);
            this.utilites2Button.Name = "utilites2Button";
            this.utilites2Button.Size = new System.Drawing.Size(890, 52);
            this.utilites2Button.TabIndex = 1;
            this.utilites2Button.Text = "Utilites2 Button";
            this.utilites2Button.UseVisualStyleBackColor = true;
            this.utilites2Button.Click += new System.EventHandler(this.utilites2Button_Click);
            // 
            // utilites3Button
            // 
            this.utilites3Button.Location = new System.Drawing.Point(12, 158);
            this.utilites3Button.Name = "utilites3Button";
            this.utilites3Button.Size = new System.Drawing.Size(890, 52);
            this.utilites3Button.TabIndex = 2;
            this.utilites3Button.Text = "Utilites3 Button";
            this.utilites3Button.UseVisualStyleBackColor = true;
            this.utilites3Button.Click += new System.EventHandler(this.utilites3Button_Click);
            // 
            // utilites4Button
            // 
            this.utilites4Button.Location = new System.Drawing.Point(12, 227);
            this.utilites4Button.Name = "utilites4Button";
            this.utilites4Button.Size = new System.Drawing.Size(890, 52);
            this.utilites4Button.TabIndex = 3;
            this.utilites4Button.Text = "Utilites4 Button";
            this.utilites4Button.UseVisualStyleBackColor = true;
            this.utilites4Button.Click += new System.EventHandler(this.utilites4Button_Click);
            // 
            // manager1Button
            // 
            this.manager1Button.Location = new System.Drawing.Point(12, 342);
            this.manager1Button.Name = "manager1Button";
            this.manager1Button.Size = new System.Drawing.Size(890, 52);
            this.manager1Button.TabIndex = 4;
            this.manager1Button.Text = "Manager1 Button";
            this.manager1Button.UseVisualStyleBackColor = true;
            this.manager1Button.Click += new System.EventHandler(this.manager1Button_Click);
            // 
            // manager2Button
            // 
            this.manager2Button.Location = new System.Drawing.Point(12, 400);
            this.manager2Button.Name = "manager2Button";
            this.manager2Button.Size = new System.Drawing.Size(890, 52);
            this.manager2Button.TabIndex = 5;
            this.manager2Button.Text = "Manager2 Button";
            this.manager2Button.UseVisualStyleBackColor = true;
            this.manager2Button.Click += new System.EventHandler(this.manager2Button_Click);
            // 
            // manager3Button
            // 
            this.manager3Button.Location = new System.Drawing.Point(12, 458);
            this.manager3Button.Name = "manager3Button";
            this.manager3Button.Size = new System.Drawing.Size(890, 52);
            this.manager3Button.TabIndex = 6;
            this.manager3Button.Text = "Manager3 Button";
            this.manager3Button.UseVisualStyleBackColor = true;
            this.manager3Button.Click += new System.EventHandler(this.manager3Button_Click);
            // 
            // SingletoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 660);
            this.Controls.Add(this.manager3Button);
            this.Controls.Add(this.manager2Button);
            this.Controls.Add(this.manager1Button);
            this.Controls.Add(this.utilites4Button);
            this.Controls.Add(this.utilites3Button);
            this.Controls.Add(this.utilites2Button);
            this.Controls.Add(this.utilites1Button);
            this.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SingletoneForm";
            this.Text = "SingletoneForm";
            this.Load += new System.EventHandler(this.SingletoneForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button utilites1Button;
        private System.Windows.Forms.Button utilites2Button;
        private System.Windows.Forms.Button utilites3Button;
        private System.Windows.Forms.Button utilites4Button;
        private System.Windows.Forms.Button manager1Button;
        private System.Windows.Forms.Button manager2Button;
        private System.Windows.Forms.Button manager3Button;
    }
}