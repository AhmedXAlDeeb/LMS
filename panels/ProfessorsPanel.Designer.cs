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
            profName = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            _Email = new DataGridViewTextBoxColumn();
            vScrollBar1 = new VScrollBar();
            searchBar = new TextBox();
            searchButt = new Button();
            profCover = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ProfesorsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profCover).BeginInit();
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
            ProfesorsTable.BackgroundColor = Color.FromArgb(233, 245, 247);
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
            ProfesorsTable.Columns.AddRange(new DataGridViewColumn[] { profName, ID, _Email });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Silver;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            ProfesorsTable.DefaultCellStyle = dataGridViewCellStyle10;
            ProfesorsTable.EnableHeadersVisualStyles = false;
            ProfesorsTable.Location = new Point(3, 183);
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
            ProfesorsTable.Size = new Size(879, 426);
            ProfesorsTable.TabIndex = 6;
            ProfesorsTable.CellContentClick += StudentsTable_CellContentClick;
            ProfesorsTable.RowsAdded += StudentsTable_RowsAdded;
            ProfesorsTable.RowsRemoved += StudentsTable_RowsRemoved;
            // 
            // profName
            // 
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle8.SelectionForeColor = Color.Transparent;
            profName.DefaultCellStyle = dataGridViewCellStyle8;
            profName.HeaderText = "Prof Name";
            profName.MinimumWidth = 6;
            profName.Name = "profName";
            profName.ReadOnly = true;
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
            vScrollBar1.Location = new Point(885, 178);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 431);
            vScrollBar1.TabIndex = 7;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // searchBar
            // 
            searchBar.BorderStyle = BorderStyle.FixedSingle;
            searchBar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            searchBar.ForeColor = Color.FromArgb(43, 180, 200);
            searchBar.Location = new Point(3, 141);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = " Search for prof";
            searchBar.Size = new Size(324, 27);
            searchBar.TabIndex = 8;
            searchBar.TextChanged += textBox1_TextChanged;
            // 
            // searchButt
            // 
            searchButt.BackColor = Color.FromArgb(43, 180, 200);
            searchButt.FlatAppearance.BorderSize = 0;
            searchButt.FlatAppearance.MouseDownBackColor = Color.Cyan;
            searchButt.FlatStyle = FlatStyle.Flat;
            searchButt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            searchButt.ForeColor = Color.White;
            searchButt.Location = new Point(344, 139);
            searchButt.Name = "searchButt";
            searchButt.Size = new Size(66, 34);
            searchButt.TabIndex = 9;
            searchButt.Text = "Search";
            searchButt.UseVisualStyleBackColor = false;
            searchButt.Click += button1_Click;
            // 
            // profCover
            // 
            profCover.Image = Properties.Resources.login__6_1;
            profCover.Location = new Point(444, 0);
            profCover.Name = "profCover";
            profCover.Size = new Size(438, 184);
            profCover.SizeMode = PictureBoxSizeMode.Zoom;
            profCover.TabIndex = 10;
            profCover.TabStop = false;
            // 
            // ProfessorsPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(profCover);
            Controls.Add(searchButt);
            Controls.Add(searchBar);
            Controls.Add(ProfesorsTable);
            Controls.Add(vScrollBar1);
            Name = "ProfessorsPanel";
            Size = new Size(911, 612);
            Load += ProfessorsPanel_Load;
            ((System.ComponentModel.ISupportInitialize)ProfesorsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)profCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProfesorsTable;
        private VScrollBar vScrollBar1;
        private TextBox searchBar;
        private Button searchButt;
        private DataGridViewTextBoxColumn profName;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn _Email;
        private PictureBox profCover;
    }
}
