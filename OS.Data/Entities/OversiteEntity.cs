﻿using OS.Data.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OS.Data.Entities
{
    public class OversiteEntity : IOversiteEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Domain { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Severity { get; set; }
        public bool Private{ get; set; }
        public int UserId { get; set; }
    }
}