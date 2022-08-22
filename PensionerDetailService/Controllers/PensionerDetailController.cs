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
        public PensionerDetailController(IPensionerDetailMicroservice pensionerDetailService)
        {
            this.pensionerDetailService = pensionerDetailService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<List<PensionerDetail>>> GetAllPensionerDetails()
        {
            IList<PensionerDetail> pensionerDetails = await pensionerDetailService.GetAllPensionerDetails();
            return Ok(pensionerDetails);
        }

        [HttpGet]
        [Route("{Aadhar}")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<PensionerDetail>> GetPensionerDetail(String Aadhar)
        {
            PensionerDetail pensioner = await pensionerDetailService.GetPensionerDetail(Aadhar);
            return Ok(pensioner);
        }
    }
}
