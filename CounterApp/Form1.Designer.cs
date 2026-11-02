namespace CounterApp
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
            this.btnStart1 = new Button();
            btnStart2 = new Button();
            this.lblCount1 = new Label();
            lblCount2 = new Label();
            SuspendLayout();
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new Point(56, 58);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new Size(112, 34);
            this.btnStart1.TabIndex = 0;
            this.btnStart1.Text = "Start";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += this.btnStart1_Click;
            // 
            // btnStart2
            // 
            btnStart2.Location = new Point(59, 123);
            btnStart2.Name = "btnStart2";
            btnStart2.Size = new Size(112, 34);
            btnStart2.TabIndex = 1;
            btnStart2.Text = "Start";
            btnStart2.UseVisualStyleBackColor = true;
            btnStart2.Click += btnStart2_Click;
            // 
            // lblCount1
            // 
            this.lblCount1.AutoSize = true;
            this.lblCount1.Location = new Point(237, 65);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new Size(22, 25);
            this.lblCount1.TabIndex = 2;
            this.lblCount1.Text = "1";
            // 
            // lblCount2
            // 
            lblCount2.AutoSize = true;
            lblCount2.Location = new Point(237, 123);
            lblCount2.Name = "lblCount2";
            lblCount2.Size = new Size(22, 25);
            lblCount2.TabIndex = 3;
            lblCount2.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 451);
            Controls.Add(lblCount2);
            Controls.Add(this.lblCount1);
            Controls.Add(btnStart2);
            Controls.Add(this.btnStart1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart1;
        private Button btnStart2;
        private Label lblCount1;
        private Label lblCount2;
    }
}
