using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiberacaoCredito.Enums
{
    public enum HttpStatusCode
    {
        OK = 200,
        BadRequest = 400,
        Forbidden = 403,
        NotFound = 404,
        InternalServerError = 500,
        NotImplemented = 502
    }
}
