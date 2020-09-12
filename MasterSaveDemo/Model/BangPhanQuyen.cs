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
        public bool chkQLNS { get; set; }
        public bool chkMSTK { get; set; }
        public bool chkLPG { get; set; }
        public bool chkLPR { get; set; }
        public bool chkTCS { get; set; }
        public bool chkBCDS { get; set; }
        public bool chkBCMD { get; set; }
        public bool chkTDQD { get; set; }
        public bool chkNLVV { get; set; }
        public bool EnabledCheckBox { get; set; }

        public BangPhanQuyen(string Ten, bool Enabled)
        {

            chkQLNS = chkMSTK = chkLPG = chkLPR = chkTCS = chkBCDS = chkBCMD = chkTDQD = chkNLVV = false;
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
                                    chkMSTK = true;
                                    break;
                                case 3:
                                    chkLPG = true;
                                    break;
                                case 4:
                                    chkLPR = true;
                                    break;
                                case 5:
                                    chkTCS = true;
                                    break;
                                case 6:
                                    chkBCDS = true;
                                    break;
                                case 7:
                                    chkBCMD = true;
                                    break;
                                case 8:
                                    chkTDQD = true;
                                    break;
                                case 9:
                                    chkNLVV = true;
                                    break;
                            }
                        }
                }
        }
    }
}
