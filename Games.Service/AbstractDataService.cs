using AutoMapper;
using Games.Common.Enums;
using Games.DataModel;
using Games.IRepository.Unit;
using System;


namespace IronLogic.OCS.Admin.Service
{
    public abstract class AbstractDataService<TUnit> : Games.IService.IDataService where TUnit : IUnit
    {
        protected readonly IMainUnit _unit;
        protected readonly AutoMapper.IMapper _mapper;
        protected AbstractDataService(IMainUnit unit)
        {
            _unit = unit;
            var config = new MapperConfiguration(MapperConfig);
            _mapper = config.CreateMapper();
        }

        protected abstract Action<IMapperConfigurationExpression> MapperConfig { get; }

        public virtual void Dispose()
        {
            if (_unit != null)
            {
                _unit.Dispose();
            }

        }

        public int SaveChanges()
        {
            return _unit.SaveChanges();
        }

        public void SetUserId(int userId)
        {
            _unit.SetUserId(userId);
        }

        public void LogAuditHistory(string entityType, string entityId, string entytyDesc, EnumActionType actionType, string actionDetails, int userId, string userName, int userRoleId, string userRoleName)
        {
            var log = new AuditHistory
            {
                EntityType = entityType??"",
                EntityId = entityId??"",
                EntytyDesc = entytyDesc??"",
                ActionTypeId = (int)actionType,
                ActionType = actionType.ToString(),
                ActionDetails = actionDetails,
                UserId = userId,
                UserName = userName,
                UserRoleId = userRoleId,
                UserRoleName = userRoleName??"",
                CreatedDate = DateTime.Now
            };
            _unit.AuditHistories.AddEntity(log);
            _unit.SaveChanges();

        }
    }
}
