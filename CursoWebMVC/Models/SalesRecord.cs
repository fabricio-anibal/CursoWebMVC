﻿using System;
using CursoWebMVC.Models.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Saller Saller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Saller saller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Saller = saller;
        }
    }
}
