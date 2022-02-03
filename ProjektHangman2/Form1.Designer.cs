namespace ProjektHangman2
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
            this.Unesi = new System.Windows.Forms.Button();
            this.UnosSlova = new System.Windows.Forms.TextBox();
            this.HangSlike = new System.Windows.Forms.PictureBox();
            this.Slova = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.TextBox();
            this.Spremi = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.HangSlike)).BeginInit();
            this.SuspendLayout();
            // 
            // Unesi
            // 
            this.Unesi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unesi.Location = new System.Drawing.Point(256, 361);
            this.Unesi.Name = "Unesi";
            this.Unesi.Size = new System.Drawing.Size(101, 55);
            this.Unesi.TabIndex = 0;
            this.Unesi.Text = "Unesi znak";
            this.Unesi.UseVisualStyleBackColor = true;
            this.Unesi.Click += new System.EventHandler(this.Unesi_Click);
            // 
            // UnosSlova
            // 
            this.UnosSlova.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnosSlova.Location = new System.Drawing.Point(191, 368);
            this.UnosSlova.Name = "UnosSlova";
            this.UnosSlova.Size = new System.Drawing.Size(33, 38);
            this.UnosSlova.TabIndex = 1;
            this.UnosSlova.Click += new System.EventHandler(this.Ogranicenje);
            this.UnosSlova.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Stisnut);
            // 
            // HangSlike
            // 
            this.HangSlike.Image = global::ProjektHangman2.Properties.Resources.slika4;
            this.HangSlike.Location = new System.Drawing.Point(83, 12);
            this.HangSlike.Name = "HangSlike";
            this.HangSlike.Size = new System.Drawing.Size(458, 277);
            this.HangSlike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HangSlike.TabIndex = 2;
            this.HangSlike.TabStop = false;
            // 
            // Slova
            // 
            this.Slova.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slova.Location = new System.Drawing.Point(94, 302);
            this.Slova.Name = "Slova";
            this.Slova.Size = new System.Drawing.Size(447, 38);
            this.Slova.TabIndex = 3;
            this.Slova.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(647, 12);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(100, 56);
            this.NewGame.TabIndex = 5;
            this.NewGame.Text = "New game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGameClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prezime:";
            // 
            // Prezime
            // 
            this.Prezime.Location = new System.Drawing.Point(645, 200);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(100, 20);
            this.Prezime.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ime:";
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(645, 166);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(100, 20);
            this.Ime.TabIndex = 11;
            // 
            // Spremi
            // 
            this.Spremi.Location = new System.Drawing.Point(645, 249);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(102, 40);
            this.Spremi.TabIndex = 15;
            this.Spremi.Text = "Spremi";
            this.Spremi.UseVisualStyleBackColor = true;
            this.Spremi.Click += new System.EventHandler(this.SpremiClick);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(461, 343);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(289, 95);
            this.ListBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.Spremi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.Slova);
            this.Controls.Add(this.HangSlike);
            this.Controls.Add(this.UnosSlova);
            this.Controls.Add(this.Unesi);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HangSlike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Unesi;
        private System.Windows.Forms.PictureBox HangSlike;
        private System.Windows.Forms.Label Slova;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Prezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.TextBox UnosSlova;
    }
}

