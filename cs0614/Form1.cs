namespace cs0614
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        int vx1 = random.Next(-10, 11);
        int vx2 = random.Next(-10, 11);
        int vx3 = random.Next(-10, 11);
        int vy1 = random.Next(-10, 11);
        int vy2 = random.Next(-10, 11);
        int vy3 = random.Next(-10, 11);

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx1;
            label1.Top += vy1;

            label2.Left += vx2;
            label2.Top += vy2;

            label3.Left += vx3;
            label3.Top += vy3;

            //label1
            if (label1.Left < 0)
            {
                vx1 = Math.Abs(vx1);
            }
            else if (label1.Left > ClientSize.Width - label1.Width)
            {
                vx1 = -Math.Abs(vx1);
            }
            if (label1.Top < 0)
            {
                vy1 = Math.Abs(vy1);
                vy1 = random.Next(10);

            }
            else if (label1.Top > ClientSize.Height - label1.Height)
            {
                vy1 = -Math.Abs(vy1);
                vy1 = random.Next(-10,1);
            }

            //label2
            if (label2.Left < 0)
            {
                vx2 = Math.Abs(vx2);
            }
            else if (label2.Left > ClientSize.Width - label2.Width)
            {
                vx2 = -Math.Abs(vx2);
            }
            if (label2.Top < 0)
            {
                vy2 = Math.Abs(vy2);
                vy2 = random.Next(10);

            }
            else if (label2.Top > ClientSize.Height - label2.Height)
            {
                vy2 = -Math.Abs(vy2);
                vy2 = random.Next(-10, 1);

            }

            //label3
            if (label3.Left < 0)
            {
                vx3 = Math.Abs(vx3);
            }
            else if (label3.Left > ClientSize.Width - label3.Width)
            {
                vx3 = -Math.Abs(vx3);
            }
            if (label3.Top < 0)
            {
                vy3 = Math.Abs(vy3);
                vy3 = random.Next(10);

            }
            else if (label3.Top > ClientSize.Height - label3.Height)
            {
                vy3 = -Math.Abs(vy3);
                vy3 = random.Next(-10, 1);

            }

        }
    }
}