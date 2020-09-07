using System;
using Microsoft.EntityFrameworkCore;

namespace MobileApp.Data.Models
{
    public partial class bcc_MyAppxContext : DbContext
    {
        public bcc_MyAppxContext(DbContextOptions options) : base(options)
        {
        }

        public bcc_MyAppxContext(DbContextOptions<bcc_MyAppxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tbl0ShoppingCar> Tbl0ShoppingCar { get; set; }
        public virtual DbSet<Tbl1ShoppingCar> Tbl1ShoppingCar { get; set; }
        public virtual DbSet<Tbl2ShoppingCar> Tbl2ShoppingCar { get; set; }
        public virtual DbSet<Tbl3ShoppingCar> Tbl3ShoppingCar { get; set; }
        public virtual DbSet<Tbl4ShoppingCar> Tbl4ShoppingCar { get; set; }
        public virtual DbSet<Tbl5ShoppingCar> Tbl5ShoppingCar { get; set; }
        public virtual DbSet<TblAdressType> TblAdressType { get; set; }
        public virtual DbSet<TblBrand> TblBrand { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblCountry> TblCountry { get; set; }
        public virtual DbSet<TblCounty> TblCounty { get; set; }
        public virtual DbSet<TblExpense> TblExpense { get; set; }
        public virtual DbSet<TblGiftCard> TblGiftCard { get; set; }
        public virtual DbSet<TblGiftCardSatisi> TblGiftCardSatisi { get; set; }
        public virtual DbSet<TblGiftCardType> TblGiftCardType { get; set; }
        public virtual DbSet<TblLog> TblLog { get; set; }
        public virtual DbSet<TblLogType> TblLogType { get; set; }
        public virtual DbSet<TblNeighborhood> TblNeighborhood { get; set; }
        public virtual DbSet<TblNewServiceArea> TblNewServiceArea { get; set; }
        public virtual DbSet<TblOrderCar> TblOrderCar { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }
        public virtual DbSet<TblProvince> TblProvince { get; set; }
        public virtual DbSet<TblRecommendedProduct> TblRecommendedProduct { get; set; }
        public virtual DbSet<TblSalesList> TblSalesList { get; set; }
        public virtual DbSet<TblSalesQuantity> TblSalesQuantity { get; set; }
        public virtual DbSet<TblShoppingCar> TblShoppingCar { get; set; }
        public virtual DbSet<TblShoppingCarCs> TblShoppingCarCs { get; set; }
        public virtual DbSet<TblShoppingCarG> TblShoppingCarG { get; set; }
        public virtual DbSet<TblShoppingCarGelirKar> TblShoppingCarGelirKar { get; set; }
        public virtual DbSet<TblShoppingCarGelirveKar> TblShoppingCarGelirveKar { get; set; }
        public virtual DbSet<TblShoppingCarKuriye> TblShoppingCarKuriye { get; set; }
        public virtual DbSet<TblShoppingCarYeniKarList> TblShoppingCarYeniKarList { get; set; }
        public virtual DbSet<TblState> TblState { get; set; }
        public virtual DbSet<TblStreet> TblStreet { get; set; }
        public virtual DbSet<TblSubCategory> TblSubCategory { get; set; }
        public virtual DbSet<TblTheDeliveryTime> TblTheDeliveryTime { get; set; }
        public virtual DbSet<TblUseOfPoints> TblUseOfPoints { get; set; }
        public virtual DbSet<TblUseOfPoints1> TblUseOfPoints1 { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }
        public virtual DbSet<TblUserAddress> TblUserAddress { get; set; }
        public virtual DbSet<TblUserMessage> TblUserMessage { get; set; }
        public virtual DbSet<TbliPriceList> TbliPriceList { get; set; }
        public virtual DbSet<TbltblShoppingCarGt> TbltblShoppingCarGt { get; set; }
        public virtual DbSet<TbltblShoppingCarKuryeT> TbltblShoppingCarKuryeT { get; set; }
        public virtual DbSet<TbltblShoppingCarKuryeveToplamList> TbltblShoppingCarKuryeveToplamList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbl0ShoppingCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tbl0ShoppingCar", "panaokCo_mMdwDe");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<Tbl1ShoppingCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tbl1ShoppingCar");

                entity.Property(e => e.IUserAddressId).HasColumnName("iUserAddress_id");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<Tbl2ShoppingCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tbl2ShoppingCar");

                entity.Property(e => e.IUserAddressId).HasColumnName("iUserAddress_id");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<Tbl3ShoppingCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tbl3ShoppingCar");

                entity.Property(e => e.IUserAddressId).HasColumnName("iUserAddress_id");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<Tbl4ShoppingCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tbl4ShoppingCar");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<Tbl5ShoppingCar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tbl5ShoppingCar");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<TblAdressType>(entity =>
            {
                entity.HasKey(e => e.IAdressTypeId);

                entity.ToTable("tblAdressType");

                entity.Property(e => e.IAdressTypeId).HasColumnName("iAdressType_id");

                entity.Property(e => e.SAdressTypeName)
                    .HasColumnName("sAdressTypeName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblBrand>(entity =>
            {
                entity.HasKey(e => e.IBrandId);

                entity.ToTable("tblBrand");

                entity.Property(e => e.IBrandId).HasColumnName("iBrand_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DBrandContractDate)
                    .HasColumnName("dBrandContractDate")
                    .HasColumnType("date");

                entity.Property(e => e.DBrandContractEndDate)
                    .HasColumnName("dBrandContractEndDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IBrandStatusId).HasColumnName("iBrandStatus_id");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.SBrandContractContent)
                    .HasColumnName("sBrandContractContent")
                    .HasColumnType("ntext");

                entity.Property(e => e.SBrandEmail)
                    .HasColumnName("sBrandEMail")
                    .HasMaxLength(30);

                entity.Property(e => e.SBrandManager)
                    .HasColumnName("sBrandManager")
                    .HasMaxLength(50);

                entity.Property(e => e.SBrandName)
                    .HasColumnName("sBrandName")
                    .HasMaxLength(50);

                entity.Property(e => e.SBrandNote)
                    .HasColumnName("sBrandNote")
                    .HasColumnType("ntext");

                entity.Property(e => e.SBrandPhone)
                    .HasColumnName("sBrandPhone")
                    .HasMaxLength(20);

                entity.Property(e => e.SBrandStatus)
                    .HasColumnName("sBrandStatus")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.ICategoryId);

                entity.ToTable("tblCategory");

                entity.Property(e => e.ICategoryId).HasColumnName("iCategory_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICategoryRow).HasColumnName("iCategoryRow");

                entity.Property(e => e.ICategoryStatusId).HasColumnName("iCategoryStatus_id");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.SCategoryImg).HasColumnName("sCategoryIMG");

                entity.Property(e => e.SCategoryName)
                    .HasColumnName("sCategoryName")
                    .HasMaxLength(100);

                entity.Property(e => e.SCategoryNameTr)
                    .HasColumnName("sCategoryNameTr")
                    .HasMaxLength(100);

                entity.Property(e => e.SCategoryStatus)
                    .HasColumnName("sCategoryStatus")
                    .HasMaxLength(15);

                entity.Property(e => e.SCreateUserFullName)
                    .HasColumnName("sCreateUserFullName")
                    .HasMaxLength(50);

                entity.Property(e => e.SDescription).HasColumnName("sDescription");
            });

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.HasKey(e => e.ICountryId);

                entity.ToTable("tblCountry");

                entity.Property(e => e.ICountryId).HasColumnName("iCountry_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICountryStatusId).HasColumnName("iCountryStatus_id");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.IUpdateUserFullName)
                    .HasColumnName("iUpdateUserFullName")
                    .HasMaxLength(50);

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.SCountryCode)
                    .HasColumnName("sCountryCode")
                    .HasMaxLength(20);

                entity.Property(e => e.SCountryName)
                    .HasColumnName("sCountryName")
                    .HasMaxLength(50);

                entity.Property(e => e.SCountryStatus)
                    .HasColumnName("sCountryStatus")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCounty>(entity =>
            {
                entity.HasKey(e => e.ICountyId);

                entity.ToTable("tblCounty");

                entity.Property(e => e.ICountyId).HasColumnName("iCounty_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICountyStatusId).HasColumnName("iCountyStatus_id");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.IProvinceId).HasColumnName("iProvince_id");

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.SCountyName)
                    .HasColumnName("sCountyName")
                    .HasMaxLength(50);

                entity.Property(e => e.SCountyStatus)
                    .HasColumnName("sCountyStatus")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SProvinceName)
                    .HasColumnName("sProvinceName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblExpense>(entity =>
            {
                entity.HasKey(e => e.IExpenseId);

                entity.ToTable("tblExpense");

                entity.Property(e => e.IExpenseId).HasColumnName("iExpense_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DExpenseDate)
                    .HasColumnName("dExpenseDate")
                    .HasColumnType("date");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.IExpenseStatuId).HasColumnName("iExpenseStatu_id");

                entity.Property(e => e.IExpenseTypeId).HasColumnName("iExpenseType_id");

                entity.Property(e => e.SExpenseContent).HasColumnName("sExpenseContent");

                entity.Property(e => e.SExpenseMoney)
                    .HasColumnName("sExpenseMoney")
                    .HasColumnType("money");

                entity.Property(e => e.SExpenseStatuName)
                    .HasColumnName("sExpenseStatuName")
                    .HasMaxLength(20);

                entity.Property(e => e.SExpenseTypeName)
                    .HasColumnName("sExpenseTypeName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblGiftCard>(entity =>
            {
                entity.HasKey(e => e.IGiftCardId);

                entity.ToTable("tblGiftCard");

                entity.Property(e => e.IGiftCardId).HasColumnName("iGiftCard_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DSellByDate)
                    .HasColumnName("dSellByDate")
                    .HasColumnType("date");

                entity.Property(e => e.DSellByDt)
                    .HasColumnName("dSellBy_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUploadDate)
                    .HasColumnName("dUploadDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUploadDt)
                    .HasColumnName("dUpload_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IGiftCardTypeId).HasColumnName("iGiftCardType_id");

                entity.Property(e => e.IPromotionId).HasColumnName("iPromotion_id");

                entity.Property(e => e.ISalesStatusId).HasColumnName("iSalesStatus_id");

                entity.Property(e => e.ISalesUserId).HasColumnName("iSalesUser_id");

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.IUploadUserId).HasColumnName("iUploadUser_id");

                entity.Property(e => e.IUsable).HasColumnName("iUsable");

                entity.Property(e => e.MCreditAmount)
                    .HasColumnName("mCreditAmount")
                    .HasColumnType("money");

                entity.Property(e => e.SCreditRating)
                    .HasColumnName("sCreditRating")
                    .HasColumnType("money");

                entity.Property(e => e.SGiftCardCode)
                    .HasColumnName("sGiftCardCode")
                    .HasMaxLength(8);

                entity.Property(e => e.SPromotionName)
                    .HasColumnName("sPromotionName")
                    .HasMaxLength(20);

                entity.Property(e => e.SSalesStatusType)
                    .HasColumnName("sSalesStatusType")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblGiftCardSatisi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tblGiftCardSatisi", "panaokCo_mMdwDe");

                entity.Property(e => e.DSellByDate)
                    .HasColumnName("dSellByDate")
                    .HasColumnType("date");

                entity.Property(e => e.IUsable).HasColumnName("iUsable");
            });

            modelBuilder.Entity<TblGiftCardType>(entity =>
            {
                entity.HasKey(e => e.IGiftCardTypeId);

                entity.ToTable("tblGiftCardType");

                entity.Property(e => e.IGiftCardTypeId).HasColumnName("iGiftCardType_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.IGiftCardTypeStatuId).HasColumnName("iGiftCardTypeStatu_id");

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.MCreditAmount)
                    .HasColumnName("mCreditAmount")
                    .HasColumnType("money");

                entity.Property(e => e.SCreditRating)
                    .HasColumnName("sCreditRating")
                    .HasColumnType("money");

                entity.Property(e => e.SCreditRatingName)
                    .HasColumnName("sCreditRatingName")
                    .HasMaxLength(20);

                entity.Property(e => e.SGiftCardTypeStatus)
                    .HasColumnName("sGiftCardTypeStatus")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblLog>(entity =>
            {
                entity.HasKey(e => e.ILogId)
                    .HasName("PK_tblLogg");

                entity.ToTable("tblLog");

                entity.Property(e => e.ILogId).HasColumnName("iLog_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DHour)
                    .HasColumnName("dHour")
                    .HasMaxLength(20);

                entity.Property(e => e.DLogDate)
                    .HasColumnName("dLogDate")
                    .HasColumnType("date");

                entity.Property(e => e.DLogDt)
                    .HasColumnName("dLog_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ILogTypeId).HasColumnName("iLogType_id");

                entity.Property(e => e.ILogUserId).HasColumnName("iLogUser_id");

                entity.Property(e => e.SLogContent)
                    .HasColumnName("sLogContent")
                    .HasMaxLength(100);

                entity.Property(e => e.SLogTypeName)
                    .HasColumnName("sLogTypeName")
                    .HasMaxLength(50);

                entity.Property(e => e.SUserIpAdress)
                    .HasColumnName("sUserIpAdress")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblLogType>(entity =>
            {
                entity.HasKey(e => e.ILogTypeId);

                entity.ToTable("tblLogType");

                entity.Property(e => e.ILogTypeId).HasColumnName("iLogType_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DLogTypeDate)
                    .HasColumnName("dLogTypeDate")
                    .HasColumnType("date");

                entity.Property(e => e.DLogTypeDt)
                    .HasColumnName("dLogType_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.SLogTypeName)
                    .HasColumnName("sLogTypeName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblNeighborhood>(entity =>
            {
                entity.HasKey(e => e.INeighborhoodId);

                entity.ToTable("tblNeighborhood");

                entity.Property(e => e.INeighborhoodId).HasColumnName("iNeighborhood_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICountyId).HasColumnName("iCounty_id");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.INeighborhoodStatusId).HasColumnName("iNeighborhoodStatus_id");

                entity.Property(e => e.IPostaCodeName).HasColumnName("iPostaCodeName");

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.SCountyName)
                    .HasColumnName("sCountyName")
                    .HasMaxLength(50);

                entity.Property(e => e.SNeighborhoodName)
                    .HasColumnName("sNeighborhoodName")
                    .HasMaxLength(50);

                entity.Property(e => e.SNeighborhoodStatus)
                    .HasColumnName("sNeighborhoodStatus")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblNewServiceArea>(entity =>
            {
                entity.HasKey(e => e.INewServiceAreaId);

                entity.ToTable("tblNewServiceArea");

                entity.Property(e => e.INewServiceAreaId).HasColumnName("iNewServiceArea_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IPostaCodeId).HasColumnName("iPostaCodeID");

                entity.Property(e => e.SEmailAddress)
                    .HasColumnName("sEmailAddress")
                    .HasMaxLength(60);

                entity.Property(e => e.SMobileNumber)
                    .HasColumnName("sMobileNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.SNewServiceAreaStatus)
                    .HasColumnName("sNewServiceAreaStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.SNumber)
                    .HasColumnName("sNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.SPostaCodeName)
                    .HasColumnName("sPostaCodeName")
                    .HasMaxLength(50);

                entity.Property(e => e.SStreet)
                    .HasColumnName("sStreet")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblOrderCar>(entity =>
            {
                entity.HasKey(e => e.IOrderCarId);

                entity.ToTable("tblOrderCar");

                entity.Property(e => e.IOrderCarId).HasColumnName("iOrderCar_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DHdateTime)
                    .HasColumnName("dHDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DIdateTime)
                    .HasColumnName("dIDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DSdateTime)
                    .HasColumnName("dSDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DStdate)
                    .HasColumnName("dSTDate")
                    .HasColumnType("date");

                entity.Property(e => e.DTdateTime)
                    .HasColumnName("dTDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DTdateTimeD)
                    .HasColumnName("dTDateTimeD")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DYdateTime)
                    .HasColumnName("dYDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IOrderNumber).HasColumnName("iOrderNumber");

                entity.Property(e => e.IStatusId).HasColumnName("iStatus_id");

                entity.Property(e => e.ITheDeliveryTimeId).HasColumnName("iTheDeliveryTime_id");

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.IUserAddressId).HasColumnName("iUserAddress_id");

                entity.Property(e => e.IUserAddressTypeId).HasColumnName("iUserAddressType_id");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.MAmountPaid)
                    .HasColumnName("mAmountPaid")
                    .HasColumnType("money");

                entity.Property(e => e.MAmountToBePaid)
                    .HasColumnName("mAmountToBePaid")
                    .HasColumnType("money");

                entity.Property(e => e.MTotalProductPrice)
                    .HasColumnName("mTotalProductPrice")
                    .HasColumnType("money");

                entity.Property(e => e.MUsedCreditAmount)
                    .HasColumnName("mUsedCreditAmount")
                    .HasColumnType("money");

                entity.Property(e => e.SStatusName)
                    .HasColumnName("sStatusName")
                    .HasMaxLength(50);

                entity.Property(e => e.SStdatetime)
                    .HasColumnName("sSTDatetime")
                    .HasMaxLength(60);

                entity.Property(e => e.STheDeliveryTimeDate)
                    .HasColumnName("sTheDeliveryTimeDate")
                    .HasMaxLength(50);

                entity.Property(e => e.SUpdateContent)
                    .HasColumnName("sUpdateContent")
                    .HasMaxLength(50);

                entity.Property(e => e.SUserAddressDetail)
                    .HasColumnName("sUserAddressDetail")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.IProductId);

                entity.ToTable("tblProduct");

                entity.Property(e => e.IProductId).HasColumnName("iProduct_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IBrandId).HasColumnName("iBrand_id");

                entity.Property(e => e.ICategoryId).HasColumnName("iCategory_id");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.IDiscountId).HasColumnName("iDiscount_id");

                entity.Property(e => e.IHalalId).HasColumnName("iHalal_id");

                entity.Property(e => e.IProductDeposit)
                    .HasColumnName("iProductDeposit")
                    .HasColumnType("money");

                entity.Property(e => e.IProductDepositId).HasColumnName("iProductDeposit_id");

                entity.Property(e => e.IProductPrice)
                    .HasColumnName("iProductPrice")
                    .HasColumnType("money");

                entity.Property(e => e.IProductPriceF)
                    .HasColumnName("iProductPriceF")
                    .HasColumnType("money");

                entity.Property(e => e.IProductRow).HasColumnName("iProductRow");

                entity.Property(e => e.IProductStatusId).HasColumnName("iProductStatus_id");

                entity.Property(e => e.IProductStock).HasColumnName("iProductStock");

                entity.Property(e => e.ISubCategoryId).HasColumnName("iSubCategory_id");

                entity.Property(e => e.ProductPriceTypeId).HasColumnName("ProductPriceType_id");

                entity.Property(e => e.SBrandName)
                    .HasColumnName("sBrandName")
                    .HasMaxLength(50);

                entity.Property(e => e.SCategoryName)
                    .HasColumnName("sCategoryName")
                    .HasMaxLength(50);

                entity.Property(e => e.SCreateUserFullName)
                    .HasColumnName("sCreateUserFullName")
                    .HasMaxLength(25);

                entity.Property(e => e.SDescription).HasColumnName("sDescription");

                entity.Property(e => e.SHalalName)
                    .HasColumnName("sHalalName")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SProductCode)
                    .HasColumnName("sProductCode")
                    .HasMaxLength(50);

                entity.Property(e => e.SProductImg).HasColumnName("sProductIMG");

                entity.Property(e => e.SProductName)
                    .HasColumnName("sProductName")
                    .HasMaxLength(75);

                entity.Property(e => e.SProductPriceTypeName)
                    .HasColumnName("sProductPriceTypeName")
                    .HasMaxLength(50);

                entity.Property(e => e.SProductPurchasePrice)
                    .HasColumnName("sProductPurchasePrice")
                    .HasColumnType("money");

                entity.Property(e => e.SProductStatus)
                    .HasColumnName("sProductStatus")
                    .HasMaxLength(15);

                entity.Property(e => e.SProfit)
                    .HasColumnName("sProfit")
                    .HasColumnType("money");

                entity.Property(e => e.SSubCategoryName)
                    .HasColumnName("sSubCategoryName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblProvince>(entity =>
            {
                entity.HasKey(e => e.IProvinceId);

                entity.ToTable("tblProvince");

                entity.Property(e => e.IProvinceId).HasColumnName("iProvince_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.IProvinceStatusId).HasColumnName("iProvinceStatus_id");

                entity.Property(e => e.IStateId).HasColumnName("iState_id");

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.SProvinceName)
                    .HasColumnName("sProvinceName")
                    .HasMaxLength(50);

                entity.Property(e => e.SProvinceStatus)
                    .HasColumnName("sProvinceStatus")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SStateName)
                    .HasColumnName("sStateName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblRecommendedProduct>(entity =>
            {
                entity.HasKey(e => e.IRecommendedProductId);

                entity.ToTable("tblRecommendedProduct");

                entity.Property(e => e.IRecommendedProductId).HasColumnName("iRecommendedProduct_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IApprovedId).HasColumnName("iApproved_id");

                entity.Property(e => e.IConsumptionFrequencyId).HasColumnName("iConsumptionFrequency_id");

                entity.Property(e => e.ICountryId).HasColumnName("iCountry_id");

                entity.Property(e => e.IStatusId).HasColumnName("iStatus_id");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.SApprovedName)
                    .HasColumnName("sApprovedName")
                    .HasMaxLength(30);

                entity.Property(e => e.SConsumptionFrequencyName)
                    .HasColumnName("sConsumptionFrequencyName")
                    .HasMaxLength(20);

                entity.Property(e => e.SCountryName)
                    .HasColumnName("sCountryName")
                    .HasMaxLength(50);

                entity.Property(e => e.SRecommendedProductName).HasColumnName("sRecommendedProductName");

                entity.Property(e => e.SStatusName)
                    .HasColumnName("sStatusName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblSalesList>(entity =>
            {
                entity.HasKey(e => e.ISalesListId)
                    .HasName("PK_tblSalesListnew");

                entity.ToTable("tblSalesList");

                entity.Property(e => e.ISalesListId).HasColumnName("iSalesList_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICustomerId).HasColumnName("iCustomer_id");

                entity.Property(e => e.IProductId).HasColumnName("iProduct_id");

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(50);

                entity.Property(e => e.SProductCount)
                    .HasColumnName("sProductCount")
                    .HasMaxLength(30);

                entity.Property(e => e.SProductImg)
                    .HasColumnName("sProductIMG")
                    .HasMaxLength(30);

                entity.Property(e => e.SProductName)
                    .HasColumnName("sProductName")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TblSalesQuantity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblSalesQuantity");

                entity.Property(e => e.IProductId).HasColumnName("iProduct_id");

                entity.Property(e => e.ISalesQuantityId)
                    .HasColumnName("iSalesQuantity_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SSalesTotal)
                    .HasColumnName("sSalesTotal")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblShoppingCar>(entity =>
            {
                entity.HasKey(e => e.IShoppingCarId);

                entity.ToTable("tblShoppingCar");

                entity.Property(e => e.IShoppingCarId).HasColumnName("iShoppingCar_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DHdateTime)
                    .HasColumnName("dHDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DIdateTime)
                    .HasColumnName("dIDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DSdateTime)
                    .HasColumnName("dSDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DTdateTime)
                    .HasColumnName("dTDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DTdateTimeD)
                    .HasColumnName("dTDateTimeD")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_Dt")
                    .HasColumnType("date");

                entity.Property(e => e.DYdateTime)
                    .HasColumnName("dYDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IListenstatus).HasColumnName("iListenstatus");

                entity.Property(e => e.IOrderCarId).HasColumnName("iOrderCar_id");

                entity.Property(e => e.IOrderNumber).HasColumnName("iOrderNumber");

                entity.Property(e => e.IProductDeposit)
                    .HasColumnName("iProductDeposit")
                    .HasColumnType("money");

                entity.Property(e => e.IProductId).HasColumnName("iProduct_id");

                entity.Property(e => e.IProductPrice)
                    .HasColumnName("iProductPrice")
                    .HasColumnType("money");

                entity.Property(e => e.IStatusId).HasColumnName("iStatus_id");

                entity.Property(e => e.ITheDeliveryTimeId).HasColumnName("iTheDeliveryTime_id");

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.IUserAddressId).HasColumnName("iUserAddress_id");

                entity.Property(e => e.IUserAddressTypeId).HasColumnName("iUserAddressType_id");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.SProfit)
                    .HasColumnName("sProfit")
                    .HasColumnType("money");

                entity.Property(e => e.SStatusName)
                    .HasColumnName("sStatusName")
                    .HasMaxLength(50);

                entity.Property(e => e.STheDeliveryTimeAmount)
                    .HasColumnName("sTheDeliveryTimeAmount")
                    .HasColumnType("money");

                entity.Property(e => e.STheDeliveryTimeDate)
                    .HasColumnName("sTheDeliveryTimeDate")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<TblShoppingCarCs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tblShoppingCarCS", "panaokCo_mMdwDe");

                entity.Property(e => e.IProductId).HasColumnName("iProduct_id");
            });

            modelBuilder.Entity<TblShoppingCarG>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tblShoppingCarG", "panaokCo_mMdwDe");

                entity.Property(e => e.Satis).HasColumnType("money");

                entity.Property(e => e.Teslimat).HasColumnType("date");

                entity.Property(e => e.ToplamKar).HasColumnType("money");
            });

            modelBuilder.Entity<TblShoppingCarGelirKar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tblShoppingCarGelirKar", "panaokCo_mMdwDe");

                entity.Property(e => e.DTdateTimeD)
                    .HasColumnName("dTDateTimeD")
                    .HasColumnType("date");

                entity.Property(e => e.IUserAddressId).HasColumnName("iUserAddress_id");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.Satis).HasColumnType("money");

                entity.Property(e => e.ToplamKar).HasColumnType("money");
            });

            modelBuilder.Entity<TblShoppingCarGelirveKar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tblShoppingCarGelirveKar", "panaokCo_mMdwDe");

                entity.Property(e => e.DTdateTime)
                    .HasColumnName("dTDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DTdateTimeD)
                    .HasColumnName("dTDateTimeD")
                    .HasColumnType("date");

                entity.Property(e => e.IUserAddressId).HasColumnName("iUserAddress_id");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.Satis).HasColumnType("money");

                entity.Property(e => e.ToplamKar).HasColumnType("money");
            });

            modelBuilder.Entity<TblShoppingCarKuriye>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tblShoppingCarKuriye", "panaokCo_mMdwDe");

                entity.Property(e => e.DTdateTimeD)
                    .HasColumnName("dTDateTimeD")
                    .HasColumnType("date");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.SiparisTutarı).HasColumnType("money");
            });

            modelBuilder.Entity<TblShoppingCarYeniKarList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tblShoppingCarYeniKarList", "panaokCo_mMdwDe");

                entity.Property(e => e.IOrderCarId).HasColumnName("iOrderCar_id");

                entity.Property(e => e.Kar).HasColumnType("money");
            });

            modelBuilder.Entity<TblState>(entity =>
            {
                entity.HasKey(e => e.IStateId);

                entity.ToTable("tblState");

                entity.Property(e => e.IStateId).HasColumnName("iState_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICountryId).HasColumnName("iCountry_id");

                entity.Property(e => e.ICreateUserFullName)
                    .HasColumnName("iCreateUserFullName")
                    .HasMaxLength(50);

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.IStateStatusId).HasColumnName("iStateStatus_id");

                entity.Property(e => e.IUpdateUserFullName)
                    .HasColumnName("iUpdateUserFullName")
                    .HasMaxLength(50);

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.SCapitalName)
                    .HasColumnName("sCapitalName")
                    .HasMaxLength(50);

                entity.Property(e => e.SCountryName)
                    .HasColumnName("sCountryName")
                    .HasMaxLength(50);

                entity.Property(e => e.SStateName)
                    .HasColumnName("sStateName")
                    .HasMaxLength(50);

                entity.Property(e => e.SStateStatus)
                    .HasColumnName("sStateStatus")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblStreet>(entity =>
            {
                entity.HasKey(e => e.IStreetId);

                entity.ToTable("tblStreet");

                entity.Property(e => e.IStreetId).HasColumnName("iStreet_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.INeighborhoodId).HasColumnName("iNeighborhood_id");

                entity.Property(e => e.IStreetStatusId).HasColumnName("iStreetStatus_id");

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.SNeighborhoodName)
                    .HasColumnName("sNeighborhoodName")
                    .HasMaxLength(50);

                entity.Property(e => e.SPostaCodeName)
                    .HasColumnName("sPostaCodeName")
                    .HasMaxLength(50);

                entity.Property(e => e.SStreetName)
                    .HasColumnName("sStreetName")
                    .HasMaxLength(50);

                entity.Property(e => e.SStreetStatus)
                    .HasColumnName("sStreetStatus")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblSubCategory>(entity =>
            {
                entity.HasKey(e => e.ISubCategoryId);

                entity.ToTable("tblSubCategory");

                entity.Property(e => e.ISubCategoryId).HasColumnName("iSubCategory_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_Dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICategoryId).HasColumnName("iCategory_id");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.ISubCategoryRow).HasColumnName("iSubCategoryRow");

                entity.Property(e => e.ISubCategoryStatusId).HasColumnName("iSubCategoryStatus_id");

                entity.Property(e => e.SCategoryName)
                    .HasColumnName("sCategoryName")
                    .HasMaxLength(50);

                entity.Property(e => e.SCreateUserFullName)
                    .HasColumnName("sCreateUserFullName")
                    .HasMaxLength(50);

                entity.Property(e => e.SDescription).HasColumnName("sDescription");

                entity.Property(e => e.SSubCategoryName)
                    .HasColumnName("sSubCategoryName")
                    .HasMaxLength(100);

                entity.Property(e => e.SSubCategoryNameTr)
                    .HasColumnName("sSubCategoryNameTr")
                    .HasMaxLength(100);

                entity.Property(e => e.SSubCategoryStatus)
                    .HasColumnName("sSubCategoryStatus")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TblTheDeliveryTime>(entity =>
            {
                entity.HasKey(e => e.ITheDeliveryTimeId);

                entity.ToTable("tblTheDeliveryTime");

                entity.Property(e => e.ITheDeliveryTimeId).HasColumnName("iTheDeliveryTime_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DHour).HasColumnName("dHour");

                entity.Property(e => e.ITheDeliveryTimeRanking).HasColumnName("iTheDeliveryTimeRanking");

                entity.Property(e => e.ITheDeliveryTimeStart).HasColumnName("iTheDeliveryTimeStart");

                entity.Property(e => e.SAmount)
                    .HasColumnName("sAmount")
                    .HasColumnType("money");

                entity.Property(e => e.SStatus)
                    .HasColumnName("sStatus")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.STheDeliveryTimeContent)
                    .HasColumnName("sTheDeliveryTimeContent")
                    .HasMaxLength(70);

                entity.Property(e => e.STheDeliveryTimeDate)
                    .HasColumnName("sTheDeliveryTimeDate")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblUseOfPoints>(entity =>
            {
                entity.HasKey(e => e.IUseOfPointsId);

                entity.ToTable("tblUseOfPoints");

                entity.Property(e => e.IUseOfPointsId).HasColumnName("iUseOfPoints_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.MTotalAmount)
                    .HasColumnName("mTotalAmount")
                    .HasColumnType("money");

                entity.Property(e => e.MUseOfPoints)
                    .HasColumnName("mUseOfPoints")
                    .HasColumnType("money");

                entity.Property(e => e.STheDeliveryTimeDate)
                    .HasColumnName("sTheDeliveryTimeDate")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblUseOfPoints1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tblUseOfPoints", "panaokCo_mMdwDe");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.OdenecekTutar).HasColumnType("money");

                entity.Property(e => e.OdenenTutar).HasColumnType("money");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.IUserId);

                entity.ToTable("tblUser");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.BArchived).HasColumnName("bArchived");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DBirthDate)
                    .HasColumnName("dBirthDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DFirstLoginDt)
                    .HasColumnName("dFirstLogin_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DLastLoginDt)
                    .HasColumnName("dLastLogin_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DLastPasswordChangeDt)
                    .HasColumnName("dLastPasswordChange_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DPasswordReminderControlDt)
                    .HasColumnName("dPasswordReminderControl_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DWrongPasswordEntryDt)
                    .HasColumnName("dWrongPasswordEntry_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IAddressId).HasColumnName("iAddress_id");

                entity.Property(e => e.ICourierNumber)
                    .HasColumnName("iCourierNumber")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ICreateUser).HasColumnName("iCreateUser");

                entity.Property(e => e.IGenderId).HasColumnName("iGender_id");

                entity.Property(e => e.ILastPasswordChangeId).HasColumnName("iLastPasswordChange_id");

                entity.Property(e => e.ILoginCount).HasColumnName("iLoginCount");

                entity.Property(e => e.IPasswordReminderControl).HasColumnName("iPasswordReminderControl");

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.IUserStatusId).HasColumnName("iUserStatus_id");

                entity.Property(e => e.IUserTypeId).HasColumnName("iUserType_id");

                entity.Property(e => e.IWrongPasswordEntryId).HasColumnName("iWrongPasswordEntry_id");

                entity.Property(e => e.MCreditAmount)
                    .HasColumnName("mCreditAmount")
                    .HasColumnType("money");

                entity.Property(e => e.PPhoto).HasColumnName("pPhoto");

                entity.Property(e => e.SBusinessPhone)
                    .HasColumnName("sBusinessPhone")
                    .HasMaxLength(30);

                entity.Property(e => e.SFirstName)
                    .HasColumnName("sFirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.SGenderName)
                    .HasColumnName("sGenderName")
                    .HasMaxLength(15);

                entity.Property(e => e.SNotes)
                    .HasColumnName("sNotes")
                    .HasColumnType("ntext");

                entity.Property(e => e.SPassword)
                    .HasColumnName("sPassword")
                    .HasMaxLength(50);

                entity.Property(e => e.SSurname)
                    .HasColumnName("sSurname")
                    .HasMaxLength(50);

                entity.Property(e => e.SUserFullName)
                    .HasColumnName("sUserFullName")
                    .HasMaxLength(50);

                entity.Property(e => e.SUserName)
                    .HasColumnName("sUserName")
                    .HasMaxLength(50);

                entity.Property(e => e.SRefreshToken).HasColumnName("sRefreshToken");

                entity.Property(e => e.DRefreshTokenEndDate).HasColumnName("dRefreshTokenEndDate").HasColumnType("datetime");

            });

            modelBuilder.Entity<TblUserAddress>(entity =>
            {
                entity.HasKey(e => e.IUserAddressId);

                entity.ToTable("tblUserAddress");

                entity.Property(e => e.IUserAddressId).HasColumnName("iUserAddress_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICountyId).HasColumnName("iCounty_id");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.INeighborhoodId).HasColumnName("iNeighborhood_id");

                entity.Property(e => e.ISelected).HasColumnName("iSelected");

                entity.Property(e => e.IStreetId).HasColumnName("iStreet_id");

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.SBusinessPhone)
                    .HasColumnName("sBusinessPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.SCountyName)
                    .HasColumnName("sCountyName")
                    .HasMaxLength(80);

                entity.Property(e => e.SFloor)
                    .HasColumnName("sFloor")
                    .HasMaxLength(20);

                entity.Property(e => e.SNo)
                    .HasColumnName("sNo")
                    .HasMaxLength(20);

                entity.Property(e => e.SPostaCodeName)
                    .HasColumnName("sPostaCodeName")
                    .HasMaxLength(50);

                entity.Property(e => e.SStreetName)
                    .HasColumnName("sStreetName")
                    .HasMaxLength(50);

                entity.Property(e => e.SUserAddressTypeId).HasColumnName("sUserAddressType_id");

                entity.Property(e => e.SUserAddressTypeName)
                    .HasColumnName("sUserAddressTypeName")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblUserMessage>(entity =>
            {
                entity.HasKey(e => e.IUserMessageId);

                entity.ToTable("tblUserMessage");

                entity.Property(e => e.IUserMessageId).HasColumnName("iUserMessage_id");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BEnable).HasColumnName("bEnable");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DReadDate)
                    .HasColumnName("dReadDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DReceiverDate)
                    .HasColumnName("dReceiverDate")
                    .HasColumnType("date");

                entity.Property(e => e.DReceiverDt)
                    .HasColumnName("dReceiver_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.IReadId).HasColumnName("iRead_id");

                entity.Property(e => e.IReceiverId).HasColumnName("iReceiver_id");

                entity.Property(e => e.ISenderDeleteDate)
                    .HasColumnName("iSenderDeleteDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ISenderDeleteId).HasColumnName("iSenderDelete_id");

                entity.Property(e => e.ISenderId).HasColumnName("iSender_id");

                entity.Property(e => e.SReadName)
                    .HasColumnName("sReadName")
                    .HasMaxLength(20);

                entity.Property(e => e.SSenderName)
                    .HasColumnName("sSenderName")
                    .HasMaxLength(20);

                entity.Property(e => e.SUserMessageContent)
                    .HasColumnName("sUserMessageContent")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<TbliPriceList>(entity =>
            {
                entity.HasKey(e => e.IPriceListId);

                entity.ToTable("tbliPriceList");

                entity.Property(e => e.IPriceListId).HasColumnName("iPriceList_id");

                entity.Property(e => e.DCreateDate)
                    .HasColumnName("dCreateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DCreateDt)
                    .HasColumnName("dCreate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DUpdateDate)
                    .HasColumnName("dUpdateDate")
                    .HasColumnType("date");

                entity.Property(e => e.DUpdateDt)
                    .HasColumnName("dUpdate_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.ICreateUserId).HasColumnName("iCreateUser_id");

                entity.Property(e => e.IProductId).HasColumnName("iProduct_id");

                entity.Property(e => e.ISalesQuantity).HasColumnName("iSalesQuantity");

                entity.Property(e => e.IUpdateUserId).HasColumnName("iUpdateUser_id");

                entity.Property(e => e.SWholesaler1)
                    .HasColumnName("sWholesaler1")
                    .HasMaxLength(20);

                entity.Property(e => e.SWholesaler2)
                    .HasColumnName("sWholesaler2")
                    .HasMaxLength(20);

                entity.Property(e => e.SWholesaler3)
                    .HasColumnName("sWholesaler3")
                    .HasMaxLength(20);

                entity.Property(e => e.SWholesaler4)
                    .HasColumnName("sWholesaler4")
                    .HasMaxLength(20);

                entity.Property(e => e.SWholesaler5)
                    .HasColumnName("sWholesaler5")
                    .HasMaxLength(20);

                entity.Property(e => e.SWholesaler6)
                    .HasColumnName("sWholesaler6")
                    .HasMaxLength(20);

                entity.Property(e => e.SWholesaler7)
                    .HasColumnName("sWholesaler7")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TbltblShoppingCarGt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tbltblShoppingCarGT", "panaokCo_mMdwDe");

                entity.Property(e => e.DTdateTimeD)
                    .HasColumnName("dTDateTimeD")
                    .HasColumnType("date");

                entity.Property(e => e.IUserAddressId).HasColumnName("iUserAddress_id");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.Satis).HasColumnType("money");

                entity.Property(e => e.ToplamKar).HasColumnType("money");
            });

            modelBuilder.Entity<TbltblShoppingCarKuryeT>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tbltblShoppingCarKuryeT", "panaokCo_mMdwDe");

                entity.Property(e => e.DTdateTime)
                    .HasColumnName("dTDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DTdateTimeD)
                    .HasColumnName("dTDateTimeD")
                    .HasColumnType("date");

                entity.Property(e => e.Expr1).HasColumnType("date");

                entity.Property(e => e.IUserAddressId).HasColumnName("iUserAddress_id");

                entity.Property(e => e.KuryeTutari).HasColumnType("money");
            });

            modelBuilder.Entity<TbltblShoppingCarKuryeveToplamList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_tbltblShoppingCarKuryeveToplamList", "panaokCo_mMdwDe");

                entity.Property(e => e.DTdateTime)
                    .HasColumnName("dTDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DTdateTimeD)
                    .HasColumnName("dTDateTimeD")
                    .HasColumnType("date");

                entity.Property(e => e.IUserAddressId).HasColumnName("iUserAddress_id");

                entity.Property(e => e.IUserId).HasColumnName("iUser_id");

                entity.Property(e => e.KuryeTutari).HasColumnType("money");

                entity.Property(e => e.Satis).HasColumnType("money");

                entity.Property(e => e.ToplamKar).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
