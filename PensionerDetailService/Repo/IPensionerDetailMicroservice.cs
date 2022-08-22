using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PensionerDetailService.Model;

namespace PensionerDetailService.Repo
{
    public interface IPensionerDetailMicroservice
    {
        Task<PensionerDetail> GetPensionerDetail(String Aadhar);
        Task<IList<PensionerDetail>> GetAllPensionerDetails();

    }
}
