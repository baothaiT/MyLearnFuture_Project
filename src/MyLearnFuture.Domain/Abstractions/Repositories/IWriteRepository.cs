using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Domain.Abstractions.Repositories;

public interface IWriteRepository<T>
{
    public Task<bool> CreateAsync(ImagesEntity imagesEntity);
    public Task<T> UpdateAsync(ImagesEntity imagesEntity);
    public Task<bool> DeleteAsync(Guid id);
}
