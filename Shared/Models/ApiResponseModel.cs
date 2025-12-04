using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class ApiResponseModel<T>
    {
        public T Result { get; set; }
        public int Id { get; set; }
        public object Exception { get; set; }
        public int Status { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsCompletedSuccessfully { get; set; }
    }
}
