﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAGA.BOL
{
    public class Cargo
    {
        public int Id { get; set; }
        [Display(Name ="Cargo / Título")]
        public string Nombre { get; set; }
    }
}