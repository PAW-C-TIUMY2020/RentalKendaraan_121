﻿using System;
using System.Collections.Generic;

namespace RentalKendaraan_20180140121.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customer = new HashSet<Customer>();
        }

        public int IdGender { get; set; }
        public string NamaGender { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
