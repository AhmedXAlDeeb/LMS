namespace LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SidebarTrans.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }
        bool homeExpand = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!homeExpand)
            {
                MenuPanel.Height += 10;
                if (MenuPanel.Height >= 200)
                {
                    HomeTimer.Stop();
                    homeExpand = true;
                }

            }
            else
            {
                MenuPanel.Height -= 10;
                if (MenuPanel.Height <= 50)
                {
                    HomeTimer.Stop();
                    homeExpand = false;

                }
            }
        }

        bool sidebarExpand = true;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 60)
                {
                    sidebarExpand = false;
                    SidebarTrans.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 200)
                {
                    sidebarExpand = true;
                    SidebarTrans.Stop();

                }
            }
        }
    }
}