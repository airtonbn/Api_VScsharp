using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace TodoApi.Models
{
    [Table("batteries")]
    public class Battery
    {
        private RocketElevatorContext context;
        public long id { get; set; }
        public long building_id { get; set; }
        public string battery_type { get; set; }
        public string status { get; set; }
    }
}