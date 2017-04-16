using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMgmt.MW.DataAccessLayer;

namespace BankMgmt.MW.BusinessLayer
{
    public class KhachHangBUS
    {
        private readonly IGenericDataRepository<KhachHang> _khachHangRepo;

        public KhachHangBUS()
        {
            _khachHangRepo = new GenericDataRepository<KhachHang>();
        }

        public List<KhachHang> GetAllKhachHang()
        {
            return _khachHangRepo.GetAll().ToList();
        }

        public KhachHang GetKhachHang(int id)
        {
            return _khachHangRepo.GetSingle(d => d.MaKhachHang.Equals(id));
        }

        public KhachHang GetSoDu(int id)
        {
            return _khachHangRepo.GetSingle(d => d.MaKhachHang.Equals(id), d => d.SoDuTaiKhoan);
        }

        public void AddKhachHang(params KhachHang[] khachHangs)
        {
            _khachHangRepo.Add(khachHangs);
        }

        public void UpdateKhachHang(params KhachHang[] khachHang)
        {
            _khachHangRepo.Update(khachHang);
        }
    }
}
