using System;

namespace Games.ViewModel.MVC
{
    public class AllocationPoolListViewModel
    {
        public long OrderId { get; set; }
        public string SalesOrderId { get; set; }
        public int OrganizationId { get; set; }
        public string Organization { get; set; }
        public string OrgLogoImgSrc { get; set; } = "/images/image-not-available.png";
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public decimal TotalWeight { get; set; }
        public decimal TotalAmount { get; set; }
        public int StoreLocationId { get; set; }
        public string StoreLocation { get; set; }
        public string DeliveryAddress { get; set; }
    }

    public class AllocationPoolSubmittedOrderViewModel
    {
        public long OrderId { get; set; }
        public string Organization { get; set; }
        public string StoreID { get; set; }
        public string OrgLogoImgSrc { get; set; } = "/images/image-not-available.png";
        public DateTime OrderDate { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal TotalQuantityEaches { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalRequestedCannabisWeight { get; set; }
        public decimal TotalAllocatedCannabisWeight { get; set; }
        public string DeliveryAddress { get; set; }
        public string SubmittedByName { get; set; }
        public string SubmittedByEMail { get; set; }

    }

    public class AllocationPoolNotSubmittedLiewModel
    {
        public string Organization { get; set; }
        public string OrgLogoImgSrc { get; set; } = "/images/image-not-available.png";
        public string CustomerID { get; set; }
        public string DeliveryAddress { get; set; }
    }

    public class AllocationPoolOrderHistoryViewModel
    {
        public long OrderId { get; set; }
        public string Organization { get; set; }
        public string StoreID { get; set; }
        public string OrgLogoImgSrc { get; set; } = "/images/image-not-available.png";
        public string SalesOrderNumber { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal TotalQuantityEaches { get; set; }
        public decimal TotalAmount { get; set; }
        public string DeliveryAddress { get; set; }
        public string SubmittedByName { get; set; }
        public string SubmittedByEMail { get; set; }
        public decimal TotalRequestedCannabisWeight { get; set; }
        public decimal TotalAllocatedCannabisWeight { get; set; }

    }
}

