﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BonaStoco.Inf.Data.ViewModel;

namespace Global.Repository.models
{
    public class Rental
    {
        public Guid RentalId { get; set; }
        public string RentalNo { get; set; }
        public int CustId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DueDate { get; set; }
        public RentalItem[] Items { get; set; }
    }

    [NamedSqlQuery("GetItemByRentId",@"SELECT * FROM tblrentalitem where rentalid = @id")]
    public class RentalItem : IViewModel
    {
        public long Id { get; set; }
        public Guid RentalId { get; set; }
        public long ItemId { get; set; }
        public string Deskripsi { get; set; }
        public int Qty { get; set; }
        public decimal Harga { get; set; }
        public decimal Total { get; set; }
        public decimal Denda { get; set; }
    }

    [NamedSqlQuery("GetHeaderById",@"Select * FROM tblrentalheader where rentalid = @id")]
    public class RentalHeader : IViewModel
    {
        public Guid RentalId { get; set; }
        public string RentalNo { get; set; }
        public int CustId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
    }

    [NamedSqlQuery("GetSummaryById",@"SELECT * FROM tblrentalsummary where rentalid = @id")]
    public class RentalSummary : IViewModel
    {
        public Guid RentalId { get; set; }
        public decimal TotalDenda { get; set; }
        public decimal Total { get; set; }
    }
}
