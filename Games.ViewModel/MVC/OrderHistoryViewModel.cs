using Games.Common.Enums;
using Games.Common.Extensions;
using Games.Common.Resources;
using Games.ViewModel.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Games.ViewModel.MVC
{
    public class OrderHistoryViewModel : BaseViewModel
    {
        public OrderHistoryViewModel()
        {
            OrderList = new List<OrderHistoryDetailViewModel>();
            Paging = new PagingViewModel();
            Documents = new List<OrderDocumentViewModel>();
            OrderStatuses = new List<SelectListItem>();
            IsReadOnlyMode = false;
        }
        public int RetailerID { get; set; }
        public List<OrderHistoryDetailViewModel> OrderList { get; set; }
        public PagingViewModel Paging { get; set; }
        public int UserRole { get; set; }
        public List<OrderDocumentViewModel> Documents { get; set; }
        public List<SelectListItem> OrderStatuses { get; set; }
        public List<SelectListItem> OrderTotalRanges { get; set; }
        public bool IsReadOnlyMode { get; set; }
        public int RetailerOrganizationId { get; set; }
        public List<SelectListItem> StoreList { get; set; }
    }

    public class OrderHistoryDetailViewModel
    {
        public long OrderId { get; set; }
        public int OrderTypeId { get; set; }
        public string SalesOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }
        public int OrderStatusId { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveredOn { get; set; }
        public string DeliveryAddress { get; set; }
        public bool HasInvoice { get; set; }
        public bool HasASN { get; set; }
        public string OrderType { get; set; }
    }

    public class OrderDocumentViewModel
    {
        public int Id { get; set; }
        public string DocumentName { get; set; }
    }

    public class OrderStatusViewModel
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
    }

}
