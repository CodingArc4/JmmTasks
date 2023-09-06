namespace SynchronusAndAsynchronus
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
            this.ClickMe = new System.Windows.Forms.Button();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AsyncBtn = new System.Windows.Forms.Button();
            this.AsyncLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClickMe
            // 
            this.ClickMe.Location = new System.Drawing.Point(246, 80);
            this.ClickMe.Name = "ClickMe";
            this.ClickMe.Size = new System.Drawing.Size(232, 56);
            this.ClickMe.TabIndex = 0;
            this.ClickMe.Text = "ClickMe";
            this.ClickMe.UseVisualStyleBackColor = true;
            this.ClickMe.Click += new System.EventHandler(this.ClickMe_Click);
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Location = new System.Drawing.Point(251, 162);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(0, 20);
            this.DateTimeLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Synchronus TimeDate Display";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asynchronus TimeDate Display";
            // 
            // AsyncBtn
            // 
            this.AsyncBtn.Location = new System.Drawing.Point(246, 261);
            this.AsyncBtn.Name = "AsyncBtn";
            this.AsyncBtn.Size = new System.Drawing.Size(232, 56);
            this.AsyncBtn.TabIndex = 4;
            this.AsyncBtn.Text = "Click";
            this.AsyncBtn.UseVisualStyleBackColor = true;
            this.AsyncBtn.Click += new System.EventHandler(this.AsyncBtn_Click);
            // 
            // AsyncLbl
            // 
            this.AsyncLbl.AutoSize = true;
            this.AsyncLbl.Location = new System.Drawing.Point(251, 345);
            this.AsyncLbl.Name = "AsyncLbl";
            this.AsyncLbl.Size = new System.Drawing.Size(0, 20);
            this.AsyncLbl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AsyncLbl);
            this.Controls.Add(this.AsyncBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.ClickMe);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 506);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickMe;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AsyncBtn;
        private System.Windows.Forms.Label AsyncLbl;
    }
}

