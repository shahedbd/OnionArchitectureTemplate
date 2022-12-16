﻿using System;

namespace Core.Entities.Models
{
    public class Branch : EntityBase
    {
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ShortDescription { get; set; }
    }
}
