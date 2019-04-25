using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    [Table("elevators")]
    public class Elevator
    {
        public RocketElevatorContext context;
        public long id { get; set; }
        public long column_id { get; set; }
        public string status { get; set; }
    }
}