namespace TrexGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Trex = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtscore = new System.Windows.Forms.Label();
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 57);
            this.panel1.TabIndex = 0;
            // 
            // Trex
            // 
            this.Trex.Image = global::TrexGame.Properties.Resources.running;
            this.Trex.Location = new System.Drawing.Point(88, 350);
            this.Trex.Name = "Trex";
            this.Trex.Size = new System.Drawing.Size(40, 43);
            this.Trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Trex.TabIndex = 1;
            this.Trex.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrexGame.Properties.Resources.obstacle_1;
            this.pictureBox2.Location = new System.Drawing.Point(468, 347);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "obstacle";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TrexGame.Properties.Resources.obstacle_2;
            this.pictureBox3.Location = new System.Drawing.Point(623, 360);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle";
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.Location = new System.Drawing.Point(64, 54);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(134, 32);
            this.txtscore.TabIndex = 4;
            this.txtscore.Text = "SCORE: 0";
            // 
            // Gametimer
            // 
            this.Gametimer.Interval = 20;
            this.Gametimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Trex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Trex;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Timer Gametimer;
    }
}

