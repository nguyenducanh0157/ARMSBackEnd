using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class CampusSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public CampusSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed campus
            modelBuilder.Entity<Campus>().HasData(
                new Campus() { 
                    CampusId = "Hanoi",
                    CampusName = "Hà Nội", 
                    Address= "Cổng số 1, Tòa nhà FPT Polytechnic, 13 phố Trịnh Văn Bô, phường Phương Canh, quận Nam Từ Liêm, TP Hà NộiKm12 Cầu Diễn, Phường Phúc Diễn, Quận Bắc Từ Liêm, Hà Nội", 
                    PhoneNumber = "02485820808" 
                },
                new Campus() { 
                    CampusId = "Danang",
                    CampusName = "Đà Nẵng",
                    Address = "219 Nguyễn Sinh Sắc, phường Hoà Minh, quận Liên Chiểu, TP Đà Nẵng",
                    PhoneNumber = "02363710999"
                },
                new Campus() { 
                    CampusId = "Cantho",
                    CampusName = "Cần Thơ",
                    Address = "Toà nhà FPT Polytechnic, đường số 22, phường Thường Thạnh,quận Cái Răng, TP Cần Thơ",
                    PhoneNumber = "0983881100"
                },
                new Campus() { 
                    CampusId = "HCM",
                    CampusName = "Tp HCM",
                    Address = "Tòa nhà QTSC9 (toà T), đường Tô Ký, phường Tân Chánh Hiệp, quận 12, TP HCM.778/B1 Nguyễn Kiệm, phường 04, quận Phú Nhuận, TP HCM",
                    PhoneNumber= "02866866486"
                },
                new Campus() { 
                    CampusId = "Thanhhoa", 
                    CampusName = "Thanh Hoá",
                    Address = "Tòa Beta, Tổ hợp giáo dục FPT, Đại lộ Võ Nguyên Giáp, phường Quảng Thành, TP Thanh Hóa",
                    PhoneNumber = "0913785213"
                }
                );

        }
    }
}
