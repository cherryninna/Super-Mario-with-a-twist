namespace ProjectVp
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
            this.WorldFrame = new System.Windows.Forms.Panel();
            this.label_Dead = new System.Windows.Forms.Label();
            this.label_Bombs = new System.Windows.Forms.Label();
            this.label_Highscore = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.pb_NPC1 = new System.Windows.Forms.PictureBox();
            this.pb_NPC2 = new System.Windows.Forms.PictureBox();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.WorldFloor = new System.Windows.Forms.Panel();
            this.pb_Block2 = new System.Windows.Forms.PictureBox();
            this.pb_Block1 = new System.Windows.Forms.PictureBox();
            this.pb_Pipe = new System.Windows.Forms.PictureBox();
            this.timer_Gravity = new System.Windows.Forms.Timer(this.components);
            this.timer_Jump = new System.Windows.Forms.Timer(this.components);
            this.timer_Anim = new System.Windows.Forms.Timer(this.components);
            this.timer_Randombomb = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timerBoomRemove = new System.Windows.Forms.Timer(this.components);
            this.timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.timer_BombFailsafe = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WorldFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pipe)).BeginInit();
            this.SuspendLayout();
            // 
            // WorldFrame
            // 
            this.WorldFrame.BackColor = System.Drawing.Color.SkyBlue;
            this.WorldFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WorldFrame.Controls.Add(this.label_Dead);
            this.WorldFrame.Controls.Add(this.label_Bombs);
            this.WorldFrame.Controls.Add(this.label_Highscore);
            this.WorldFrame.Controls.Add(this.label_Score);
            this.WorldFrame.Controls.Add(this.pb_NPC1);
            this.WorldFrame.Controls.Add(this.pb_NPC2);
            this.WorldFrame.Controls.Add(this.pb_Player);
            this.WorldFrame.Controls.Add(this.pb_Block2);
            this.WorldFrame.Controls.Add(this.pb_Block1);
            this.WorldFrame.Controls.Add(this.pb_Pipe);
            this.WorldFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorldFrame.Location = new System.Drawing.Point(0, 0);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(745, 268);
            this.WorldFrame.TabIndex = 0;
            // 
            // label_Dead
            // 
            this.label_Dead.AutoSize = true;
            this.label_Dead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dead.Location = new System.Drawing.Point(275, 124);
            this.label_Dead.Name = "label_Dead";
            this.label_Dead.Size = new System.Drawing.Size(177, 13);
            this.label_Dead.TabIndex = 11;
            this.label_Dead.Text = "You died, press space to start";
            // 
            // label_Bombs
            // 
            this.label_Bombs.AutoSize = true;
            this.label_Bombs.Location = new System.Drawing.Point(12, 45);
            this.label_Bombs.Name = "label_Bombs";
            this.label_Bombs.Size = new System.Drawing.Size(42, 13);
            this.label_Bombs.TabIndex = 10;
            this.label_Bombs.Text = "Bombs:";
            // 
            // label_Highscore
            // 
            this.label_Highscore.AutoSize = true;
            this.label_Highscore.Location = new System.Drawing.Point(12, 32);
            this.label_Highscore.Name = "label_Highscore";
            this.label_Highscore.Size = new System.Drawing.Size(67, 13);
            this.label_Highscore.TabIndex = 9;
            this.label_Highscore.Text = "Highscore: 0";
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Location = new System.Drawing.Point(12, 19);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(47, 13);
            this.label_Score.TabIndex = 8;
            this.label_Score.Text = "Score: 0";
            this.label_Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // pb_NPC1
            // 
            this.pb_NPC1.Image = global::ProjectVp.Enemy.Enemy_left;
            this.pb_NPC1.Location = new System.Drawing.Point(51, 69);
            this.pb_NPC1.Name = "pb_NPC1";
            this.pb_NPC1.Size = new System.Drawing.Size(30, 30);
            this.pb_NPC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NPC1.TabIndex = 7;
            this.pb_NPC1.TabStop = false;
            // 
            // pb_NPC2
            // 
            this.pb_NPC2.Image = global::ProjectVp.Enemy.Enemy_right;
            this.pb_NPC2.Location = new System.Drawing.Point(15, 69);
            this.pb_NPC2.Name = "pb_NPC2";
            this.pb_NPC2.Size = new System.Drawing.Size(30, 30);
            this.pb_NPC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NPC2.TabIndex = 6;
            this.pb_NPC2.TabStop = false;
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = global::ProjectVp.Character.stand_r;
            this.pb_Player.Location = new System.Drawing.Point(15, 105);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(16, 32);
            this.pb_Player.TabIndex = 2;
            this.pb_Player.TabStop = false;
            // 
            // WorldFloor
            // 
            this.WorldFloor.BackgroundImage = global::ProjectVp.World.floor;
            this.WorldFloor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WorldFloor.Location = new System.Drawing.Point(0, 263);
            this.WorldFloor.Name = "WorldFloor";
            this.WorldFloor.Size = new System.Drawing.Size(745, 33);
            this.WorldFloor.TabIndex = 2;
            this.WorldFloor.Paint += new System.Windows.Forms.PaintEventHandler(this.WorldFloor_Paint);
            // 
            // pb_Block2
            // 
            this.pb_Block2.BackColor = System.Drawing.Color.Gray;
            this.pb_Block2.BackgroundImage = global::ProjectVp.World.Platform;
            this.pb_Block2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Block2.Location = new System.Drawing.Point(80, 186);
            this.pb_Block2.Name = "pb_Block2";
            this.pb_Block2.Size = new System.Drawing.Size(151, 24);
            this.pb_Block2.TabIndex = 4;
            this.pb_Block2.TabStop = false;
            // 
            // pb_Block1
            // 
            this.pb_Block1.BackColor = System.Drawing.Color.Gray;
            this.pb_Block1.BackgroundImage = global::ProjectVp.World.Platform;
            this.pb_Block1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Block1.Location = new System.Drawing.Point(501, 186);
            this.pb_Block1.Name = "pb_Block1";
            this.pb_Block1.Size = new System.Drawing.Size(186, 23);
            this.pb_Block1.TabIndex = 5;
            this.pb_Block1.TabStop = false;
            // 
            // pb_Pipe
            // 
            this.pb_Pipe.BackColor = System.Drawing.Color.SkyBlue;
            this.pb_Pipe.BackgroundImage = global::ProjectVp.World.Pipe;
            this.pb_Pipe.Location = new System.Drawing.Point(317, 228);
            this.pb_Pipe.Name = "pb_Pipe";
            this.pb_Pipe.Size = new System.Drawing.Size(35, 45);
            this.pb_Pipe.TabIndex = 3;
            this.pb_Pipe.TabStop = false;
            this.pb_Pipe.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer_Gravity
            // 
            this.timer_Gravity.Enabled = true;
            this.timer_Gravity.Interval = 1;
            this.timer_Gravity.Tick += new System.EventHandler(this.timer_Gravity_Tick);
            // 
            // timer_Jump
            // 
            this.timer_Jump.Enabled = true;
            this.timer_Jump.Interval = 1;
            this.timer_Jump.Tick += new System.EventHandler(this.timer_Jump_Tick);
            // 
            // timer_Anim
            // 
            this.timer_Anim.Enabled = true;
            this.timer_Anim.Interval = 1;
            this.timer_Anim.Tick += new System.EventHandler(this.timer_Anim_Tick);
            // 
            // timer_Randombomb
            // 
            this.timer_Randombomb.Enabled = true;
            this.timer_Randombomb.Interval = 800;
            this.timer_Randombomb.Tick += new System.EventHandler(this.timer_Randombomb_Tick);
            // 
            // timerBoomRemove
            // 
            this.timerBoomRemove.Enabled = true;
            this.timerBoomRemove.Tick += new System.EventHandler(this.timerBoomRemove_Tick);
            // 
            // timer_Sec
            // 
            this.timer_Sec.Enabled = true;
            this.timer_Sec.Interval = 1000;
            this.timer_Sec.Tick += new System.EventHandler(this.timer_Sec_Tick);
            // 
            // timer_BombFailsafe
            // 
            this.timer_BombFailsafe.Enabled = true;
            this.timer_BombFailsafe.Interval = 3000;
            this.timer_BombFailsafe.Tick += new System.EventHandler(this.timer_BombFailsafe_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 296);
            this.Controls.Add(this.WorldFloor);
            this.Controls.Add(this.WorldFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            this.WorldFrame.ResumeLayout(false);
            this.WorldFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.Timer timer_Gravity;
        private System.Windows.Forms.Timer timer_Jump;
        private System.Windows.Forms.Timer timer_Anim;
        private System.Windows.Forms.Timer timer_Randombomb;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timerBoomRemove;
        private System.Windows.Forms.Timer timer_Sec;
        private System.Windows.Forms.Timer timer_BombFailsafe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel WorldFloor;
        private System.Windows.Forms.PictureBox pb_Pipe;
        private System.Windows.Forms.PictureBox pb_Block2;
        private System.Windows.Forms.PictureBox pb_Block1;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Label label_Dead;
        private System.Windows.Forms.Label label_Bombs;
        private System.Windows.Forms.Label label_Highscore;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.PictureBox pb_NPC1;
        private System.Windows.Forms.PictureBox pb_NPC2;
    }
}

