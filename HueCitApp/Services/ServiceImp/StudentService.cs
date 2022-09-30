using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using HueCitApp.Connection;
using Microsoft.Extensions.Configuration;

namespace HueCitApp.Services.ServiceImp
{
    public class StudentService:ConnectionDb,IStudentService
    {
        public StudentService(IConfiguration configuration) : base(configuration)
        {

        }

        public  async Task<List<object>> getAllDsHocSinhTheoTaiKhoan (string taikhoanHues)
        {
          
            using (var connection = getConnection())
            {
                var students = await connection.QueryAsync<object>("getHSLKTheoTkHueS", new { taikhoan = taikhoanHues },
                      commandType: CommandType.StoredProcedure);
                return students.AsList();
            }
        }

        public async Task<object> getStudentByStudentID(string studentId)
        {
            using (var connection = getConnection())
            {
                var students = await connection.QueryAsync<object>("getInfoStudentByID", new { studentId = studentId },
                      commandType: CommandType.StoredProcedure);
                return students;
            }
        }
    }
}

