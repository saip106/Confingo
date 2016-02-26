using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Confingo.BusinessLayer;
using Confingo.DataAccess;

namespace Confingo.Services.Controllers
{
    public class ResourcesController : ApiController
    {
        [HttpGet]
        [Route("api/users/{userId}/resources")]
        public GetResourcesResponse Get(int userId)
        {
            using (var entities = new ConfingoEntities())
            {
                var resources = entities
                    .Resources
                    .Where(x => x.UserId == userId)
                    .Select(x => new ResourceDto
                    {
                        Name = x.Name,
                        Description = x.Description,
                        UniqueId = x.UniqueId
                    })
                    .ToArray();

                return new GetResourcesResponse
                {
                    Resources = resources
                };
            }
        }

        public CreateResourceResponse Post([FromBody]CreateResourceRequest request)
        {
            using (var entities = new ConfingoEntities())
            {
                var resource = new Resource
                {
                    Name = request.Name,
                    Description = request.Description,
                    UniqueId = new UniqueCodeGenerator().GetUniqueKey(),
                    UserId = request.UserId
                };
                
                entities.Resources.Add(resource);
                entities.SaveChanges();

                return new CreateResourceResponse
                {
                    Resource = resource
                };
            }
        }
    }

    public class GetResourceResponse
    {
        public ResourceDto Resource { get; set; }
    }

    public class CreateResourceRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    }

    public class CreateResourceResponse
    {
        public Resource Resource { get; set; }
    }

    public class GetResourcesResponse
    {
        public GetResourcesResponse()
        {
            Resources = new ResourceDto[0];
        }

        public ResourceDto[] Resources { get; set; }
    }

    public class ResourceDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UniqueId { get; set; }
    }
}
