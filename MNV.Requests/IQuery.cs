using MediatR;
using MNV.Results;

namespace MNV.Requests
{
    public interface IQuery : IRequest<IResult>
    {
    }
}
