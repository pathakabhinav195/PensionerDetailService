using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PensionerDetailService.Model;
using PensionerDetailService.Repo;

namespace PensionerDetailTests
{
    internal class PensionerDetailUnitTests
    {
        private PensionerDetailMicroservice _service = new PensionerDetailMicroservice();

        [SetUp]
        public void Setup() { }

        [Test]
        public async Task GetAllPensionerDetails_Success()
        {
            var expected = 3;
            var pensionerDetails = await _service.GetAllPensionerDetails();
            var actual = pensionerDetails.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public async Task GetAllPensionerDetails_Failure()
        {
            var expected = 0;
            var pensionerDetails = await _service.GetAllPensionerDetails();
            var actual = pensionerDetails.Count;
            Assert.AreNotEqual(expected, actual);

        }

        [Test]
        public async Task GetPensionerDetail_Success()
        {
            PensionerDetail pensioner = await _service.GetPensionerDetail("871401017777");
            Assert.AreEqual("Abhinav Pathak", pensioner.Name);
        }
    }
}
