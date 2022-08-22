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

        public PensionerDetailMicroservice()
        {
            db = new PensionerDb();
        }
        public async Task<IList<PensionerDetail>> GetAllPensionerDetails()
        {
            List<PensionerDetail> pensionerDetails = await db.Pensioners.ToListAsync();
            return pensionerDetails;
        }

        public async Task<PensionerDetail> GetPensionerDetail(string Aadhar)
        {
            PensionerDetail pensioner = await db.Pensioners.FindAsync(Aadhar);
            return pensioner;
        }
    }
}
