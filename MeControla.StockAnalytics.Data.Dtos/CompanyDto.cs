﻿using MeControla.Core.Data.Dtos;
using System;

namespace MeControla.StockAnalytics.Data.Dtos
{
    public class CompanyDto : IDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CVMCode { get; set; }
        public string Document { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}