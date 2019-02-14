namespace KirschJanosMarkSajatRepoLayer
{
    partial class FormAccountok
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
            this.adatracsMegjelenito = new System.Windows.Forms.DataGridView();
            this.gombBetoltes = new System.Windows.Forms.Button();
            this.gombUj = new System.Windows.Forms.Button();
            this.gombModosit = new System.Windows.Forms.Button();
            this.gombTorles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adatracsMegjelenito)).BeginInit();
            this.SuspendLayout();
            // 
            // adatracsMegjelenito
            // 
            this.adatracsMegjelenito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adatracsMegjelenito.Location = new System.Drawing.Point(30, 37);
            this.adatracsMegjelenito.Name = "adatracsMegjelenito";
            this.adatracsMegjelenito.Size = new System.Drawing.Size(741, 299);
            this.adatracsMegjelenito.TabIndex = 0;
            // 
            // gombBetoltes
            // 
            this.gombBetoltes.Location = new System.Drawing.Point(924, 68);
            this.gombBetoltes.Name = "gombBetoltes";
            this.gombBetoltes.Size = new System.Drawing.Size(75, 23);
            this.gombBetoltes.TabIndex = 1;
            this.gombBetoltes.Text = "Betöltés";
            this.gombBetoltes.UseVisualStyleBackColor = true;
            this.gombBetoltes.Click += new System.EventHandler(this.gombBetoltes_Click);
            // 
            // gombUj
            // 
            this.gombUj.Location = new System.Drawing.Point(924, 120);
            this.gombUj.Name = "gombUj";
            this.gombUj.Size = new System.Drawing.Size(75, 23);
            this.gombUj.TabIndex = 1;
            this.gombUj.Text = "Új";
            this.gombUj.UseVisualStyleBackColor = true;
            this.gombUj.Click += new System.EventHandler(this.gombUj_Click);
            // 
            // gombModosit
            // 
            this.gombModosit.Location = new System.Drawing.Point(924, 173);
            this.gombModosit.Name = "gombModosit";
            this.gombModosit.Size = new System.Drawing.Size(75, 23);
            this.gombModosit.TabIndex = 1;
            this.gombModosit.Text = "Módosít";
            this.gombModosit.UseVisualStyleBackColor = true;
            this.gombModosit.Click += new System.EventHandler(this.gombModosit_Click);
            // 
            // gombTorles
            // 
            this.gombTorles.Location = new System.Drawing.Point(924, 228);
            this.gombTorles.Name = "gombTorles";
            this.gombTorles.Size = new System.Drawing.Size(75, 23);
            this.gombTorles.TabIndex = 1;
            this.gombTorles.Text = "Törlés";
            this.gombTorles.UseVisualStyleBackColor = true;
            this.gombTorles.Click += new System.EventHandler(this.gombTorles_Click);
            // 
            // FormAccountok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 418);
            this.Controls.Add(this.gombTorles);
            this.Controls.Add(this.gombModosit);
            this.Controls.Add(this.gombUj);
            this.Controls.Add(this.gombBetoltes);
            this.Controls.Add(this.adatracsMegjelenito);
            this.Name = "FormAccountok";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adatracsMegjelenito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adatracsMegjelenito;
        private System.Windows.Forms.Button gombBetoltes;
        private System.Windows.Forms.Button gombUj;
        private System.Windows.Forms.Button gombModosit;
        private System.Windows.Forms.Button gombTorles;
    }
}

