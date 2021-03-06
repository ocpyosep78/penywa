﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BonaStoco.Inf.Data.ViewModel;

namespace Global.Repository.models
{
    [SqlQuery("SELECT * FROM tblcustomer")]
    [NamedSqlQuery("GetCustomerById",@"SELECT * FROM tblcustomer where id = @id")]
    [NamedSqlQuery("GetCustomerByName",@"SELECT * FROM tblcustomer where lower(name) like @key")]
    public class Customer : IViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alamat { get; set; }
        public string Kota { get; set; }
        public string Negara { get; set; }
        public string KodePos { get; set; }
        public string Email { get; set; }
        public decimal Outstanding { get; set; }
    }
}
