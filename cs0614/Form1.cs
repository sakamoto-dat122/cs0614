namespace cs0614
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        int[] vx = new int[100];
        int[] vy = new int[100];

        Label[] labels = new Label[100];//100ŒÂ•ª‚ÌV‚µ‚¢—Ìˆæ‚ğŠm•Û


        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                labels[i] = new Label();//1ŒÂ‚Ìƒ‰ƒxƒ‹‚ğŠÇ—‚·‚é—Ìˆæ
                labels[i].AutoSize = true;
                labels[i].Text = "Ÿ";
                Controls.Add(labels[i]);
                labels[i].Font = new Font(
                    "Yu Gothic UI",
                    24F,
                    FontStyle.Regular,
                    GraphicsUnit.Point);
                labels[i].Location = new Point(random.Next(ClientSize.Width - labels[i].Width), random.Next(ClientSize.Height - labels[i].Height));
            }

            for (int i = 0; i < 100; i++)
            {
                vx[i] = random.Next(-10, 11);
                vy[i] = random.Next(-10, 11);
            }

            /*
            vx[0] = random.Next(-10, 11);
            vy[0] = random.Next(-10, 11);
            vx[1] = random.Next(-10, 11);
            vy[1] = random.Next(-10, 11);
            vx[2] = random.Next(-10, 11);
            vy[2] = random.Next(-10, 11);
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];

                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                else if (labels[i].Left > ClientSize.Width - labels[i].Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                    vy[i] = random.Next(10);

                }
                else if (labels[i].Top > ClientSize.Height - labels[i].Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                    vy[i] = random.Next(-10, 1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show($"{i}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                if (i == 5)
                {
                    break;
                }
                MessageBox.Show(i.ToString());
            }

            MessageBox.Show($"after {i}");
        }
    }
}