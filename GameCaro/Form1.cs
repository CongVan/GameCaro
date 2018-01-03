using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class frmCoCaro : Form
    {
        private CaroChess caroChess;
        private Graphics grs;
        public frmCoCaro()
        {

            InitializeComponent();
            caroChess=new CaroChess();
            grs = pnlBanCo.CreateGraphics();
            caroChess.KhoiTaoMangOCo();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

        private void frmCoCaro_Load(object sender, EventArgs e)
        {
            lblChuChay.Text = "Đây là luật chơi cờ caro.....\nChúc các bạn vui vẻ!!!";
            tmChuChay.Enabled = true;
        
        }
        private void pnlBanCo_Paint(object sender, PaintEventArgs e)
        {
            caroChess.VeBanCo(grs);
            caroChess.VeLaiQuanCo(grs);
        }
        private void tmChuChay_Tick(object sender, EventArgs e)
        {
            lblChuChay.Location = new Point(lblChuChay.Location.X, lblChuChay.Location.Y - 1);
            if (lblChuChay.Location.Y + pnlChuChay.Height < 50)
            {
                lblChuChay.Location = new Point(lblChuChay.Location.X, pnlChuChay.Height);
            }
        }
        //lick chuột để đánh quân cờ
        private void pnlBanCo_MouseClick(object sender, MouseEventArgs e)
        {
            //gọi hàm đánh cờ từ caroChess tham số là vị trí (x,y) và cọ vẽ
            if (!caroChess.SangSang)
            {
                return;
            }
            
            caroChess.DanhCo(e.X, e.Y, grs);
            if (caroChess.KiemTraChienThang())
            {
                caroChess.KetThucTroChoi();
            }
        }

        private void PvsP(object sender, EventArgs e)
        {
            //xóa bàn cờ giữ lại màu nền bàn cờ
            grs.Clear(pnlBanCo.BackColor);
            caroChess.StartPlayervsPlayer(grs);

        }

        private void btnPlayervsPlayer_Click(object sender, EventArgs e)
        {
            //xóa bàn cờ giữ lại màu nền bàn cờ
            grs.Clear(pnlBanCo.BackColor);
            caroChess.StartPlayervsPlayer(grs);

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // grs.Clear(pnlBanCo.BackColor);
            caroChess.Undo(grs);

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caroChess.Redo(grs);
        }

        private void pnlBanCo_MouseMove(object sender, MouseEventArgs e)
        {
            if (caroChess.SangSang)
            {
                caroChess.QuanCoHienTai(e.X, e.Y, grs);
            }
            
          //  caroChess.QuanCoHienTai(e.X, e.Y, grs);
        }

    





     

    }
}
