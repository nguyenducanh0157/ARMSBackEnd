using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class SupplierSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public SupplierSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed Supplier
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier() {SupplierId=1, SupplierName="Fpt Software",Img= "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FFptSoftware.png?alt=media&token=552c0a51-fdea-4795-acd7-fd10fe5cb45f" },
                new Supplier() { SupplierId = 2, SupplierName = "Tập đoàn bưu chính viễn thông", Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FVNPT.png?alt=media&token=96d1f135-015a-4c8c-a8a3-dbd283cbd345" },
                new Supplier() { SupplierId = 3, SupplierName = "Base.vn", Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FBase.vn.png?alt=media&token=be9f0ae0-8704-4cf5-b20c-d344d7d9ea3c" },
                new Supplier() { SupplierId = 4, SupplierName = "UniMedia", Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FUniMedia.png?alt=media&token=8b223dea-5076-485c-95c8-467c39568c88" },
                new Supplier() { SupplierId = 5, SupplierName = "Avepoint Việt Nam", Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FAvepoint.png?alt=media&token=ebbbdabb-d411-4a6b-a57b-a16b1c144a8c" },
                new Supplier() { SupplierId = 6, SupplierName = "CMC", Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FCMC.jpg?alt=media&token=e37589d5-9907-44fd-abac-a1ace3537f27" },
                new Supplier() { SupplierId = 7, SupplierName = "Kaopiz", Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FKaopiz.png?alt=media&token=b9d29e81-712e-4b78-b8c3-2d74144347f3" },
                new Supplier() { SupplierId = 8, SupplierName = "Viettel", Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Supplier%2FViettel.png?alt=media&token=3493a983-26d0-4c41-967e-341c3cfcc269" }
                );

        }
    }
}
