using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using QuangNhaDat;

namespace QuangNhaDat.Core.DAL
{
    public static class DALHelpers
    {
        public static string  myconect { get; set; }
        static DALHelpers()
        {
            
        }
        //Get Single record
        public static T Get<T>(string sql, DynamicParameters param = null)
        {
            using (IDbConnection conn = new SqlConnection(myconect))
            {
                param = param ?? new DynamicParameters();
                return conn.QueryFirstOrDefault<T>(sql, param, commandType: CommandType.StoredProcedure);
            }
        }
        public static async Task<T> GetAsync<T>(string sql, DynamicParameters param = null)
        {
            using (IDbConnection conn = new SqlConnection(myconect))
            {
                param = param ?? new DynamicParameters();
                return await conn.QueryFirstOrDefaultAsync<T>(sql, param, commandType: CommandType.StoredProcedure);
            }
        }
        //Gets multiple record
        public static IEnumerable<T> Gets<T>(string sql, DynamicParameters param = null)
        {
            using (IDbConnection conn = new SqlConnection(myconect))
            {
                param = param ?? new DynamicParameters();
                return conn.Query<T>(sql, param, commandType: CommandType.StoredProcedure);
            }
        }
        public static async Task<IEnumerable<T>> GetsAsync<T>(string sql, DynamicParameters param = null)
        {
            using (IDbConnection conn = new SqlConnection(myconect))
            {
                param = param ?? new DynamicParameters();
                return await conn.QueryAsync<T>(sql, param, commandType: CommandType.StoredProcedure);
            }
        }
        public static int Execute(string sql, DynamicParameters param = null)
        {
            using (IDbConnection conn = new SqlConnection(myconect))
            {
                param = param ?? new DynamicParameters();
                var affectedRows = conn.Execute(sql, param, commandType: CommandType.StoredProcedure);
                return affectedRows;
            }
        }
        public static async Task<int> ExecuteAsync(string sql, DynamicParameters param = null)
        {
            using (SqlConnection conn = new SqlConnection(myconect))
            {
                param = param ?? new DynamicParameters();
                return await conn.ExecuteAsync(sql, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
