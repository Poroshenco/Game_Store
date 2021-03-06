﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public string GameName { get; set; }

        public DateTime Date { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public string PaymentMethod { get; set; }
    }
}