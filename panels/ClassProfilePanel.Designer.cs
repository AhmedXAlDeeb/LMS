namespace SchoolManagementSystem.panels
{
    partial class ClassProfilePanel
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

        //private void InitializeComponent()
        //{
        //  InitializeComponent(Name);
        //}

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        /// DataGridViewTextBoxColumn name
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            button1 = new Button();
            textBox1 = new TextBox();
            StudentsTable = new DataGridView();
            stuName = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            vScrollBar1 = new VScrollBar();
            SearchButton = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            TimeLabel = new Label();
            label2 = new Label();
            codeLabel = new Label();
            label3 = new Label();
            NameLabel = new Label();
            label4 = new Label();
            hallLabel = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)StudentsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(315, 11);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 241);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 34);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // StudentsTable
            // 
            StudentsTable.AllowUserToAddRows = false;
            StudentsTable.AllowUserToDeleteRows = false;
            StudentsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(233, 245, 247);
            StudentsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            StudentsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentsTable.BackgroundColor = Color.FromArgb(233, 245, 247);
            StudentsTable.BorderStyle = BorderStyle.None;
            StudentsTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            StudentsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(43, 180, 200);
            dataGridViewCellStyle8.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(43, 180, 200);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            StudentsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            StudentsTable.ColumnHeadersHeight = 35;
            StudentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            StudentsTable.Columns.AddRange(new DataGridViewColumn[] { stuName, ID, Grade });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Silver;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            StudentsTable.DefaultCellStyle = dataGridViewCellStyle11;
            StudentsTable.EnableHeadersVisualStyles = false;
            StudentsTable.Location = new Point(3, 291);
            StudentsTable.Name = "StudentsTable";
            StudentsTable.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            StudentsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            StudentsTable.RowHeadersVisible = false;
            StudentsTable.RowHeadersWidth = 51;
            StudentsTable.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            StudentsTable.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            StudentsTable.RowTemplate.Height = 29;
            StudentsTable.ScrollBars = ScrollBars.None;
            StudentsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentsTable.Size = new Size(879, 318);
            StudentsTable.TabIndex = 4;
            StudentsTable.CellContentClick += dataGridView1_CellContentClick;
            StudentsTable.RowsAdded += StudentsTable_RowsAdded;
            StudentsTable.RowsRemoved += StudentsTable_RowsRemoved;
            // 
            // stuName
            // 
            dataGridViewCellStyle9.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = Color.Transparent;
            stuName.DefaultCellStyle = dataGridViewCellStyle9;
            stuName.HeaderText = "Stu. Name";
            stuName.MinimumWidth = 6;
            stuName.Name = "stuName";
            stuName.ReadOnly = true;
            // 
            // ID
            // 
            dataGridViewCellStyle10.BackColor = Color.White;
            ID.DefaultCellStyle = dataGridViewCellStyle10;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Grade
            // 
            Grade.HeaderText = "Grade";
            Grade.MinimumWidth = 6;
            Grade.Name = "Grade";
            Grade.ReadOnly = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(885, 291);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 318);
            vScrollBar1.TabIndex = 5;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(43, 180, 200);
            SearchButton.FlatAppearance.BorderColor = Color.FromArgb(43, 180, 200);
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Location = new Point(756, 241);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 34);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login__2_;
            pictureBox1.Location = new Point(-24, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Mono", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(443, 24);
            label5.Name = "label5";
            label5.Size = new Size(360, 45);
            label5.TabIndex = 15;
            label5.Text = "Class Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(21, 83);
            label1.Name = "label1";
            label1.Size = new Size(60, 27);
            label1.TabIndex = 11;
            label1.Text = "Time";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TimeLabel.ForeColor = Color.FromArgb(0, 119, 133);
            TimeLabel.Location = new Point(87, 83);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(132, 27);
            TimeLabel.TabIndex = 9;
            TimeLabel.Text = "Time Label";
            TimeLabel.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(289, 14);
            label2.Name = "label2";
            label2.Size = new Size(132, 27);
            label2.TabIndex = 12;
            label2.Text = "Class Code";
            label2.Click += label2_Click;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            codeLabel.ForeColor = Color.FromArgb(0, 119, 133);
            codeLabel.Location = new Point(411, 14);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(132, 27);
            codeLabel.TabIndex = 7;
            codeLabel.Text = "Code Label";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(21, 15);
            label3.Name = "label3";
            label3.Size = new Size(60, 27);
            label3.TabIndex = 13;
            label3.Text = "Hall";
            label3.Click += label3_Click_1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.ForeColor = Color.FromArgb(0, 119, 133);
            NameLabel.Location = new Point(150, 48);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(132, 27);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name Label";
            NameLabel.Click += NameLabel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(20, 48);
            label4.Name = "label4";
            label4.Size = new Size(132, 27);
            label4.TabIndex = 14;
            label4.Text = "Class Name";
            // 
            // hallLabel
            // 
            hallLabel.AutoSize = true;
            hallLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hallLabel.ForeColor = Color.FromArgb(0, 119, 133);
            hallLabel.Location = new Point(76, 15);
            hallLabel.Name = "hallLabel";
            hallLabel.Size = new Size(132, 27);
            hallLabel.TabIndex = 8;
            hallLabel.Text = "Hall Label";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 241, 241);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(hallLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(NameLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(codeLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TimeLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(330, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(552, 125);
            panel1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Coral;
            label6.Location = new Point(289, 48);
            label6.Name = "label6";
            label6.Size = new Size(180, 27);
            label6.TabIndex = 15;
            label6.Text = "Professor Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 119, 133);
            label7.Location = new Point(289, 85);
            label7.Name = "label7";
            label7.Size = new Size(192, 27);
            label7.TabIndex = 16;
            label7.Text = "Professor Label";
            // 
            // ClassProfilePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(SearchButton);
            Controls.Add(StudentsTable);
            Controls.Add(vScrollBar1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "ClassProfilePanel";
            Size = new Size(911, 612);
            ((System.ComponentModel.ISupportInitialize)StudentsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private DataGridView StudentsTable;
        private VScrollBar vScrollBar1;
        private Button SearchButton;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn stuName;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Grade;
        private Label label5;
        private Label label1;
        private Label TimeLabel;
        private Label label2;
        private Label codeLabel;
        private Label label3;
        private Label NameLabel;
        private Label label4;
        private Label hallLabel;
        private Panel panel1;
        private Label label7;
        private Label label6;
    }
}
