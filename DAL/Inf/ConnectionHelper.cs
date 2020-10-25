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
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\repositories\DreamHotel\dbt\dbHotel.mdf;Integrated Security=True;Connect Timeout=30";
        }
    }
}
