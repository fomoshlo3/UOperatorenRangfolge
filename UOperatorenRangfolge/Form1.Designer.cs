namespace UOperatorenRangfolge
{
    partial class MainForm
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
            this.CmdAnzeigen1 = new System.Windows.Forms.Button();
            this.CmdAnzeigen2 = new System.Windows.Forms.Button();
            this.CmdAnzeigen3 = new System.Windows.Forms.Button();
            this.CmdAnzeigen4 = new System.Windows.Forms.Button();
            this.CmdBeenden = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            this.CmdAnzeigen1.Location = new System.Drawing.Point(387, 23);
            this.CmdAnzeigen1.Name = "CmdAnzeigen1";
            this.CmdAnzeigen1.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen1.TabIndex = 0;
            this.CmdAnzeigen1.Text = "Anzeigen1";
            this.CmdAnzeigen1.UseVisualStyleBackColor = true;
            this.CmdAnzeigen1.Click += new System.EventHandler(this.CmdAnzeigen1_Click);
            // 
            // CmdAnzeigen2
            // 
            this.CmdAnzeigen2.Location = new System.Drawing.Point(387, 52);
            this.CmdAnzeigen2.Name = "CmdAnzeigen2";
            this.CmdAnzeigen2.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen2.TabIndex = 1;
            this.CmdAnzeigen2.Text = "Anzeigen2";
            this.CmdAnzeigen2.UseVisualStyleBackColor = true;
            this.CmdAnzeigen2.Click += new System.EventHandler(this.CmdAnzeigen2_Click);
            // 
            // CmdAnzeigen3
            // 
            this.CmdAnzeigen3.Location = new System.Drawing.Point(387, 81);
            this.CmdAnzeigen3.Name = "CmdAnzeigen3";
            this.CmdAnzeigen3.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen3.TabIndex = 2;
            this.CmdAnzeigen3.Text = "Anzeigen3";
            this.CmdAnzeigen3.UseVisualStyleBackColor = true;
            this.CmdAnzeigen3.Click += new System.EventHandler(this.CmdAnzeigen3_Click);
            // 
            // CmdAnzeigen4
            // 
            this.CmdAnzeigen4.Location = new System.Drawing.Point(387, 110);
            this.CmdAnzeigen4.Name = "CmdAnzeigen4";
            this.CmdAnzeigen4.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen4.TabIndex = 3;
            this.CmdAnzeigen4.Text = "Anzeigen4";
            this.CmdAnzeigen4.UseVisualStyleBackColor = true;
            this.CmdAnzeigen4.Click += new System.EventHandler(this.CmdAnzeigen4_Click);
            // 
            // CmdBeenden
            // 
            this.CmdBeenden.Location = new System.Drawing.Point(387, 153);
            this.CmdBeenden.Name = "CmdBeenden";
            this.CmdBeenden.Size = new System.Drawing.Size(75, 23);
            this.CmdBeenden.TabIndex = 4;
            this.CmdBeenden.Text = "Beenden";
            this.CmdBeenden.UseVisualStyleBackColor = true;
            this.CmdBeenden.Click += new System.EventHandler(this.CmdBeenden_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 27);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(34, 15);
            this.LblAnzeige.TabIndex = 5;
            this.LblAnzeige.Text = "(leer)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 191);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdBeenden);
            this.Controls.Add(this.CmdAnzeigen4);
            this.Controls.Add(this.CmdAnzeigen3);
            this.Controls.Add(this.CmdAnzeigen2);
            this.Controls.Add(this.CmdAnzeigen1);
            this.Name = "MainForm";
            this.Text = "UOperatorenRangfolge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdAnzeigen1;
        private Button CmdAnzeigen2;
        private Button CmdAnzeigen3;
        private Button CmdAnzeigen4;
        private Button CmdBeenden;
        private Label LblAnzeige;
    }
}