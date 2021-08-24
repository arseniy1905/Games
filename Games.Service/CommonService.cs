using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using Games.Common.Enums;
using Games.Common.Extensions;
using Games.Common.Models;
using Games.Common.State;
using Games.DataModel;
using Games.IRepository.Unit;
using Games.IService;
using Games.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace IronLogic.OCS.Admin.Service
{
    public class CommonService : AbstractDataService<IMainUnit>, ICommonService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        private SessionState CurrentSession
        {
            get
            {
                return _httpContextAccessor.HttpContext.Session.GetSessionState();
            } 
        }
            

        protected override Action<IMapperConfigurationExpression> MapperConfig => cfg =>
        {
            cfg.AddExpressionMapping();
            cfg.CreateMap<Province, SelectListItem>()
            .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()));

            cfg.CreateMap<EntityTypeMaster, SelectListItem>()
            .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ID.ToString()));
            cfg.CreateMap<NotificationMaster, NotificationViewModel>();
            cfg.CreateMap<ContactTypeMaster, SelectListItem>()
            .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()));
        };
        public CommonService(IMainUnit unit, IHttpContextAccessor httpContextAccessor) : base(unit)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public List<SelectListItem> GetEntityTypes(int languageId)
        {
            var entities = _unit.EntityTypeMasters.ToList();
            var result = _mapper.Map<List<EntityTypeMaster>, List<SelectListItem>>(entities, opts => opts.AfterMap((entities, list) =>
            {
                for (var i = 0; i < entities.Count; i++)
                {
                    if (languageId == (int)EnumLanguage.English)
                    {
                        list[i].Text = entities[i].EntityType;
                    }
                    else
                    {
                        list[i].Text = entities[i].EntityTypeFr;
                    }
                }
            }));
            return result;
        }

        public List<SelectListItem> GetProvinces(int languageId)
        {
            var provinces = _unit.Provinces.ToList();
            var result = _mapper.Map<List<Province>, List<SelectListItem>>(provinces, opts => opts.AfterMap((provinces, list) =>
            {
                for (var i = 0; i < provinces.Count; i++)
                {
                    if (languageId == (int)EnumLanguage.English)
                    {
                        list[i].Text = provinces[i].ProvinceName;
                    }
                    else
                    {
                        list[i].Text = provinces[i].ProvinceNameFr;
                    }
                }
            }));
            return result;
        }



        public int GetRetailerStatus(int retailerId)
        {
            return _unit.Retailers.Where(r => r.Id == retailerId).Select(a => a.RetailerStatusId).FirstOrDefault();
        }
        

        public long LogServiceCallLog(string requestId, string url, string request, string response)
        {
            var serviceLog = new ServiceCallLog
            {
                Attributes = "RequestID:" + requestId,
                CreatedDate = DateTime.Now,
                Endpoint = url,
                EventType = 1,
                IsError = false,
                Request = request,
                Response = response
            };
            _unit.ServiceCallLog.AddEntity(serviceLog);
            _unit.SaveChanges();
            return serviceLog.Id;
        }

        public List<NotificationViewModel> GetNotifications(int languageId)
        {
            return _unit.NotificationMasters.Where(a => a.StatusID == (int)EnumStatus.ACTIVE).Select(a=> new NotificationViewModel { ID = a.Id, Notification = a.Notification}).ToList();
        }
        public List<int> GetUserNotificationIds(int languageId, int userId)
        {
            return _unit.UserNotificationMappings.Where(a => a.UserId == userId && a.StatusId == (int)EnumStatus.ACTIVE).Select(a => a.NotificationId).ToList();
        }

        public int LogError(string url, string source, string message, string stackTrace)
        {
            var model = new ExceptionLog()
            {
                Url = url,
                Source = source,
                Message = message,
                StackTrace = stackTrace,
                LoggedDate =DateTime.Now

            };
            _unit.ExceptionLogs.AddEntity(model);
            SaveChanges();
            return model.Id;
        }
        public void LogAuditHistory(string entityType, string entityId, string entytyDesc, EnumActionType actionType, string actionDetails)
        {
            LogAuditHistory(entityType, entityId, entytyDesc, actionType, actionDetails, CurrentSession.User.Id, CurrentSession.User.UserName, CurrentSession.User.UserRoleId ?? 0, CurrentSession.User.UserRole);
        }

        public List<SelectListItem> GetContactTypes(int languageId)
        {
            var contactTypes = _unit.ContactTypeMasters.ToList();
            var result = _mapper.Map<List<ContactTypeMaster>, List<SelectListItem>>(contactTypes, opts => opts.AfterMap((contactTypes, list) =>
            {
                for (var i = 0; i < contactTypes.Count; i++)
                {
                    if (languageId == (int)EnumLanguage.English)
                    {
                        list[i].Text = contactTypes[i].ContactTypeName;
                    }
                    else
                    {
                        list[i].Text = contactTypes[i].ContactTypeNameFr;
                    }
                }
            }));
            return result;
        }
    }
}
