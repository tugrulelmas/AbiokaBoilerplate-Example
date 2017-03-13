using AbiokaApi.Infrastructure.Framework.RestHelper.Attributes;
using System.Web.Http;

namespace AB.Host.Controllers
{
    [CustomActionFilter]
    [CustomExceptionFilter]
    public class BaseApiController : ApiController
    {
    }
}