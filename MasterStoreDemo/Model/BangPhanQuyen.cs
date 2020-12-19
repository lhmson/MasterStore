using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MasterStoreDemo.Model
{
    public class BangPhanQuyen
    {
        public string TenNhomQuyen { get; set; }
        public bool chkNhapHang { get; set; }
        public bool chkKiemDuyetNhapHang { get; set; }
        public bool chkBanHang { get; set; }
        public bool chkKiemDuyetXuatHang { get; set; }
        public bool chkTraCuu { get; set; }
        public bool chkBCDS { get; set; }
        public bool chkBCTK { get; set; }
        public bool chkQLNS { get; set; }
        public bool EnabledCheckBox { get; set; }

        public BangPhanQuyen(string Ten, bool Enabled)
        {

            chkNhapHang = chkKiemDuyetNhapHang = chkBanHang = chkTraCuu = chkBCDS = chkBCTK = chkKiemDuyetXuatHang = chkQLNS = false;
            EnabledCheckBox = Enabled;

            ObservableCollection<PHANQUYEN> phanQuyen = new ObservableCollection<PHANQUYEN>(DataProvider.Ins.DB.PHANQUYENs);
            ObservableCollection<NHOMNGUOIDUNG> nhomnguoiDung = new ObservableCollection<NHOMNGUOIDUNG>(DataProvider.Ins.DB.NHOMNGUOIDUNGs);

            TenNhomQuyen = Ten;
            foreach (var nhom in nhomnguoiDung)
                if (nhom.TenNhom == Ten)
                {
                    foreach (var PQ in phanQuyen)
                        if (PQ.MaNhom==nhom.MaNhom)
                        {
                            switch (PQ.MaChucNang)
                            {
                                case 1:
                                    chkQLNS = true;
                                    break;
                                case 2:
                                    chkNhapHang = true;
                                    break;
                                case 3:
                                    chkKiemDuyetNhapHang = true;
                                    break;
                                case 4:
                                    chkBanHang = true;
                                    break;
                                case 5:
                                    chkKiemDuyetXuatHang = true;
                                    break;
                                case 6:
                                    chkTraCuu = true;
                                    break;
                                case 7:
                                    chkBCDS = true;
                                    break;
                                case 8:
                                    chkBCTK = true;
                                    break;
                            }
                        }
                }
        }
    }
}
