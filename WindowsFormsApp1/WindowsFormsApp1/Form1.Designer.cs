namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.btnUpisKnjiga = new System.Windows.Forms.Button();
            this.btnUpisKorisnika = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnUpisStanja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpisKnjiga
            // 
            this.btnUpisKnjiga.Location = new System.Drawing.Point(12, 19);
            this.btnUpisKnjiga.Name = "btnUpisKnjiga";
            this.btnUpisKnjiga.Size = new System.Drawing.Size(138, 93);
            this.btnUpisKnjiga.TabIndex = 0;
            this.btnUpisKnjiga.Text = "Upis Knjiga";
            this.btnUpisKnjiga.UseVisualStyleBackColor = true;
            this.btnUpisKnjiga.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpisKorisnika
            // 
            this.btnUpisKorisnika.Location = new System.Drawing.Point(300, 19);
            this.btnUpisKorisnika.Name = "btnUpisKorisnika";
            this.btnUpisKorisnika.Size = new System.Drawing.Size(138, 93);
            this.btnUpisKorisnika.TabIndex = 1;
            this.btnUpisKorisnika.Text = "Upis korisnika";
            this.btnUpisKorisnika.UseVisualStyleBackColor = true;
            this.btnUpisKorisnika.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnUpisStanja
            // 
            this.btnUpisStanja.Location = new System.Drawing.Point(156, 19);
            this.btnUpisStanja.Name = "btnUpisStanja";
            this.btnUpisStanja.Size = new System.Drawing.Size(138, 93);
            this.btnUpisStanja.TabIndex = 2;
            this.btnUpisStanja.Text = "Upis stanja";
            this.btnUpisStanja.UseVisualStyleBackColor = true;
            this.btnUpisStanja.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 149);
            this.Controls.Add(this.btnUpisStanja);
            this.Controls.Add(this.btnUpisKorisnika);
            this.Controls.Add(this.btnUpisKnjiga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpisKnjiga;
        private System.Windows.Forms.Button btnUpisKorisnika;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnUpisStanja;
    }
}

