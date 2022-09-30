using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HueCitApp.Services.ServiceImp
{
    public interface IStudentService
    {
        public  Task<List<object>> getAllDsHocSinhTheoTaiKhoan(string taikhoanHues);
        public Task<object> getStudentByStudentID(string studentId);
    }
}

