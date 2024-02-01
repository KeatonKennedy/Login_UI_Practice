namespace UX_UI_Practice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SignUpbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.LogInbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SignUpbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.SignUpbtn.FlatAppearance.BorderSize = 0;
            this.SignUpbtn.ForeColor = System.Drawing.Color.White;
            this.SignUpbtn.Location = new System.Drawing.Point(50, 372);
            this.SignUpbtn.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(277, 39);
            this.SignUpbtn.TabIndex = 0;
            this.SignUpbtn.Text = "Sign Up";
            this.SignUpbtn.UseVisualStyleBackColor = false;
            this.SignUpbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 4;
            // 
            // Nametxt
            // 
            this.Nametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.Nametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nametxt.ForeColor = System.Drawing.Color.White;
            this.Nametxt.Location = new System.Drawing.Point(60, 212);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(255, 20);
            this.Nametxt.TabIndex = 5;
            // 
            // Emailtxt
            // 
            this.Emailtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.Emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emailtxt.ForeColor = System.Drawing.Color.White;
            this.Emailtxt.Location = new System.Drawing.Point(60, 270);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(255, 20);
            this.Emailtxt.TabIndex = 6;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.Passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtxt.ForeColor = System.Drawing.Color.White;
            this.Passwordtxt.Location = new System.Drawing.Point(60, 325);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(255, 20);
            this.Passwordtxt.TabIndex = 7;
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.BackColor = System.Drawing.Color.White;
            this.ContinueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContinueBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.ContinueBtn.FlatAppearance.BorderSize = 0;
            this.ContinueBtn.ForeColor = System.Drawing.Color.Black;
            this.ContinueBtn.Location = new System.Drawing.Point(50, 419);
            this.ContinueBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(277, 40);
            this.ContinueBtn.TabIndex = 8;
            this.ContinueBtn.Text = "Continue Another Way";
            this.ContinueBtn.UseVisualStyleBackColor = false;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // LogInbtn
            // 
            this.LogInbtn.BackColor = System.Drawing.Color.White;
            this.LogInbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(235)))));
            this.LogInbtn.FlatAppearance.BorderSize = 0;
            this.LogInbtn.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInbtn.ForeColor = System.Drawing.Color.Black;
            this.LogInbtn.Location = new System.Drawing.Point(250, 476);
            this.LogInbtn.Margin = new System.Windows.Forms.Padding(4);
            this.LogInbtn.Name = "LogInbtn";
            this.LogInbtn.Size = new System.Drawing.Size(45, 22);
            this.LogInbtn.TabIndex = 9;
            this.LogInbtn.Text = "Log In";
            this.LogInbtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 574);
            this.Controls.Add(this.LogInbtn);
            this.Controls.Add(this.ContinueBtn);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SignUpbtn;
        private Label label1;
        private Label label2;
        private TextBox Nametxt;
        private TextBox Emailtxt;
        private TextBox Passwordtxt;
        private Button ContinueBtn;
        private Button LogInbtn;
    }
}