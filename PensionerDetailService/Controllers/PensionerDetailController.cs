using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PensionerDetailService.Model;
using PensionerDetailService.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensionerDetailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /*[Authorize]*/
    public class PensionerDetailController : Controller
    {
        IPensionerDetailMicroservice pensionerDetailService;
        private readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public PensionerDetailController(IPensionerDetailMicroservice pensionerDetailService)
        {
            this.pensionerDetailService = pensionerDetailService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<List<PensionerDetail>>> GetAllPensionerDetails()
        {
            IList<PensionerDetail> pensionerDetails = await pensionerDetailService.GetAllPensionerDetails();
            log.Info("Got all pensioner details in Pensioner detail controller");
            return Ok(pensionerDetails);
        }

        [HttpGet]
        [Route("{Aadhar}")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<PensionerDetail>> GetPensionerDetail(String Aadhar)
        {
            PensionerDetail pensioner = await pensionerDetailService.GetPensionerDetail(Aadhar);
            log.Info("Got pensioner details in Pensioner detail controller");
            return Ok(pensioner);
        }
    }
}
