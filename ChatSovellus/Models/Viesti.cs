using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatSovellus.Models
{
    public class Viesti
    {
        public string Viestiteksti { get; set; }

        public DateTime lähetetty { get; set; }

        public Konsultti lähettäjä { get; set; }

        public Konsultti vastaanottaja { get; set; }

        public bool onkoPrivaatti { get; set; }
    }

    public class Viestilista
    {
        List<Viesti> viestilista { get; set; }
    }
}