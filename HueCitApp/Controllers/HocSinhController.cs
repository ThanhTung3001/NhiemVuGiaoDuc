using System;
using System.Threading.Tasks;
using HueCitApp.Services.ServiceImp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace HueCitApp.Controllers
{
    //[ApiController]
    //[Route("api/[controller]")]
    public class HocSinhController : BaseApiController
    {
        public readonly IStudentService studentSv;
        public HocSinhController(IWebHostEnvironment hostingEnvironment,IStudentService studentService) : base(hostingEnvironment)
        {
            this.studentSv = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> index(string username)
        {
            var result = await studentSv.getAllDsHocSinhTheoTaiKhoan(username);
           return SuccessResult(result, "get data success", 200);
        }
    }
}

