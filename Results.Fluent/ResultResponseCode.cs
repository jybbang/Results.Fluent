﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Fluent
{
    public class ResultResponse
       : Enumeration
    {
        public static ResultResponse None = new ResultResponse(0, nameof(None));
        public static ResultResponse BadRequest = new ResultResponse(400, nameof(BadRequest));
        public static ResultResponse Unauthorized = new ResultResponse(401, nameof(Unauthorized));
        public static ResultResponse Forbidden = new ResultResponse(403, nameof(Forbidden));
        public static ResultResponse NotFound = new ResultResponse(404, nameof(NotFound));
        public static ResultResponse NotAllowed = new ResultResponse(404, nameof(NotAllowed));
        public static ResultResponse Conflict = new ResultResponse(409, nameof(Conflict));
        public static ResultResponse Invalid = new ResultResponse(500, nameof(Invalid));

        public ResultResponse(int id, string name)
            : base(id, name)
        {
        }
    }
}
