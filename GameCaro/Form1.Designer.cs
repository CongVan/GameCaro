namespace GameCaro
{
    partial class frmCoCaro
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsComToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlayervsPlayer = new System.Windows.Forms.Button();
            this.btnPlayervsCom = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChoiMoi = new System.Windows.Forms.Button();
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.pnlChuChay = new System.Windows.Forms.Panel();
            this.lblChuChay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmChuChay = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlChuChay.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerToolStripMenuItem,
            this.playerVsComToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            this.playerVsPlayerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.playerVsPlayerToolStripMenuItem.Text = "Player vs Player";
            this.playerVsPlayerToolStripMenuItem.Click += new System.EventHandler(this.PvsP);
            // 
            // playerVsComToolStripMenuItem
            // 
            this.playerVsComToolStripMenuItem.Name = "playerVsComToolStripMenuItem";
            this.playerVsComToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.playerVsComToolStripMenuItem.Text = "Player vs Com";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GameCaro.Properties.Resources._1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 170);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlayervsPlayer
            // 
            this.btnPlayervsPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayervsPlayer.Location = new System.Drawing.Point(12, 407);
            this.btnPlayervsPlayer.Name = "btnPlayervsPlayer";
            this.btnPlayervsPlayer.Size = new System.Drawing.Size(188, 38);
            this.btnPlayervsPlayer.TabIndex = 4;
            this.btnPlayervsPlayer.Text = "Player vs Player";
            this.btnPlayervsPlayer.UseVisualStyleBackColor = true;
            this.btnPlayervsPlayer.Click += new System.EventHandler(this.btnPlayervsPlayer_Click);
            // 
            // btnPlayervsCom
            // 
            this.btnPlayervsCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayervsCom.Location = new System.Drawing.Point(12, 451);
            this.btnPlayervsCom.Name = "btnPlayervsCom";
            this.btnPlayervsCom.Size = new System.Drawing.Size(188, 36);
            this.btnPlayervsCom.TabIndex = 5;
            this.btnPlayervsCom.Text = "Player vs Com";
            this.btnPlayervsCom.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(12, 505);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 33);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnChoiMoi
            // 
            this.btnChoiMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiMoi.Location = new System.Drawing.Point(119, 505);
            this.btnChoiMoi.Name = "btnChoiMoi";
            this.btnChoiMoi.Size = new System.Drawing.Size(85, 33);
            this.btnChoiMoi.TabIndex = 7;
            this.btnChoiMoi.Text = "Chơi Mới";
            this.btnChoiMoi.UseVisualStyleBackColor = true;
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.BackColor = System.Drawing.Color.White;
            this.pnlBanCo.Location = new System.Drawing.Point(222, 38);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(500, 500);
            this.pnlBanCo.TabIndex = 0;
            this.pnlBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanCo_Paint);
            this.pnlBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBanCo_MouseClick);
            this.pnlBanCo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBanCo_MouseMove);
            // 
            // pnlChuChay
            // 
            this.pnlChuChay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChuChay.CausesValidation = false;
            this.pnlChuChay.Controls.Add(this.lblChuChay);
            this.pnlChuChay.Location = new System.Drawing.Point(14, 246);
            this.pnlChuChay.Name = "pnlChuChay";
            this.pnlChuChay.Size = new System.Drawing.Size(186, 155);
            this.pnlChuChay.TabIndex = 3;
            // 
            // lblChuChay
            // 
            this.lblChuChay.AutoSize = true;
            this.lblChuChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuChay.Location = new System.Drawing.Point(3, 145);
            this.lblChuChay.Name = "lblChuChay";
            this.lblChuChay.Size = new System.Drawing.Size(12, 16);
            this.lblChuChay.TabIndex = 0;
            this.lblChuChay.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Luật Chơi";
            // 
            // tmChuChay
            // 
            this.tmChuChay.Interval = 25;
            this.tmChuChay.Tick += new System.EventHandler(this.tmChuChay_Tick);
            // 
            // frmCoCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(744, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlChuChay);
            this.Controls.Add(this.pnlBanCo);
            this.Controls.Add(this.btnChoiMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPlayervsCom);
            this.Controls.Add(this.btnPlayervsPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmCoCaro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ Caro";
            this.Load += new System.EventHandler(this.frmCoCaro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlChuChay.ResumeLayout(false);
            this.pnlChuChay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsComToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlayervsPlayer;
        private System.Windows.Forms.Button btnPlayervsCom;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChoiMoi;
        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.Panel pnlChuChay;
        private System.Windows.Forms.Label lblChuChay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmChuChay;
    }
}

