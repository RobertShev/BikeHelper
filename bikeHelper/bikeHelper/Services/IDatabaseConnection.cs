using System;
using System.Collections.Generic;
using System.Text;

namespace bikeHelper.Services
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
