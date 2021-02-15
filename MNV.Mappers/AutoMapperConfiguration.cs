using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNV.Mappers
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration Initialize()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new UserMapper());
            });

            return mappingConfig;
        }
    }
}
