using System;
using System.Collections.Generic;
using System.Text;

namespace Incorrect.Core
{
    public class Response
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public Response()
        {
            Code = 200;
            Message = "操作成功";
        }
    }

    public class Response<T>
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public List<T> Data { get; set; }

        public Response()
        {
            Code = 200;
            Message = "操作成功";
        }
    }
}
