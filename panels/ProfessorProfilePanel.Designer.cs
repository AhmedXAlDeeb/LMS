﻿namespace SchoolManagementSystem.panels
{
    partial class ProfessorProfilePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessorProfilePanel));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            profName = new Label();
            profTitle = new Label();
            profID = new Label();
            profAge = new Label();
            profEmail = new Label();
            profPhone = new Label();
            StudentsTable = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            vScrollBar1 = new VScrollBar();
            label1 = new Label();
            comboBox1 = new ComboBox();
            addCourse = new Button();
            Edit = new Button();
            Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentsTable).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(911, 612);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // profName
            // 
            profName.AutoSize = true;
            profName.BackColor = Color.FromArgb(43, 180, 200);
            profName.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            profName.ForeColor = Color.White;
            profName.Location = new Point(182, 40);
            profName.Name = "profName";
            profName.Size = new Size(69, 29);
            profName.TabIndex = 2;
            profName.Text = "label1";
            // 
            // profTitle
            // 
            profTitle.AutoSize = true;
            profTitle.BackColor = SystemColors.ButtonHighlight;
            profTitle.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            profTitle.ForeColor = Color.FromArgb(11, 111, 125);
            profTitle.Location = new Point(182, 131);
            profTitle.Name = "profTitle";
            profTitle.Size = new Size(43, 17);
            profTitle.TabIndex = 3;
            profTitle.Text = "label2";
            profTitle.Click += profTitle_Click;
            // 
            // profID
            // 
            profID.AutoSize = true;
            profID.BackColor = Color.FromArgb(43, 180, 200);
            profID.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            profID.ForeColor = Color.White;
            profID.Location = new Point(182, 79);
            profID.Name = "profID";
            profID.Size = new Size(43, 17);
            profID.TabIndex = 4;
            profID.Text = "label3";
            // 
            // profAge
            // 
            profAge.AutoSize = true;
            profAge.BackColor = SystemColors.ButtonHighlight;
            profAge.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            profAge.ForeColor = Color.FromArgb(11, 111, 125);
            profAge.Location = new Point(182, 172);
            profAge.Name = "profAge";
            profAge.Size = new Size(43, 17);
            profAge.TabIndex = 5;
            profAge.Text = "label4";
            // 
            // profEmail
            // 
            profEmail.AutoSize = true;
            profEmail.BackColor = SystemColors.ButtonHighlight;
            profEmail.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            profEmail.ForeColor = Color.FromArgb(11, 111, 125);
            profEmail.Location = new Point(532, 172);
            profEmail.Name = "profEmail";
            profEmail.Size = new Size(43, 17);
            profEmail.TabIndex = 6;
            profEmail.Text = "label5";
            // 
            // profPhone
            // 
            profPhone.AutoSize = true;
            profPhone.BackColor = SystemColors.ButtonHighlight;
            profPhone.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            profPhone.ForeColor = Color.FromArgb(11, 111, 125);
            profPhone.Location = new Point(532, 131);
            profPhone.Name = "profPhone";
            profPhone.Size = new Size(43, 17);
            profPhone.TabIndex = 7;
            profPhone.Text = "label6";
            // 
            // StudentsTable
            // 
            StudentsTable.AllowUserToAddRows = false;
            StudentsTable.AllowUserToDeleteRows = false;
            StudentsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(233, 245, 247);
            StudentsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            StudentsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentsTable.BackgroundColor = SystemColors.ControlLight;
            StudentsTable.BorderStyle = BorderStyle.None;
            StudentsTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            StudentsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 180, 200);
            dataGridViewCellStyle2.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 180, 200);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            StudentsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            StudentsTable.ColumnHeadersHeight = 35;
            StudentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            StudentsTable.Columns.AddRange(new DataGridViewColumn[] { Name });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            StudentsTable.DefaultCellStyle = dataGridViewCellStyle4;
            StudentsTable.EnableHeadersVisualStyles = false;
            StudentsTable.Location = new Point(36, 239);
            StudentsTable.Name = "StudentsTable";
            StudentsTable.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            StudentsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            StudentsTable.RowHeadersVisible = false;
            StudentsTable.RowHeadersWidth = 51;
            StudentsTable.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            StudentsTable.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            StudentsTable.RowTemplate.Height = 29;
            StudentsTable.ScrollBars = ScrollBars.None;
            StudentsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentsTable.Size = new Size(737, 211);
            StudentsTable.TabIndex = 8;
            StudentsTable.CellContentClick += StudentsTable_CellContentClick;
            StudentsTable.RowsAdded += StudentsTable_RowsAdded;
            StudentsTable.RowsRemoved += StudentsTable_RowsRemoved;
            // 
            // Name
            // 
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Transparent;
            Name.DefaultCellStyle = dataGridViewCellStyle3;
            Name.HeaderText = "Courses";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(815, 239);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 211);
            vScrollBar1.TabIndex = 9;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(241, 241, 241);
            label1.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 180, 200);
            label1.Location = new Point(36, 500);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 10;
            label1.Text = "Add a new course";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 532);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(402, 28);
            comboBox1.TabIndex = 11;
            // 
            // addCourse
            // 
            addCourse.BackColor = Color.FromArgb(43, 180, 200);
            addCourse.FlatStyle = FlatStyle.Flat;
            addCourse.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addCourse.ForeColor = Color.White;
            addCourse.Location = new Point(484, 532);
            addCourse.Name = "addCourse";
            addCourse.Size = new Size(80, 29);
            addCourse.TabIndex = 12;
            addCourse.Text = "Add";
            addCourse.UseVisualStyleBackColor = false;
            addCourse.Click += addCourse_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.DarkGray;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Edit.ForeColor = Color.White;
            Edit.Location = new Point(716, 530);
            Edit.Name = "Edit";
            Edit.Size = new Size(80, 29);
            Edit.TabIndex = 17;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Red;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.ForeColor = Color.White;
            Delete.Location = new Point(815, 530);
            Delete.Name = "Delete";
            Delete.Size = new Size(80, 29);
            Delete.TabIndex = 16;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // ProfessorProfilePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(addCourse);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(vScrollBar1);
            Controls.Add(StudentsTable);
            Controls.Add(profPhone);
            Controls.Add(profEmail);
            Controls.Add(profAge);
            Controls.Add(profID);
            Controls.Add(profTitle);
            Controls.Add(profName);
            Controls.Add(pictureBox1);
//            Name = "ProfessorProfilePanel";
            Size = new Size(911, 612);
            Load += ProfessorProfilePanel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label profName;
        private Label profTitle;
        private Label profID;
        private Label profAge;
        private Label profEmail;
        private Label profPhone;
        private DataGridView StudentsTable;
        private DataGridViewTextBoxColumn Name;
        private VScrollBar vScrollBar1;
        private Label label1;
        private ComboBox comboBox1;
        private Button addCourse;
        private Button Edit;
        private Button Delete;
    }
}
