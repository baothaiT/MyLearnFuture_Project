using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.Image.Delete;

public class DeleteImageCommandHandler : IRequestHandler<DeleteImageCommand, bool>
{
    private readonly IImageRepository _imageRepository;
    public DeleteImageCommandHandler(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }
    public Task<bool> Handle(DeleteImageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
