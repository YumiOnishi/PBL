using OpenCvSharp;
using System.IO;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
//using OpenCvSharp;
//using OpenCvSharp.Extensions;

namespace PBL_new
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Load(openFileDialog2.FileName);
                path_name.Text = pictureBox1.ImageLocation;

                string fileName = Path.GetFileName(path_name.Text);
                file_name.Text = fileName;
            }
            

            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                string filepath = folderBrowserDialog2.SelectedPath;
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@filepath);
                System.IO.FileInfo[] files =
                    di.GetFiles("*.bmp", System.IO.SearchOption.AllDirectories);


                //ListBox1�Ɍ��ʂ�\������

                foreach (System.IO.FileInfo f in files)
                {
                    imageList1.Images.Add(Image.FromFile(f.FullName));
                    //imageList1.ImageSize = new Size(256, 256);
                    imageList1.ColorDepth = ColorDepth.Depth32Bit;
                    pictureBox1.Image = imageList1.Images[0];
                    path_name.Text = f.FullName;
                    string fileName = Path.GetFileName(path_name.Text);
                    file_name.Text = fileName;
                    //pictureBox1.Load(f.FullName);

                }


            }

        }
        int n = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = imageList1.Images[n];
            if (n == imageList1.Images.Count - 1)
            {
                n = 0;
            }
            else
            {
                n++;

            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (n == 0)
            {
                n = imageList1.Images.Count-1;
            }
            else
            {
                n--;
                //string fileName = Path.GetFileName(imageList1[n]);
                //file_name.Text = fileName;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = imageList1.Images[n];

            /*
            pictureBox1.Image = imageList1.Images[n];
            if (n == imageList1.Images.Count)
            {
                n = 0;
            }
            else
            {
                n++;
            }

            */


            /*
                for (int i = 0; i < img_num.Length; i++)
            {
                pictureBox1.Image = imageList1.Images[n];
            }
            imageList.Images.Add(Image.FromFile(path));
            */
            //pictureBox1.Image = imageList1.Images[0];
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        //��]
        private void button4_Click(object sender, EventArgs e)
        {
            // �摜��90�x��]����

            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //pictureBox1.GoBack();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = imageList1.Images[n];
            if (n == imageList1.Images.Count)
            {
                n = 0;
            }
            else
            {
                n++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //���x�ϊ�

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //�K�E�V�A���t�B���^�Ɛ�s��
            //image = cv2.GaussianBlur(image, ksize = (5, 5), sigmaX = 1);
            //k = 1.0;
            //kernel = np.array([[-k, -k, -k], [-k, 1 + 8 * k, -k], [-k, -k, -k]]);
            //image = cv2.filter2D(image, ddepth = -1, kernel = kernel);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            //g.DrawImage(prm_img, new Point(x, y));
            //myPainting(g);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           //myPainting(e.Graphics);
        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        //�摜�폜
        private void button13_Click(object sender, EventArgs e)
        {
            // �������摜���������遚����
            pictureBox1.Image = null;
            file_name.Text = "�t�@�C����";
            path_name.Text = "�p�X��";

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string extension = System.IO.Path.GetExtension(saveFileDialog1.FileName);

            switch (extension.ToUpper())
            {
                case ".GIF":
                    // ������PictureBox�̃C���[�W��GIF�`���ŕۑ����遚����
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
                case ".JPEG":
                    // ������PictureBox�̃C���[�W��JPEG�`���ŕۑ����遚����
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case ".PNG":
                    // ������PictureBox�̃C���[�W��GIF�`���ŕۑ����遚����
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    break;
            }
        }

        //�摜�̕ۑ�
        private void button14_Click(object sender, EventArgs e)
        {
            // �t�B���^�[�̐ݒ�
            saveFileDialog1.Filter = "GIF�`��|*.gif|JPEG�`��|*.jpeg|PNG�`��|*.png";

            // �t�@�C���ۑ��_�C�A���O��\��
            saveFileDialog1.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}