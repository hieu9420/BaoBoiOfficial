using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaoBoi.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoiChuc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CauChuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoiChuc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PhoneUser",
                columns: table => new
                {
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Pay = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DatePlay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatePay = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneUser", x => x.Phone);
                });

            migrationBuilder.InsertData(
                table: "LoiChuc",
                columns: new[] { "ID", "CauChuc", "Type" },
                values: new object[,]
                {
                    { 1, "Mừng 2021 phát tài phát lộc. Tiền vô xồng xộc, tiền ra từ từ. Sức khỏe có dư, công danh tấn tới. Tình duyên phơi phới,hạnh phúc thăng hoa.Xin chúc mọi nhà một năm đại thắng.", 0 },
                    { 2, "Năm mới đã tới thật gần, chúc cho đại gia đình một năm mới An Khang Thịnh Vượng", 0 },
                    { 3, "Năm mới với bao điều thú vị đang đến với bạn. Chúc bạn có đủ niềm đam mê để khám phá và tận hưởng từng ngày tươi đẹp của cuộc sống mới", 0 },
                    { 4, "Tết đến, xuân về, an khang thịnh vượng, phát tài phát lộc, sức khỏe dồi dào, mọi điều như ý", 0 },
                    { 5, "Chúc mọi người năm mới An khang thịnh vượng, tài lộc đầy nhà, con cháu sum vầy, một năm bình an và sung túc", 0 },
                    { 6, "Có thể những niềm vui của năm mới kéo dài mãi mãi trong cuộc sống của bạn. Có thể bạn sẽ tìm thấy được ánh sáng dẫn bạn đến thành công, cái đích mà bạn mong muốn. Chúc mừng năm mới", 0 },
                    { 7, "Hãy cùng vẫy tay tạm biệt năm cũ, đón nhận năm mới với nhiều ước mơ, hoài bão và cả hy vọng. Chúc bạn năm mới tràn ngập niềm vui và hạnh phúc", 0 },
                    { 8, "May all your new year wishes come true", 0 },
                    { 9, "Best wishes for a happy and successful new year", 0 },
                    { 10, "Wishing you all the magic of the new year", 0 },
                    { 11, "Let your spirit soar and have a joy-filled new year", 0 }
                });

            migrationBuilder.InsertData(
                table: "PhoneUser",
                columns: new[] { "Phone", "Amount", "DatePay", "DatePlay", "Name", "Type" },
                values: new object[,]
                {
                    { "0929207097", 0.0, null, null, "Quốc Thông", 0 },
                    { "0375767266", 0.0, null, null, "Quyền", 0 },
                    { "0396513565", 0.0, null, null, "Sáng", 0 },
                    { "0962744683", 0.0, null, null, "Sơn Xù", 0 },
                    { "60162175578", 0.0, null, null, "Stephen", 1 },
                    { "0342829455", 0.0, null, null, "Thảo", 0 },
                    { "0989538072", 0.0, null, null, "Sven", 0 },
                    { "0349548560", 0.0, null, null, "Sỹ", 0 },
                    { "1", 0.0, null, null, "Test", 0 },
                    { "0969102120", 0.0, null, null, "Thái", 0 },
                    { "0354023098", 0.0, null, null, "Quốc Thông", 0 },
                    { "0354601772", 0.0, null, null, "Sumi", 0 },
                    { "0394204227", 0.0, null, null, "Quốc Hưng", 0 },
                    { "0327090718", 0.0, null, null, "Nhung", 0 },
                    { "0978225695", 0.0, null, null, "Phú", 0 },
                    { "0978939976", 0.0, null, null, "Phạm Linh Linh", 1 },
                    { "0349925559", 0.0, null, null, "Oanh Cao", 0 },
                    { "0914290456", 0.0, null, null, "Thầy Lộc", 3 },
                    { "0934452821", 0.0, null, null, "Nhật", 0 },
                    { "0388855622", 0.0, null, null, "Nhật", 0 },
                    { "0374094726", 0.0, null, null, "Ngoan", 0 },
                    { "0986839804", 0.0, null, null, "Nghĩa", 0 },
                    { "0969853537", 0.0, null, null, "Nghĩa", 0 },
                    { "0332263410", 0.0, null, null, "Ngân Muội", 0 },
                    { "0375188165", 0.0, null, null, "Mỹ Thanh", 0 },
                    { "0329003084", 0.0, null, null, "Mỹ Thanh", 0 },
                    { "0333262399", 0.0, null, null, "Quân", 0 },
                    { "0908202983", 0.0, null, null, "Thầy Vĩnh", 3 },
                    { "0363944069", 0.0, null, null, "Thuý", 0 },
                    { "0976393245", 0.0, null, null, "Thơ", 0 },
                    { "0368013361", 0.0, null, null, "Yến", 0 }
                });

            migrationBuilder.InsertData(
                table: "PhoneUser",
                columns: new[] { "Phone", "Amount", "DatePay", "DatePlay", "Name", "Type" },
                values: new object[,]
                {
                    { "0163673765", 0.0, null, null, "Yee Kuan", 0 },
                    { "0353264570", 0.0, null, null, "Xuân Nam", 0 },
                    { "0977811837", 0.0, null, null, "Xuân", 0 },
                    { "0968270836", 0.0, null, null, "Vũ Linh", 0 },
                    { "0886525647", 0.0, null, null, "Vũ Đạt", 0 },
                    { "0376463339", 0.0, null, null, "Vũ", 0 },
                    { "0377377487", 0.0, null, null, "Vĩ", 0 },
                    { "0399658291", 0.0, null, null, "Vĩ", 0 },
                    { "0978086565", 0.0, null, null, "Vân Muội Muội", 0 },
                    { "0987221504", 0.0, null, null, "Ursa", 0 },
                    { "0566820006", 0.0, null, null, "Ù", 0 },
                    { "0382115375", 0.0, null, null, "Thịnh", 2 },
                    { "0376093038", 0.0, null, null, "Tường Vi", 0 },
                    { "0348879740", 0.0, null, null, "Trí Thông", 0 },
                    { "0966785834", 0.0, null, null, "Trang Tuyền", 0 },
                    { "0376545320", 0.0, null, null, "Tráng", 0 },
                    { "0367816473", 0.0, null, null, "Tráng", 0 },
                    { "0986179154", 0.0, null, null, "Toàn", 0 },
                    { "0369712191", 0.0, null, null, "Tô Bướm", 0 },
                    { "0968113772", 0.0, null, null, "Thuý", 0 },
                    { "0329979306", 0.0, null, null, "Thuý", 0 },
                    { "0388825432", 0.0, null, null, "Thuý", 0 },
                    { "0359516706", 0.0, null, null, "Mẹ", 4 },
                    { "0332950027", 0.0, null, null, "Thuận", 0 },
                    { "0989764925", 0.0, null, null, "Thu Trang", 0 },
                    { "0394959832", 0.0, null, null, "Trinh Toeic", 0 },
                    { "0354171005", 0.0, null, null, "Lu", 0 },
                    { "0916789498", 0.0, null, null, "Hợi", 0 },
                    { "0386586120", 0.0, null, null, "Ka Ram", 0 },
                    { "0908991164", 0.0, null, null, "Chị Thúy Vy", 1 },
                    { "0396813296", 0.0, null, null, "Chị Thảo Vy", 1 },
                    { "0909820075", 0.0, null, null, "Chị Phương Anh", 1 },
                    { "0354755733", 0.0, null, null, "Chị Phiên", 1 },
                    { "0342103967", 0.0, null, null, "Chị Mai Anh", 1 },
                    { "0909047892", 0.0, null, null, "Chị Lành Enrich", 1 },
                    { "0397280420", 0.0, null, null, "Chị Giàu", 4 },
                    { "0397667520", 0.0, null, null, "Chị Dung", 0 },
                    { "0388915223", 0.0, null, null, "Chị Châm", 0 },
                    { "0986522539", 0.0, null, null, "Cậu Tèo", 4 },
                    { "0912298018", 0.0, null, null, "Bò", 0 },
                    { "0359271374", 0.0, null, null, "Bảo Bối", 5 },
                    { "0925347343", 0.0, null, null, "Chị Trâm", 0 }
                });

            migrationBuilder.InsertData(
                table: "PhoneUser",
                columns: new[] { "Phone", "Amount", "DatePay", "DatePlay", "Name", "Type" },
                values: new object[,]
                {
                    { "0912520927", 0.0, null, null, "Bà Nội", 4 },
                    { "0962857858", 0.0, null, null, "Anh Trung Design", 1 },
                    { "0908233009", 0.0, null, null, "Anh Thi", 2 },
                    { "0935201352", 0.0, null, null, "Anh Quân", 2 },
                    { "0355559738", 0.0, null, null, "Anh Nhanh", 4 },
                    { "0327489656", 0.0, null, null, "Anh Nguyên", 0 },
                    { "0775080990", 0.0, null, null, "Anh khải", 1 },
                    { "0332160345", 0.0, null, null, "Anh Hoà", 1 },
                    { "0907603537", 0.0, null, null, "Anh Hiếu CIMB", 2 },
                    { "0967440028", 0.0, null, null, "Anh Đức Anh", 4 },
                    { "0901239894", 0.0, null, null, "Anh Doanh CIMB", 1 },
                    { "0903754094", 0.0, null, null, "Anh Bình CIMB", 2 },
                    { "0967738406", 0.0, null, null, "Admin", 5 },
                    { "0982848104", 0.0, null, null, "Ba", 4 },
                    { "0329613873", 0.0, null, null, "Chị Trang", 1 },
                    { "0933184113", 0.0, null, null, "Chị Trinh", 0 },
                    { "0968338488", 0.0, null, null, "Chị Trinh", 0 },
                    { "0339427771", 0.0, null, null, "Huyền Đen", 0 },
                    { "0367257428", 0.0, null, null, "Hương", 0 },
                    { "0976016307", 0.0, null, null, "Hồng", 0 },
                    { "0388991387", 0.0, null, null, "Yến", 0 },
                    { "0394137496", 0.0, null, null, "Hợi", 0 },
                    { "0563419551", 0.0, null, null, "Hợi", 0 },
                    { "0339610931", 0.0, null, null, "Hoàng", 0 },
                    { "0962957940", 0.0, null, null, "Hoàng", 0 },
                    { "0978374265", 0.0, null, null, "Hiệp", 0 },
                    { "0337253858", 0.0, null, null, "Hí", 0 },
                    { "0327141466", 0.0, null, null, "Hí", 0 },
                    { "0378015202", 0.0, null, null, "Hí", 0 },
                    { "0373514988", 0.0, null, null, "Gấm", 0 },
                    { "0358050165", 0.0, null, null, "Duyên", 0 },
                    { "0386884721", 0.0, null, null, "Duyên", 0 },
                    { "0776611227", 0.0, null, null, "Dì Chúc", 4 },
                    { "0378109170", 0.0, null, null, "Đẹt", 4 },
                    { "0568200441", 0.0, null, null, "Dat La", 0 },
                    { "0989040813", 0.0, null, null, "Đăng Phúc", 0 },
                    { "0963463845", 0.0, null, null, "Đại", 0 },
                    { "0979224841", 0.0, null, null, "Cô Trinh", 3 },
                    { "0938091809", 0.0, null, null, "Cô Sương - PLS", 2 },
                    { "0975723759", 0.0, null, null, "Cô Nhung Trọ", 0 },
                    { "0327370037", 0.0, null, null, "Cô Dung", 3 },
                    { "0984903994", 0.0, null, null, "Chức", 0 }
                });

            migrationBuilder.InsertData(
                table: "PhoneUser",
                columns: new[] { "Phone", "Amount", "DatePay", "DatePlay", "Name", "Type" },
                values: new object[,]
                {
                    { "0383539845", 0.0, null, null, "Chức", 0 },
                    { "0372303720", 0.0, null, null, "Chong Yau CIMB", 1 },
                    { "0774992232", 0.0, null, null, "Lê Thịnh", 1 },
                    { "60123836370", 0.0, null, null, "Yew Khai Shing", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoiChuc");

            migrationBuilder.DropTable(
                name: "PhoneUser");
        }
    }
}
