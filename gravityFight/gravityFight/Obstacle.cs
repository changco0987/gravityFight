using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace gravityFight
{
    class Obstacle : Player
    {

        //Obstacle size
        public int height { get; set; }
        public Timer obstacleMove = new Timer();


        public void Move() 
        {
            obstacleMove.Interval = 100;
            obstacleMove.Tick += ObstacleMove_Tick;
            obstacleMove.Start();
        }

        private void ObstacleMove_Tick(object sender, EventArgs e)
        {

            Object.Left -= 10;

            checkIfColide();//It always check if the bird was colide in any of the obstacle
            if (Object.Left<0) 
            {
                obstacleMove.Stop();
                obstacleMove.Dispose();
                Dispose();

            }
        }

        public override void create(string tag)
        {
            Object = new PictureBox();
            Object.SizeMode = PictureBoxSizeMode.StretchImage;
            Object.Height = height;
            Object.Width = 52;
            Object.Top = topPos;
            Object.Left = leftPos;
            Object.Image = Sprite;
            Object.BackColor = Color.Transparent;
            Object.Tag = tag;
            container.Controls.Add(Object);

        }


        public async void checkIfColide()
        {
            Form1 mainScene = new Form1();
            foreach (var item in container.Controls.OfType<PictureBox>())
            {
                if (item.Tag.ToString() == "bird" && Object.Bounds.IntersectsWith(item.Bounds))
                {
                    obstacleMove.Stop();
                    obstacleMove.Dispose();
                    Dispose();
                    item.Image.Dispose();
                    item.Image = null;
                    animatedPictureBox(item);
                    await Task.Delay(250);
                    item.Dispose();
                    Object.Dispose();

                    CustomMsgBox msgBox = new CustomMsgBox();
                    msgBox.ShowDialog();
                    container.Dispose();
                }
                else if (item.Tag.ToString() == "bird" && (item.Top > mainScene.Height || item.Top < 0))
                {
                    obstacleMove.Stop();
                    obstacleMove.Dispose();
                    Dispose();
                    item.Image.Dispose();
                    item.Image = null;
                    animatedPictureBox(item);
                    await Task.Delay(250);
                    item.Dispose();
                    Object.Dispose();

                    CustomMsgBox msgBox = new CustomMsgBox();
                    msgBox.ShowDialog();
                    container.Dispose();
                }

            }
        }


        public void animatedPictureBox(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources.explosion_anim3;
            pictureBox.Refresh();
            pictureBox.Visible = true;
        }

    }
}
