namespace MulticastServer
{
    partial class MulticastServer
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
            this.rtb_server = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_server
            // 
            this.rtb_server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_server.Location = new System.Drawing.Point(0, 0);
            this.rtb_server.Name = "rtb_server";
            this.rtb_server.Size = new System.Drawing.Size(800, 450);
            this.rtb_server.TabIndex = 0;
            this.rtb_server.Text = "";
            this.rtb_server.TextChanged += new System.EventHandler(this.rtb_server_TextChanged);
            // 
            // MulticastServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_server);
            this.Name = "MulticastServer";
            this.Text = "MulticastServer";
            this.Load += new System.EventHandler(this.MulticastServer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_server;
    }
}

