using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.Image.Create;

public class CreateImageCommandHandler : IRequestHandler<CreateImageCommand, bool>
{
    private readonly IImageRepository _imageRepository;
    public CreateImageCommandHandler(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }
    public Task<bool> Handle(CreateImageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
