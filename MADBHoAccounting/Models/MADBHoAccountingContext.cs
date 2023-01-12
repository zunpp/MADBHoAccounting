using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MADBHoAccounting.Models
{
    public partial class MADBHoAccountingContext : DbContext
    {
        public MADBHoAccountingContext()
        {
        }

        public MADBHoAccountingContext(DbContextOptions<MADBHoAccountingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<G1> G1 { get; set; }
        public virtual DbSet<G2> G2 { get; set; }
        public virtual DbSet<G3> G3 { get; set; }
        public virtual DbSet<G4> G4 { get; set; }
        public virtual DbSet<In> In { get; set; }
        public virtual DbSet<TbAccountCashType> TbAccountCashType { get; set; }
        public virtual DbSet<TbAccountDetailEntry> TbAccountDetailEntry { get; set; }
        public virtual DbSet<TbAccountMainTitle> TbAccountMainTitle { get; set; }
        public virtual DbSet<TbAccountName> TbAccountName { get; set; }
        public virtual DbSet<TbAccountSubItem> TbAccountSubItem { get; set; }
        public virtual DbSet<TbAccountTransactionDetail> TbAccountTransactionDetail { get; set; }
        public virtual DbSet<TbAccountType> TbAccountType { get; set; }
        public virtual DbSet<TbDepartment> TbDepartment { get; set; }
        public virtual DbSet<TbFinancialYear> TbFinancialYear { get; set; }
        public virtual DbSet<TbLoginHistory> TbLoginHistory { get; set; }
        public virtual DbSet<TbRegion> TbRegion { get; set; }
        public virtual DbSet<TbStateDivision> TbStateDivision { get; set; }
        public virtual DbSet<TbTotalBalance> TbTotalBalance { get; set; }
        public virtual DbSet<TbTownAndDivision> TbTownAndDivision { get; set; }
        public virtual DbSet<TbTownship> TbTownship { get; set; }
        public virtual DbSet<TbUser> TbUser { get; set; }
        public virtual DbSet<TbUserLogin> TbUserLogin { get; set; }
        public virtual DbSet<VwAccountCashType> VwAccountCashType { get; set; }
        public virtual DbSet<VwAccountDetail> VwAccountDetail { get; set; }
        public virtual DbSet<VwAccountMainTitle> VwAccountMainTitle { get; set; }
        public virtual DbSet<VwAccountMainTitleforOnlineCheck> VwAccountMainTitleforOnlineCheck { get; set; }
        public virtual DbSet<VwAccountName> VwAccountName { get; set; }
        public virtual DbSet<VwAccountProgressive> VwAccountProgressive { get; set; }
        public virtual DbSet<VwAccountSubItem> VwAccountSubItem { get; set; }
        public virtual DbSet<VwAccountTitle> VwAccountTitle { get; set; }
        public virtual DbSet<VwAccountTransactionDetail> VwAccountTransactionDetail { get; set; }
        public virtual DbSet<VwAccountTransactionDetailSelectForOnlineCheck> VwAccountTransactionDetailSelectForOnlineCheck { get; set; }
        public virtual DbSet<VwAccountType> VwAccountType { get; set; }
        public virtual DbSet<VwBalance> VwBalance { get; set; }
        public virtual DbSet<VwBalancing> VwBalancing { get; set; }
        public virtual DbSet<VwCashScrollCr> VwCashScrollCr { get; set; }
        public virtual DbSet<VwCashScrollDr> VwCashScrollDr { get; set; }
        public virtual DbSet<VwCleanCash> VwCleanCash { get; set; }
        public virtual DbSet<VwDayBook> VwDayBook { get; set; }
        public virtual DbSet<VwDayBookHo> VwDayBookHo { get; set; }
        public virtual DbSet<VwDepartment> VwDepartment { get; set; }
        public virtual DbSet<VwEntry> VwEntry { get; set; }
        public virtual DbSet<VwEntryHeadAcc> VwEntryHeadAcc { get; set; }
        public virtual DbSet<VwExpendicture> VwExpendicture { get; set; }
        public virtual DbSet<VwExpendictureProgressive> VwExpendictureProgressive { get; set; }
        public virtual DbSet<VwFinancialHalfDate> VwFinancialHalfDate { get; set; }
        public virtual DbSet<VwFinancialYear> VwFinancialYear { get; set; }
        public virtual DbSet<VwGeneralLedger> VwGeneralLedger { get; set; }
        public virtual DbSet<VwIncome> VwIncome { get; set; }
        public virtual DbSet<VwIncomeProgressive> VwIncomeProgressive { get; set; }
        public virtual DbSet<VwIncomeSelect> VwIncomeSelect { get; set; }
        public virtual DbSet<VwJicaloanReturnTransPeopleGroupByRegion> VwJicaloanReturnTransPeopleGroupByRegion { get; set; }
        public virtual DbSet<VwJicaloanReturnTransactionGroupByRegion> VwJicaloanReturnTransactionGroupByRegion { get; set; }
        public virtual DbSet<VwLoanInterestDetailTransaction> VwLoanInterestDetailTransaction { get; set; }
        public virtual DbSet<VwLoanReturnTransPeopleGroupByRegion> VwLoanReturnTransPeopleGroupByRegion { get; set; }
        public virtual DbSet<VwLoanReturnTransactionGroupByRegion> VwLoanReturnTransactionGroupByRegion { get; set; }
        public virtual DbSet<VwMonthReturn> VwMonthReturn { get; set; }
        public virtual DbSet<VwRegion> VwRegion { get; set; }
        public virtual DbSet<VwStateDivision> VwStateDivision { get; set; }
        public virtual DbSet<VwSusidiary> VwSusidiary { get; set; }
        public virtual DbSet<VwTotalBalance> VwTotalBalance { get; set; }
        public virtual DbSet<VwTownAndAccount> VwTownAndAccount { get; set; }
        public virtual DbSet<VwTownAndAccountBalance> VwTownAndAccountBalance { get; set; }
        public virtual DbSet<VwTownship> VwTownship { get; set; }
        public virtual DbSet<VwTownshipName> VwTownshipName { get; set; }
        public virtual DbSet<VwTransferScrollCr> VwTransferScrollCr { get; set; }
        public virtual DbSet<VwTransferScrollDr> VwTransferScrollDr { get; set; }
        public virtual DbSet<VwTrialBalance> VwTrialBalance { get; set; }
        public virtual DbSet<VwTribalance> VwTribalance { get; set; }
        public virtual DbSet<VwUser> VwUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MKTMGR\\SQLEXPRESS;Database=MADBHoAccounting;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<G1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccountCode).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.MiniAccount).HasMaxLength(255);

                entity.Property(e => e.TownCode).HasMaxLength(255);
            });

            modelBuilder.Entity<G2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccountCode).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.MiniAccount).HasMaxLength(255);

                entity.Property(e => e.TownCode).HasMaxLength(255);
            });

            modelBuilder.Entity<G3>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccountCode).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.MiniAccount).HasMaxLength(255);

                entity.Property(e => e.TownCode).HasMaxLength(255);
            });

            modelBuilder.Entity<G4>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccountCode).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.MiniAccount).HasMaxLength(255);

                entity.Property(e => e.TownCode).HasMaxLength(255);
            });

            modelBuilder.Entity<In>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("in");

                entity.Property(e => e.AccountMainTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountMainTitleInEnglish).HasMaxLength(200);

                entity.Property(e => e.AccountMainTitleInMyanmar).HasMaxLength(500);

                entity.Property(e => e.AccountNatural)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSubTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountSubTitleInEnglish).HasMaxLength(500);

                entity.Property(e => e.AccountSubTitleInMyanmar).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbAccountCashType>(entity =>
            {
                entity.HasKey(e => e.AccountCashPkid);

                entity.ToTable("TB_AccountCashType");

                entity.Property(e => e.AccountCashType).HasMaxLength(50);

                entity.Property(e => e.AccountCashTypeId)
                    .HasColumnName("AccountCashTypeID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbAccountDetailEntry>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("TB_AccountDetailEntry");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MiniAccount).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TownCode).HasMaxLength(50);
            });

            modelBuilder.Entity<TbAccountMainTitle>(entity =>
            {
                entity.HasKey(e => e.AccountMainTitlePkid);

                entity.ToTable("TB_AccountMainTitle");

                entity.Property(e => e.AccountMainTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountMainTitleInEnglish).HasMaxLength(200);

                entity.Property(e => e.AccountMainTitleInMyanmar).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbAccountName>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("TB_AccountName");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountCode).HasMaxLength(10);

                entity.Property(e => e.AccountNature).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MainHeadName).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderCode).HasMaxLength(5);

                entity.Property(e => e.SubsiHeadName).HasMaxLength(250);
            });

            modelBuilder.Entity<TbAccountSubItem>(entity =>
            {
                entity.HasKey(e => e.AccountSubItemPkid);

                entity.ToTable("TB_AccountSubItem");

                entity.Property(e => e.AccountMainTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountSubTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountSubTitleInEnglish).HasMaxLength(500);

                entity.Property(e => e.AccountSubTitleInMyanmar).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbAccountTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.AccountPkid);

                entity.ToTable("TB_AccountTransactionDetail");

                entity.Property(e => e.AccountCashTypeId)
                    .HasColumnName("AccountCashTypeID")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountMainTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountSubTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountTypeForHo)
                    .HasColumnName("AccountTypeForHO")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.LocationOfAccountTypeForHo)
                    .HasColumnName("LocationOfAccountTypeForHO")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbAccountType>(entity =>
            {
                entity.HasKey(e => e.AccountTypePkid);

                entity.ToTable("TB_AccountType");

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.AccountTypeId)
                    .HasColumnName("AccountTypeID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentPkid);

                entity.ToTable("TB_Department");

                entity.Property(e => e.Department).HasMaxLength(500);

                entity.Property(e => e.DepartmentCode).HasMaxLength(50);
            });

            modelBuilder.Entity<TbFinancialYear>(entity =>
            {
                entity.HasKey(e => e.FinancialYearPkid);

                entity.ToTable("TB_FinancialYear");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FinancialEndDate).HasColumnType("datetime");

                entity.Property(e => e.FinancialMiddleDate).HasColumnType("datetime");

                entity.Property(e => e.FinancialStartDate).HasColumnType("datetime");

                entity.Property(e => e.FinancialYear).HasMaxLength(50);
            });

            modelBuilder.Entity<TbLoginHistory>(entity =>
            {
                entity.HasKey(e => e.LogInHistoryPkid);

                entity.ToTable("TB_LoginHistory");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Pcname)
                    .HasColumnName("PCName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbRegion>(entity =>
            {
                entity.HasKey(e => e.RegionPkid);

                entity.ToTable("TB_Region");

                entity.Property(e => e.Region).HasMaxLength(500);

                entity.Property(e => e.RegionCode).HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbStateDivision>(entity =>
            {
                entity.HasKey(e => e.StateDivisionPkid);

                entity.ToTable("TB_StateDivision");

                entity.Property(e => e.StateDivision).HasMaxLength(50);

                entity.Property(e => e.StateDivisionCode).HasMaxLength(50);
            });

            modelBuilder.Entity<TbTotalBalance>(entity =>
            {
                entity.HasKey(e => e.TotalBalancePkid);

                entity.ToTable("TB_TotalBalance");

                entity.Property(e => e.CloseCashCreditTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CloseCashDebitTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CloseCreditTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CloseDebitTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CloseTransferCreditTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CloseTransferDebitTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OpenCashCreditTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenCashDebitTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenCreditTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenDebitTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenTransferCreditTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenTransferDebitTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedMonthOfYear).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbTownAndDivision>(entity =>
            {
                entity.HasKey(e => e.TownId);

                entity.ToTable("TB_TownAndDivision");

                entity.Property(e => e.TownId).HasColumnName("TownID");

                entity.Property(e => e.DiviSionName).HasMaxLength(150);

                entity.Property(e => e.DivisionCode).HasMaxLength(4);

                entity.Property(e => e.GroupNumber).HasMaxLength(50);

                entity.Property(e => e.TownCode).HasMaxLength(10);

                entity.Property(e => e.TownName).HasMaxLength(150);

                entity.Property(e => e.TownOrderCode).HasMaxLength(3);
            });

            modelBuilder.Entity<TbTownship>(entity =>
            {
                entity.HasKey(e => e.TownshipPkid);

                entity.ToTable("TB_Township");

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.Township).HasMaxLength(500);

                entity.Property(e => e.TownshipCode).HasMaxLength(50);

                entity.Property(e => e.UploadForTownship).HasMaxLength(50);
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.HasKey(e => e.UserPkid);

                entity.ToTable("TB_User");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode).HasMaxLength(50);

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.LogoutTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<TbUserLogin>(entity =>
            {
                entity.HasKey(e => e.UserPkid);

                entity.ToTable("TB_UserLogin");

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Office)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UsernameOrEmail)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwAccountCashType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountCashType");

                entity.Property(e => e.AccountCashPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.AccountCashType).HasMaxLength(50);

                entity.Property(e => e.AccountCashTypeId)
                    .HasColumnName("AccountCashTypeID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwAccountDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountDetail");

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiviSionName).HasMaxLength(150);

                entity.Property(e => e.GroupNumber).HasMaxLength(50);

                entity.Property(e => e.MainHeadName).HasMaxLength(250);

                entity.Property(e => e.MiniAccount).HasMaxLength(50);

                entity.Property(e => e.SubsiHeadName).HasMaxLength(250);

                entity.Property(e => e.TownCode).HasMaxLength(50);

                entity.Property(e => e.TownName).HasMaxLength(150);
            });

            modelBuilder.Entity<VwAccountMainTitle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountMainTitle");

                entity.Property(e => e.AccountMainTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountMainTitleInEnglish).HasMaxLength(200);

                entity.Property(e => e.AccountMainTitleInMyanmar).HasMaxLength(500);

                entity.Property(e => e.AccountMainTitlePkid).ValueGeneratedOnAdd();

                entity.Property(e => e.AccountNatural)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwAccountMainTitleforOnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AccountMainTitleforOnlineCheck");

                entity.Property(e => e.AccountMainTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountMainTitleInEnglish).HasMaxLength(200);

                entity.Property(e => e.AccountMainTitleInMyanmar).HasMaxLength(500);

                entity.Property(e => e.AccountMainTitlePkid).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwAccountName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountName");

                entity.Property(e => e.AccountCode).HasMaxLength(10);

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccountNature).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MainHeadName).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderCode).HasMaxLength(5);

                entity.Property(e => e.SubsiHeadName).HasMaxLength(250);
            });

            modelBuilder.Entity<VwAccountProgressive>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountProgressive");

                entity.Property(e => e.PayAllowanceAcc)
                    .IsRequired()
                    .HasColumnName("Pay_Allowance_Acc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAccountSubItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountSubItem");

                entity.Property(e => e.AccountMainTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountSubItemPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.AccountSubTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountSubTitleInEnglish).HasMaxLength(500);

                entity.Property(e => e.AccountSubTitleInMyanmar).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAccountTitle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountTitle");

                entity.Property(e => e.AccountMainTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountMainTitleInEnglish).HasMaxLength(200);

                entity.Property(e => e.AccountMainTitleInMyanmar).HasMaxLength(500);

                entity.Property(e => e.AccountNatural)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSubTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountSubTitleInEnglish).HasMaxLength(500);

                entity.Property(e => e.AccountSubTitleInMyanmar).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwAccountTransactionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountTransactionDetail");

                entity.Property(e => e.AccountCashType).HasMaxLength(50);

                entity.Property(e => e.AccountCashTypeId)
                    .HasColumnName("AccountCashTypeID")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountMainTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountMainTitleInEnglish).HasMaxLength(200);

                entity.Property(e => e.AccountMainTitleInMyanmar).HasMaxLength(500);

                entity.Property(e => e.AccountSubTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountSubTitleInEnglish).HasMaxLength(500);

                entity.Property(e => e.AccountSubTitleInMyanmar).HasMaxLength(500);

                entity.Property(e => e.AccountTypeForHo)
                    .HasColumnName("AccountTypeForHO")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.LocationOfAccountTypeForHo)
                    .HasColumnName("LocationOfAccountTypeForHO")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAccountTransactionDetailSelectForOnlineCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AccountTransactionDetail_SelectForOnlineCheck");

                entity.Property(e => e.AccountCashTypeId)
                    .HasColumnName("AccountCashTypeID")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountMainTitleCode).HasMaxLength(50);

                entity.Property(e => e.AccountPkid).ValueGeneratedOnAdd();

                entity.Property(e => e.AccountSubTitleCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAccountType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAccountType");

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.AccountTypeId)
                    .HasColumnName("AccountTypeID")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountTypePkid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Balance");

                entity.Property(e => e.Balance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBalancing>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwBalancing");

                entity.Property(e => e.AccountNatural)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSubTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DebitAmount).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCashScrollCr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCashScrollCR");

                entity.Property(e => e.AccountMainTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCashScrollDr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCashScrollDR");

                entity.Property(e => e.AccountMainTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCleanCash>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCleanCash");

                entity.Property(e => e.AccountMainTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Debit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDayBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDayBook");

                entity.Property(e => e.Credit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Debit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.MainHead)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDayBookHo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDayBookHO");

                entity.Property(e => e.AccountMainTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSubTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCash)
                    .HasColumnName("Credit_Cash")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.CreditTransfer)
                    .HasColumnName("Credit_Transfer")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DebitCash)
                    .HasColumnName("Debit_Cash")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DebitTransfer)
                    .HasColumnName("Debit_Transfer")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDepartment");

                entity.Property(e => e.Department).HasMaxLength(500);

                entity.Property(e => e.DepartmentCode).HasMaxLength(50);

                entity.Property(e => e.DepartmentPkid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEntry");

                entity.Property(e => e.AccountSubTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DebitAmount).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEntryHeadAcc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwEntryHeadAcc");

                entity.Property(e => e.AccountMainTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DebitAmount).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwExpendicture>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwExpendicture");

                entity.Property(e => e.DuringMonth).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.EndOfMonth).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Subsihead)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwExpendictureProgressive>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwExpendictureProgressive");

                entity.Property(e => e.ACleaning)
                    .HasColumnName("A_Cleaning")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Accommodation).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Advertisement).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.AdvertisementJica)
                    .HasColumnName("Advertisement_JICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.BDwoffice)
                    .HasColumnName("B_DWOffice")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.BankingSoftwareOther).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.CWages1Persentage)
                    .HasColumnName("C_Wages1Persentage")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DOther)
                    .HasColumnName("D_Other")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DefurEquipment)
                    .HasColumnName("DEFurEquipment")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DeofficeBuilding)
                    .HasColumnName("DEOfficeBuilding")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DeofficeEquipment)
                    .HasColumnName("DEOfficeEquipment")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DeofficeVehicle)
                    .HasColumnName("DEOfficeVehicle")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DiviSionName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Entertainment).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.ExhibitionExpense).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.ExhibitionJica).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.ExhibitionMeb)
                    .HasColumnName("ExhibitionMEB")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Fireprevention).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.FurnitureAndOtherJica)
                    .HasColumnName("FurnitureAndOtherJICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Insurance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntOnMeb)
                    .HasColumnName("IntOnMEB")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntOnMebJica)
                    .HasColumnName("IntOnMEB_JICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntOnResidentSavingDeposit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntOnRsd)
                    .HasColumnName("IntOnRSD")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.LightingPower).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.MealAllowance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.MfurnitureOther)
                    .HasColumnName("MFurnitureOther")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.MofficeBuilding)
                    .HasColumnName("MOfficeBuilding")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.MofficeEquipment)
                    .HasColumnName("MOfficeEquipment")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.MofficeVehicle)
                    .HasColumnName("MOfficeVehicle")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Newspaper).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.OfficeBuildingJica)
                    .HasColumnName("OfficeBuildingJICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.OfficeEquipmentJica)
                    .HasColumnName("OfficeEquipmentJICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.OfficeSupplies).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.OfficeSuppliesCovid19).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.OfficeSuppliesJica)
                    .HasColumnName("OfficeSuppliesJICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.OfficeSuppliesMeb)
                    .HasColumnName("OfficeSuppliesMEB")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.OfficeSuppliesSunflower).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.OfficeVehicleJica)
                    .HasColumnName("OfficeVehicleJICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.OtherGeneral).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PS)
                    .HasColumnName("P_S")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PSCovid19)
                    .HasColumnName("P_S_Covid19")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PSJica)
                    .HasColumnName("P_S_Jica")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PSMeb)
                    .HasColumnName("P_S_MEB")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PSSunflower)
                    .HasColumnName("P_S_Sunflower")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PatrolOilLubri).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PayAllwance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Pension).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Ptt)
                    .HasColumnName("PTT")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.RateTaxs).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Rbc)
                    .HasColumnName("RBC")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.RbcCovid19)
                    .HasColumnName("RBC_Covid19")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Rbcjica)
                    .HasColumnName("RBCJICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Rbcmeb)
                    .HasColumnName("RBCMEB")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Rbcsunflower)
                    .HasColumnName("RBCSunflower")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Rent).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.SpecialAllowance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TAndH)
                    .HasColumnName("T_and_H")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TAndHCovid19)
                    .HasColumnName("T_and_H_Covid19")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TAndHJica)
                    .HasColumnName("T_and_H_Jica")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TAndHMeb)
                    .HasColumnName("T_and_H_MEB")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TAndHSunflower)
                    .HasColumnName("T_and_H_Sunflower")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Ta)
                    .HasColumnName("TA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TaJica)
                    .HasColumnName("TA_JICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TaMeb)
                    .HasColumnName("TA_MEB")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Tasunflower)
                    .HasColumnName("TASunflower")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownOrderCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingExpense).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TrainingJica)
                    .HasColumnName("TrainingJICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TrainingMeb)
                    .HasColumnName("TrainingMEB")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TravellingCovid19).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.UniformAllwance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.VehicleRentalExpenseMeb)
                    .HasColumnName("VehicleRentalExpenseMEB")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.VehicleRexpense)
                    .HasColumnName("VehicleRExpense")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.VreJica)
                    .HasColumnName("VRE_JICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Wages).HasColumnType("numeric(2, 2)");
            });

            modelBuilder.Entity<VwFinancialHalfDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwFinancialHalfDate");

                entity.Property(e => e.HalfDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwFinancialYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwFinancialYear");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FinancialEndDate).HasColumnType("datetime");

                entity.Property(e => e.FinancialMiddleDate).HasColumnType("datetime");

                entity.Property(e => e.FinancialStartDate).HasColumnType("datetime");

                entity.Property(e => e.FinancialYear).HasMaxLength(50);

                entity.Property(e => e.FinancialYearPkid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGeneralLedger>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGeneralLedger");

                entity.Property(e => e.AccountMainTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNatural)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DebitAmount).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwIncome>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwIncome");

                entity.Property(e => e.DuringMonth).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.EndOfMonth).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.SubsiHead)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwIncomeProgressive>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwIncomeProgressive");

                entity.Property(e => e.DiviSionName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FeeAndCommission).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntCovid19)
                    .HasColumnName("Int_Covid19")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntLrsLtlJica)
                    .HasColumnName("Int_LRS_LTL_JICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntLrsStlJica)
                    .HasColumnName("Int_LRS_STL_JICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntLsl)
                    .HasColumnName("Int_LSL")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntLtl)
                    .HasColumnName("Int_LTL")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntLtrs)
                    .HasColumnName("Int_LTRS")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntMebLtl)
                    .HasColumnName("Int_MEB_LTL")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntMebStl)
                    .HasColumnName("Int_MEB_STL")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntOverdraft)
                    .HasColumnName("Int_Overdraft")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntSlc)
                    .HasColumnName("Int_SLC")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.IntStl)
                    .HasColumnName("Int_STL")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Misc).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PenIntCovid19)
                    .HasColumnName("PenInt_Covid19")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PenIntLrsLtlJica)
                    .HasColumnName("PenInt_LRS_LTL_JICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PenIntLrsLtlMeb)
                    .HasColumnName("PenInt_LRS_LTL_MEB")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PenIntLrsStlJica)
                    .HasColumnName("PenInt_LRS_STL_JICA")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PenIntLrsStlMeb)
                    .HasColumnName("PenInt_LRS_STL_MEB")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PenIntLs)
                    .HasColumnName("PenInt_LS")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PenIntLt)
                    .HasColumnName("PenInt_LT")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PenIntLtrs)
                    .HasColumnName("PenIntLTRS")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PenIntSlc)
                    .HasColumnName("PenInt_SLC")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.PenIntSt)
                    .HasColumnName("PenInt_ST")
                    .HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownOrderCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwIncomeSelect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwIncomeSelect");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DuringMonth).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.EndOfMonth).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.SubsiHead)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwJicaloanReturnTransPeopleGroupByRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJICALoanReturnTransPeopleGroupByRegion");

                entity.Property(e => e.DebtPeople)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DebtPeoplePercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MachineType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PeoplePercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPeople)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwJicaloanReturnTransactionGroupByRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwJICALoanReturnTransactionGroupByRegion");

                entity.Property(e => e.BalancePercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MachineType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnedPercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .IsRequired()
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoan)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLoanInterestDetailTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLoanInterestDetailTransaction");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Balance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanSeason)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nrc)
                    .IsRequired()
                    .HasColumnName("NRC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PersonPkid).HasColumnName("PersonPKID");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAmount)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .IsRequired()
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasColumnName("TransactionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLoanReturnTransPeopleGroupByRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLoanReturnTransPeopleGroupByRegion");

                entity.Property(e => e.DebtPeople)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DebtPeoplePercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanSeason)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PeoplePercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPeople)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLoanReturnTransactionGroupByRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwLoanReturnTransactionGroupByRegion");

                entity.Property(e => e.BalancePercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanSeason)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoanYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnedPercentage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateDivisionId)
                    .IsRequired()
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoan)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalReturn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipId)
                    .IsRequired()
                    .HasColumnName("TownshipID")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwMonthReturn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMonthReturn");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountDescription)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Debit).HasColumnType("numeric(2, 2)");
            });

            modelBuilder.Entity<VwRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwRegion");

                entity.Property(e => e.Region).HasMaxLength(500);

                entity.Property(e => e.RegionCode).HasMaxLength(50);

                entity.Property(e => e.Township).HasMaxLength(500);

                entity.Property(e => e.TownshipId)
                    .HasColumnName("TownshipID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwStateDivision>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwStateDivision");

                entity.Property(e => e.StateDivision).HasMaxLength(50);

                entity.Property(e => e.StateDivisionCode).HasMaxLength(50);

                entity.Property(e => e.StateDivisionPkid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSusidiary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwSusidiary");

                entity.Property(e => e.AccountNatural)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSubTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSubTitleInMyanmar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.DebitAmount).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwTotalBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTotalBalance");

                entity.Property(e => e.CloseCashCreditTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CloseCashDebitTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CloseCreditTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CloseDebitTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CloseTransferCreditTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CloseTransferDebitTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OpenCashCreditTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenCashDebitTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenCreditTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenDebitTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenTransferCreditTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OpenTransferDebitTotalBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalBalancePkid).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedMonthOfYear).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwTownAndAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTownAndAccount");

                entity.Property(e => e.CodeTownName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Debit).HasColumnType("numeric(2, 2)");
            });

            modelBuilder.Entity<VwTownAndAccountBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTownAndAccountBalance");

                entity.Property(e => e.Balance).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.CodeTownName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwTownship>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTownship");

                entity.Property(e => e.StateDivision).HasMaxLength(50);

                entity.Property(e => e.StateDivisionId)
                    .HasColumnName("StateDivisionID")
                    .HasMaxLength(50);

                entity.Property(e => e.Township).HasMaxLength(500);

                entity.Property(e => e.TownshipCode).HasMaxLength(50);

                entity.Property(e => e.UploadForTownship).HasMaxLength(50);
            });

            modelBuilder.Entity<VwTownshipName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTownshipName");

                entity.Property(e => e.Township)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TownshipCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwTransferScrollCr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTransferScrollCR");

                entity.Property(e => e.AccountMainTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwTransferScrollDr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTransferScrollDR");

                entity.Property(e => e.AccountMainTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Debit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwTrialBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTrialBalance");

                entity.Property(e => e.AccountMainTitleCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AccountMainTitleInEnglish)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Credit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Debit).HasColumnType("numeric(2, 2)");
            });

            modelBuilder.Entity<VwTribalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTribalance");

                entity.Property(e => e.Credit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.Debit).HasColumnType("numeric(2, 2)");

                entity.Property(e => e.MainHead)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwUser");

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Department).HasMaxLength(500);

                entity.Property(e => e.DepartmentCode).HasMaxLength(50);

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.LogoutTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
