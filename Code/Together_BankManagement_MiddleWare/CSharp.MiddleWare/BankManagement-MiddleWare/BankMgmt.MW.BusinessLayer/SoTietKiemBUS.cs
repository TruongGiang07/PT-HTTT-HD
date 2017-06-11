using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMgmt.MW.DataModel;
using BankMgmt.MW.DataAccessLayer;

namespace BankMgmt.MW.BusinessLayer
{
    public class SoTietKiemBUS
    {
        private readonly IGenericDataRepository<SoTietKiem> _soTietKiemRepo;

        public SoTietKiemBUS()
        {
            _soTietKiemRepo = new GenericDataRepository<SoTietKiem>();
        }

        public List<SoTietKiem> GetAllSoTietKiem()
        {
            return _soTietKiemRepo.GetAll(x => x.KhachHang).Where(i => i.TinhTrang == 1).ToList();
        }

        public SoTietKiem GetSoTietKiem(int stkId)
        {
            return _soTietKiemRepo.GetSingle(x => x.MaSoTietKiem.Equals(stkId));
        }
        public void AddSoTietKiem(params SoTietKiem[] soTietKiem)
        {
            _soTietKiemRepo.Add(soTietKiem);
        }

        public void RemoveSoTietKiem(params SoTietKiem[] soTietKiem)
        {
            _soTietKiemRepo.Remove(soTietKiem);
        }

        public void UpdateSoTietKiem(params SoTietKiem[] soTietKiem)
        {
            _soTietKiemRepo.Update(soTietKiem);
        }
    }
}
