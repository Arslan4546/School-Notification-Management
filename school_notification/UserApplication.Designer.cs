namespace ApplicationLayer
{
    partial class UserApplication
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
            label1 = new Label();
            label2 = new Label();
            User = new TextBox();
            LoginBtn = new Button();
            label3 = new Label();
            Pass = new TextBox();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 79);
            label1.Name = "label1";
            label1.Size = new Size(212, 48);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 178);
            label2.Name = "label2";
            label2.Size = new Size(169, 38);
            label2.TabIndex = 1;
            label2.Text = "User Name ";
            // 
            // User
            // 
            User.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User.Location = new Point(315, 181);
            User.Name = "User";
            User.Size = new Size(245, 39);
            User.TabIndex = 2;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ButtonFace;
            LoginBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.ControlText;
            LoginBtn.Location = new Point(315, 330);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(112, 54);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 247);
            label3.Name = "label3";
            label3.Size = new Size(138, 38);
            label3.TabIndex = 1;
            label3.Text = "User Pass";
            // 
            // Pass
            // 
            Pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pass.Location = new Point(315, 250);
            Pass.Name = "Pass";
            Pass.PasswordChar = '*';
            Pass.Size = new Size(245, 39);
            Pass.TabIndex = 2;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = SystemColors.ButtonFace;
            ExitBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.ForeColor = SystemColors.ControlText;
            ExitBtn.Location = new Point(448, 330);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(112, 54);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // UserApplication
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitBtn);
            Controls.Add(LoginBtn);
            Controls.Add(Pass);
            Controls.Add(label3);
            Controls.Add(User);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserApplication";
            Text = "UserApplication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox User;
        private Button LoginBtn;
        private Label label3;
        private TextBox Pass;
        private Button ExitBtn;
    }
}