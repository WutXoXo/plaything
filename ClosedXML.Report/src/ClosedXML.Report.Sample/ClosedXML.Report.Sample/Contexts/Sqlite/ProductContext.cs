using ClosedXML.Report.Sample.Entities.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosedXML.Report.Sample.Contexts.Sqlite
{
    public class ProductContext : DbContext
    {
        #region Contructor
        public ProductContext(DbContextOptions<ProductContext> options)
                : base(options)
        {
        }
        #endregion


        #region Public properties
        public DbSet<ProductEntity> Product { get; set; }
        #endregion

        /// <summary>
        /// On Configuring
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Report.db");

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Private methods
        private List<ProductEntity> GetProducts()
        {
            return new List<ProductEntity>
            {
                new ProductEntity { Id = 1,Code = "8850125082311",Barcode = "8850125082311", Name = "ไมโล เครื่องดื่มช็อกโกแลตมอลต์ปรุงสำเร็จชนิดผง สูตรน้ำตาลน้อย 25 กรัม แพ็ค 15",Quantity = 100,Price = 98,IsActive =true,CreatedBy =1,CreatedAt=DateTime.Now,UpdatedBy=1,UpdatedAt =DateTime.Now },
                new ProductEntity { Id = 2,Code = "8851959632185",Barcode = "8851959632185", Name = "แฟนต้า น้ำอัดลม น้ำเขียว 325 มล. 6 กระป๋อง",Quantity = 200,Price = 72,IsActive =true,CreatedBy =1,CreatedAt=DateTime.Now,UpdatedBy=1,UpdatedAt =DateTime.Now },
                new ProductEntity { Id = 3,Code = "8850250004943",Barcode = "8850250004943", Name = "ยำยำ บะหมี่กึ่งสำเร็จรูป รสต้มยำกุ้ง 67 ก. แพ็ค",Quantity = 300,Price = 48,IsActive =true,CreatedBy =1,CreatedAt=DateTime.Now,UpdatedBy=1,UpdatedAt =DateTime.Now },
                new ProductEntity { Id = 4,Code = "8850006322499",Barcode = "8850006322499", Name = "คอลเกต ยาสีฟัน สูตรเกลือสมุนไพร 150 กรัม แพ็ค 2",Quantity = 400,Price = 99,IsActive =true,CreatedBy =1,CreatedAt=DateTime.Now,UpdatedBy=1,UpdatedAt =DateTime.Now },
                new ProductEntity { Id = 5,Code = "8888336032917",Barcode = "8888336032917", Name = "ฮักกี้ส์ โกลด์ ซอฟท์แอนด์สลิม แพ้นท์ กางเกงผ้าอ้อมเด็ก ขนาด XL แพ็ค 38 ชิ้น",Quantity = 500,Price = 449,IsActive =true,CreatedBy =1,CreatedAt=DateTime.Now,UpdatedBy=1,UpdatedAt =DateTime.Now }
            };
        }
        #endregion
    }
}
