using MediatR;
using MyLearnFuture.Application.UserCases.V1.Queries.Topic.GetAll;
using MyLearnFuture.Domain.Abstractions.Repositories;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Queries.Topic.GetById;

public class GetByIdTopicQueryHandler : IRequestHandler<GetByIdTopicQuery, TopicsEntity>
{
    private readonly ITopicRepository _topicRepository;
    public GetByIdTopicQueryHandler(ITopicRepository topicRepository)
    {
        _topicRepository = topicRepository;
    }
    public async Task<TopicsEntity> Handle(GetByIdTopicQuery request, CancellationToken cancellationToken)
    {
        return await _topicRepository.GetByIdAsync(request.Id);
    }
}
