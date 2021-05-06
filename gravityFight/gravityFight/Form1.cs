using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gravityFight
{
    public partial class Form1 : Form
    {
        //To avoid the windows form from flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }


        //To avoid the screen from stuttering to make the object movement smooth
        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }


        Player player;
        Obstacle obstaclePipe;
        int time;
        public Form1()
        {
            InitializeComponent();
            player = new Player();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.container = this;
            player.Sprite = Properties.Resources.bluebird_midflap;
            player.topPos = this.Height / 2-45;
            player.leftPos = (this.Width / 2) / 2-100;
            player.create("bird");
            this.DoubleBuffered = true;
            enableDoubleBuff(player.Object);
            time = 0;
            timeDisplay.Text = time.ToString();
            playersTime.Start();
            movement.Start();
            obstacleReverse.Start();
            obstacle.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                player.playerMove("space");
            }
        }


        private void movement_Tick(object sender, EventArgs e)
        {
            player.playerMove("not pressed");
        }

        private void obstacle_Tick(object sender, EventArgs e)
        {
            obstaclePipe = new Obstacle();
            obstaclePipe.container = this;
            obstaclePipe.Sprite = Properties.Resources.pipe_red;
            Random random = new Random();
            obstaclePipe.height = random.Next(125,195);
            obstaclePipe.topPos = this.Height-obstaclePipe.height-38;
            obstaclePipe.leftPos = this.Width;

            obstaclePipe.create("obstacle");
            enableDoubleBuff(obstaclePipe.Object);
            obstaclePipe.Move();
        }

        private void obstacleReverse_Tick(object sender, EventArgs e)
        {
            obstaclePipe = new Obstacle();
            obstaclePipe.container = this;
            obstaclePipe.Sprite = Properties.Resources.pipe_red_Reverse;
            Random random = new Random();
            obstaclePipe.height = random.Next(125, 195);
            obstaclePipe.topPos = 0;
            obstaclePipe.leftPos = this.Width;

            obstaclePipe.create("obstacle");
            enableDoubleBuff(obstaclePipe.Object);
            obstaclePipe.Move();
        }

        private void playersTime_Tick(object sender, EventArgs e)
        {
            time++;
            timeDisplay.Text = time.ToString();
            if (player.Object.IsDisposed)
            {
                playersTime.Stop();
                playersTime.Dispose();
            }
        }
    }
}
