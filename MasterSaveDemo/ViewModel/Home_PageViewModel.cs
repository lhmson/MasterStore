﻿using MasterSaveDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MasterSaveDemo.ViewModel
{
    public class Home_PageViewModel : BaseViewModel
    {
        //#region Variables

        //private string _SL_SoMo;
        //public string SL_SoMo { get => _SL_SoMo; set { _SL_SoMo = value; OnPropertyChanged(); } }

        //private string _SL_PhieuGui;
        //public string SL_PhieuGui { get => _SL_PhieuGui; set { _SL_PhieuGui = value; OnPropertyChanged(); } }

        //private string _SL_PhieuRut;
        //public string SL_PhieuRut { get => _SL_PhieuRut; set { _SL_PhieuRut = value; OnPropertyChanged(); } }

        //private string _TongThu;
        //public string TongThu { get => _TongThu; set { _TongThu = value; OnPropertyChanged(); } }

        //private string _TongChi;
        //public string TongChi { get => _TongChi; set { _TongChi = value; OnPropertyChanged(); } }
        //#endregion

        //#region Functions made by Sanhcutedeptraivodoi

        //public void Tinh_SoMo()
        //{
        //    ObservableCollection<SOTIETKIEM> list_STK = new ObservableCollection<SOTIETKIEM>(DataProvider.Ins.DB.SOTIETKIEMs);
        //    int count = 0;

        //    foreach (var item in list_STK)
        //        if (item.NgayMoSo.ToString("dd-MM-yyyy") == DateTime.Today.ToString("dd-MM-yyyy"))
        //            count++;

        //    SL_SoMo = count.ToString();
        //}

        //public void Tinh_SoPhieuGui_TongThu()
        //{
        //    ObservableCollection<PHIEUGUI> list_PhieuGui = new ObservableCollection<PHIEUGUI>(DataProvider.Ins.DB.PHIEUGUIs);
        //    int count = 0;
        //    decimal sum = 0;

        //    foreach (var item in list_PhieuGui)
        //        if (item.NgayGui.ToString("dd-MM-yyyy") == DateTime.Today.ToString("dd-MM-yyyy"))
        //        {
        //            sum += item.SoTienGui;
        //            count++;
        //        }
        //    ObservableCollection<SOTIETKIEM> list_STK = new ObservableCollection<SOTIETKIEM>(DataProvider.Ins.DB.SOTIETKIEMs);
        //    foreach (var item in list_STK)
        //        if (item.NgayMoSo.ToString("dd-MM-yyyy") == DateTime.Today.ToString("dd-MM-yyyy"))
        //        {
        //            sum += item.SoTienGuiBanDau;
        //        }

        //    if (sum < 1000)
        //    {
        //        TongThu = sum.ToString();
        //    }
        //    else
        //    {
        //        TongThu = sum.ToString("0,000");
        //    }
        //    SL_PhieuGui = count.ToString();
        //}

        //public void Tinh_SoPhieuRut_TongChi()
        //{
        //    ObservableCollection<PHIEURUT> list_PhieuRut = new ObservableCollection<PHIEURUT>(DataProvider.Ins.DB.PHIEURUTs);
        //    int count = 0;
        //    decimal sum = 0;

        //    foreach (var item in list_PhieuRut)
        //        if (item.NgayRut.ToString("dd-MM-yyyy") == DateTime.Today.ToString("dd-MM-yyyy"))
        //        {
        //            count++;
        //            sum += item.SoTienRut;
        //        }

        //    if (sum < 1000)
        //    {
        //        TongChi = sum.ToString();
        //    }
        //    else
        //    {
        //        TongChi = sum.ToString("0,000");
        //    }
        //    SL_PhieuRut = count.ToString();
        //}

        //#endregion

        //public Home_PageViewModel()
        //{
        //    Tinh_SoMo();
        //    Tinh_SoPhieuGui_TongThu();
        //    Tinh_SoPhieuRut_TongChi();
        //}
    }
}