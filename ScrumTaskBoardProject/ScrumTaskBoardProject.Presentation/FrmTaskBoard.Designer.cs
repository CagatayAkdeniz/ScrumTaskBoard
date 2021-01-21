namespace ScrumTaskBoardProject.Presentation
{
    partial class FrmTaskBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgwToDo = new System.Windows.Forms.DataGridView();
            this.dgwInProgress = new System.Windows.Forms.DataGridView();
            this.dgwRevision = new System.Windows.Forms.DataGridView();
            this.dgwCheck = new System.Windows.Forms.DataGridView();
            this.dgwDone = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRevision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(239, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(814, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "In Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1446, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Revision";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(527, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Check";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1155, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Done";
            // 
            // dgwToDo
            // 
            this.dgwToDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwToDo.Location = new System.Drawing.Point(13, 59);
            this.dgwToDo.Name = "dgwToDo";
            this.dgwToDo.Size = new System.Drawing.Size(551, 292);
            this.dgwToDo.TabIndex = 5;
            this.dgwToDo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwToDo_CellDoubleClick);
            // 
            // dgwInProgress
            // 
            this.dgwInProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwInProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInProgress.Location = new System.Drawing.Point(598, 59);
            this.dgwInProgress.Name = "dgwInProgress";
            this.dgwInProgress.Size = new System.Drawing.Size(551, 292);
            this.dgwInProgress.TabIndex = 6;
            this.dgwInProgress.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwInProgress_CellDoubleClick);
            // 
            // dgwRevision
            // 
            this.dgwRevision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRevision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRevision.Location = new System.Drawing.Point(1183, 59);
            this.dgwRevision.Name = "dgwRevision";
            this.dgwRevision.Size = new System.Drawing.Size(551, 292);
            this.dgwRevision.TabIndex = 7;
            this.dgwRevision.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRevision_CellDoubleClick);
            // 
            // dgwCheck
            // 
            this.dgwCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCheck.Location = new System.Drawing.Point(282, 402);
            this.dgwCheck.Name = "dgwCheck";
            this.dgwCheck.Size = new System.Drawing.Size(551, 292);
            this.dgwCheck.TabIndex = 8;
            this.dgwCheck.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCheck_CellDoubleClick);
            // 
            // dgwDone
            // 
            this.dgwDone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDone.Location = new System.Drawing.Point(868, 402);
            this.dgwDone.Name = "dgwDone";
            this.dgwDone.Size = new System.Drawing.Size(551, 292);
            this.dgwDone.TabIndex = 9;
            this.dgwDone.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDone_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cyan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(447, 735);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(853, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum Bilgisini Güncelleyeceğiniz Task\'ın üzerine 2 kere basınız";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(12, 735);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(238, 33);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ana Menüye Dön";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmTaskBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1745, 788);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgwDone);
            this.Controls.Add(this.dgwCheck);
            this.Controls.Add(this.dgwRevision);
            this.Controls.Add(this.dgwInProgress);
            this.Controls.Add(this.dgwToDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTaskBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskBoard";
            this.Load += new System.EventHandler(this.FrmTaskBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRevision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwToDo;
        private System.Windows.Forms.DataGridView dgwInProgress;
        private System.Windows.Forms.DataGridView dgwRevision;
        private System.Windows.Forms.DataGridView dgwCheck;
        private System.Windows.Forms.DataGridView dgwDone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}