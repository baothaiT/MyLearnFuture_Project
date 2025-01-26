using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.Topic.Create;

public class CreateTopicCommandHandler : IRequestHandler<CreateTopicCommand, bool>
{
    public readonly ITopicRepository _topicRepository;
    public CreateTopicCommandHandler(ITopicRepository topicRepository)
    {
        _topicRepository = topicRepository;
    }
    public Task<bool> Handle(CreateTopicCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
