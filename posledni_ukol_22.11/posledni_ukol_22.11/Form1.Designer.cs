namespace posledni_ukol_22._11
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vstup = new System.Windows.Forms.TextBox();
            this.hledat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vstup
            // 
            this.vstup.Location = new System.Drawing.Point(13, 13);
            this.vstup.Multiline = true;
            this.vstup.Name = "vstup";
            this.vstup.Size = new System.Drawing.Size(100, 119);
            this.vstup.TabIndex = 0;
            // 
            // hledat
            // 
            this.hledat.Location = new System.Drawing.Point(120, 13);
            this.hledat.Name = "hledat";
            this.hledat.Size = new System.Drawing.Size(75, 23);
            this.hledat.TabIndex = 1;
            this.hledat.Text = "Hledat";
            this.hledat.UseVisualStyleBackColor = true;
            this.hledat.Click += new System.EventHandler(this.hledat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 143);
            this.Controls.Add(this.hledat);
            this.Controls.Add(this.vstup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Poslední úkol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vstup;
        private System.Windows.Forms.Button hledat;
    }
}

