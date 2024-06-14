namespace cs0614
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        int[] vx = new int[3];
        int[] vy = new int[3];


        public Form1()
        {
            InitializeComponent();
            vx[0] = random.Next(-10, 10);
            vy[0] = random.Next(-10, 10);
            vx[1] = random.Next(-10, 10);
            vy[1] = random.Next(-10, 10);
            vx[2] = random.Next(-10, 10);
            vy[2] = random.Next(-10, 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx[0];
            label1.Top += vy[0];

            label2.Left += vx[1];
            label2.Top += vy[1];

            label3.Left += vx[2];
            label3.Top += vy[2];

            //label1
            if (label1.Left < 0)
            {
                vx[0] = Math.Abs(vx[0]);
            }
            else if (label1.Left > ClientSize.Width - label1.Width)
            {
                vx[0] = -Math.Abs(vx[0]);
            }
            if (label1.Top < 0)
            {
                vy[0] = Math.Abs(vy[0]);
                vy[0] = random.Next(10);

            }
            else if (label1.Top > ClientSize.Height - label1.Height)
            {
                vy[0] = -Math.Abs(vy[0]);
                vy[0] = random.Next(-10, 1);
            }

            //label2
            if (label2.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            else if (label2.Left > ClientSize.Width - label2.Width)
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            if (label2.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
                vy[1] = random.Next(10);

            }
            else if (label2.Top > ClientSize.Height - label2.Height)
            {
                vy[1] = -Math.Abs(vy[1]);
                vy[1] = random.Next(-10, 1);

            }

            //label3
            if (label3.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            else if (label3.Left > ClientSize.Width - label3.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label3.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
                vy[2] = random.Next(10);

            }
            else if (label3.Top > ClientSize.Height - label3.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
                vy[2] = random.Next(-10, 1);

            }

        }
    }
}