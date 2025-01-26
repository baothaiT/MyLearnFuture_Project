using MediatR;
using MyLearnFuture.Application.UserCases.V1.Queries.SpacedRepetitionConfig.GetAll;
using MyLearnFuture.Domain.Abstractions.Repositories;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Queries.Image.GetAll;

public class GetAllImageQueryHandler : IRequestHandler<GetAllImageQuery, IEnumerable<ImagesEntity>>
{
    private readonly IImageRepository _imageRepository;
    public GetAllImageQueryHandler(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }
    public async Task<IEnumerable<ImagesEntity>> Handle(GetAllImageQuery request, CancellationToken cancellationToken)
    {
        return await _imageRepository.GetAllAsync();
    }
}
