namespace szereles_teszt
{
    partial class Osztott
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Osztott));
            this.LB_Kerdes = new System.Windows.Forms.Label();
            this.BTN_Btomlo = new System.Windows.Forms.Button();
            this.BTN_Ctomlo = new System.Windows.Forms.Button();
            this.BTN_Sugarcso = new System.Windows.Forms.Button();
            this.BTN_Oszto = new System.Windows.Forms.Button();
            this.BTN_Torol = new System.Windows.Forms.Button();
            this.BTN_Ellenorzes = new System.Windows.Forms.Button();
            this.LB_Valasz = new System.Windows.Forms.Label();
            this.LB_Visszajelzes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_Kerdes
            // 
            this.LB_Kerdes.AutoSize = true;
            this.LB_Kerdes.Location = new System.Drawing.Point(93, 12);
            this.LB_Kerdes.MinimumSize = new System.Drawing.Size(205, 23);
            this.LB_Kerdes.Name = "LB_Kerdes";
            this.LB_Kerdes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_Kerdes.Size = new System.Drawing.Size(205, 23);
            this.LB_Kerdes.TabIndex = 0;
            this.LB_Kerdes.Text = "Kérdés";
            // 
            // BTN_Btomlo
            // 
            this.BTN_Btomlo.Location = new System.Drawing.Point(12, 12);
            this.BTN_Btomlo.Name = "BTN_Btomlo";
            this.BTN_Btomlo.Size = new System.Drawing.Size(75, 23);
            this.BTN_Btomlo.TabIndex = 1;
            this.BTN_Btomlo.Tag = "B_Tomlo";
            this.BTN_Btomlo.Text = "B tömlő";
            this.BTN_Btomlo.UseVisualStyleBackColor = true;
            this.BTN_Btomlo.Click += new System.EventHandler(this.BTN_Click);
            // 
            // BTN_Ctomlo
            // 
            this.BTN_Ctomlo.Location = new System.Drawing.Point(12, 41);
            this.BTN_Ctomlo.Name = "BTN_Ctomlo";
            this.BTN_Ctomlo.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ctomlo.TabIndex = 2;
            this.BTN_Ctomlo.Tag = "C_Tomlo";
            this.BTN_Ctomlo.Text = "C tömlő";
            this.BTN_Ctomlo.UseVisualStyleBackColor = true;
            this.BTN_Ctomlo.Click += new System.EventHandler(this.BTN_Click);
            // 
            // BTN_Sugarcso
            // 
            this.BTN_Sugarcso.Location = new System.Drawing.Point(12, 99);
            this.BTN_Sugarcso.Name = "BTN_Sugarcso";
            this.BTN_Sugarcso.Size = new System.Drawing.Size(75, 23);
            this.BTN_Sugarcso.TabIndex = 4;
            this.BTN_Sugarcso.Tag = "Sugarcso";
            this.BTN_Sugarcso.Text = "Sugárcső";
            this.BTN_Sugarcso.UseVisualStyleBackColor = true;
            this.BTN_Sugarcso.Click += new System.EventHandler(this.BTN_Click);
            // 
            // BTN_Oszto
            // 
            this.BTN_Oszto.Location = new System.Drawing.Point(12, 70);
            this.BTN_Oszto.Name = "BTN_Oszto";
            this.BTN_Oszto.Size = new System.Drawing.Size(75, 23);
            this.BTN_Oszto.TabIndex = 3;
            this.BTN_Oszto.Tag = "Oszto";
            this.BTN_Oszto.Text = "Osztó";
            this.BTN_Oszto.UseVisualStyleBackColor = true;
            this.BTN_Oszto.Click += new System.EventHandler(this.BTN_Click);
            // 
            // BTN_Torol
            // 
            this.BTN_Torol.Location = new System.Drawing.Point(12, 128);
            this.BTN_Torol.Name = "BTN_Torol";
            this.BTN_Torol.Size = new System.Drawing.Size(100, 23);
            this.BTN_Torol.TabIndex = 5;
            this.BTN_Torol.Text = "Válasz törlése";
            this.BTN_Torol.UseVisualStyleBackColor = true;
            this.BTN_Torol.Click += new System.EventHandler(this.Torol);
            // 
            // BTN_Ellenorzes
            // 
            this.BTN_Ellenorzes.Location = new System.Drawing.Point(12, 157);
            this.BTN_Ellenorzes.Name = "BTN_Ellenorzes";
            this.BTN_Ellenorzes.Size = new System.Drawing.Size(100, 50);
            this.BTN_Ellenorzes.TabIndex = 6;
            this.BTN_Ellenorzes.Text = "Ellenőrzés";
            this.BTN_Ellenorzes.UseVisualStyleBackColor = true;
            this.BTN_Ellenorzes.Click += new System.EventHandler(this.Ellenorzes);
            // 
            // LB_Valasz
            // 
            this.LB_Valasz.AutoSize = true;
            this.LB_Valasz.Location = new System.Drawing.Point(93, 41);
            this.LB_Valasz.MaximumSize = new System.Drawing.Size(220, 75);
            this.LB_Valasz.MinimumSize = new System.Drawing.Size(205, 81);
            this.LB_Valasz.Name = "LB_Valasz";
            this.LB_Valasz.Size = new System.Drawing.Size(205, 81);
            this.LB_Valasz.TabIndex = 7;
            this.LB_Valasz.Text = "Válasz: ";
            // 
            // LB_Visszajelzes
            // 
            this.LB_Visszajelzes.AutoSize = true;
            this.LB_Visszajelzes.BackColor = System.Drawing.Color.Gray;
            this.LB_Visszajelzes.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.LB_Visszajelzes.ForeColor = System.Drawing.Color.Orange;
            this.LB_Visszajelzes.Location = new System.Drawing.Point(118, 157);
            this.LB_Visszajelzes.MaximumSize = new System.Drawing.Size(180, 50);
            this.LB_Visszajelzes.MinimumSize = new System.Drawing.Size(180, 50);
            this.LB_Visszajelzes.Name = "LB_Visszajelzes";
            this.LB_Visszajelzes.Size = new System.Drawing.Size(180, 50);
            this.LB_Visszajelzes.TabIndex = 8;
            this.LB_Visszajelzes.Text = "Az ellenőrzéshez nyomja meg az \"Ellenőrzés\" gombot";
            this.LB_Visszajelzes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Osztott
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(310, 219);
            this.Controls.Add(this.LB_Visszajelzes);
            this.Controls.Add(this.LB_Valasz);
            this.Controls.Add(this.BTN_Ellenorzes);
            this.Controls.Add(this.BTN_Torol);
            this.Controls.Add(this.BTN_Sugarcso);
            this.Controls.Add(this.BTN_Oszto);
            this.Controls.Add(this.BTN_Ctomlo);
            this.Controls.Add(this.BTN_Btomlo);
            this.Controls.Add(this.LB_Kerdes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Osztott";
            this.Text = "Osztott sugár szerelése";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Osztott_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LB_Kerdes;
        private Button BTN_Btomlo;
        private Button BTN_Ctomlo;
        private Button BTN_Sugarcso;
        private Button BTN_Oszto;
        private Button BTN_Torol;
        private Button BTN_Ellenorzes;
        private Label LB_Valasz;
        private Label LB_Visszajelzes;
    }
}