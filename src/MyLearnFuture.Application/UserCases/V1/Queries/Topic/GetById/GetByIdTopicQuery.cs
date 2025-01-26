using MediatR;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Queries.Topic.GetById;

public class GetByIdTopicQuery : IRequest<TopicsEntity>
{
    public Guid Id { get; set; }
}
