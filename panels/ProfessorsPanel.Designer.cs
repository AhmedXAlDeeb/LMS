namespace SchoolManagementSystem.panels
{
    partial class ProfessorsPanel
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            ProfesorsTable = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            _Email = new DataGridViewTextBoxColumn();
            vScrollBar1 = new VScrollBar();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ProfesorsTable).BeginInit();
            SuspendLayout();
            // 
            // ProfesorsTable
            // 
            ProfesorsTable.AllowUserToAddRows = false;
            ProfesorsTable.AllowUserToDeleteRows = false;
            ProfesorsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(233, 245, 247);
            ProfesorsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            ProfesorsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProfesorsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProfesorsTable.BackgroundColor = SystemColors.HighlightText;
            ProfesorsTable.BorderStyle = BorderStyle.None;
            ProfesorsTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ProfesorsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(43, 180, 200);
            dataGridViewCellStyle7.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(43, 180, 200);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            ProfesorsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            ProfesorsTable.ColumnHeadersHeight = 35;
            ProfesorsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProfesorsTable.Columns.AddRange(new DataGridViewColumn[] { Name, ID, _Email });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Silver;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            ProfesorsTable.DefaultCellStyle = dataGridViewCellStyle10;
            ProfesorsTable.EnableHeadersVisualStyles = false;
            ProfesorsTable.Location = new Point(39, 115);
            ProfesorsTable.Name = "ProfesorsTable";
            ProfesorsTable.ReadOnly = true;
            ProfesorsTable.RowHeadersVisible = false;
            ProfesorsTable.RowHeadersWidth = 51;
            ProfesorsTable.RowTemplate.DefaultCellStyle.NullValue = "None";
            ProfesorsTable.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
            ProfesorsTable.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            ProfesorsTable.RowTemplate.Height = 29;
            ProfesorsTable.ScrollBars = ScrollBars.None;
            ProfesorsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProfesorsTable.Size = new Size(466, 289);
            ProfesorsTable.TabIndex = 6;
            ProfesorsTable.CellContentClick += StudentsTable_CellContentClick;
            ProfesorsTable.RowsAdded += StudentsTable_RowsAdded;
            ProfesorsTable.RowsRemoved += StudentsTable_RowsRemoved;
            // 
            // Name
            // 
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle8.SelectionForeColor = Color.Transparent;
            Name.DefaultCellStyle = dataGridViewCellStyle8;
            Name.HeaderText = "Prof Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // ID
            // 
            dataGridViewCellStyle9.BackColor = Color.White;
            ID.DefaultCellStyle = dataGridViewCellStyle9;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // _Email
            // 
            _Email.HeaderText = "Eamil";
            _Email.MinimumWidth = 6;
            _Email.Name = "_Email";
            _Email.ReadOnly = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(543, 115);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 272);
            vScrollBar1.TabIndex = 7;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 34);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(404, 45);
            button1.Name = "button1";
            button1.Size = new Size(66, 34);
            button1.TabIndex = 9;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProfessorsPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(ProfesorsTable);
            Controls.Add(vScrollBar1);
            //Name = "ProfessorsPanel";
            Size = new Size(859, 518);
            Load += ProfessorsPanel_Load;
            ((System.ComponentModel.ISupportInitialize)ProfesorsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProfesorsTable;
        private VScrollBar vScrollBar1;
        private TextBox textBox1;
        private Button button1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn _Email;
    }
}
