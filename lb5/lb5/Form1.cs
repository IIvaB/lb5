using System;

namespace lb5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ���� ��21 ������ 3");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(207, 272);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen1 = new Pen(Color.Black, 2);

            graph.FillRectangle(Brushes.LightGray, new Rectangle(20, 20, 80, 200)); // ������

            graph.FillRectangle(Brushes.DarkOliveGreen, new Rectangle(35, 37, 50, 160)); // ����� ������
           
            graph.FillEllipse(Brushes.Red, new Rectangle(45, 45, 30, 30)); // �������
            graph.FillEllipse(Brushes.Yellow, new Rectangle(45, 100, 30, 30)); // ������
            graph.FillEllipse(Brushes.Green, new Rectangle(45, 150, 30, 30)); // �������

            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
