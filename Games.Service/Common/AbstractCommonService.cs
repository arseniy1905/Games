using Games.IRepository.Unit;
using Games.IService.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;

namespace IronLogic.OCS.Admin.Service.Common
{
    public abstract class AbstractCommonService : ICommonService
    {
        protected readonly IConfiguration _configuration;
        protected readonly AutoMapper.IMapper _mapper;
        protected readonly IWebHostEnvironment _hostingEnvironment;
        private IMainUnit mainUnit;

        public AbstractCommonService(IConfiguration configuration, IWebHostEnvironment hostingEnvironment)
        {
            _configuration = configuration;
            var config = new AutoMapper.MapperConfiguration(MapperConfig);
            _mapper = config.CreateMapper();
            _hostingEnvironment = hostingEnvironment;
        }

        protected AbstractCommonService(IMainUnit mainUnit)
        {
            this.mainUnit = mainUnit;
        }

        protected abstract Action<AutoMapper.IMapperConfigurationExpression> MapperConfig { get; }

        public virtual void Dispose()
        {

        }

        
    }
}
