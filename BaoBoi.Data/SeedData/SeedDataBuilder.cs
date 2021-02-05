using BaoBoi.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaoBoi.Data.SeedData
{
    public static class SeedDataBuilder
    { 
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of Bao Boi Official" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of Bao Boi Official" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of Bao Boi Official" }
               );

            #region LoiChuc seed data
            modelBuilder.Entity<LoiChuc>().HasData(
                new LoiChuc() { ID=1, CauChuc= "Mừng 2021 phát tài phát lộc. Tiền vô xồng xộc, tiền ra từ từ. " +
                "Sức khỏe có dư, công danh tấn tới. Tình duyên phơi phới,hạnh phúc thăng hoa.Xin chúc mọi nhà một năm đại thắng.", Type=0},
                new LoiChuc() { ID=2, CauChuc= "Năm mới đã tới thật gần, chúc cho đại gia đình một năm mới An Khang Thịnh Vượng", Type=0 },
                new LoiChuc() { ID=3, CauChuc= "Năm mới với bao điều thú vị đang đến với bạn. Chúc bạn có đủ niềm đam mê để khám " +
                "phá và tận hưởng từng ngày tươi đẹp của cuộc sống mới", Type=0 },
                new LoiChuc() { ID=4, CauChuc= "Tết đến, xuân về, an khang thịnh vượng, phát tài phát lộc, sức khỏe dồi dào, mọi điều như ý", Type=0 },
                new LoiChuc() { ID=5, CauChuc= "Chúc mọi người năm mới An khang thịnh vượng, tài lộc đầy nhà, con cháu sum vầy, một năm bình an và sung túc", Type=0 },
                new LoiChuc() { ID=6, CauChuc= "Có thể những niềm vui của năm mới kéo dài mãi mãi trong cuộc sống của bạn. Có thể bạn " +
                "sẽ tìm thấy được ánh sáng dẫn bạn đến thành công, cái đích mà bạn mong muốn. Chúc mừng năm mới", Type=0 },
                new LoiChuc() { ID=7, CauChuc= "Hãy cùng vẫy tay tạm biệt năm cũ, đón nhận năm mới với nhiều ước mơ, hoài bão và cả hy vọng. " +
                "Chúc bạn năm mới tràn ngập niềm vui và hạnh phúc", Type=0 },
                new LoiChuc() { ID = 8, CauChuc = "May all your new year wishes come true", Type = 0 },
                new LoiChuc() { ID = 9, CauChuc = "Best wishes for a happy and successful new year", Type = 0 },
                new LoiChuc() { ID = 10, CauChuc = "Wishing you all the magic of the new year", Type = 0 },
                new LoiChuc() { ID = 11, CauChuc = "Let your spirit soar and have a joy-filled new year", Type = 0 }
                );
            #endregion

            #region PhoneUser seed data
            modelBuilder.Entity<PhoneUser>().HasData(
                new PhoneUser() { Phone="0967738406", Name="Admin", Amount=0.00, Type=5, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0903754094", Name= "Anh Bình CIMB", Amount=0.00, Type=2, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0901239894", Name= "Anh Doanh CIMB", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0967440028", Name= "Anh Đức Anh", Amount=0.00, Type=4, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0907603537", Name= "Anh Hiếu CIMB", Amount=0.00, Type=2, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0332160345", Name= "Anh Hoà", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0775080990", Name= "Anh khải", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0327489656", Name= "Anh Nguyên", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0355559738", Name= "Anh Nhanh", Amount=0.00, Type=4, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0935201352", Name= "Anh Quân", Amount=0.00, Type=2, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0908233009", Name= "Anh Thi", Amount=0.00, Type=2, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0962857858", Name= "Anh Trung Design", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0982848104", Name= "Ba", Amount=0.00, Type=4, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0912520927", Name= "Bà Nội", Amount=0.00, Type=4, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0359271374", Name= "Bảo Bối", Amount=0.00, Type=5, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0912298018", Name= "Bò", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0986522539", Name= "Cậu Tèo", Amount=0.00, Type=4, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0388915223", Name= "Chị Châm", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0397667520", Name= "Chị Dung", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0397280420", Name= "Chị Giàu", Amount=0.00, Type=4, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0909047892", Name= "Chị Lành Enrich", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0342103967", Name= "Chị Mai Anh", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0354755733", Name= "Chị Phiên", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0909820075", Name= "Chị Phương Anh", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0396813296", Name= "Chị Thảo Vy", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0908991164", Name= "Chị Thúy Vy", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0925347343", Name= "Chị Trâm", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0329613873", Name= "Chị Trang", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0933184113", Name= "Chị Trinh", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0968338488", Name= "Chị Trinh", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0372303720", Name= "Chong Yau CIMB", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0383539845", Name= "Chức", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0984903994", Name= "Chức", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0327370037", Name= "Cô Dung", Amount=0.00, Type=3, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0975723759", Name= "Cô Nhung Trọ", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0938091809", Name= "Cô Sương - PLS", Amount=0.00, Type=2, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0979224841", Name= "Cô Trinh", Amount=0.00, Type=3, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0963463845", Name= "Đại", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0989040813", Name= "Đăng Phúc", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0568200441", Name= "Dat La", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0378109170", Name= "Đẹt", Amount=0.00, Type=4, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0776611227", Name= "Dì Chúc", Amount=0.00, Type=4, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0386884721", Name= "Duyên", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0358050165", Name= "Duyên", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0373514988", Name= "Gấm", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0344087516", Name= "Hà Trang", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0378015202", Name= "Hí", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0327141466", Name= "Hí", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0337253858", Name= "Hí", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0978374265", Name= "Hiệp", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0962957940", Name= "Hoàng", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0339610931", Name= "Hoàng", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0563419551", Name= "Hợi", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0394137496", Name= "Hợi", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0916789498", Name= "Hợi", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0976016307", Name= "Hồng", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0367257428", Name= "Hương", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0339427771", Name= "Huyền Đen", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0386586120", Name= "Ka Ram", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0774992232", Name= "Lê Thịnh", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0354171005", Name= "Lu", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0359516706", Name= "Mẹ", Amount=0.00, Type=4, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0329003084", Name= "Mỹ Thanh", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0375188165", Name= "Mỹ Thanh", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0332263410", Name= "Ngân Muội", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0969853537", Name= "Nghĩa", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0986839804", Name= "Nghĩa", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0374094726", Name= "Ngoan", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0388855622", Name= "Nhật", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0934452821", Name= "Nhật", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0327090718", Name= "Nhung", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0349925559", Name= "Oanh Cao", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0978939976", Name= "Phạm Linh Linh", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0978225695", Name= "Phú", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0333262399", Name= "Quân", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0394204227", Name= "Quốc Hưng", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0354023098", Name= "Quốc Thông", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0929207097", Name= "Quốc Thông", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0375767266", Name= "Quyền", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0396513565", Name= "Sáng", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0962744683", Name= "Sơn Xù", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "60162175578", Name= "Stephen", Amount=0.00, Type=1, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0354601772", Name= "Sumi", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0989538072", Name= "Sven", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0349548560", Name= "Sỹ", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "1", Name= "Test", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0969102120", Name= "Thái", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0342829455", Name= "Thảo", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0914290456", Name= "Thầy Lộc", Amount=0.00, Type=3, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0908202983", Name= "Thầy Vĩnh", Amount=0.00, Type=3, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0382115375", Name= "Thịnh", Amount=0.00, Type=2, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0976393245", Name= "Thơ", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0989764925", Name= "Thu Trang", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0332950027", Name= "Thuận", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0363944069", Name= "Thuý", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0388825432", Name= "Thuý", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0329979306", Name= "Thuý", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0968113772", Name= "Thuý", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0369712191", Name= "Tô Bướm", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0986179154", Name= "Toàn", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0367816473", Name= "Tráng", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0376545320", Name= "Tráng", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0966785834", Name= "Trang Tuyền", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0348879740", Name= "Trí Thông", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0394959832", Name= "Trinh Toeic", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0376093038", Name= "Tường Vi", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0566820006", Name= "Ù", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0987221504", Name= "Ursa", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0978086565", Name= "Vân Muội Muội", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0399658291", Name= "Vĩ", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0377377487", Name= "Vĩ", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0376463339", Name= "Vũ", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0886525647", Name= "Vũ Đạt", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0968270836", Name= "Vũ Linh", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0977811837", Name= "Xuân", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0353264570", Name= "Xuân Nam", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0163673765", Name= "Yee Kuan", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0368013361", Name= "Yến", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "0388991387", Name= "Yến", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null },
                new PhoneUser() { Phone= "60123836370", Name= "Yew Khai Shing", Amount=0.00, Type=0, Pay=false, DatePlay=null, DatePay = null }
                );

            #endregion

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false });

            #region User seed data
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });
            var hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser() {
                    Id = adminId,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "hieule.9420@gmail.com",
                    NormalizedEmail = "hieule.9420@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "1"),
                    SecurityStamp = string.Empty,
                    FirstName = "Le",
                    LastName = "Hieu",
                    Dob = new DateTime(1996, 05, 03)
                }
                );
            #endregion
        }
    }
}
