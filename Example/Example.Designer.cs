namespace Test
{
    partial class Example
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
            this.Log_Btn = new System.Windows.Forms.Button();
            this.DEBUGMSG_BOX = new System.Windows.Forms.ComboBox();
            this.LOG_BOX = new System.Windows.Forms.ComboBox();
            this.Selected_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Log_Btn
            // 
            this.Log_Btn.Location = new System.Drawing.Point(353, 12);
            this.Log_Btn.Name = "Log_Btn";
            this.Log_Btn.Size = new System.Drawing.Size(123, 23);
            this.Log_Btn.TabIndex = 0;
            this.Log_Btn.Text = "Default Example Log";
            this.Log_Btn.UseVisualStyleBackColor = true;
            this.Log_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DEBUGMSG_BOX
            // 
            this.DEBUGMSG_BOX.FormattingEnabled = true;
            this.DEBUGMSG_BOX.Location = new System.Drawing.Point(31, 89);
            this.DEBUGMSG_BOX.Name = "DEBUGMSG_BOX";
            this.DEBUGMSG_BOX.Size = new System.Drawing.Size(121, 21);
            this.DEBUGMSG_BOX.TabIndex = 1;
            // 
            // LOG_BOX
            // 
            this.LOG_BOX.FormattingEnabled = true;
            this.LOG_BOX.Location = new System.Drawing.Point(158, 89);
            this.LOG_BOX.Name = "LOG_BOX";
            this.LOG_BOX.Size = new System.Drawing.Size(121, 21);
            this.LOG_BOX.TabIndex = 2;
            // 
            // Selected_Btn
            // 
            this.Selected_Btn.Location = new System.Drawing.Point(114, 12);
            this.Selected_Btn.Name = "Selected_Btn";
            this.Selected_Btn.Size = new System.Drawing.Size(90, 23);
            this.Selected_Btn.TabIndex = 3;
            this.Selected_Btn.Text = "Selected Log";
            this.Selected_Btn.UseVisualStyleBackColor = true;
            this.Selected_Btn.Click += new System.EventHandler(this.Selected_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DEBUGMSG COLOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "LOG COLOR";
            // 
            // Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 214);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Selected_Btn);
            this.Controls.Add(this.LOG_BOX);
            this.Controls.Add(this.DEBUGMSG_BOX);
            this.Controls.Add(this.Log_Btn);
            this.Name = "Example";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Log_Btn;
        private System.Windows.Forms.ComboBox DEBUGMSG_BOX;
        private System.Windows.Forms.ComboBox LOG_BOX;
        private System.Windows.Forms.Button Selected_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

