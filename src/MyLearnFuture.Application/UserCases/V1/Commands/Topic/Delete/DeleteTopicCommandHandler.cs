using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.Topic.Delete;

public class DeleteTopicCommandHandler : IRequestHandler<DeleteTopicCommand, bool>
{
    public readonly ITopicRepository _topicRepository;
    public DeleteTopicCommandHandler(ITopicRepository topicRepository)
    {
        _topicRepository = topicRepository;
    }
    public Task<bool> Handle(DeleteTopicCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
