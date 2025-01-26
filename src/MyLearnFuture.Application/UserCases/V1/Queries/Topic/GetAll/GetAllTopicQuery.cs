using MediatR;
using MyLearnFuture.Domain.Entities;

namespace MyLearnFuture.Application.UserCases.V1.Queries.Topic.GetAll;

public class GetAllTopicQuery : IRequest<IEnumerable<TopicsEntity>>
{

}
