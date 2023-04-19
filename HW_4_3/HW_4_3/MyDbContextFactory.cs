using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HW_4_3
{
    internal class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbcontext>
    {
        public MyDbcontext CreateDbContext(string[] args)
        {
            string connectionFile = File.ReadAllText("config.json");
            Connection connection = JsonSerializer.Deserialize<Connection>(connectionFile);
            string connectionString = connection.GetConnectionString.CString;
            var optionsBuilder = new DbContextOptionsBuilder<MyDbcontext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            return new MyDbcontext(options);
        }
    }
}



     
   
