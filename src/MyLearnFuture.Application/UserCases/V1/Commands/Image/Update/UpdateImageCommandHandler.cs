using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.Image.Update;

public class UpdateImageCommandHandler : IRequestHandler<UpdateImageCommand, ImagesEntity>
{
    private readonly IImageRepository _imageRepository;
    public UpdateImageCommandHandler(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }
    public Task<ImagesEntity> Handle(UpdateImageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
