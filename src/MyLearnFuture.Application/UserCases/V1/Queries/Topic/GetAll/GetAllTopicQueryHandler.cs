using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Queries.Topic.GetAll;

public class GetAllTopicQueryHandler : IRequestHandler<GetAllTopicQuery, IEnumerable<TopicsEntity>>
{
    private readonly ITopicRepository _topicRepository;
    public GetAllTopicQueryHandler(ITopicRepository topicRepository)
    {
        _topicRepository = topicRepository;
    }
    public async Task<IEnumerable<TopicsEntity>> Handle(GetAllTopicQuery request, CancellationToken cancellationToken)
    {
        return await _topicRepository.GetAllAsync();
    }
}
