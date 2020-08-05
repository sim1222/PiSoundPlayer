namespace PiSoundPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playbutton = new System.Windows.Forms.Button();
            this.filebutton = new System.Windows.Forms.Button();
            this.filebox = new System.Windows.Forms.ComboBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // playbutton
            // 
            this.playbutton.Location = new System.Drawing.Point(12, 42);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(254, 125);
            this.playbutton.TabIndex = 0;
            this.playbutton.Text = "再生";
            this.playbutton.UseVisualStyleBackColor = true;
            this.playbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playbutton_MouseDown);
            this.playbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playbutton_MouseUp);
            // 
            // filebutton
            // 
            this.filebutton.Location = new System.Drawing.Point(213, 13);
            this.filebutton.Name = "filebutton";
            this.filebutton.Size = new System.Drawing.Size(53, 23);
            this.filebutton.TabIndex = 1;
            this.filebutton.Text = "参照";
            this.filebutton.UseVisualStyleBackColor = true;
            this.filebutton.Click += new System.EventHandler(this.filebutton_Click);
            // 
            // filebox
            // 
            this.filebox.FormattingEnabled = true;
            this.filebox.Location = new System.Drawing.Point(12, 13);
            this.filebox.Name = "filebox";
            this.filebox.Size = new System.Drawing.Size(195, 20);
            this.filebox.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 173);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(212, 45);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(213, 184);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(53, 23);
            this.reload.TabIndex = 4;
            this.reload.Text = "リロード";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 219);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.filebox);
            this.Controls.Add(this.filebutton);
            this.Controls.Add(this.playbutton);
            this.Name = "Form1";
            this.Text = "PiSoundPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.Button filebutton;
        private System.Windows.Forms.ComboBox filebox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button reload;
    }
}