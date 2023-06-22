using QLNS.BLL;
using QLNS.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace QLNS
{
    public class QLNS_Entity : DbContext
    {
        public QLNS_Entity()
            : base("name=QLNS_Entity")
        {
            Database.SetInitializer<QLNS_Entity>(new CreateDB());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            AddStamps();
            return base.SaveChanges();
        }

        private void AddStamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow; // current datetime

                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = now;
                    ((BaseEntity)entity.Entity).IsDeleted = false;
                    if (BLL_Login.Instance.id_account != 0) ((BaseEntity)entity.Entity).CreatedBy = BLL_Login.Instance.GetStaff().ID_Staff;
                }
                //if (entity.State == EntityState.Deleted)
                //{
                //    ((BaseEntity)entity.Entity).DeletedAt = now;
                //    ((BaseEntity)entity.Entity).DeletedBy = BLL_Login.Instance.GetStaff().ID_Staff;
                //    ((BaseEntity)entity.Entity).IsDeleted = true;
                //}    
                if ((bool)(((BaseEntity)entity.Entity).IsDeleted == true))
                {
                    ((BaseEntity)entity.Entity).DeletedAt = now;
                    ((BaseEntity)entity.Entity).DeletedBy = BLL_Login.Instance.GetStaff().ID_Staff;
                }    
                ((BaseEntity)entity.Entity).UpdatedAt = now;
                if (BLL_Login.Instance.id_account != 0) ((BaseEntity)entity.Entity).UpdatedBy = BLL_Login.Instance.GetStaff().ID_Staff;
            }
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Book_Discount> Book_Discounts { get; set; }
        public virtual DbSet<Book_Entry_Diary> Book_Entry_Diarys { get; set; }
        public virtual DbSet<Book_Warehouse> Book_Warehouses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Detail_Bill> Detail_Bills { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Publish> Publishes { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<User_Account> User_Accounts { get; set; }
        public virtual DbSet<User_Role> User_Roles { get; set; }
    }
}