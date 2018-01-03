using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public enum KETTHUC
    {
        HoaCo,
        Player1,
        Player2,
        COM,
    }
    class CaroChess
    {
        public static Pen pen;
        public static SolidBrush sbRed;
        public static SolidBrush sbBlack;
        public static SolidBrush sbXoa;
        public static SolidBrush sbKey;
        private BanCo _BanCo;
        private OCo[,] _MangOCo;
        private Stack<OCo> stk_CacNuocDaDi;
        private Stack<OCo> stk_CacNuocUndo;
        private int _LuotDi;
        private bool _SangSang;
        private KETTHUC _ketThuc;
        private  int DongHT=-1;
        private  int CotHT=-1;

        public bool SangSang
        {
            get { return _SangSang; }
        }
        public CaroChess()
        {
            pen = new Pen(Color.CornflowerBlue);
            sbBlack = new SolidBrush(Color.Black);
            sbRed = new SolidBrush(Color.Red);
            sbXoa = new SolidBrush(Color.White);
            sbKey = new SolidBrush(Color.Blue);
            _BanCo = new BanCo(20, 20);
            _MangOCo = new OCo[_BanCo.SoDong, _BanCo.SoCot];
            stk_CacNuocDaDi = new Stack<OCo>();
            stk_CacNuocUndo = new Stack<OCo>();
            _LuotDi = 1;
        }
        public void VeBanCo(Graphics g)
        {
            _BanCo.VeBanCo(g); 
        }
        public void KhoiTaoMangOCo()
        {
            for (int i = 0; i < _BanCo.SoDong; i++)
            {
                for (int j = 0; j < _BanCo.SoCot; j++)
                {
                    _MangOCo[i,j]=new OCo(i,j,new Point(j*OCo._ChieuRong,i*OCo._ChieuCao),0);
                }
            }
        }
        //tiến hành đánh cờ, nhận vào vị trí trỏ chuột và cọ vẽ
        public bool DanhCo(int MouseX,int MouseY,Graphics g)
        {
            //kiểm tra các đường vạch thì k đánh đc
            if (MouseX % OCo._ChieuRong == 0 || MouseY % OCo._ChieuCao == 0)
            {
                return false;
            }
            //tính ra ô cờ từ vị trí trỏ chuột
            int Cot = MouseX / OCo._ChieuRong;
            int Dong = MouseY / OCo._ChieuCao;
            if (_MangOCo[Dong, Cot].SoHuu != 0)
                return false;
            switch (_LuotDi)
            {
                case 1:
                    {
                        _MangOCo[Dong, Cot].SoHuu = 1;
                        _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, sbBlack);
                        _LuotDi = 2;
                  
                        break;
                    }
                   
                case 2:
                     {
                        _MangOCo[Dong, Cot].SoHuu = 2;
                        _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, sbRed);
                        _LuotDi = 1;
                
                        break;
                    }

                default:
                    MessageBox.Show("Error!");
                    break;
            }

            //tiến hành vẽ quân cờ tương ứng , gọi hàm vẽ quân cờ
            //lưu quân cờ đã đi vào stack cho undo , redo và vẽ quân cờ
            ////////////stk_CacNuocDaDi.Push(_MangOCo[Dong, Cot])////////;-->nên tạo mới vùng nhớ
            //tránh lỗi sử dụng cùng vùng nhớ khi undo và redo
            stk_CacNuocUndo = new Stack<OCo>();
            OCo oco=new OCo(_MangOCo[Dong, Cot].Dong,_MangOCo[Dong, Cot].Cot,_MangOCo[Dong, Cot].ViTri,_MangOCo[Dong, Cot].SoHuu);
            stk_CacNuocDaDi.Push(oco);
            
            
            
            
            return true;
        }
        public void VeLaiQuanCo(Graphics g)
        {
            foreach (OCo oco in stk_CacNuocDaDi)
            {
                if (oco.SoHuu == 1)
                {
                    _BanCo.VeQuanCo(g, oco.ViTri, sbBlack);
                }
                else if (oco.SoHuu == 2)
                {
                    _BanCo.VeQuanCo(g, oco.ViTri, sbRed);
                }
                
            }
        }
        //chơi mới chế độ pvp
        public void StartPlayervsPlayer(Graphics g)
        {
            
            _SangSang = true;
            stk_CacNuocDaDi = new Stack<OCo>();
            KhoiTaoMangOCo();
            stk_CacNuocUndo = new Stack<OCo>();
            _LuotDi = 1;
            VeBanCo(g);
            
        }
        public void Undo(Graphics g)
        {
            if (stk_CacNuocDaDi.Count != 0)
            {
                //lấy quân cờ ra khỏi stack
                OCo oco = stk_CacNuocDaDi.Pop();
                //thêm quân cờ đã lấy vào redo
                stk_CacNuocUndo.Push(new OCo(oco.Dong, oco.Cot, oco.ViTri, oco.SoHuu));
                _MangOCo[oco.Dong, oco.Cot].SoHuu = 0;
                _BanCo.XoaQuanCo(g,oco.ViTri,sbXoa);
                //quay lai luot choi cua ng choi trc
                if (_LuotDi == 1)
                    _LuotDi = 2;
                else
                    _LuotDi = 1;
              
            }
        //    VeBanCo(g);
         //   VeLaiQuanCo(g);
        }
        public void Redo(Graphics g)
        {
            if (stk_CacNuocUndo.Count != 0)
            {
                //lấy 1 quân cờ đã ra từ stack redo
                OCo oco = stk_CacNuocUndo.Pop();
                //tạo mới vùng nhớ lưu vào stack cacnuocdadi 
                stk_CacNuocDaDi.Push(new OCo(oco.Dong, oco.Cot, oco.ViTri, oco.SoHuu));

                _BanCo.VeQuanCo(g, oco.ViTri, oco.SoHuu == 1 ? sbBlack : sbRed);
                if (_LuotDi == 1)
                    _LuotDi = 2;
                else
                    _LuotDi = 1;
            }

        }
        #region Duyet Chien Thang
        public void KetThucTroChoi()
        {
            switch (_ketThuc)
            {
                case KETTHUC.HoaCo:
                    MessageBox.Show("Hòa Cờ Rồi!");
                    break;
                case KETTHUC.Player1:
                    MessageBox.Show("Quân Đen (P1) Chiến Thắng!");
                    break;
                case KETTHUC.Player2:
                    MessageBox.Show("Quân Đỏ (P2) Chiến Thắng!");
                    break;
                case KETTHUC.COM:
                    MessageBox.Show("Computer Chiến Thắng!");
                    break;
            }
            _SangSang = false;
        }
        public bool KiemTraChienThang()
        {

            if (stk_CacNuocDaDi.Count == _BanCo.SoCot * _BanCo.SoDong)
            {
                _ketThuc = KETTHUC.HoaCo;
                return true;
            }
            foreach (OCo oco in stk_CacNuocDaDi)
            {
                if (DuyetDoc(oco.Dong, oco.Cot, oco.SoHuu)||DuyetNgang(oco.Dong, oco.Cot, oco.SoHuu)||DuyetCheoXuoi(oco.Dong, oco.Cot, oco.SoHuu)||DuyetCheoNguoc(oco.Dong, oco.Cot, oco.SoHuu))
                {
                    _ketThuc = oco.SoHuu == 1 ? KETTHUC.Player1 : KETTHUC.Player2;
                    return true;
                }
              
            }


            return false;
        }
        private bool DuyetDoc(int currDong,int currCot,int crrSoHuu)
        {
            if (currDong > _BanCo.SoDong - 5)
            {
                return false;
            }
            int Dem;
            //xét đã đủ 5 quân cùng 1 cột chưa
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[currDong+Dem, currCot].SoHuu != crrSoHuu)
                {
                    return false;
                }
            }
            //nếu đã đủ 5 quân cùng 1 cột xét tiếp xem có chặn 2 đầu hay k
            if (currDong == 0)//5 quân cột đầu tiên k thể chăn đc 2 đâu -> thắng
            {
                return true;
            }
            if (currDong +Dem== _BanCo.SoDong)//đủ 5 quân biên dưới k thể chặn 2 đầu -> thắng
            {
                return true;
            }
            //khi 2 đầu k có quân nào chặn ->thắng
            if(_MangOCo[currDong-1,currCot].SoHuu==0||_MangOCo[currDong+Dem,currCot].SoHuu==0)
            {
                return true;
            }

                return false;
        }
        private bool DuyetNgang(int currDong, int currCot, int crrSoHuu)
        {
            if (currCot > _BanCo.SoCot - 5)
            {
                return false;
            }
            int Dem;
            //xét đã đủ 5 quân cùng 1 dòng chưa
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[currDong, currCot+Dem].SoHuu != crrSoHuu)
                {
                    return false;
                }
            }
            //nếu đã đủ 5 quân cùng 1 dòng xét tiếp xem có chặn 2 đầu hay k
            if (currCot == 0)
            {
                return true;
            }
            if (currCot + Dem == _BanCo.SoCot)
            {
                return true;
            }
            //khi 2 đầu k có quân nào chặn ->thắng
            if (_MangOCo[currDong, currCot - 1].SoHuu == 0 || _MangOCo[currDong, currCot + Dem].SoHuu == 0)
            {
                return true;
            }

            return false;
        }
        private bool DuyetCheoXuoi(int currDong, int currCot, int crrSoHuu)
        {
            if (currDong>_BanCo.SoDong-5|| currCot > _BanCo.SoCot - 5)
            {
                return false;
            }
            int Dem;
  
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[currDong+Dem, currCot + Dem].SoHuu != crrSoHuu)
                {
                    return false;
                }
            }
         
            if (currDong==0|| currCot == 0)
            {
                return true;
            }
            if (currDong+Dem==_BanCo.SoDong|| currCot + Dem == _BanCo.SoCot)
            {
                return true;
            }

            if (_MangOCo[currDong-1, currCot - 1].SoHuu == 0 || _MangOCo[currDong+Dem, currCot + Dem].SoHuu == 0)
            {
                return true;
            }

            return false;
        }
        private bool DuyetCheoNguoc(int currDong, int currCot, int crrSoHuu)
        {
            //Dòng <4 thì k có cơ hội chiến thắng
            if (currDong<4|| currCot > _BanCo.SoCot - 5)
            {
                return false;
            }
            int Dem;
            //Khi xét chéo ngược thì d òng sẽ giảm nhưng cột sẽ tăng
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[currDong-Dem, currCot + Dem].SoHuu != crrSoHuu)
                {
                    return false;
                }
            }
            //không thể chăn 2 đầu được--> thắng// xét theo dòng và cả cột
            if (currDong == 4 || currDong == _BanCo.SoDong - 1||currCot==0||currCot==_BanCo.SoCot-1) 
            {
                return true;
            }
            //xét 2 đầu ngoài xem có bị chăn hay không --Xét theo dòng
            if (_MangOCo[currDong+1, currCot - 1].SoHuu == 0 || _MangOCo[currDong-Dem, currCot + Dem].SoHuu == 0)
            {
                return true;
            }


            return false;
        }
        #endregion
        public void QuanCoHienTai(int MouseX, int MouseY, Graphics g)
        {
            if (MouseX % OCo._ChieuRong == 0 || MouseY % OCo._ChieuCao == 0)
            {
                return ;
            }
            if ((MouseX > 500 || MouseY > 500 || MouseX < 0 || MouseY < 0) && (CotHT != -1 || DongHT != -1)) 
            {
                XoaCoKhiRaNgoai(DongHT, CotHT, g);
            }
            int Cot = MouseX / OCo._ChieuRong;
            int Dong = MouseY / OCo._ChieuCao;
            if (DongHT != -1 || CotHT != -1)
            {
                if ((Cot != CotHT || Dong != DongHT) &&  _MangOCo[DongHT, CotHT].SoHuu == 0)
                {
                    _BanCo.XoaQuanCo(g, _MangOCo[DongHT, CotHT].ViTri, sbXoa);
                    DongHT = Dong;
                    CotHT = Cot;
                }
            }
            DongHT =Dong;
            CotHT = Cot;
            if (_MangOCo[Dong, Cot].SoHuu != 0)
                return ;
            switch (_LuotDi)
            {
                case 1:
                    {
                        _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, sbBlack);    
                   
                        break;
                    }
                case 2:
                    {
                        _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, sbRed);
                        break;
                    }
                    
            }
        }
        public void XoaCoKhiRaNgoai(int MouseX, int MouseY, Graphics g)
        {

            _BanCo.XoaQuanCo(g, _MangOCo[DongHT, CotHT].ViTri, sbXoa);
            DongHT = CotHT = -1;
        }

    }
}
