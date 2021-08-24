using Games.DataModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.IRepository.Unit
{
    public interface IHistoryLogging
    {
        IEnumerable<ChangeHistory> GetLogEntries(ChangeTracker changeTracker, int loggedByUserId);
    }
}
