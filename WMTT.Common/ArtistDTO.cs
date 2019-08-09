using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMTT.Common
{
    public class ArtistDTO
    {
        public int IdArtist { get; set; }
        public string FullName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public System.DateTime StartDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
