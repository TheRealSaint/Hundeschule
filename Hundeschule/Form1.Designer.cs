namespace Hundeschule
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add_dog = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_status_anzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_dog
            // 
            this.btn_add_dog.Location = new System.Drawing.Point(13, 12);
            this.btn_add_dog.Name = "btn_add_dog";
            this.btn_add_dog.Size = new System.Drawing.Size(75, 37);
            this.btn_add_dog.TabIndex = 0;
            this.btn_add_dog.Text = "Hund hinzufügen";
            this.btn_add_dog.UseVisualStyleBackColor = true;
            this.btn_add_dog.Click += new System.EventHandler(this.btn_add_dog_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(94, 6);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(981, 433);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_status_anzeigen
            // 
            this.btn_status_anzeigen.Location = new System.Drawing.Point(12, 55);
            this.btn_status_anzeigen.Name = "btn_status_anzeigen";
            this.btn_status_anzeigen.Size = new System.Drawing.Size(75, 37);
            this.btn_status_anzeigen.TabIndex = 2;
            this.btn_status_anzeigen.Text = "Status anzeigen";
            this.btn_status_anzeigen.UseVisualStyleBackColor = true;
            this.btn_status_anzeigen.Click += new System.EventHandler(this.btn_status_anzeigen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.btn_status_anzeigen);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_add_dog);
            this.Name = "Form1";
            this.Text = "Trainingsplatz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_dog;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_status_anzeigen;
    }
}

