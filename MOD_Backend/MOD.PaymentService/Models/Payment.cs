﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.PaymentService.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public long PaymentId { get; set; }


        public long UserId { get; set; }

        public long MentorId { get; set; }

        public double Amount { get; set; }

        public double MentorAmount { get; set; }


    }
}