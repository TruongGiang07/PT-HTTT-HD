using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankMgmt.MW.BusinessLayer
{
    class GiaoDichBUS
    {
        private readonly IGenericDataRepository<GiaoDich> _giaoDichRepo;

        public GiaoDichBUS()
        {
            _giaoDichRepo = new GenericDataRepository<GiaoDich>();
        }

        public List<GiaoDich> GetAllGiaoDich()
        {
            return _giaoDichRepo.GetAll().ToList();
        }

        public void AddGiaoDich(params GiaoDich[] giaoDich)
        {
            _giaoDichRepo.Add(giaoDich);
        }
    }
}
