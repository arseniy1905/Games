using Games.Common.Enums;
using Games.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Games.IService
{
    public interface ICommonService : IDataService
    {
        List<SelectListItem> GetProvinces(int languageId);
        List<SelectListItem> GetEntityTypes(int languageId);
        int GetRetailerStatus(int retailerId);
        long LogServiceCallLog(string requestId, string url, string request, string response);
        List<NotificationViewModel> GetNotifications(int languageId);
        List<int> GetUserNotificationIds(int languageId, int userId);
        int LogError(string url, string source, string message, string stackTrace);
        void LogAuditHistory(string entityType, string entityId, string entytyDesc, EnumActionType actionType, string actionDetails);
        List<SelectListItem> GetContactTypes(int languageId);
    }
}
