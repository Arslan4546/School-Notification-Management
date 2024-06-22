namespace school_notification
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
            label1 = new Label();
            schNotification = new TextBox();
            groupBox1 = new GroupBox();
            showbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            insertbtn = new Button();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            schEmail = new TextBox();
            schCell = new TextBox();
            schSms = new TextBox();
            schContact = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            schValidation = new TextBox();
            schTime = new TextBox();
            schDate = new TextBox();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            lblPic = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 85);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 0;
            label1.Text = "Notification Id";
            // 
            // schNotification
            // 
            schNotification.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            schNotification.Location = new Point(205, 85);
            schNotification.Name = "schNotification";
            schNotification.Size = new Size(187, 34);
            schNotification.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(showbtn);
            groupBox1.Controls.Add(updatebtn);
            groupBox1.Controls.Add(deletebtn);
            groupBox1.Controls.Add(insertbtn);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(schEmail);
            groupBox1.Controls.Add(schCell);
            groupBox1.Controls.Add(schSms);
            groupBox1.Controls.Add(schContact);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(schValidation);
            groupBox1.Controls.Add(schTime);
            groupBox1.Controls.Add(schDate);
            groupBox1.Controls.Add(schNotification);
            groupBox1.Location = new Point(21, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(850, 536);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "School Notification";
            // 
            // showbtn
            // 
            showbtn.BackColor = SystemColors.ControlDarkDark;
            showbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showbtn.Location = new Point(622, 441);
            showbtn.Name = "showbtn";
            showbtn.Size = new Size(138, 52);
            showbtn.TabIndex = 3;
            showbtn.Text = "DISPLAY";
            showbtn.UseVisualStyleBackColor = false;
            showbtn.Click += showbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = SystemColors.ControlDarkDark;
            updatebtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.Location = new Point(452, 441);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(138, 52);
            updatebtn.TabIndex = 3;
            updatebtn.Text = "UPDATE";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = SystemColors.ControlDarkDark;
            deletebtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtn.Location = new Point(286, 441);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(138, 52);
            deletebtn.TabIndex = 3;
            deletebtn.Text = "DELETE";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // insertbtn
            // 
            insertbtn.BackColor = SystemColors.ControlDarkDark;
            insertbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertbtn.Location = new Point(124, 441);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(138, 52);
            insertbtn.TabIndex = 3;
            insertbtn.Text = "INSERT";
            insertbtn.UseVisualStyleBackColor = false;
            insertbtn.Click += insertbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(435, 334);
            label8.Name = "label8";
            label8.Size = new Size(76, 32);
            label8.TabIndex = 0;
            label8.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(435, 256);
            label6.Name = "label6";
            label6.Size = new Size(56, 32);
            label6.TabIndex = 0;
            label6.Text = "Cell";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(436, 174);
            label4.Name = "label4";
            label4.Size = new Size(63, 32);
            label4.TabIndex = 0;
            label4.Text = "SMS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(433, 85);
            label2.Name = "label2";
            label2.Size = new Size(156, 32);
            label2.TabIndex = 0;
            label2.Text = "Contact Info";
            // 
            // schEmail
            // 
            schEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            schEmail.Location = new Point(608, 334);
            schEmail.Name = "schEmail";
            schEmail.Size = new Size(187, 34);
            schEmail.TabIndex = 1;
            schEmail.TextChanged += schEmail_TextChanged;
            // 
            // schCell
            // 
            schCell.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            schCell.Location = new Point(608, 256);
            schCell.Name = "schCell";
            schCell.Size = new Size(187, 34);
            schCell.TabIndex = 1;
            schCell.TextChanged += schCell_TextChanged;
            // 
            // schSms
            // 
            schSms.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            schSms.Location = new Point(608, 174);
            schSms.Name = "schSms";
            schSms.Size = new Size(187, 34);
            schSms.TabIndex = 1;
            // 
            // schContact
            // 
            schContact.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            schContact.Location = new Point(608, 85);
            schContact.Name = "schContact";
            schContact.Size = new Size(187, 34);
            schContact.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 334);
            label7.Name = "label7";
            label7.Size = new Size(129, 32);
            label7.TabIndex = 0;
            label7.Text = "Validation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 256);
            label5.Name = "label5";
            label5.Size = new Size(70, 32);
            label5.TabIndex = 0;
            label5.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 174);
            label3.Name = "label3";
            label3.Size = new Size(67, 32);
            label3.TabIndex = 0;
            label3.Text = "Date";
            // 
            // schValidation
            // 
            schValidation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            schValidation.Location = new Point(205, 334);
            schValidation.Name = "schValidation";
            schValidation.Size = new Size(187, 34);
            schValidation.TabIndex = 1;
            // 
            // schTime
            // 
            schTime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            schTime.Location = new Point(205, 256);
            schTime.Name = "schTime";
            schTime.Size = new Size(187, 34);
            schTime.TabIndex = 1;
            // 
            // schDate
            // 
            schDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            schDate.Location = new Point(205, 174);
            schDate.Name = "schDate";
            schDate.Size = new Size(187, 34);
            schDate.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDarkDark;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(888, 221);
            button5.Name = "button5";
            button5.Size = new Size(189, 52);
            button5.TabIndex = 3;
            button5.Text = "BROWSE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(888, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 113);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 606);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(841, 374);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblPic
            // 
            lblPic.AutoSize = true;
            lblPic.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPic.Location = new Point(888, 180);
            lblPic.Name = "lblPic";
            lblPic.Size = new Size(0, 28);
            lblPic.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 1021);
            Controls.Add(lblPic);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "School Notification ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox schNotification;
        private GroupBox groupBox1;
        private Button updatebtn;
        private Button deletebtn;
        private Button insertbtn;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label2;
        private TextBox schEmail;
        private TextBox schCell;
        private TextBox schSms;
        private TextBox schContact;
        private Label label7;
        private Label label5;
        private Label label3;
        private TextBox schValidation;
        private TextBox schTime;
        private TextBox schDate;
        private Button showbtn;
        private Button button5;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label lblPic;
    }
}
