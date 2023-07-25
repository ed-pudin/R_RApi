using R_RApi.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R_RApi.DataAccessLayer.Response
{
    public class ResponseApi
    {
        public int status { get; set; }
        public int statusCode { get; set; }
        public string message { get; set; }
        public List<dynamic> values { get; set; }
        public ResponseApi(int status, int statusCode, string message, List<dynamic> values)
        {
            this.status = status;
            this.statusCode = statusCode;
            this.message = message;
            this.values = values;
        }


    }
}
