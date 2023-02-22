namespace MountainsPuzzle
{
    partial class MountainsPuzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MountainsPuzzle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.OriginPic = new System.Windows.Forms.PictureBox();
            this.Timelbl = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.PauseGamebtn = new System.Windows.Forms.Button();
            this.Shufflebtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OriginPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(63, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 641);
            this.panel1.TabIndex = 0;
            // 
            // OriginPic
            // 
            this.OriginPic.BackgroundImage = global::MountainsPuzzle.Properties.Resources.mountains2;
            this.OriginPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OriginPic.Location = new System.Drawing.Point(906, 12);
            this.OriginPic.Name = "OriginPic";
            this.OriginPic.Size = new System.Drawing.Size(262, 234);
            this.OriginPic.TabIndex = 1;
            this.OriginPic.TabStop = false;
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Timelbl.Location = new System.Drawing.Point(915, 284);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(255, 54);
            this.Timelbl.TabIndex = 2;
            this.Timelbl.Text = "00:00:00";
            // 
            // GameTime
            // 
            this.GameTime.Interval = 1000;
            this.GameTime.Tick += new System.EventHandler(this.GameTime_Tick);
            // 
            // PauseGamebtn
            // 
            this.PauseGamebtn.Location = new System.Drawing.Point(906, 367);
            this.PauseGamebtn.Name = "PauseGamebtn";
            this.PauseGamebtn.Size = new System.Drawing.Size(138, 56);
            this.PauseGamebtn.TabIndex = 3;
            this.PauseGamebtn.Text = "Pause";
            this.PauseGamebtn.UseVisualStyleBackColor = true;
            this.PauseGamebtn.Click += new System.EventHandler(this.PauseGamebtn_Click);
            // 
            // Shufflebtn
            // 
            this.Shufflebtn.Location = new System.Drawing.Point(1082, 367);
            this.Shufflebtn.Name = "Shufflebtn";
            this.Shufflebtn.Size = new System.Drawing.Size(138, 56);
            this.Shufflebtn.TabIndex = 4;
            this.Shufflebtn.Text = "Shuffle";
            this.Shufflebtn.UseVisualStyleBackColor = true;
            this.Shufflebtn.Click += new System.EventHandler(this.Shufflebtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(1000, 459);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(138, 56);
            this.Exitbtn.TabIndex = 5;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            // 
            // MountainsPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 727);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Shufflebtn);
            this.Controls.Add(this.PauseGamebtn);
            this.Controls.Add(this.Timelbl);
            this.Controls.Add(this.OriginPic);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MountainsPuzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mountain Puzzle Game";
            this.Load += new System.EventHandler(this.MountainsPuzzle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OriginPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox OriginPic;
        private System.Windows.Forms.Label Timelbl;
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.Button PauseGamebtn;
        private System.Windows.Forms.Button Shufflebtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}

