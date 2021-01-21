namespace ScrumTaskBoardProject.Presentation
{
    partial class FrmAnaMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProjeListe = new System.Windows.Forms.Button();
            this.btnProjeEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKullaniciListe = new System.Windows.Forms.Button();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTaskGuncelle = new System.Windows.Forms.Button();
            this.btnTaskList = new System.Windows.Forms.Button();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaskBoard = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProjeListe);
            this.groupBox1.Controls.Add(this.btnProjeEkle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proje İşlemleri";
            // 
            // btnProjeListe
            // 
            this.btnProjeListe.Location = new System.Drawing.Point(73, 89);
            this.btnProjeListe.Name = "btnProjeListe";
            this.btnProjeListe.Size = new System.Drawing.Size(139, 29);
            this.btnProjeListe.TabIndex = 1;
            this.btnProjeListe.Text = "Proje Listesi";
            this.btnProjeListe.UseVisualStyleBackColor = true;
            this.btnProjeListe.Click += new System.EventHandler(this.btnProjeListe_Click);
            // 
            // btnProjeEkle
            // 
            this.btnProjeEkle.Location = new System.Drawing.Point(73, 41);
            this.btnProjeEkle.Name = "btnProjeEkle";
            this.btnProjeEkle.Size = new System.Drawing.Size(139, 29);
            this.btnProjeEkle.TabIndex = 0;
            this.btnProjeEkle.Text = "Proje Ekle";
            this.btnProjeEkle.UseVisualStyleBackColor = true;
            this.btnProjeEkle.Click += new System.EventHandler(this.btnProjeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKullaniciListe);
            this.groupBox2.Controls.Add(this.btnKullaniciEkle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(349, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı İşlemleri";
            // 
            // btnKullaniciListe
            // 
            this.btnKullaniciListe.Location = new System.Drawing.Point(73, 89);
            this.btnKullaniciListe.Name = "btnKullaniciListe";
            this.btnKullaniciListe.Size = new System.Drawing.Size(139, 29);
            this.btnKullaniciListe.TabIndex = 1;
            this.btnKullaniciListe.Text = "Kullanıcı Listesi";
            this.btnKullaniciListe.UseVisualStyleBackColor = true;
            this.btnKullaniciListe.Click += new System.EventHandler(this.btnKullaniciListe_Click);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(73, 41);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(139, 29);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTaskGuncelle);
            this.groupBox3.Controls.Add(this.btnTaskList);
            this.groupBox3.Controls.Add(this.btnTaskEkle);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(58, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Task İşlemleri";
            // 
            // btnTaskGuncelle
            // 
            this.btnTaskGuncelle.Location = new System.Drawing.Point(118, 68);
            this.btnTaskGuncelle.Name = "btnTaskGuncelle";
            this.btnTaskGuncelle.Size = new System.Drawing.Size(139, 29);
            this.btnTaskGuncelle.TabIndex = 2;
            this.btnTaskGuncelle.Text = "Task Güncelle";
            this.btnTaskGuncelle.UseVisualStyleBackColor = true;
            this.btnTaskGuncelle.Click += new System.EventHandler(this.btnTaskGuncelle_Click);
            // 
            // btnTaskList
            // 
            this.btnTaskList.Location = new System.Drawing.Point(118, 103);
            this.btnTaskList.Name = "btnTaskList";
            this.btnTaskList.Size = new System.Drawing.Size(139, 29);
            this.btnTaskList.TabIndex = 1;
            this.btnTaskList.Text = "Task Listesi";
            this.btnTaskList.UseVisualStyleBackColor = true;
            this.btnTaskList.Click += new System.EventHandler(this.btnTaskList_Click);
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Location = new System.Drawing.Point(118, 33);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(139, 29);
            this.btnTaskEkle.TabIndex = 0;
            this.btnTaskEkle.Text = "Task Ekle";
            this.btnTaskEkle.UseVisualStyleBackColor = true;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(154, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proje-Task Takip";
            // 
            // btnTaskBoard
            // 
            this.btnTaskBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaskBoard.Location = new System.Drawing.Point(447, 295);
            this.btnTaskBoard.Name = "btnTaskBoard";
            this.btnTaskBoard.Size = new System.Drawing.Size(184, 60);
            this.btnTaskBoard.TabIndex = 4;
            this.btnTaskBoard.Text = "TASKBOARD";
            this.btnTaskBoard.UseVisualStyleBackColor = true;
            this.btnTaskBoard.Click += new System.EventHandler(this.btnTaskBoard_Click);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(660, 417);
            this.Controls.Add(this.btnTaskBoard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAnaMenu_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProjeListe;
        private System.Windows.Forms.Button btnProjeEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKullaniciListe;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTaskList;
        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaskGuncelle;
        private System.Windows.Forms.Button btnTaskBoard;
    }
}

