using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterSaveDemo.Model;
using System.Windows;

namespace MasterSaveDemo.Helper
{
    class NhapLaiVaoVon
    {
        private static NhapLaiVaoVon _ins;
        public static NhapLaiVaoVon Ins
        {
            get
            {
                if (_ins == null) _ins = new NhapLaiVaoVon();
                return _ins;
            }
            set
            {
                _ins = value;
            }
        }

        private NhapLaiVaoVon()
        {

        }
        private bool TinhLai(SOTIETKIEM stk, LOAITIETKIEM ltk, double laisuat, int songay)
        {
            try
            {
                decimal laisuat_theongay = (decimal)laisuat/360;
                stk.SoDu = stk.SoDu * (1 + (laisuat_theongay/100)*songay);
                if (ltk.KyHan == 0)
                {
                    stk.NgayDaoHanKeTiep = DateTime.Today.AddDays(1);
                }
                else
                {
                    stk.NgayDaoHanKeTiep = stk.NgayDaoHanKeTiep.AddDays(ltk.KyHan);
                }
                if(stk.LaiSuatApDung != ltk.LaiSuat)
                {
                    stk.LaiSuatApDung = ltk.LaiSuat;
                }
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public List<string> AllToday()
        {
            try
            {
                List<string> MaSo = new List<string>();
                List<SOTIETKIEM> list_stk = DataProvider.Ins.DB.SOTIETKIEMs.Where(x => x.NgayDaoHanKeTiep == DateTime.Today).ToList();
                if (list_stk.Count == 0)
                {
                    //Them vao thong bao rang da nhap lai vao von cua hom nay roi!
                }
                else
                {
                    foreach (SOTIETKIEM stk in list_stk)
                    {
                        LOAITIETKIEM ltk = DataProvider.Ins.DB.LOAITIETKIEMs.Where(x => x.MaLoaiTietKiem == stk.MaLoaiTietKiem).Single();
                        if (ltk.KyHan == 0)
                        {

                        }
                        else
                        {
                            NhapLaiVaoVon.Ins.StartThis(stk.MaSoTietKiem, false);
                            MaSo.Add(stk.MaSoTietKiem);
                        }
                    }
                }
                return MaSo;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi không xác định, vui lòng thử lại sau.");
                return null;
            }
        }
        public bool StartThis(string MSTK, bool confirm)
        {
            try
            {
                SOTIETKIEM stk = DataProvider.Ins.DB.SOTIETKIEMs.Where(x => x.MaSoTietKiem == MSTK).Single();
                LOAITIETKIEM ltk = DataProvider.Ins.DB.LOAITIETKIEMs.Where(x => x.MaLoaiTietKiem == stk.MaLoaiTietKiem).Single();
                //truong hop so khong ki han
                if (ltk.KyHan == 0 && confirm == true && DateTime.Today.AddDays(1)> stk.NgayDaoHanKeTiep)
                {
                    if (!TinhLai(stk, ltk, stk.LaiSuatApDung, (int)(DateTime.Today.AddDays(1) - stk.NgayDaoHanKeTiep).TotalDays))
                        return false;
                }
                else
                {
                    //Truong hop chua toi ngay dao han, nhung van rut ngay (da du so ngay toi thieu)
                    if (stk.NgayDaoHanKeTiep > DateTime.Today && (stk.NgayDaoHanKeTiep - DateTime.Today).TotalDays < ltk.KyHan)
                    {
                        if (confirm == true) //confirm true neu dang rut tien, nguoi nhan se duoc tinh lai ngay
                        {
                            if (!TinhLai(stk, ltk, DataProvider.Ins.DB.LOAITIETKIEMs.Where(x => x.KyHan == 0).First().LaiSuat, ltk.KyHan - (int)(stk.NgayDaoHanKeTiep - DateTime.Today).TotalDays))
                                return false;
                        }
                        else //confirm false trong truong hop dang nhap lai hang loat (chi cong lai cho tai khoan dao han), khong nhap gì
                        {

                        }
                    }
                    else
                    {
                        if (stk.NgayDaoHanKeTiep == DateTime.Today || (stk.NgayDaoHanKeTiep < DateTime.Today && confirm == false))
                        {
                            if (!TinhLai(stk, ltk, stk.LaiSuatApDung, ltk.KyHan))
                                return false;
                        }
                        else
                        {
                            if (stk.NgayDaoHanKeTiep < DateTime.Today && confirm == true)
                            {
                                if (!TinhLai(stk, ltk, stk.LaiSuatApDung, ltk.KyHan))
                                    return false;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
