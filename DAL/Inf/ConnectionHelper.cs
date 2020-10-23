using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Inf
{
    internal class ConnectionHelper
    {
        public static string GetConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\source\repos\DreamHotel\dbt\dbHotel.mdf;Integrated Security=True;Connect Timeout=30";
        }
    }
}
