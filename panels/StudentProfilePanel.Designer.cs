namespace SchoolManagementSystem.panels
{
    partial class StudentProfilePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentProfilePanel));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            stuName = new Label();
            stuAge = new Label();
            stuEmail = new Label();
            stuPhone = new Label();
            stuGrade = new Label();
            stuID = new Label();
            StudentsTable = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            vScrollBar1 = new VScrollBar();
            label1 = new Label();
            comboBox1 = new ComboBox();
            addCourse = new Button();
            Delete = new Button();
            Edit = new Button();
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
            // stuName
            // 
            stuName.AutoSize = true;
            stuName.BackColor = Color.FromArgb(43, 180, 200);
            stuName.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stuName.ForeColor = Color.White;
            stuName.Location = new Point(187, 36);
            stuName.Name = "stuName";
            stuName.Size = new Size(69, 29);
            stuName.TabIndex = 1;
            stuName.Text = "label1";
            stuName.Click += label1_Click;
            // 
            // stuAge
            // 
            stuAge.AutoSize = true;
            stuAge.BackColor = SystemColors.ButtonHighlight;
            stuAge.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            stuAge.ForeColor = Color.FromArgb(11, 111, 125);
            stuAge.Location = new Point(187, 122);
            stuAge.Name = "stuAge";
            stuAge.Size = new Size(43, 17);
            stuAge.TabIndex = 2;
            stuAge.Text = "label2";
            // 
            // stuEmail
            // 
            stuEmail.AutoSize = true;
            stuEmail.BackColor = SystemColors.ButtonHighlight;
            stuEmail.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            stuEmail.ForeColor = Color.FromArgb(11, 111, 125);
            stuEmail.Location = new Point(187, 183);
            stuEmail.Name = "stuEmail";
            stuEmail.Size = new Size(43, 17);
            stuEmail.TabIndex = 3;
            stuEmail.Text = "label3";
            // 
            // stuPhone
            // 
            stuPhone.AutoSize = true;
            stuPhone.BackColor = SystemColors.ButtonHighlight;
            stuPhone.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            stuPhone.ForeColor = Color.FromArgb(11, 111, 125);
            stuPhone.Location = new Point(187, 153);
            stuPhone.Name = "stuPhone";
            stuPhone.Size = new Size(43, 17);
            stuPhone.TabIndex = 4;
            stuPhone.Text = "label4";
            // 
            // stuGrade
            // 
            stuGrade.AutoSize = true;
            stuGrade.BackColor = SystemColors.ButtonHighlight;
            stuGrade.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            stuGrade.ForeColor = Color.FromArgb(11, 111, 125);
            stuGrade.Location = new Point(578, 153);
            stuGrade.Name = "stuGrade";
            stuGrade.Size = new Size(43, 17);
            stuGrade.TabIndex = 5;
            stuGrade.Text = "label5";
            // 
            // stuID
            // 
            stuID.AutoSize = true;
            stuID.BackColor = Color.FromArgb(43, 180, 200);
            stuID.Font = new Font("Yu Gothic UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            stuID.ForeColor = Color.White;
            stuID.Location = new Point(187, 76);
            stuID.Name = "stuID";
            stuID.Size = new Size(43, 17);
            stuID.TabIndex = 6;
            stuID.Text = "label6";
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
            StudentsTable.Location = new Point(42, 239);
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
            StudentsTable.Size = new Size(746, 216);
            StudentsTable.TabIndex = 7;
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
            vScrollBar1.Location = new Point(823, 239);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 216);
            vScrollBar1.TabIndex = 8;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(241, 241, 241);
            label1.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 180, 200);
            label1.Location = new Point(42, 496);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 11;
            label1.Text = "Add a new course";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(42, 531);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(402, 28);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // addCourse
            // 
            addCourse.BackColor = Color.FromArgb(43, 180, 200);
            addCourse.FlatStyle = FlatStyle.Flat;
            addCourse.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addCourse.ForeColor = Color.White;
            addCourse.Location = new Point(482, 531);
            addCourse.Name = "addCourse";
            addCourse.Size = new Size(80, 29);
            addCourse.TabIndex = 13;
            addCourse.Text = "Add";
            addCourse.UseVisualStyleBackColor = false;
            addCourse.Click += addCourse_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Red;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.ForeColor = Color.White;
            Delete.Location = new Point(807, 531);
            Delete.Name = "Delete";
            Delete.Size = new Size(80, 29);
            Delete.TabIndex = 14;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.DarkGray;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Edit.ForeColor = Color.White;
            Edit.Location = new Point(708, 531);
            Edit.Name = "Edit";
            Edit.Size = new Size(80, 29);
            Edit.TabIndex = 15;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // StudentProfilePanel
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
            Controls.Add(stuID);
            Controls.Add(stuGrade);
            Controls.Add(stuPhone);
            Controls.Add(stuEmail);
            Controls.Add(stuAge);
            Controls.Add(stuName);
            Controls.Add(pictureBox1);
            Name.Name = "StudentProfilePanel";
            Size = new Size(911, 612);
            Load += StudentProfilePanel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label stuName;
        private Label stuAge;
        private Label stuEmail;
        private Label stuPhone;
        private Label stuGrade;
        private Label stuID;
        private DataGridView StudentsTable;
        private VScrollBar vScrollBar1;
        private DataGridViewTextBoxColumn Name;
        private Label label1;
        private ComboBox comboBox1;
        private Button addCourse;
        private Button Delete;
        private Button Edit;
    }
}
