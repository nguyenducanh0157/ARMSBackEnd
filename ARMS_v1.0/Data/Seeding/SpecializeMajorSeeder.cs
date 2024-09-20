using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class SpecializeMajorSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public SpecializeMajorSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed SpecializeMajor
            modelBuilder.Entity<SpecializeMajor>().HasData(
                new SpecializeMajor() { 
                    MajorID = "E",
                    SpecializeMajorID = "ME",
                    SpecializeMajorName = "Lập trình mobile",
                    MajorCode = "7480201",
                    Description = "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.",
                    TimeStudy ="2 năm"
                },
                new SpecializeMajor() { MajorID = "E", SpecializeMajorID = "GE", SpecializeMajorName = "Lập trình game", MajorCode = "7480201",
                    Description = "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.",
                    TimeStudy = "2 năm"
                },
                new SpecializeMajor() { MajorID = "E", SpecializeMajorID = "WE", SpecializeMajorName = "Lập trình web", MajorCode = "7480201",
                    Description = "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.",
                    TimeStudy = "2 năm"
                },
                new SpecializeMajor() { MajorID = "E", SpecializeMajorID = "TE", SpecializeMajorName = "Kiểm thử", MajorCode = "7480201",
                    Description = "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.",
                    TimeStudy = "2 năm"
                },

                new SpecializeMajor() { MajorID = "A", SpecializeMajorID = "EA", SpecializeMajorName = "Ngôn ngữ anh", MajorCode = "7220201",
                    Description = "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.",
                    TimeStudy = "2 năm"
                },
                new SpecializeMajor() { MajorID = "A", SpecializeMajorID = "JA", SpecializeMajorName = "Ngôn ngữ nhật", MajorCode = "7220209", TimeStudy = "2 năm" },
                new SpecializeMajor() { MajorID = "A", SpecializeMajorID = "KA", SpecializeMajorName = "Ngôn ngữ hàn", MajorCode = "7220210", TimeStudy = "24 năm" },

                new SpecializeMajor() { MajorID = "S", SpecializeMajorID = "SM", SpecializeMajorName = "Marketing", MajorCode = "7340101", TimeStudy = "2 năm" },
                new SpecializeMajor() { MajorID = "S", SpecializeMajorID = "HM", SpecializeMajorName = "Quản trị khách sạn", MajorCode = "7340101", TimeStudy = "24 năm" },
                new SpecializeMajor() { MajorID = "S", SpecializeMajorID = "RM", SpecializeMajorName = "Quản trị nhà hàng", MajorCode = "7340101",TimeStudy = "24 năm" },

                new SpecializeMajor() { MajorID = "B", SpecializeMajorID = "BT", SpecializeMajorName = "Phum xăm thẩm mỹ", MajorCode = "71490", TimeStudy = "2 năm" },
                new SpecializeMajor() { MajorID = "B", SpecializeMajorID = "BS", SpecializeMajorName = "Chăm sóc da và massage",MajorCode = "71490", TimeStudy = "2 năm" },

                new SpecializeMajor() { MajorID = "O", SpecializeMajorID = "AO", SpecializeMajorName = "Kiểm toán", MajorCode = "71490", TimeStudy = "2 năm" },
                new SpecializeMajor() { MajorID = "O", SpecializeMajorID = "SO", SpecializeMajorName = "Thư ký văn phòng", MajorCode = "71490", TimeStudy = "24 năm" },
                new SpecializeMajor() { MajorID = "O", SpecializeMajorID = "FO", SpecializeMajorName = "Kỹ thuật chế biến món ăn", MajorCode = "71490", TimeStudy = "2 năm" }
                );
            // seed Subject
            modelBuilder.Entity<Subject>().HasData(
                new Subject() {SubjectCode ="GDQP", SubjectName ="Giáo dục quốc phòng", StudyTime ="1 tháng", NumberOfCredits = 0, SemesterNumber =0, SpecializeMajorID= "ME"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "GE"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "WE"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "TE"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "EA"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "JA"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "KA"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "SM"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "HM"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "RM"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "BT"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "BS"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "AO"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "SO"},
                new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0,SpecializeMajorID = "FO"},

                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "ME" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "GE" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "WE" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "TE" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "EA" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "JA" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "KA" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "SM" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "HM" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "RM" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "BT" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "BS" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "AO" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "SO" },
                new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "FO" },

                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "ME" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "GE" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "WE" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "TE" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "EA" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "JA" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "KA" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "SM" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "HM" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "RM" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "BT" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "BS" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "AO" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "SO" },
                new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "FO" },

                new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "ME" },
                new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "EA" },
                new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "SM" },
                new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "HM" },
                new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "RM" },
                new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, SpecializeMajorID = "AO" },

                new Subject() { SubjectCode = "MAE101", SubjectName = "Toán rời rạc", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, SpecializeMajorID = "ME" },
                new Subject() { SubjectCode = "MAE101", SubjectName = "Toán rời rạc", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, SpecializeMajorID = "GE" },
                new Subject() { SubjectCode = "MAE101", SubjectName = "Toán rời rạc", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, SpecializeMajorID = "WE" },
                new Subject() { SubjectCode = "MAE101", SubjectName = "Toán rời rạc", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, SpecializeMajorID = "TE" },

                new Subject() { SubjectCode = "PRF101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, SpecializeMajorID = "ME" },
                new Subject() { SubjectCode = "PRF101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, SpecializeMajorID = "GE" },
                new Subject() { SubjectCode = "PRF101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, SpecializeMajorID = "WE" },
                new Subject() { SubjectCode = "PRF101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, SpecializeMajorID = "TE" },

                new Subject() { SubjectCode = "MAD101", SubjectName = "Toán cho ngành kỹ thuật", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 2, SpecializeMajorID = "ME" },
                new Subject() { SubjectCode = "MAD101", SubjectName = "Toán cho ngành kỹ thuật", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 2, SpecializeMajorID = "GE" },
                new Subject() { SubjectCode = "MAD101", SubjectName = "Toán cho ngành kỹ thuật", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 2, SpecializeMajorID = "WE" },
                new Subject() { SubjectCode = "MAD101", SubjectName = "Toán cho ngành kỹ thuật", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 2, SpecializeMajorID = "TE" },

                new Subject() { SubjectCode = "DBI101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 3, SpecializeMajorID = "ME" },
                new Subject() { SubjectCode = "DBI101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 3, SpecializeMajorID = "GE" },
                new Subject() { SubjectCode = "DBI101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 3, SpecializeMajorID = "WE" },
                new Subject() { SubjectCode = "DBI101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 3, SpecializeMajorID = "TE" }
                );
        }
    }
}
