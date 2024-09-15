namespace WinForm
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
            tbSayHello = new TextBox();
            btnSayHello = new Button();
            SuspendLayout();
            // 
            // tbSayHello
            // 
            tbSayHello.Location = new Point(12, 12);
            tbSayHello.Name = "tbSayHello";
            tbSayHello.Size = new Size(496, 27);
            tbSayHello.TabIndex = 0;
            // 
            // btnSayHello
            // 
            btnSayHello.Location = new Point(12, 45);
            btnSayHello.Name = "btnSayHello";
            btnSayHello.Size = new Size(496, 33);
            btnSayHello.TabIndex = 1;
            btnSayHello.Text = "button1";
            btnSayHello.UseVisualStyleBackColor = true;
            btnSayHello.Click += btnSayHello_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSayHello);
            Controls.Add(tbSayHello);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSayHello;
        private Button btnSayHello;
    }
}
