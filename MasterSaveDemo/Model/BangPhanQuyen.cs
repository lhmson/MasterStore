using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MasterSaveDemo.Model
{
    public class BangPhanQuyen
    {
        public string TenNhomQuyen { get; set; }
        public bool chkNhapHang { get; set; }
        public bool chkXuatHang { get; set; }
        public bool chkBanHang { get; set; }
        public bool chkTraCuu { get; set; }
        public bool chkBCDS { get; set; }
        public bool chkBCTK { get; set; }
        public bool chkTDQD { get; set; }
        public bool chkQLNS { get; set; }
        public bool EnabledCheckBox { get; set; }

        public BangPhanQuyen(string Ten, bool Enabled)
        {

            chkNhapHang = chkXuatHang = chkBanHang = chkTraCuu = chkBCDS = chkBCTK = chkTDQD = chkQLNS = false;
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
                                    chkNhapHang = true;
                                    break;
                                case 2:
                                    chkXuatHang = true;
                                    break;
                                case 3:
                                    chkBanHang = true;
                                    break;
                                case 4:
                                    chkTraCuu = true;
                                    break;
                                case 5:
                                    chkBCDS = true;
                                    break;
                                case 6:
                                    chkBCTK = true;
                                    break;
                                case 7:
                                    chkTDQD = true;
                                    break;
                                case 8:
                                    chkQLNS = true;
                                    break;
                            }
                        }
                }
        }
    }
}
