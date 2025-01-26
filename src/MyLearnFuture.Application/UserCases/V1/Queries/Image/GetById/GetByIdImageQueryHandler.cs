using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Queries.Image.GetById;

public class GetByIdImageQueryHandler : IRequestHandler<GetByIdImageQuery, ImagesEntity>
{
    private readonly IImageRepository _imageRepository;
    public GetByIdImageQueryHandler(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }
    public async Task<ImagesEntity> Handle(GetByIdImageQuery request, CancellationToken cancellationToken)
    {
        return await _imageRepository.GetByIdAsync(request.Id);
    }
}
