using System;
using System.Linq;
using System.Web.Http;
using Confingo.DataAccess;

namespace Confingo.Services.Controllers
{
    public class MessagesController : ApiController
    {
        public void Post([FromBody]CreateMessageRequest request)
        {
            using (var entities = new ConfingoEntities())
            {
                var resource = entities.Resources.FirstOrDefault(x => x.UniqueId == request.ResourceUniqueId);

                if (resource == null)
                {
                    throw new Exception(string.Format("Resource with Id {0} not found", request.ResourceUniqueId));
                }

                var conversation = entities.Conversations
                    .FirstOrDefault(x => x.ResourceId == resource.Id && x.FinderUserId == request.FinderUserId);


                if (conversation == null)
                {
                    var newConversation = new Conversation
                    {
                        ResourceId = resource.Id,
                        FinderUserId = request.FinderUserId
                    };
                    entities.SaveChanges();
                    conversation = newConversation;
                }

                var message = new Message
                {
                    Conversation = conversation,
                    MessageText = request.MessageText,
                    IsMessageFromFinder = request.IsMessageFromFinder,
                    TimeStamp = DateTime.Now
                };

                entities.Messages.Add(message);
                entities.SaveChanges();
            }
        }
    }

    public class CreateMessageRequest
    {
        public int FinderUserId { get; set; }
        public string ResourceUniqueId { get; set; }
        public string MessageText { get; set; }
        public bool IsMessageFromFinder { get; set; }
    }
}
