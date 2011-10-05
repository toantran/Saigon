using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumsun.Saigon.Domain.Services.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class ReponseDTO
    {
        public IEnumerable<ServiceError> Errors { get; set; }
    }
}
