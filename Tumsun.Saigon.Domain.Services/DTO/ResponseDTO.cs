using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumsun.Saigon.Domain.Services.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class ResponseDTO
    {

        public ResponseDTO()
        {
            Errors = Enumerable.Empty<ServiceError>();            
        }

        public IEnumerable<ServiceError> Errors { get; set; }
    }
}
