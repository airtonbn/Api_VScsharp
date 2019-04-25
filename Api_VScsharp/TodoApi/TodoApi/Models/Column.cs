using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    [Table("columns")]
    public class Column
    {
        private RocketElevatorContext context;
        public long id { get; set; }
        public long battery_id { get; set; }
        public string status { get; set; }
    }
}