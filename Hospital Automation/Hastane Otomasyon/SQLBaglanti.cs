﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Otomasyon
{
    class SQLBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=Emhyr\\SQLSERVER;Initial Catalog=hastane;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
