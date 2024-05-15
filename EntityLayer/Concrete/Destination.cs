﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
        public string CoverImage1 { get; set; }
        public string CoverImage2 { get; set; }
        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<ReComment> ReComments { get; set; }

    }
}
