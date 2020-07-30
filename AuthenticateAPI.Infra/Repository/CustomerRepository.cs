using AuthenticateAPI.Domain.Class;
using AuthenticateAPI.Domain.Interfaces.Repository;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticateAPI.Infra.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IConfiguration _configuration;

        public CustomerRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> Add(Customer entity)
        {
            entity.DateCreated = DateTime.Now;
            var sql = "INSERT INTO Customer (Id, Name, Password, Email, Document, DateCreated, DateModified, Blocked, BlockedDate) Values (@Id, @Name, @Password, @Email, @Document, @DateCreated, @DateModified, @Blocked, @BlockedDate);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }

        public async Task<int> Delete(int id)
        {
            var sql = "DELETE FROM Customer WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return affectedRows;
            }
        }

        public async Task<Customer> Get(int id)
        {
            var sql = "SELECT * FROM Customer WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Customer>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            var sql = "SELECT * FROM Customer;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Customer>(sql);
                return result;
            }
        }

        public async Task<int> Update(Customer entity)
        {
            entity.DateModified = DateTime.Now;
            var sql = "UPDATE Customer SET Name = @Name, Description = @Description, Status = @Status, DueDate = @DueDate, DateModified = @DateModified WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }

        public async Task<Customer> CheckCredentials(string email, string password)
        {
            var sql = "SELECT Customer WHERE Email = @Username AND Password = @Password";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Customer>(sql, new { Email = email, Password = password });
                return result.FirstOrDefault();
            }
        }
    }
}
