using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMgmt.MW.DataAccessLayer;

namespace BankMgmt.MW.BusinessLayer
{
    public class GiaoDichChuyenTienBUS
    {
        private readonly IGenericDataRepository<GiaoDichChuyenTien> _giaoDichChuyenTienRepo;

        public GiaoDichChuyenTienBUS()
        {
            _giaoDichChuyenTienRepo = new GenericDataRepository<GiaoDichChuyenTien>();
        }

        public List<GiaoDichChuyenTien> GetAllGiaoDichChuyenTien()
        {
            return _giaoDichChuyenTienRepo.GetAll().ToList();
        }

        public void AddGiaoDichChuyenTien(params GiaoDichChuyenTien[] giaoDichChuyenTiens)
        {
            _giaoDichChuyenTienRepo.Add(giaoDichChuyenTiens);
        }
    }
}
