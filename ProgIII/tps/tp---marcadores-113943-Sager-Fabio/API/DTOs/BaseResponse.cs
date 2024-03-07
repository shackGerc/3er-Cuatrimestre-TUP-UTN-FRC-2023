using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class BaseResponse
    {
        public string Error { get; set; }
        public bool Ok { get; set; }
        public string MensajeInfo { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}