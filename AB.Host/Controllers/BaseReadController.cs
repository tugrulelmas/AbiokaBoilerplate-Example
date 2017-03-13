using AbiokaApi.ApplicationService.Abstractions;
using AbiokaApi.ApplicationService.DTOs;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AB.Host.Controllers
{
    public abstract class BaseReadController<T> : BaseApiController where T : DTO
    {
        private readonly IReadService<T> readService;

        public BaseReadController(IReadService<T> readService) {
            this.readService = readService;
        }

        [Route("")]
        [HttpGet]
        public virtual HttpResponseMessage Get() {
            var result = readService.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [Route("{id}")]
        [HttpGet]
        public virtual HttpResponseMessage Get([FromUri]Guid id) {
            var result = readService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [Route("")]
        [HttpGet]
        public virtual HttpResponseMessage Get([FromUri]int page, [FromUri]int limit, [FromUri]string order) {
            var result = readService.GetWithPage(page, limit, order);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
