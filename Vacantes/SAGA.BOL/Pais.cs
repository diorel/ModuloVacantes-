﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SAGA.BOL
{
    public class Pais
    {
          
        public int Id { get; set; }
        [MaxLength(50)]
        public string pais { get; set; }
    }
}