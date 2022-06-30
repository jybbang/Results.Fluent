using System;
using System.Collections.Generic;
using System.Text;

namespace Results.Fluent
{
    public class ResultResponse : Enumeration
    {
        public readonly static ResultResponse None = new ResultResponse(0, nameof(None));
        public readonly static ResultResponse BadRequest = new ResultResponse(400, nameof(BadRequest));
        public readonly static ResultResponse Unauthorized = new ResultResponse(401, nameof(Unauthorized));
        public readonly static ResultResponse Forbidden = new ResultResponse(403, nameof(Forbidden));
        public readonly static ResultResponse NotFound = new ResultResponse(404, nameof(NotFound));
        public readonly static ResultResponse NotAllowed = new ResultResponse(404, nameof(NotAllowed));
        public readonly static ResultResponse Conflict = new ResultResponse(409, nameof(Conflict));
        public readonly static ResultResponse Invalid = new ResultResponse(500, nameof(Invalid));

        public ResultResponse(int id, string name) : base(id, name)
        { }
    }
}
