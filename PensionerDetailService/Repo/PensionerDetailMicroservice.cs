using Microsoft.EntityFrameworkCore;
using PensionerDetailService.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PensionerDetailService.Repo
{
    public class PensionerDetailMicroservice : IPensionerDetailMicroservice
    {
        PensionerDb db;
        private readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PensionerDetailMicroservice()
        {
            db = new PensionerDb();
        }
        public async Task<IList<PensionerDetail>> GetAllPensionerDetails()
        {
            List<PensionerDetail> pensionerDetails = await db.Pensioners.ToListAsync();
            log.Info("Get all pensioner dertails");
            return pensionerDetails;
        }

        public async Task<PensionerDetail> GetPensionerDetail(string Aadhar)
        {
            PensionerDetail pensioner = await db.Pensioners.FindAsync(Aadhar);
            log.Info("Get 1 pensioner dertails");
            return pensioner;
        }
    }
}
