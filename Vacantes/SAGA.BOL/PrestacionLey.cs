using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGA.BOL
{
    public class PrestacionLey
    {
        [Key]
        public int id { get; set; }
        public string  prestacionLey { get; set; }
    }
}
