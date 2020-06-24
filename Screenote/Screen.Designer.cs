namespace Screenote
{
    partial class Screen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            this.picture = new System.Windows.Forms.PictureBox();
            this.magnifier = new System.Windows.Forms.PictureBox();
            this.noteIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.noteicon_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_close = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnifier)).BeginInit();
            this.noteicon_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Margin = new System.Windows.Forms.Padding(0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 100);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // magnifier
            // 
            this.magnifier.Location = new System.Drawing.Point(0, 0);
            this.magnifier.Margin = new System.Windows.Forms.Padding(0);
            this.magnifier.Name = "magnifier";
            this.magnifier.Size = new System.Drawing.Size(100, 100);
            this.magnifier.TabIndex = 1;
            this.magnifier.TabStop = false;
            this.magnifier.Visible = false;
            // 
            // noteIcon
            // 
            this.noteIcon.ContextMenuStrip = this.noteicon_contextMenuStrip;
            this.noteIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("noteIcon.Icon")));
            this.noteIcon.Text = "Screen";
            this.noteIcon.Visible = true;
            this.noteIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.noteIcon_MouseDoubleClick);
            // 
            // noteicon_contextMenuStrip
            // 
            this.noteicon_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_close});
            this.noteicon_contextMenuStrip.Name = "noteicon_contextMenuStrip";
            this.noteicon_contextMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItem_close
            // 
            this.toolStripMenuItem_close.Name = "toolStripMenuItem_close";
            this.toolStripMenuItem_close.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_close.Text = "关 闭";
            this.toolStripMenuItem_close.Click += new System.EventHandler(this.toolStripMenuItem_close_Click);
            // 
            // Screen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(100, 100);
            this.ControlBox = false;
            this.Controls.Add(this.magnifier);
            this.Controls.Add(this.picture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Screen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Screen_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Screen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnifier)).EndInit();
            this.noteicon_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox magnifier;
        private System.Windows.Forms.NotifyIcon noteIcon;
        private System.Windows.Forms.ContextMenuStrip noteicon_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_close;
    }
}