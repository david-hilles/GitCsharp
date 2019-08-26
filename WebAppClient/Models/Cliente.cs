using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppClient.Models
{
    public class Cliente : UserControls
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }

        public string EstadoCivil { get; set;}

        public string Rg { get; set; }


    }
}