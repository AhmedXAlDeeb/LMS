﻿namespace SchoolManagementSystem.panels
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            button1 = new Button();
            textBox1 = new TextBox();
            ProfesorsTable = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            _Email = new DataGridViewTextBoxColumn();
            vScrollBar1 = new VScrollBar();
            ((System.ComponentModel.ISupportInitialize)ProfesorsTable).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(505, 80);
            button1.Name = "button1";
            button1.Size = new Size(66, 34);
            button1.TabIndex = 13;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 80);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 34);
            textBox1.TabIndex = 12;
            // 
            // ProfesorsTable
            // 
            ProfesorsTable.AllowUserToAddRows = false;
            ProfesorsTable.AllowUserToDeleteRows = false;
            ProfesorsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(233, 245, 247);
            ProfesorsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ProfesorsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProfesorsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProfesorsTable.BackgroundColor = Color.FromArgb(233, 245, 247);
            ProfesorsTable.BorderStyle = BorderStyle.None;
            ProfesorsTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ProfesorsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 180, 200);
            dataGridViewCellStyle2.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 180, 200);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProfesorsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProfesorsTable.ColumnHeadersHeight = 35;
            ProfesorsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProfesorsTable.Columns.AddRange(new DataGridViewColumn[] { Name, ID, _Email });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            ProfesorsTable.DefaultCellStyle = dataGridViewCellStyle5;
            ProfesorsTable.EnableHeadersVisualStyles = false;
            ProfesorsTable.Location = new Point(140, 150);
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
            ProfesorsTable.Size = new Size(407, 371);
            ProfesorsTable.TabIndex = 10;
            ProfesorsTable.CellContentClick += ProfesorsTable_CellContentClick;
            ProfesorsTable.RowsAdded += ProfesorsTable_RowsAdded;
            ProfesorsTable.RowsRemoved += ProfesorsTable_RowsRemoved;
            // 
            // Name
            // 
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionForeColor = Color.Transparent;
            Name.DefaultCellStyle = dataGridViewCellStyle3;
            Name.HeaderText = "Prof Name";
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
            // _Email
            // 
            _Email.HeaderText = "Eamil";
            _Email.MinimumWidth = 6;
            _Email.Name = "_Email";
            _Email.ReadOnly = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(644, 150);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 272);
            vScrollBar1.TabIndex = 11;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // ClassesPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(ProfesorsTable);
            Controls.Add(vScrollBar1);
            this.Name.Name = "ClassesPanel";
            Size = new Size(800, 600);
            Load += ClassesPanel_Load;
            ((System.ComponentModel.ISupportInitialize)ProfesorsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private DataGridView ProfesorsTable;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn _Email;
        private VScrollBar vScrollBar1;
    }
}
