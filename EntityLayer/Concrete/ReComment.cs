using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ReComment
    {
        public int ReCommentID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
