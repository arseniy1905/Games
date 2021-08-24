using Games.Common.Enums;
using Games.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class BaseAdminViewModel
    {
        public BaseAdminViewModel()
        {
            Breadcrumbs = new List<BreadCrumbViewModel>();
        }
        public List<BreadCrumbViewModel> Breadcrumbs { get; set; }

        public void LoadBreadCrumb(int pageId, bool EditMode, string CustomText="")
        {
            switch (pageId)
            {
                case (int)EnumAdminPageID.InviteRetailer:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Retailer Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Invite Retailers", LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.RetailerDashboard:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Retailer Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Retailers", LinkRequired = false});
                    //Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Active Retailers", LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.AddEditRetailer:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Retailer Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Retailers", LinkRequired = true, Link = "/Admin/Retailers" });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.ApprovalQueue:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Retailer Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Approval Queue", LinkRequired = false});
                    break;
                case (int)EnumAdminPageID.EditApprovalQueu:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Retailer Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Approval Queue", LinkRequired = true, Link = "/Admin/RequestInfos" });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.RetailerGroup:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Retailer Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Retailer Groups", LinkRequired = false});
                    break;
                case (int)EnumAdminPageID.AddEditRetailerGroup:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Retailer Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Retailer Groups", LinkRequired = true, Link = "/Admin/RetailerGroup" });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.UserDashboard:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "User Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Users", LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.AddEditUser:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "User Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Users", LinkRequired = true, Link = "/Admin/Users" });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.RoleDashboard:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "User Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Roles", LinkRequired = false, Link = "/Admin/Roles" });
                    break;
                case (int)EnumAdminPageID.AddEditRole:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "User Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Roles", LinkRequired = true, Link = "/Admin/Roles" });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.ProductManagement:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "All Products", LinkRequired = false, Link = "/Admin/Products" });
                    break;
                case (int)EnumAdminPageID.EditProduct:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "All Products", LinkRequired = true, Link = "/Admin/Products" });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.ProductTags:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Tags", LinkRequired = true });
                    break;
                case (int)EnumAdminPageID.AddEditProductTags:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Tags", LinkRequired = true, Link = "/Admin/ProductTags" });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.Collections:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Collections", LinkRequired = true});
                    break;
                case (int)EnumAdminPageID.AddEditCollections:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Collections", LinkRequired = true, Link = "/Admin/ProductTagCollections" });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.SKUClassification:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "SKU Classifications", LinkRequired = true });
                    break;
                case (int)EnumAdminPageID.AddEditSKUClassification:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "SKU Classifications", LinkRequired = true, Link = "/Admin/SKUClassifications" });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.AlertBanners:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Content Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Alert Banners", LinkRequired = true });
                    break;
                case (int)EnumAdminPageID.AddEditAlerBanner:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Content Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Alert Banners", LinkRequired = true, Link = "/Admin/AlertBanners" });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.OrderDayConfiguration:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Order Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Order Day Configuration", LinkRequired = true});
                    break;
                case (int)EnumAdminPageID.UploadDeliverySchedule:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Order Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Upload Delivery Schedule", LinkRequired = true});
                    break;
                case (int)EnumAdminPageID.AllocationPool:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Order Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Allocation Pool", LinkRequired = true});
                    break;
                case (int)EnumAdminPageID.ConfigureHeroBanners:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Content Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Configure Hero Banners", LinkRequired = true });
                    break;
                case (int)EnumAdminPageID.AddEditConfigureHeroBanner:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Content Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Configure Hero Banners", LinkRequired = true, Link = "/Admin/ConfigureHeroBanners" });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.CreateEmailBlast:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Content Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Email Communication", LinkRequired = true });
                    break;
                case (int)EnumAdminPageID.AuditHistory:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "System Administration", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Audit History", LinkRequired = true });
                    break;
                case (int)EnumAdminPageID.HomePages:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Content Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Home Pages", LinkRequired = true });
                    break;
                case (int)EnumAdminPageID.CreateHomePage:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Content Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Home Pages", LinkRequired = true, Link = "/Admin/HomePages" });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    break;
                case (int)EnumAdminPageID.Organization:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Retailer Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Organizations", LinkRequired = !string.IsNullOrEmpty(CustomText), Link = "/Admin/Organization" });
                    if (!string.IsNullOrEmpty(CustomText))
                    {
                        Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    }
                    break;
                case (int)EnumAdminPageID.Categories:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Categories", LinkRequired = true });
                    break;
                case (int)EnumAdminPageID.RelatedProducts:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Related Product Rules", LinkRequired = true});
                    if (!string.IsNullOrEmpty(CustomText))
                    {
                        Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    }
                    break;
                case (int)EnumAdminPageID.RelatedProduct:
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Product Management", LinkRequired = false });
                    Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = "Related Product Rules", LinkRequired = true, Link = "/Admin/RelatedProductRules" });
                    if (!string.IsNullOrEmpty(CustomText))
                    {
                        Breadcrumbs.Add(new BreadCrumbViewModel { DisplayText = CustomText, LinkRequired = false });
                    }
                    break;
                default:
                    break;
            }

        }
        private int sortOrder = -1;
        public int SortOrder
        {
            private get { return sortOrder; }
            set { sortOrder = value; }
        }
        public string SortBy { get; set; }

        public int GetSortOrder(string sortBy)
        {
            if (SortBy == sortBy)
            {
                return SortOrder;
            }
            return -1;
        }
    }

}
