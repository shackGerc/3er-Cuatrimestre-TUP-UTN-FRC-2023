using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOS.Zoos
{
    public class ZoosListDTO : RespuestaBase
    {
        public List<StandardZoo> zoos { get; set; }
    }
}