namespace SchoolManagementSystem.UserControls
{
    partial class ClassesPanel
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassesPanel));
            button1 = new Button();
            NameLabel = new Label();
            textBox1 = new TextBox();
            StudentsTable = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            vScrollBar1 = new VScrollBar();
            ((System.ComponentModel.ISupportInitialize)StudentsTable).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(545, 181);
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
            NameLabel.Location = new Point(338, 42);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(50, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 500);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 34);
            textBox1.TabIndex = 3;
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
            StudentsTable.BackgroundColor = SystemColors.HighlightText;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            StudentsTable.DefaultCellStyle = dataGridViewCellStyle4;
            StudentsTable.EnableHeadersVisualStyles = false;
            StudentsTable.Location = new Point(280, 291);
            StudentsTable.Name = "StudentsTable";
            StudentsTable.ReadOnly = true;
            StudentsTable.RowHeadersVisible = false;
            StudentsTable.RowHeadersWidth = 51;
            StudentsTable.RowTemplate.Height = 29;
            StudentsTable.ScrollBars = ScrollBars.None;
            StudentsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentsTable.Size = new Size(485, 288);
            StudentsTable.TabIndex = 4;
            StudentsTable.CellContentClick += dataGridView1_CellContentClick;
            StudentsTable.RowsAdded += StudentsTable_RowsAdded;
            StudentsTable.RowsRemoved += StudentsTable_RowsRemoved;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // ID
            // 
            dataGridViewCellStyle3.BackColor = Color.White;
            ID.DefaultCellStyle = dataGridViewCellStyle3;
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
            vScrollBar1.Location = new Point(769, 361);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 224);
            vScrollBar1.TabIndex = 5;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // ClassesPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(StudentsTable);
            Controls.Add(vScrollBar1);
            Controls.Add(textBox1);
            Controls.Add(NameLabel);
            Controls.Add(button1);
            DoubleBuffered = true;
            //Name = "ClassesPanel";
            Size = new Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)StudentsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label NameLabel;
        private TextBox textBox1;
        private DataGridView StudentsTable;
        private VScrollBar vScrollBar1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Grade;
    }
}
