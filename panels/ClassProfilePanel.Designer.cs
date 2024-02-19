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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            button1 = new Button();
            NameLabel = new Label();
            textBox1 = new TextBox();
            StudentsTable = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            vScrollBar1 = new VScrollBar();
            SearchButton = new Button();
            codeLabel = new Label();
            hallLabel = new Label();
            TimeLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)StudentsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(531, 24);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(608, 148);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(89, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name Label";
            NameLabel.Click += NameLabel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, 196);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 34);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
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
            StudentsTable.BackgroundColor = Color.FromArgb(233, 245, 247);
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
            StudentsTable.Columns.AddRange(new DataGridViewColumn[] { Name, ID, Grade });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            StudentsTable.DefaultCellStyle = dataGridViewCellStyle5;
            StudentsTable.EnableHeadersVisualStyles = false;
            StudentsTable.Location = new Point(15, 291);
            StudentsTable.Name = "StudentsTable";
            StudentsTable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            StudentsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            StudentsTable.RowHeadersVisible = false;
            StudentsTable.RowHeadersWidth = 51;
            StudentsTable.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            StudentsTable.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            StudentsTable.RowTemplate.Height = 29;
            StudentsTable.ScrollBars = ScrollBars.None;
            StudentsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentsTable.Size = new Size(572, 288);
            StudentsTable.TabIndex = 4;
            StudentsTable.CellContentClick += dataGridView1_CellContentClick;
            StudentsTable.RowsAdded += StudentsTable_RowsAdded;
            StudentsTable.RowsRemoved += StudentsTable_RowsRemoved;
            // 
            // Name
            // 
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Transparent;
            Name.DefaultCellStyle = dataGridViewCellStyle3;
            Name.HeaderText = "Stu. Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // ID
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            ID.DefaultCellStyle = dataGridViewCellStyle4;
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
            vScrollBar1.Location = new Point(608, 337);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 224);
            vScrollBar1.TabIndex = 5;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(644, 196);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 34);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new Point(608, 78);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(84, 20);
            codeLabel.TabIndex = 7;
            codeLabel.Text = "Code Label";
            // 
            // hallLabel
            // 
            hallLabel.AutoSize = true;
            hallLabel.Location = new Point(469, 148);
            hallLabel.Name = "hallLabel";
            hallLabel.Size = new Size(76, 20);
            hallLabel.TabIndex = 8;
            hallLabel.Text = "Hall Label";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(463, 78);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(82, 20);
            TimeLabel.TabIndex = 9;
            TimeLabel.Text = "Time Label";
            TimeLabel.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login__2_;
            pictureBox1.Location = new Point(0, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // ClassProfilePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(pictureBox1);
            Controls.Add(TimeLabel);
            Controls.Add(hallLabel);
            Controls.Add(codeLabel);
            Controls.Add(SearchButton);
            Controls.Add(StudentsTable);
            Controls.Add(vScrollBar1);
            Controls.Add(textBox1);
            Controls.Add(NameLabel);
            Controls.Add(button1);
            DoubleBuffered = true;
            this.Name.Name = "ClassProfilePanel";
            Size = new Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)StudentsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label NameLabel;
        private TextBox textBox1;
        private DataGridView StudentsTable;
        private VScrollBar vScrollBar1;
        private Button SearchButton;
        private Label codeLabel;
        private Label hallLabel;
        private Label TimeLabel;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Grade;
        private PictureBox pictureBox1;
    }
}
