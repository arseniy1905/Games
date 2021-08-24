using System;
using System.Collections.Generic;

namespace Games.Common.State
{
    [Serializable]
    public class SessionState
    {
        public SessionState()
        {
            User = new User();
            Language = new Language();
            Retailer = new Retailer();
            UserPermissions = new List<PermissionCategoryState>();
            BannerIDs = new List<int>();
            //TempOrder = new TempOrder();
            DeliveryScheduleFile = new DeliveryScheduleFile();
            Error = new Error();
            FirstAlertDisplayed = false;
            SecondAlertDisplayed = false;
            ExpiredAlertDisplayed = false;
            FlowThruEnabled = false;
        }
        public User User { get; set; }
        public Language Language { get; set; }
        public Retailer Retailer { get; set; }
        public List<PermissionCategoryState> UserPermissions { get; set; }
        public long OrderId { get; set; }
        public long MainOrderId { get; set; }
        public bool FlowThruEnabled { get; set; }
        public int OrderItemCount { get; set; }
        public int NoOfRetailers { get; set; }
        public bool FirstAlertDisplayed { get; set; }
        public bool SecondAlertDisplayed { get; set; }
        public bool ExpiredAlertDisplayed { get; set; }
        public List<int> BannerIDs { get; set; }
        //public TempOrder TempOrder { get; set; }
        public DeliveryScheduleFile DeliveryScheduleFile { get; set; }
        public Error Error { get; set; }

        public void ClearSession()
        {
            User = new User();
            Language = new Language();
            Retailer = new Retailer();
            Error = new Error();
            UserPermissions = new List<PermissionCategoryState>();
            //TempOrder = new TempOrder();
            DeliveryScheduleFile = new DeliveryScheduleFile();
            OrderId = 0;
            OrderItemCount = 0;
            NoOfRetailers = 0;
            MainOrderId = 0;
            FirstAlertDisplayed = false;
            SecondAlertDisplayed = false;
            ExpiredAlertDisplayed = false;
            BannerIDs = new List<int>();
        }

        public void ClearOrderContext()
        {
            OrderId = 0;
            OrderItemCount = 0;
            NoOfRetailers = 0;
            MainOrderId = 0;
            FirstAlertDisplayed = false;
            SecondAlertDisplayed = false;
            ExpiredAlertDisplayed = false;
        }
    }
}
