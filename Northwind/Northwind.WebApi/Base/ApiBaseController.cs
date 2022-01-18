using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Base;
using Northwind.Entity.IBase;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WebApi.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBaseController<TInterface,T,TDto> : ControllerBase where TInterface : IGenericServise<T,TDto> where T:EntityBase where TDto:DtoBase
    {
        public readonly TInterface service;

        public ApiBaseController(TInterface service)
        {
            this.service = service;
        }

        [HttpGet]
        public IResponse<TDto> Find (int id)
        {
            try
            {
                var entity= service.Find(id);
                return entity;
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    Message= $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                };
            }
        }
    }
}
