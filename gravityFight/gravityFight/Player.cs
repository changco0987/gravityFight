using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace gravityFight
{
    class Player : IDisposable
    {
        public Form container = new Form();
        public PictureBox Object;
        public Image Sprite { get; set; }
        public int leftPos { get; set; }
        public int topPos { get; set; }


        public virtual void create(string tag) 
        {
            Object = new PictureBox();
            Object.SizeMode = PictureBoxSizeMode.AutoSize;
            Object.Top = topPos;
            Object.Left = leftPos;
            Object.Image = Sprite;
            Object.BackColor = Color.Transparent;
            Object.Tag = tag;
            container.Controls.Add(Object);

        }

        //public void animation(PictureBox animatedPicture)
        //{
        //    animatedPicture.Image = Properties.Resources.animatedBird;
        //    animatedPicture.Refresh();
        //    animatedPicture.Visible = true;

        //}

        public void playerMove(string keyPressed) 
        {
            if (keyPressed.Equals("space"))
            {
                Object.Top -= 12;
            }
            else if (keyPressed.Equals("not pressed"))
            {
                Object.Top += 6;

            }
        }

        public void Dispose() 
        {
            Object.Dispose();
            Sprite.Dispose();
            GC.SuppressFinalize(Object);
        }



    }
}
