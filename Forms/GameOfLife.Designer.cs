using Project214.Forms.Custom_Components;

namespace Project214.Forms
{
    partial class GameOfLife
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_step = new System.Windows.Forms.Button();
            this.btn_play_pause = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.pbx_gameCanvas = new Project214.Forms.Custom_Components.ExpandedPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_gameCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.StepGame);
            // 
            // btn_step
            // 
            this.btn_step.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_step.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_step.FlatAppearance.BorderSize = 2;
            this.btn_step.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_step.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold);
            this.btn_step.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_step.Location = new System.Drawing.Point(12, 518);
            this.btn_step.Name = "btn_step";
            this.btn_step.Size = new System.Drawing.Size(164, 28);
            this.btn_step.TabIndex = 8;
            this.btn_step.Text = "Step";
            this.btn_step.UseVisualStyleBackColor = true;
            this.btn_step.Click += new System.EventHandler(this.StepGame);
            // 
            // btn_play_pause
            // 
            this.btn_play_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_play_pause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_play_pause.FlatAppearance.BorderSize = 2;
            this.btn_play_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play_pause.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold);
            this.btn_play_pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_play_pause.Location = new System.Drawing.Point(182, 518);
            this.btn_play_pause.Name = "btn_play_pause";
            this.btn_play_pause.Size = new System.Drawing.Size(148, 28);
            this.btn_play_pause.TabIndex = 7;
            this.btn_play_pause.Text = "Play";
            this.btn_play_pause.UseVisualStyleBackColor = true;
            this.btn_play_pause.Click += new System.EventHandler(this.btn_play_pause_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Quit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_Quit.FlatAppearance.BorderSize = 2;
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quit.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Quit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btn_Quit.Location = new System.Drawing.Point(336, 518);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(164, 28);
            this.btn_Quit.TabIndex = 8;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // pbx_gameCanvas
            // 
            this.pbx_gameCanvas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbx_gameCanvas.Location = new System.Drawing.Point(0, 0);
            this.pbx_gameCanvas.Name = "pbx_gameCanvas";
            this.pbx_gameCanvas.Size = new System.Drawing.Size(512, 512);
            this.pbx_gameCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_gameCanvas.TabIndex = 0;
            this.pbx_gameCanvas.TabStop = false;
            this.pbx_gameCanvas.Click += new System.EventHandler(this.pbx_gameCanvas_Click);
            // 
            // GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(512, 559);
            this.Controls.Add(this.btn_play_pause);
            this.Controls.Add(this.btn_step);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.pbx_gameCanvas);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOfLife";
            this.Text = "GameOfLife";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOfLife_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_gameCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private ExpandedPictureBox pbx_gameCanvas;
        private System.Windows.Forms.Button btn_play_pause;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_step;
    }
}