namespace SchoolManagementSystem.UserControls
{
    partial class ControlPanalControl
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
            test = new Button();
            SuspendLayout();
            // 
            // test
            // 
            test.Location = new Point(68, 172);
            test.Name = "test";
            test.Size = new Size(94, 29);
            test.TabIndex = 0;
            test.Text = "test";
            test.UseVisualStyleBackColor = true;
            test.Click += test_Click;
            // 
            // ControlPanalControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(test);
            Name = "ControlPanalControl";
            Size = new Size(771, 460);
            ResumeLayout(false);
        }

        #endregion

        private Button test;
    }
}
