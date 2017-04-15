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

        public void AddKhachHang(params KhachHang[] khachHangs)
        {
            _khachHangRepo.Add(khachHangs);
        }
    }
}
