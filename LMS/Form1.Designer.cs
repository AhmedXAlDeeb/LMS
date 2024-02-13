namespace LMS
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            sidebarBtn = new PictureBox();
            sidebar = new FlowLayoutPanel();
            MenuPanel = new Panel();
            panel7 = new Panel();
            SubOption2 = new Button();
            panel3 = new Panel();
            HomeButton = new Button();
            panel2 = new Panel();
            SubOption1 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            HomeTimer = new System.Windows.Forms.Timer(components);
            SidebarTrans = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sidebarBtn).BeginInit();
            sidebar.SuspendLayout();
            MenuPanel.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 180, 200);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sidebarBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(67, 21);
            label1.Name = "label1";
            label1.Size = new Size(156, 19);
            label1.TabIndex = 1;
            label1.Text = "Our paltform Name";
            label1.Click += label1_Click;
            // 
            // sidebarBtn
            // 
            sidebarBtn.Image = (Image)resources.GetObject("sidebarBtn.Image");
            sidebarBtn.Location = new Point(12, 0);
            sidebarBtn.Name = "sidebarBtn";
            sidebarBtn.Size = new Size(39, 40);
            sidebarBtn.TabIndex = 0;
            sidebarBtn.TabStop = false;
            sidebarBtn.Click += pictureBox1_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(43, 180, 200);
            sidebar.Controls.Add(MenuPanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 40);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(60, 572);
            sidebar.TabIndex = 2;
            sidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(43, 180, 200);
            MenuPanel.Controls.Add(panel7);
            MenuPanel.Controls.Add(panel3);
            MenuPanel.Controls.Add(panel2);
            MenuPanel.Location = new Point(3, 3);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(197, 50);
            MenuPanel.TabIndex = 5;
            MenuPanel.Paint += panel6_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaptionText;
            panel7.Controls.Add(SubOption2);
            panel7.Location = new Point(0, 140);
            panel7.Name = "panel7";
            panel7.Size = new Size(220, 50);
            panel7.TabIndex = 7;
            // 
            // SubOption2
            // 
            SubOption2.BackColor = Color.FromArgb(43, 180, 200);
            SubOption2.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SubOption2.ForeColor = Color.White;
            SubOption2.Image = (Image)resources.GetObject("SubOption2.Image");
            SubOption2.ImageAlign = ContentAlignment.MiddleLeft;
            SubOption2.Location = new Point(-15, -14);
            SubOption2.Name = "SubOption2";
            SubOption2.Padding = new Padding(25, 0, 0, 0);
            SubOption2.Size = new Size(264, 78);
            SubOption2.TabIndex = 0;
            SubOption2.Text = "          Sub Option 2";
            SubOption2.TextAlign = ContentAlignment.MiddleLeft;
            SubOption2.UseCompatibleTextRendering = true;
            SubOption2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(HomeButton);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 50);
            panel3.TabIndex = 4;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.FromArgb(43, 180, 200);
            HomeButton.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HomeButton.ForeColor = Color.White;
            HomeButton.Image = (Image)resources.GetObject("HomeButton.Image");
            HomeButton.ImageAlign = ContentAlignment.MiddleLeft;
            HomeButton.Location = new Point(-18, -14);
            HomeButton.Name = "HomeButton";
            HomeButton.Padding = new Padding(25, 0, 0, 0);
            HomeButton.Size = new Size(264, 78);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "          Home";
            HomeButton.TextAlign = ContentAlignment.MiddleLeft;
            HomeButton.UseCompatibleTextRendering = true;
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(SubOption1);
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 50);
            panel2.TabIndex = 5;
            // 
            // SubOption1
            // 
            SubOption1.BackColor = Color.FromArgb(43, 180, 200);
            SubOption1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SubOption1.ForeColor = Color.White;
            SubOption1.Image = (Image)resources.GetObject("SubOption1.Image");
            SubOption1.ImageAlign = ContentAlignment.MiddleLeft;
            SubOption1.Location = new Point(-15, -14);
            SubOption1.Name = "SubOption1";
            SubOption1.Padding = new Padding(25, 0, 0, 0);
            SubOption1.Size = new Size(264, 78);
            SubOption1.TabIndex = 0;
            SubOption1.Text = "          Sub Option 1";
            SubOption1.TextAlign = ContentAlignment.MiddleLeft;
            SubOption1.UseCompatibleTextRendering = true;
            SubOption1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(button3);
            panel4.Location = new Point(453, 413);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 50);
            panel4.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(43, 180, 200);
            button3.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-15, -14);
            button3.Name = "button3";
            button3.Padding = new Padding(25, 0, 0, 0);
            button3.Size = new Size(264, 78);
            button3.TabIndex = 0;
            button3.Text = "          Home";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseCompatibleTextRendering = true;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(button4);
            panel5.Location = new Point(453, 483);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 50);
            panel5.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(43, 180, 200);
            button4.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-15, -14);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.Size = new Size(264, 78);
            button4.TabIndex = 0;
            button4.Text = "          Home";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseCompatibleTextRendering = true;
            button4.UseVisualStyleBackColor = false;
            // 
            // HomeTimer
            // 
            HomeTimer.Tick += timer1_Tick;
            // 
            // SidebarTrans
            // 
            SidebarTrans.Interval = 10;
            SidebarTrans.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(918, 612);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sidebarBtn).EndInit();
            sidebar.ResumeLayout(false);
            MenuPanel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox sidebarBtn;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Panel panel3;
        private Button HomeButton;
        private Panel MenuPanel;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel2;
        private Button SubOption1;
        private Panel panel7;
        private Button SubOption2;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Timer SidebarTrans;
    }
}