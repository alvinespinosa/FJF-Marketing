using Dapper;
using FJFMarketing.Models.Entities;
using FJFMarketing.Repository.Dapper.Interface;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FJFMarketing.Repository.Dapper
{
    public class ItemRepository : IReadOnlyRepository<Item>
    {
        private readonly IConfiguration _config;

        public ItemRepository(IConfiguration config)
        {
            _config = config;
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("MyConnectionString"));
            }
        }

        public Item FindById(string id)
        {
            Item item = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                item = cn.Query<Item>("SELECT * FROM Items WHERE ID=@ID", new { ID = id }).SingleOrDefault();
            }

            return item;
        }

        public IEnumerable<Item> GetAll()
        {
            IEnumerable<Item> items = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                items = cn.Query<Item>("SELECT * FROM Items");
            }

            return items;
        }
    }
}
