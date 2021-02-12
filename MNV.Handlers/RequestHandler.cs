using AutoMapper;
using MNV.Core.Database;
using System;

namespace MNV.Handlers
{
    public abstract class RequestHandler
    {
        protected readonly IDataContext _dataContext;
        protected readonly IMapper _mapper;

        public RequestHandler(IDataContext dataContext,
            IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
    }
}
