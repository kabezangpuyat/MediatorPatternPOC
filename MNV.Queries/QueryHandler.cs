using AutoMapper;
using MNV.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNV.Queries
{
    public abstract class QueryHandler
    {
        protected readonly IDataContext _dataContext;
        protected readonly IMapper _mapper;
        public QueryHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
            //_mapper = mapper;
        }
    }
}
