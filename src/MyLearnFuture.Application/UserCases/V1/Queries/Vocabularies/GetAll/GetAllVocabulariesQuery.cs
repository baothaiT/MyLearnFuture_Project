using MediatR;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Queries.Vocabularies.GetAll;

public class GetAllVocabulariesQuery : IRequest<IEnumerable<VocabulariesEntity>>
{
}
