﻿using Data.Models;
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
            //seed banner 
            modelBuilder.Entity<Banner>().HasData(
                new Banner()
                {
                    BannerId =1,
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce",
                    CampusId = "Hanoi"
                    
                },
                new Banner()
                {
                    BannerId = 2,
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d",
                    CampusId = "Hanoi"

                },
                new Banner()
                {
                    BannerId = 4,
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce",
                    CampusId = "Danang"

                },
                 new Banner()
                 {
                     BannerId = 5,
                     Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d",
                     CampusId = "Danang"

                 },
                new Banner()
                {
                    BannerId = 7,
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce",
                    CampusId = "HCM"

                },
                new Banner()
                {
                    BannerId = 8,
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d",
                    CampusId = "HCM"

                },
                new Banner()
                {
                    BannerId = 10,
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce",
                    CampusId = "Cantho"

                },
                new Banner()
                {
                    BannerId = 11,
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d",
                    CampusId = "Cantho"

                },
                new Banner()
                {
                    BannerId = 13,
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce",
                    CampusId = "Thanhhoa"

                },
                new Banner()
                {
                    BannerId = 14,
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d",
                    CampusId = "Thanhhoa"

                }
                );
            // seed alumistudent 
            modelBuilder.Entity<AlumiStudent>().HasData(
                new AlumiStudent()
                {
                    AlumiStudentId = 1,
                    FullName ="Nguyễn Đức Anh",
                    CampusId ="Hanoi",
                    Desciption = "Là một người trẻ, năng động thích môi trường năng động và được học những kiến thức thực tế. Mình nhận thấy đây là môi trường hoàn hảo để chắp cánh ước mơ trở thành nhà quản trị khách sạn của mình.",
                    SpecializeMajorID = "ME",
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/AlumiStudent%2Fstudent1.webp?alt=media&token=03b25b7d-e847-4e6d-ae4c-5da00e1c8183"
                },
                new AlumiStudent()
                {
                    AlumiStudentId = 2,
                    FullName = "Vũ Nguyễn Minh Sơn",
                    CampusId = "Hanoi",
                    Desciption = "Là một người trẻ, năng động thích môi trường năng động và được học những kiến thức thực tế. Mình nhận thấy đây là môi trường hoàn hảo để chắp cánh ước mơ trở thành nhà quản trị khách sạn của mình.",
                    SpecializeMajorID = "ME",
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/AlumiStudent%2Fstudent1.webp?alt=media&token=03b25b7d-e847-4e6d-ae4c-5da00e1c8183"
                },
                new AlumiStudent()
                {
                    AlumiStudentId = 3,
                    FullName = "Lê Quang An",
                    CampusId = "Hanoi",
                    Desciption = "Là một người trẻ, năng động thích môi trường năng động và được học những kiến thức thực tế. Mình nhận thấy đây là môi trường hoàn hảo để chắp cánh ước mơ trở thành nhà quản trị khách sạn của mình.",
                    SpecializeMajorID = "ME",
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/AlumiStudent%2Fstudent1.webp?alt=media&token=03b25b7d-e847-4e6d-ae4c-5da00e1c8183"
                },
                new AlumiStudent()
                {
                    AlumiStudentId = 4,
                    FullName = "Trần Tú Anh",
                    CampusId = "Hanoi",
                    Desciption = "Là một người trẻ, năng động thích môi trường năng động và được học những kiến thức thực tế. Mình nhận thấy đây là môi trường hoàn hảo để chắp cánh ước mơ trở thành nhà quản trị khách sạn của mình.",
                    SpecializeMajorID = "ME",
                    Img = "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/AlumiStudent%2Fstudent1.webp?alt=media&token=03b25b7d-e847-4e6d-ae4c-5da00e1c8183"
                }
                );
           // seed campus
           modelBuilder.Entity<Campus>().HasData(
                new Campus() { 
                    CampusId = "Hanoi",
                    CampusName = "Hà Nội", 
                    Address= "Cổng số 1, Tòa nhà FPT Polytechnic, 13 phố Trịnh Văn Bô, phường Phương Canh, quận Nam Từ Liêm, TP Hà NộiKm12 Cầu Diễn, Phường Phúc Diễn, Quận Bắc Từ Liêm, Hà Nội", 
                    PhoneNumber = "02485820808",
                    AdmissionPlanID = 1,
                    History = "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.",
                    WhyChooseUs = "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất.",
                    Achievements = "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.",
                    TrainingMotto = "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ."
                },
                new Campus() { 
                    CampusId = "Danang",
                    CampusName = "Đà Nẵng",
                    Address = "219 Nguyễn Sinh Sắc, phường Hoà Minh, quận Liên Chiểu, TP Đà Nẵng",
                    PhoneNumber = "02363710999",
                    AdmissionPlanID = 2,
                    History = "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.",
                    WhyChooseUs = "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất.",
                    Achievements = "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.",
                    TrainingMotto = "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ."
                },
                new Campus() { 
                    CampusId = "Cantho",
                    CampusName = "Cần Thơ",
                    Address = "Toà nhà FPT Polytechnic, đường số 22, phường Thường Thạnh,quận Cái Răng, TP Cần Thơ",
                    PhoneNumber = "0983881100",
                    AdmissionPlanID = 3,
                    History = "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.",
                    WhyChooseUs = "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất.",
                    Achievements = "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.",
                    TrainingMotto = "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ."
                },
                new Campus() { 
                    CampusId = "HCM",
                    CampusName = "Tp HCM",
                    Address = "Tòa nhà QTSC9 (toà T), đường Tô Ký, phường Tân Chánh Hiệp, quận 12, TP HCM.778/B1 Nguyễn Kiệm, phường 04, quận Phú Nhuận, TP HCM",
                    PhoneNumber= "02866866486",
                    AdmissionPlanID = 4,
                    History = "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.",
                    WhyChooseUs = "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất.",
                    Achievements = "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.",
                    TrainingMotto = "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ."

                },
                new Campus() { 
                    CampusId = "Thanhhoa", 
                    CampusName = "Thanh Hoá",
                    Address = "Tòa Beta, Tổ hợp giáo dục FPT, Đại lộ Võ Nguyên Giáp, phường Quảng Thành, TP Thanh Hóa",
                    PhoneNumber = "0913785213",
                    AdmissionPlanID = 5,
                    History = "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.",
                    WhyChooseUs = "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất.",
                    Achievements = "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.",
                    TrainingMotto = "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ."
                }
                );

        }
    }
}
