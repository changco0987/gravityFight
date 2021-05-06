
namespace gravityFight
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.movement = new System.Windows.Forms.Timer(this.components);
            this.obstacle = new System.Windows.Forms.Timer(this.components);
            this.obstacleReverse = new System.Windows.Forms.Timer(this.components);
            this.timeDisplay = new System.Windows.Forms.Label();
            this.playersTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // movement
            // 
            this.movement.Tick += new System.EventHandler(this.movement_Tick);
            // 
            // obstacle
            // 
            this.obstacle.Interval = 2000;
            this.obstacle.Tick += new System.EventHandler(this.obstacle_Tick);
            // 
            // obstacleReverse
            // 
            this.obstacleReverse.Interval = 2000;
            this.obstacleReverse.Tick += new System.EventHandler(this.obstacleReverse_Tick);
            // 
            // timeDisplay
            // 
            this.timeDisplay.AutoSize = true;
            this.timeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.timeDisplay.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplay.ForeColor = System.Drawing.Color.SpringGreen;
            this.timeDisplay.Location = new System.Drawing.Point(8, 4);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.Size = new System.Drawing.Size(51, 17);
            this.timeDisplay.TabIndex = 0;
            this.timeDisplay.Text = "label1";
            // 
            // playersTime
            // 
            this.playersTime.Interval = 1000;
            this.playersTime.Tick += new System.EventHandler(this.playersTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gravityFight.Properties.Resources.background_night;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.timeDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer movement;
        private System.Windows.Forms.Timer obstacle;
        private System.Windows.Forms.Timer obstacleReverse;
        private System.Windows.Forms.Label timeDisplay;
        private System.Windows.Forms.Timer playersTime;
    }
}

