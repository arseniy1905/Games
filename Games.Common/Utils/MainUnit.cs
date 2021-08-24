using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IronLogic.OCS.Admin.Common.Utils
{
    public class MainUnit:BaseUnit
    {
        protected override void Init()
        {
            base.Init();
            _statuses = new GenericRepository<StatusMaster>(Set<StatusMaster>());
            _configurations = new GenericRepository<Config>(Set<Config>());
            _provinces = new GenericRepository<Province>(Set<Province>());
            _stores = new GenericRepository<Store>(Set<Store>());
            _userTypes = new GenericRepository<UserType>(Set<UserType>());
            _users = new GenericRepository<User>(Set<User>());
            _urlTokens = new GenericRepository<UrlToken>(Set<UrlToken>());
            _menuItems = new GenericRepository<MenuItem>(Set<MenuItem>());

            _locations = new GenericRepository<Location>(Set<Location>());
            _retailerGroups = new GenericRepository<RetailerGroup>(Set<RetailerGroup>());
            _retailers = new GenericRepository<Retailer>(Set<Retailer>());

            _emailTemplates = new GenericRepository<EmailTemplate>(Set<EmailTemplate>());
            _resources = new GenericRepository<Resource>(Set<Resource>());

            _requestInfo = new GenericRepository<RequestInfo>(Set<RequestInfo>());
            _requestStatusMasters = new GenericRepository<RequestStatusMaster>(Set<RequestStatusMaster>());
            _requestTypeMasters = new GenericRepository<RequestTypeMaster>(Set<RequestTypeMaster>());
            _requestTypeMasters = new GenericRepository<RequestTypeMaster>(Set<RequestTypeMaster>());
            _deliveryDoorAccessMasters = new GenericRepository<DeliveryDoorAccessMaster>(Set<DeliveryDoorAccessMaster>());
            _retailerStoreDetails = new GenericRepository<RetailerStoreDetails>(Set<RetailerStoreDetails>());
            _retailerStoreHours = new GenericRepository<RetailerStoreHours>(Set<RetailerStoreHours>());
            _dayMasters = new GenericRepository<DayMaster>(Set<DayMaster>());
            _emailNotificationLogs = new GenericRepository<EmailNotificationLog>(Set<EmailNotificationLog>());
            _userInfoStages = new GenericRepository<UserInfoStage>(Set<UserInfoStage>());

            _uploadDocuments = new GenericRepository<UploadDocument>(Set<UploadDocument>());
        }

        public MainUnit(string connection) : base(connection)
        {


        }

        public MainUnit(DbContextOptions options) : base(options)
        {

        }

        private GenericRepository<StatusMaster> _statuses;

        IRepository<StatusMaster> IMainUnit.Statuses => _statuses;
        IRepository<User> IMainUnit.Users => _users;
        IRepository<Config> IMainUnit.Configurations => _configurations;
        private GenericRepository<UserType> _userTypes;
        IRepository<UserType> IMainUnit.UserTypes => _userTypes;
        private GenericRepository<Province> _provinces;
        IRepository<Province> IMainUnit.Province => _provinces;
        private GenericRepository<Store> _stores;
        IRepository<Store> IMainUnit.Stores => _stores;

        private IRepository<Config> _configurations;

        private GenericRepository<User> _users;

        private GenericRepository<UrlToken> _urlTokens;
        IRepository<UrlToken> IMainUnit.UrlTokens => _urlTokens;
        private GenericRepository<MenuItem> _menuItems;
        IRepository<MenuItem> IMainUnit.MenuItems => _menuItems;

        private GenericRepository<Location> _locations;
        IRepository<Location> IMainUnit.Locations => _locations;

        private GenericRepository<RetailerGroup> _retailerGroups;
        IRepository<RetailerGroup> IMainUnit.RetailerGroups => _retailerGroups;

        private GenericRepository<Retailer> _retailers;
        IRepository<Retailer> IMainUnit.Retailers => _retailers;
        private GenericRepository<Resource> _resources;
        public IRepository<Resource> Resources => _resources;

        private GenericRepository<RequestStatusMaster> _requestStatusMasters;
        IRepository<RequestStatusMaster> IMainUnit.RequestStatusMasters => _requestStatusMasters;

        private GenericRepository<RequestTypeMaster> _requestTypeMasters;
        IRepository<RequestTypeMaster> IMainUnit.RequestTypeMasters => _requestTypeMasters;

        private GenericRepository<EmailTemplate> _emailTemplates;
        IRepository<EmailTemplate> IMainUnit.EmailTemplates => _emailTemplates;

        private GenericRepository<RequestInfo> _requestInfo;
        IRepository<RequestInfo> IMainUnit.RequestInfo => _requestInfo;

        private GenericRepository<EmailTypeMaster> _emailTypeMasters;
        IRepository<EmailTypeMaster> IMainUnit.EmailTypeMasters => _emailTypeMasters;

        private GenericRepository<EmailNotificationLog> _emailNotificationLogs;
        IRepository<EmailNotificationLog> IMainUnit.EmailNotificationLogs => _emailNotificationLogs;
        private GenericRepository<UserInfoStage> _userInfoStages;
        public IRepository<UserInfoStage> UserInfoStages => _userInfoStages;

        private GenericRepository<UploadDocument> _uploadDocuments;
        IRepository<UploadDocument> IMainUnit.UploadDocuments => _uploadDocuments;

        private GenericRepository<DeliveryDoorAccessMaster> _deliveryDoorAccessMasters;
        IRepository<DeliveryDoorAccessMaster> IMainUnit.DeliveryDoorAccessMasters => _deliveryDoorAccessMasters;

        private GenericRepository<RetailerStoreDetails> _retailerStoreDetails;
        IRepository<RetailerStoreDetails> IMainUnit.RetailerStoreDetails => _retailerStoreDetails;

        private GenericRepository<RetailerStoreHours> _retailerStoreHours;
        IRepository<RetailerStoreHours> IMainUnit.RetailerStoreHours => _retailerStoreHours;

        private GenericRepository<DayMaster> _dayMasters;
        IRepository<DayMaster> IMainUnit.DayMasters => _dayMasters;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connection);

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //CONFIG - STATUS
            modelBuilder.Entity<Config>().HasOne(c => c.Status).WithMany().HasForeignKey(c => c.StatusId);
            //PROVINCE - STATUS
            modelBuilder.Entity<Province>().HasOne(p => p.Status).WithMany().HasForeignKey(p => p.StatusId);
            //USERTYPE - STATUS
            modelBuilder.Entity<UserType>().HasOne(ut => ut.Status).WithMany().HasForeignKey(ut => ut.StatusId);
            //STORE - STATUS
            modelBuilder.Entity<Store>().HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusId);
            //STORE - PROVINCE
            modelBuilder.Entity<Store>().HasOne(s => s.Province).WithMany().HasForeignKey(s => s.ProvinceId);
            //DeliveryDoorAccessMaster - Status
            modelBuilder.Entity<DeliveryDoorAccessMaster>().HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusId);
            //RetailerStoreDetails - DeliveryDoorAccess
            modelBuilder.Entity<RetailerStoreDetails>().HasOne(s => s.DeliveryDoorAccess).WithMany().HasForeignKey(s => s.DeliveryDoorAccessID);
            //RetailerStoreDetails - RetailerGroups
            modelBuilder.Entity<RetailerStoreDetails>().HasOne(s => s.Locations).WithMany().HasForeignKey(s => s.ReceivingLocationID);
            //RetailerStoreHours - Retailer
            modelBuilder.Entity<RetailerStoreHours>().HasOne(s => s.Retailer).WithMany().HasForeignKey(s => s.RetailerId);
            //RetailerStoreHours - Store
            modelBuilder.Entity<RetailerStoreHours>().HasOne(s => s.Store).WithMany().HasForeignKey(s => s.StoreId);
            //RetailerStoreHours - Status
            modelBuilder.Entity<RetailerStoreHours>().HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusId);
            //DayMaster - Status
            modelBuilder.Entity<DayMaster>().HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusID);


            // USER - STATUS
            modelBuilder.Entity<User>()
                .HasOne(u => u.Status)
                .WithMany()
                .HasForeignKey(u => u.StatusId);
            // USER - STORE
            modelBuilder.Entity<User>()
                .HasOne(u => u.Store)
                .WithMany()
                .HasForeignKey(u => u.StoreId);
            // USER - USERTYPE
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserType)
                .WithMany()
                .HasForeignKey(u => u.UserTypeId);

            // UrlToken
            modelBuilder.Entity<UrlToken>()
                .HasOne(u => u.User)
                .WithMany(u => u.UrlTokens)
                .HasForeignKey("UserId");
            modelBuilder.Entity<UrlToken>()
                .HasOne(u => u.Creator);
            modelBuilder.Entity<UrlToken>()
                .Property(u => u.CreatedDate)
                .HasDefaultValueSql("getdate()");
            //Menu
            modelBuilder.Entity<MenuItem>().HasOne(ut => ut.Status).WithMany().HasForeignKey(ut => ut.StatusId);

            // Location - Retailer
            modelBuilder.Entity<Location>()
                .HasOne(u => u.Retailer)
                .WithMany(u => u.Locations)
                .HasForeignKey("RetailerId");

            // EmailTemplate
            modelBuilder.Entity<EmailTemplate>()
                .HasOne(u => u.Status)
                .WithMany()
                .HasForeignKey(u => u.StatusId);

            // RequestInfo
            modelBuilder.Entity<RequestInfo>()
                .HasOne(u => u.RequestStatus)
                .WithMany()
                .HasForeignKey(u => u.RequestStatusID);

            modelBuilder.Entity<RequestInfo>()
                .HasOne(u => u.RequestType)
                .WithMany()
                .HasForeignKey(u => u.RequestTypeID);

            modelBuilder.Entity<RequestInfo>()
                .HasOne(u => u.RequestType)
                .WithMany()
                .HasForeignKey(u => u.RequestTypeID);

            // EmailTypeMaster
            modelBuilder.Entity<EmailTypeMaster>()
                .HasOne(u => u.Status)
                .WithMany()
                .HasForeignKey(u => u.StatusId);

            // EmailNotificationLog
            modelBuilder.Entity<EmailNotificationLog>()
                .HasOne(u => u.EmailTemplate)
                .WithMany()
                .HasForeignKey(u => u.EmailTemplateId);
            modelBuilder.Entity<EmailNotificationLog>()
                .HasOne(u => u.EmailType)
                .WithMany()
                .HasForeignKey(u => u.EmailTypeId);

            // Resource - Status
            modelBuilder.Entity<Resource>()
                .HasOne(r => r.Status)
                .WithMany()
                .HasForeignKey("StatusId");

            // RequestStatusMaster
            // UserInfoStage - Status
            modelBuilder.Entity<UserInfoStage>()
                .HasOne(r => r.Status)
                .WithMany()
                .HasForeignKey("StatusId");

            // UploadDocument
            modelBuilder.Entity<UploadDocument>().HasNoKey();
        }
        public bool EnsureDeleted()
        {
            return this.Database.EnsureDeleted();
        }
    }
}
