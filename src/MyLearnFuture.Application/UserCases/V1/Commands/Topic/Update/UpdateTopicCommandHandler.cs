using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.Topic.Update;

public class UpdateTopicCommandHandler : IRequestHandler<UpdateTopicCommand, TopicsEntity>
{
    public readonly ITopicRepository _topicRepository;
    public UpdateTopicCommandHandler(ITopicRepository topicRepository)
    {
        _topicRepository = topicRepository;
    }
    public Task<TopicsEntity> Handle(UpdateTopicCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
