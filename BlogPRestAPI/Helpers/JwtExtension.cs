﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPRestAPI.Helper
{
    public static class JwtExtension
    {
        public static void AddApplicationError(this HttpResponse response, string message )
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Allow-origin", "*");
            response.Headers.Add("Access-Control-Expose-Header", "Application-Error");
        }
    }
}
