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
            return _soTietKiemRepo.GetAll().ToList();
        }

        public void AddSoTietKiem(params SoTietKiem[] soTietKiem)
        {
            _soTietKiemRepo.Add(soTietKiem);
        }
    }
}
