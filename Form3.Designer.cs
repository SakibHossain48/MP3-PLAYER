namespace Mp3_Player
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSong = new System.Windows.Forms.ListBox();
            this.AddMusicbutton = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.buttonMin);
            this.panel1.Controls.Add(this.buttonexit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 69);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.Maroon;
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMin.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMin.Location = new System.Drawing.Point(755, 4);
            this.buttonMin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(50, 32);
            this.buttonMin.TabIndex = 4;
            this.buttonMin.Text = "-";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonexit.FlatAppearance.BorderSize = 0;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonexit.Location = new System.Drawing.Point(825, 4);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(58, 32);
            this.buttonexit.TabIndex = 3;
            this.buttonexit.Text = "x";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(63, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shakib MP3 Player";
            // 
            // listBoxSong
            // 
            this.listBoxSong.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBoxSong.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSong.FormattingEnabled = true;
            this.listBoxSong.ItemHeight = 12;
            this.listBoxSong.Location = new System.Drawing.Point(663, 107);
            this.listBoxSong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBoxSong.Name = "listBoxSong";
            this.listBoxSong.Size = new System.Drawing.Size(257, 376);
            this.listBoxSong.TabIndex = 1;
            this.listBoxSong.SelectedIndexChanged += new System.EventHandler(this.listBoxSong_SelectedIndexChanged);
            // 
            // AddMusicbutton
            // 
            this.AddMusicbutton.BackColor = System.Drawing.Color.Red;
            this.AddMusicbutton.FlatAppearance.BorderSize = 0;
            this.AddMusicbutton.Location = new System.Drawing.Point(663, 482);
            this.AddMusicbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AddMusicbutton.Name = "AddMusicbutton";
            this.AddMusicbutton.Size = new System.Drawing.Size(257, 54);
            this.AddMusicbutton.TabIndex = 2;
            this.AddMusicbutton.Text = "Add Music";
            this.AddMusicbutton.UseVisualStyleBackColor = false;
            this.AddMusicbutton.Click += new System.EventHandler(this.AddMusicbutton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(52, 155);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(445, 174);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(989, 537);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.AddMusicbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxSong);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSong;
        private System.Windows.Forms.Button AddMusicbutton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}