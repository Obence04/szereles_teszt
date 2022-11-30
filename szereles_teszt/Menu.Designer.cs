namespace szereles_teszt
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BTN_OS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_OS
            // 
            this.BTN_OS.Location = new System.Drawing.Point(12, 12);
            this.BTN_OS.Name = "BTN_OS";
            this.BTN_OS.Size = new System.Drawing.Size(75, 50);
            this.BTN_OS.TabIndex = 0;
            this.BTN_OS.Text = "Osztott sugár";
            this.BTN_OS.UseVisualStyleBackColor = true;
            this.BTN_OS.Click += new System.EventHandler(this.BTN_OS_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(270, 232);
            this.Controls.Add(this.BTN_OS);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menü";
            this.ResumeLayout(false);

        }

        #endregion
        private Button BTN_OS;
    }
}