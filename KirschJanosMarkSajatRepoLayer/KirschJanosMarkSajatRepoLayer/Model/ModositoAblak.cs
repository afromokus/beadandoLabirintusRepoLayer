using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KirschJanosMarkSajatRepoLayer.Model
{
    class ModositoAblak : Form
    {
        private Button buttonOK;
        private Button buttonMegse;
        private TextBox textBoxAz;
        private TextBox textBoxFelhNev;
        private TextBox textBoxJelszo;
        private TextBox textBoxEmail;
        private TextBox textBoxJog;
        private TextBox textBoxSzint;
        private TextBox textBoxRegioAz;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;

        public ModositoAblak (Account account)
        {
            InitializeComponent();
            textBoxAz.Text = account.Az.ToString();
            textBoxFelhNev.Text = account.FelhNev.ToString();
            textBoxJelszo.Text = account.Jelszo.ToString();
            textBoxEmail.Text = account.EmailCim.ToString();
            textBoxJog.Text = account.Jog.ToString();
            textBoxSzint.Text = account.Szint.ToString();
            textBoxRegioAz.Text = account.Regio_az.ToString();
        }

        public TextBox TextBoxAz { get => textBoxAz; set => textBoxAz = value; }

        internal bool mindenAdatErvenyes()
        {
            return true;
        }

        public TextBox TextBoxFelhNev { get => textBoxFelhNev; set => textBoxFelhNev = value; }
        public TextBox TextBoxJelszo { get => textBoxJelszo; set => textBoxJelszo = value; }
        public TextBox TextBoxEmail { get => textBoxEmail; set => textBoxEmail = value; }
        public TextBox TextBoxJog { get => textBoxJog; set => textBoxJog = value; }
        public TextBox TextBoxSzint { get => textBoxSzint; set => textBoxSzint = value; }
        public TextBox TextBoxRegioAz { get => textBoxRegioAz; set => textBoxRegioAz = value; }

        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonMegse = new System.Windows.Forms.Button();
            this.textBoxAz = new System.Windows.Forms.TextBox();
            this.textBoxFelhNev = new System.Windows.Forms.TextBox();
            this.textBoxJelszo = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxJog = new System.Windows.Forms.TextBox();
            this.textBoxSzint = new System.Windows.Forms.TextBox();
            this.textBoxRegioAz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(78, 394);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonMegse
            // 
            this.buttonMegse.Location = new System.Drawing.Point(347, 394);
            this.buttonMegse.Name = "buttonMegse";
            this.buttonMegse.Size = new System.Drawing.Size(75, 23);
            this.buttonMegse.TabIndex = 1;
            this.buttonMegse.Text = "Mégse";
            this.buttonMegse.UseVisualStyleBackColor = true;
            // 
            // textBoxAz
            // 
            this.textBoxAz.Location = new System.Drawing.Point(222, 34);
            this.textBoxAz.Name = "textBoxAz";
            this.textBoxAz.Size = new System.Drawing.Size(223, 20);
            this.textBoxAz.TabIndex = 2;
            // 
            // textBoxFelhNev
            // 
            this.textBoxFelhNev.Location = new System.Drawing.Point(222, 82);
            this.textBoxFelhNev.Name = "textBoxFelhNev";
            this.textBoxFelhNev.Size = new System.Drawing.Size(223, 20);
            this.textBoxFelhNev.TabIndex = 2;
            // 
            // textBoxJelszo
            // 
            this.textBoxJelszo.Location = new System.Drawing.Point(222, 124);
            this.textBoxJelszo.Name = "textBoxJelszo";
            this.textBoxJelszo.Size = new System.Drawing.Size(223, 20);
            this.textBoxJelszo.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(222, 178);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(223, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxJog
            // 
            this.textBoxJog.Location = new System.Drawing.Point(222, 226);
            this.textBoxJog.Name = "textBoxJog";
            this.textBoxJog.Size = new System.Drawing.Size(223, 20);
            this.textBoxJog.TabIndex = 2;
            // 
            // textBoxSzint
            // 
            this.textBoxSzint.Location = new System.Drawing.Point(222, 268);
            this.textBoxSzint.Name = "textBoxSzint";
            this.textBoxSzint.Size = new System.Drawing.Size(223, 20);
            this.textBoxSzint.TabIndex = 2;
            // 
            // textBoxRegioAz
            // 
            this.textBoxRegioAz.Location = new System.Drawing.Point(222, 311);
            this.textBoxRegioAz.Name = "textBoxRegioAz";
            this.textBoxRegioAz.Size = new System.Drawing.Size(223, 20);
            this.textBoxRegioAz.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Azonosító:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Felhasználónév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jelszó";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail cím";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Jogosultság:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Szint:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Régió azonosítója:";
            // 
            // ModositoAblak
            // 
            this.ClientSize = new System.Drawing.Size(549, 459);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRegioAz);
            this.Controls.Add(this.textBoxSzint);
            this.Controls.Add(this.textBoxJog);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxJelszo);
            this.Controls.Add(this.textBoxFelhNev);
            this.Controls.Add(this.textBoxAz);
            this.Controls.Add(this.buttonMegse);
            this.Controls.Add(this.buttonOK);
            this.Name = "ModositoAblak";
            this.Text = "Fiók módosítása";
            this.Load += new System.EventHandler(this.ModositoAblak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ModositoAblak_Load(object sender, EventArgs e)
        {

        }
    }
}
