namespace Multicast
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
            this.rtb_client = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_client
            // 
            this.rtb_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_client.Location = new System.Drawing.Point(0, 0);
            this.rtb_client.Name = "rtb_client";
            this.rtb_client.Size = new System.Drawing.Size(800, 450);
            this.rtb_client.TabIndex = 0;
            this.rtb_client.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_client);
            this.Name = "Form1";
            this.Text = "MulticastClient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_client;
    }
}

