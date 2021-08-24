using Games.DataModel;
using Games.IRepository.Unit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Games.Repository.SQL.Unit
{
    public class HistoryLogging : IHistoryLogging
    {
        public IEnumerable<ChangeHistory> GetLogEntries(ChangeTracker changeTracker, int loggedByUserId)
        {
            if (changeTracker.HasChanges())
            {
                foreach (var entry in changeTracker.Entries())
                {
                    var tableName = entry.Entity.GetType().Name;
                    if (!TablesLogged.Contains(tableName))
                    {
                        continue;
                    }
                    var pkValues = GetPrimaryKeyValues(entry);
                    var originalValues = entry.OriginalValues;
                    var currentValues = entry.CurrentValues;
                    foreach (var p in entry.Properties)
                    {
                        var columnName = p.Metadata.Name;
                        var changeTypeId = (short)EnumRepoActionType.Add;
                        var oldValue = (originalValues[columnName]?.ToString()) ?? "";
                        var newValue = (currentValues[columnName]?.ToString()) ?? "";
                        switch (entry.State)
                        {
                            case EntityState.Added:
                                oldValue = string.Empty;
                                break;
                            case EntityState.Modified:
                                changeTypeId = (short)EnumRepoActionType.Edit;
                                if (oldValue == newValue)
                                {
                                    continue;
                                }
                                break;
                            case EntityState.Deleted:
                                changeTypeId = (short)EnumRepoActionType.Delete;
                                newValue = string.Empty;
                                break;
                            default:
                                break;
                        }

                        if (entry.State == EntityState.Added || entry.State == EntityState.Modified || entry.State == EntityState.Deleted)
                        {
                            var history = new ChangeHistory()
                            {
                                ChangeTypeId = changeTypeId,
                                TableName = tableName,
                                TablePrimaryKeyValues = pkValues,
                                ColumnName = columnName,
                                OldValue = oldValue,
                                NewValue = newValue,
                                DateLogged = DateTime.Now,
                                LoggedByUserId = loggedByUserId
                            };
                            yield return history;
                        }
                    }
                }
            }
        }

        private string GetPrimaryKeyValues(EntityEntry entry)
        {
            var pkValues = entry.Metadata.FindPrimaryKey().Properties
                          .Select(x => new
                          {
                              x.Name,
                              Value = entry.Property(x.Name).CurrentValue
                          });
            return JsonSerializer.Serialize(pkValues);
        }

        private enum EnumRepoActionType
        {
            View = 1,
            Add = 2,
            Edit = 3,
            Delete = 4
        }

        private IList<string> TablesLogged
        {
            get
            {
                return new List<string>
                {
                    nameof(UserRole),
                    nameof(User),
                    nameof(Retailer),
                    nameof(RetailerGroup),
                    nameof(Item),
                    nameof(ItemSKUDetail),
                    nameof(ProductTag),
                    nameof(ProductTagCollection),
                    nameof(SKUClassification)
                };
            }
        }
    }
}
