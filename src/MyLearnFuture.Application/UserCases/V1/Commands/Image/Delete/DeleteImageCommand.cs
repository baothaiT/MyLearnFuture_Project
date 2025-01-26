using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.Image.Delete;

public class DeleteImageCommand : IRequest<bool>
{
    public Guid Id { get; set; }
}
