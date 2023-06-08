using System.Globalization;
using EPS.Smartcart.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EPS.Smartcart.Infrastructure.Seeding;

public static class ProductSeeding
{
    public static void Seed(this EntityTypeBuilder<Product> builder)
    {
        builder.HasData(
            new Product
            {
                Id = "da7ebf21-1666-4c44-ae4f-294b705b5c35",
                Name = "Fuelton",
                Description =
                    "Labore quis officia commodo dolor sint consequat. Culpa eiusmod amet laborum quis veniam duis pariatur reprehenderit. Ut minim in consectetur tempor ea non incididunt laborum enim consequat qui. Et duis veniam culpa nisi incididunt excepteur ullamco ad fugiat laborum. Quis ea quis eiusmod et ullamco. Do id voluptate dolor aliquip officia anim dolore ipsum elit enim amet id in enim. Magna anim amet non laborum do labore aute fugiat incididunt.",
                Price = 87.31,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 105,
                ExperitionDate = DateTime.ParseExact("2023-07-05", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "885419ca-7a02-4d45-b384-7a750189a70b",
                Name = "Isologia",
                Description =
                    "Et cupidatat adipisicing tempor anim elit excepteur commodo magna qui excepteur ut adipisicing nostrud. Mollit nulla sunt esse fugiat culpa cillum culpa. Voluptate eiusmod magna non qui aute nulla sit minim voluptate. Dolor aliquip non occaecat ullamco anim occaecat in est incididunt voluptate ipsum sint consequat fugiat. Officia minim id commodo excepteur. Et minim sunt aliqua ipsum quis duis sit elit nisi veniam ut adipisicing. Commodo quis laborum dolor anim ut consequat aliquip.",
                Price = 95.98,
                Discount = 0,
                DiscountPercentage = 40,
                Amount = 2,
                ExperitionDate = DateTime.ParseExact("2023-06-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
                
            }, new Product
            {
                Id = "15194bd5-c162-4496-86ba-4a009cbfd1f6",
                Name = "Acusage",
                Description =
                    "Dolore proident laborum ex sunt exercitation cupidatat consectetur duis reprehenderit exercitation reprehenderit. Et nisi ipsum fugiat dolore in proident eu mollit ipsum aliquip pariatur ex nisi. Id culpa irure et eiusmod incididunt sit id occaecat laboris. Mollit id amet consequat deserunt tempor nulla occaecat id tempor. Aliquip magna voluptate ipsum ad et irure reprehenderit pariatur id officia tempor. Sit laboris occaecat et qui labore laboris excepteur exercitation. Occaecat dolore enim irure dolore enim est ipsum id quis pariatur.",
                Price = 17.37,
                Discount = 0,
                DiscountPercentage = 25,
                Amount = 249,
                ExperitionDate = DateTime.ParseExact("2023-07-24", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "22e7e15a-56eb-4d82-9f52-5ea6aac6ebda",
                Name = "Terragen",
                Description =
                    "Deserunt ex non duis est reprehenderit mollit quis occaecat aliqua sit exercitation exercitation incididunt sit. Exercitation magna ad qui exercitation cupidatat. Pariatur excepteur amet nostrud nulla anim magna tempor Lorem minim dolore nostrud commodo irure qui. Do ad nulla nulla culpa. Officia eu id ea voluptate duis culpa amet laboris quis et sit sint cupidatat. Nostrud consectetur cupidatat mollit laboris veniam dolor. Pariatur commodo proident deserunt sint non aliquip do proident nisi mollit anim officia pariatur.",
                Price = 65.68,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 49,
                ExperitionDate = DateTime.ParseExact("2023-07-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "0d8b65a5-1798-48c3-ab1e-5a508fde6035",
                Name = "Vendblend",
                Description =
                    "Elit dolor velit fugiat minim. Adipisicing laboris pariatur cillum et aute amet. Tempor consequat in adipisicing non deserunt sit eiusmod. Pariatur amet tempor consectetur nostrud aliqua reprehenderit mollit irure officia consectetur consectetur veniam. Velit enim voluptate adipisicing qui culpa consequat nostrud exercitation id minim ullamco quis. Veniam ipsum amet esse cupidatat sit laboris magna sunt dolor velit consectetur. Exercitation dolor sunt duis adipisicing ea ullamco mollit non ullamco adipisicing id elit.",
                Price = 73.43,
                Discount = 0,
                DiscountPercentage = 40,
                Amount = 137,
                ExperitionDate = DateTime.ParseExact("2023-07-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "25eafe7a-44aa-4278-9867-3cd6c1de77b5",
                Name = "Gazak",
                Description =
                    "Sunt sint in ut nisi id anim exercitation deserunt. Culpa ut aliquip nisi ut proident nostrud. Eiusmod proident fugiat veniam qui qui eiusmod exercitation cillum magna cupidatat. Nostrud quis sunt esse officia sint in. Quis cupidatat sint reprehenderit enim sunt. Quis nisi occaecat amet ex deserunt velit. Esse anim sunt pariatur anim Lorem minim consequat.",
                Price = 61.49,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 29,
                ExperitionDate = DateTime.ParseExact("2023-07-09", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "344ab9f6-db86-4043-a44d-0e84783e3b3f",
                Name = "Geekmosis",
                Description =
                    "Aliqua aliquip pariatur ipsum nisi ullamco occaecat laborum fugiat magna exercitation ut sint ea labore. Mollit in reprehenderit laborum enim commodo proident in veniam tempor exercitation consectetur. Incididunt aute labore excepteur sit officia ullamco nostrud non commodo occaecat excepteur. Do labore ipsum laboris sint commodo velit irure ad aute cupidatat est in. Voluptate do Lorem sunt occaecat eiusmod deserunt esse labore sint cupidatat in nostrud mollit. Pariatur eu esse deserunt sint aliqua exercitation mollit. Est esse irure mollit veniam enim tempor sunt consectetur occaecat sunt nisi laborum.",
                Price = 83.14,
                Discount = 0,
                DiscountPercentage = 20,
                Amount = 219,
                ExperitionDate = DateTime.ParseExact("2023-07-09", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "340d1c07-7db0-4d4b-b4ea-9459770eca72",
                Name = "Junipoor",
                Description =
                    "Nulla proident non laboris ipsum dolore duis anim. Laboris adipisicing fugiat labore reprehenderit proident ex qui sint in qui tempor do cupidatat culpa. Amet ut officia mollit sunt exercitation incididunt id eiusmod. Nisi aute dolor labore ullamco. Non amet eu officia anim dolore ipsum ut ex enim exercitation. Eu laborum elit reprehenderit cupidatat fugiat sint nostrud culpa est ea ullamco et id. Elit fugiat eu mollit aliqua commodo.",
                Price = 98.37,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 70,
                ExperitionDate = DateTime.ParseExact("2023-07-09", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "dedf459e-07b8-4e96-b258-8423a3c25573",
                Name = "Zillidium",
                Description =
                    "Occaecat incididunt tempor adipisicing sint ea. Ad sunt minim dolore do aliquip ad cupidatat elit cillum ut. Est aliquip commodo sit commodo nulla. Eu cillum ipsum nisi fugiat amet. Nulla excepteur excepteur laborum tempor enim occaecat consectetur. In mollit fugiat officia incididunt. Non eu culpa est veniam ea eiusmod enim sit laboris esse mollit velit.",
                Price = 51.61,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 106,
                ExperitionDate = DateTime.ParseExact("2023-07-16", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "a2afc7fe-47e1-40c0-a2ea-6205f7f60bcb",
                Name = "Aclima",
                Description =
                    "Reprehenderit qui irure officia ut aliquip consequat laborum dolore tempor laboris. Ipsum fugiat ipsum adipisicing ullamco elit veniam deserunt dolor eiusmod officia reprehenderit aliqua in. Qui occaecat consectetur laboris velit deserunt eiusmod. Excepteur tempor ullamco do ullamco id id id velit cupidatat exercitation cupidatat eiusmod. Deserunt nisi deserunt nisi ullamco cupidatat. Irure pariatur labore labore qui aliquip sunt cupidatat mollit magna esse ea ad veniam. Exercitation amet ipsum elit sint mollit non consequat enim proident.",
                Price = 72.74,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 131,
                ExperitionDate = DateTime.ParseExact("2023-06-23", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "58dd95e2-b27e-4243-bfe2-4ec8f7297357",
                Name = "Progenex",
                Description =
                    "Officia laboris consectetur consequat eu ipsum esse adipisicing. Ut ipsum voluptate qui enim. Fugiat cupidatat labore eu est aliqua qui qui duis pariatur. Tempor commodo non consectetur nisi incididunt aliqua proident aliquip anim proident occaecat. Ipsum ea amet cillum fugiat dolore quis voluptate ex qui. Reprehenderit nostrud et et aliqua sint incididunt commodo. Eiusmod dolore do velit sunt sit nulla occaecat nulla reprehenderit excepteur enim consequat dolor.",
                Price = 7.18,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 207,
                ExperitionDate = DateTime.ParseExact("2023-07-21", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "651dd684-4dc5-4250-ad5d-01b2fc41d444",
                Name = "Genekom",
                Description =
                    "Incididunt ut anim cupidatat do dolore ullamco incididunt pariatur proident culpa qui sunt ut laboris. Sunt anim sunt qui excepteur dolor id consectetur quis anim dolor. Amet labore deserunt velit esse ex irure qui culpa velit aliquip proident labore voluptate. Reprehenderit elit excepteur ad anim consectetur ea nulla. Amet occaecat reprehenderit anim laboris Lorem esse. Veniam do enim qui culpa irure in exercitation duis laboris adipisicing id velit. Id id enim sunt pariatur sint.",
                Price = 44.02,
                Discount = 0,
                DiscountPercentage = 25,
                Amount = 213,
                ExperitionDate = DateTime.ParseExact("2023-06-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "e5ae6e4f-73c0-456f-adf4-2e12f1d4beae",
                Name = "Nutralab",
                Description =
                    "Dolor Lorem nulla fugiat non anim id. Ad cupidatat laboris consectetur incididunt consequat commodo cupidatat nulla. Ea exercitation duis ut laboris cupidatat veniam sit quis et. Voluptate non quis excepteur cupidatat eu exercitation in proident. Sunt Lorem enim cupidatat elit quis anim eiusmod incididunt ullamco deserunt exercitation id nostrud. Elit ad elit aute dolor ullamco excepteur cillum. Consequat fugiat non id aliqua commodo non mollit anim dolor sit laboris consequat.",
                Price = 19.07,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 249,
                ExperitionDate = DateTime.ParseExact("2023-07-26", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "d8e0406f-e747-4a57-b333-30ce03ed4720",
                Name = "Anocha",
                Description =
                    "Id adipisicing eu deserunt in culpa mollit consequat occaecat aute deserunt proident ipsum do voluptate. Sit dolore pariatur incididunt ut proident elit mollit voluptate laboris pariatur. Ea sit culpa adipisicing nulla veniam pariatur eu nisi velit ipsum. Pariatur mollit consectetur consequat ut est duis in in. Consectetur irure qui cupidatat nulla labore in magna. Excepteur qui cillum dolore commodo quis nisi do eu nostrud amet cillum nostrud. Qui qui cupidatat aliquip sit culpa dolor magna qui.",
                Price = 42.33,
                Discount = 0,
                DiscountPercentage = 25,
                Amount = 139,
                ExperitionDate = DateTime.ParseExact("2023-07-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "d37d4aa7-7a21-4c7f-8367-d89e530edee0",
                Name = "Xoggle",
                Description =
                    "Qui mollit dolore ad adipisicing duis qui esse cillum mollit sunt do ipsum minim. Proident id excepteur magna consectetur eu. Dolor incididunt Lorem aliqua nisi elit aliqua quis. Sit eiusmod fugiat ad officia amet velit tempor duis tempor do duis fugiat adipisicing. Reprehenderit reprehenderit adipisicing quis elit minim adipisicing incididunt ipsum ex. Lorem exercitation officia deserunt elit ex consequat eiusmod occaecat sunt sint aliquip commodo. Qui cillum veniam est commodo veniam labore occaecat consectetur mollit sunt fugiat.",
                Price = 76.17,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 37,
                ExperitionDate = DateTime.ParseExact("2023-07-20", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "a13a20df-3a91-46c2-a974-cc870f332b3d",
                Name = "Permadyne",
                Description =
                    "In ad occaecat nisi consectetur ullamco consequat elit eu consectetur eu aute deserunt dolor. Aliqua sit minim irure mollit sunt officia. Non esse excepteur mollit commodo voluptate id enim enim dolor nisi ut consectetur. Ad tempor consequat reprehenderit aute commodo incididunt incididunt in dolor amet Lorem ad. Amet duis fugiat nulla sunt ullamco nulla duis dolore quis veniam dolore occaecat irure. Tempor exercitation nostrud tempor mollit cupidatat. Enim incididunt anim in deserunt dolor tempor sint reprehenderit enim ullamco nulla ad enim qui.",
                Price = 70.97,
                Discount = 0,
                DiscountPercentage = 20,
                Amount = 57,
                ExperitionDate = DateTime.ParseExact("2023-06-24", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "6721d8ee-9f3f-470f-9d90-9f819117b20c",
                Name = "Noralex",
                Description =
                    "Ullamco duis ut irure et deserunt magna ex. Veniam ullamco sint aute minim reprehenderit veniam ut aliquip ipsum. Culpa minim in dolor dolore consequat consequat consectetur non. Est cupidatat consequat Lorem laboris elit culpa eiusmod quis commodo id commodo magna. Duis officia commodo magna quis cupidatat nulla deserunt. Nostrud fugiat occaecat sunt dolore nisi nostrud nulla dolore. Ut voluptate excepteur occaecat dolore nisi nostrud.",
                Price = 74.86,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 174,
                ExperitionDate = DateTime.ParseExact("2023-07-19", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "4e9be7e7-bc35-4960-92df-6e77f68544c5",
                Name = "Aquacine",
                Description =
                    "Esse irure ipsum ex ad consequat pariatur culpa reprehenderit esse anim cillum adipisicing sint esse. Velit sint magna deserunt exercitation elit cupidatat ex. Aute aute dolore esse eu adipisicing sunt magna dolor do nisi. Est anim eiusmod eiusmod ea officia Lorem exercitation labore sit est consectetur exercitation minim ad. Eu ex elit aliqua incididunt elit cillum deserunt ut consequat nulla magna irure esse. Enim nisi laborum proident veniam. Ipsum incididunt deserunt minim enim sint tempor sunt veniam incididunt eiusmod veniam.",
                Price = 78.29,
                Discount = 0,
                DiscountPercentage = 40,
                Amount = 136,
                ExperitionDate = DateTime.ParseExact("2023-07-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "0bef168e-20d1-46e2-b8d8-d50c1db8011b",
                Name = "Puria",
                Description =
                    "Adipisicing tempor voluptate non ad aliquip nostrud exercitation excepteur. Veniam sit tempor aute consectetur velit eiusmod proident in dolore in do aliquip velit ut. Ea duis occaecat magna nostrud enim adipisicing voluptate pariatur consequat esse laboris. Do enim et proident pariatur. Proident laborum Lorem nostrud est. Eiusmod ut cillum fugiat fugiat consectetur consectetur minim nulla proident laborum. Dolor exercitation id excepteur incididunt anim laborum mollit eiusmod in minim ullamco do aliquip enim.",
                Price = 86.05,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 213,
                ExperitionDate = DateTime.ParseExact("2023-07-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "fc5e1c38-ce5a-487b-bf60-2117ddc14e65",
                Name = "Blanet",
                Description =
                    "Mollit nisi minim laboris laborum ex commodo non excepteur est proident adipisicing velit ea. In ad tempor anim deserunt. Voluptate nostrud qui labore eiusmod exercitation quis. Sit ullamco ut culpa eiusmod magna. Aliquip eiusmod tempor Lorem qui nulla culpa do sint qui. Elit consequat veniam fugiat laboris eu ad cillum irure id. Veniam eiusmod laboris consequat et incididunt et aliquip labore consequat quis tempor anim.",
                Price = 19.57,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 15,
                ExperitionDate = DateTime.ParseExact("2023-07-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "3a89077a-6857-4e06-9372-df755fb8e051",
                Name = "Applideck",
                Description =
                    "Lorem cupidatat elit tempor duis enim tempor proident aliquip excepteur et voluptate ex. Id sit reprehenderit est sint tempor dolor aliqua dolore Lorem ad. Proident pariatur eiusmod proident non proident ea dolore tempor. Ex ea ad deserunt eiusmod. Incididunt aliqua proident elit duis dolore ex exercitation. Ad duis nulla quis dolor officia aliquip occaecat non qui ea elit. Ad incididunt sit adipisicing non magna.",
                Price = 74.35,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 74,
                ExperitionDate = DateTime.ParseExact("2023-07-29", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "a12fb8f0-8381-48a9-bd9a-bd509765af72",
                Name = "Exoswitch",
                Description =
                    "Cupidatat sint laborum amet dolor ullamco. In veniam in irure deserunt ad quis nisi commodo elit laborum aute. Sit laboris aliqua ut eiusmod et duis fugiat nostrud anim ad esse sunt labore incididunt. Labore consectetur tempor dolore sit dolore ea laborum. Esse sit fugiat dolore tempor laboris dolore nulla id occaecat magna do ut. Magna aliquip Lorem dolore ea culpa irure dolore ex duis. Aliquip esse cupidatat id fugiat pariatur reprehenderit.",
                Price = 67.71,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 134,
                ExperitionDate = DateTime.ParseExact("2023-07-19", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "a2b27d13-c84e-4be3-828a-60e57fc70890",
                Name = "Telequiet",
                Description =
                    "Proident quis nisi enim amet aute Lorem exercitation aliqua reprehenderit culpa incididunt adipisicing qui. Officia pariatur ad incididunt ad voluptate id. Est elit sit pariatur voluptate irure id anim sunt ullamco. Voluptate reprehenderit ullamco reprehenderit ut Lorem eu aliqua est est dolor nulla excepteur. Aute sint aliqua occaecat sunt veniam voluptate amet cupidatat elit commodo sint labore anim. Velit fugiat consectetur quis est eu laboris aliquip consectetur excepteur non non irure. Exercitation in non eiusmod voluptate cillum irure sint nisi sit nulla et duis sit excepteur.",
                Price = 36.57,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 211,
                ExperitionDate = DateTime.ParseExact("2023-07-02", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "fd460b9c-dce5-40ca-8e12-dc61f15327b1",
                Name = "Visualix",
                Description =
                    "Lorem anim laboris laborum aliquip. Nostrud cupidatat minim enim sint Lorem qui incididunt deserunt. Veniam culpa consectetur excepteur minim esse. Laboris deserunt amet adipisicing officia dolore fugiat excepteur quis aliqua duis ea dolor Lorem. Irure ut culpa nisi reprehenderit. Consequat adipisicing elit eu enim nostrud sint anim Lorem irure officia. Consequat ullamco irure voluptate qui exercitation Lorem deserunt ullamco cillum fugiat mollit eu.",
                Price = 39.23,
                Discount = 0,
                DiscountPercentage = 15,
                Amount = 91,
                ExperitionDate = DateTime.ParseExact("2023-07-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "c6cb47f3-f6cb-4bfa-9cf9-d53002b20671",
                Name = "Insuresys",
                Description =
                    "Irure deserunt est duis tempor nisi dolore. Quis ipsum non pariatur voluptate et consequat occaecat excepteur nostrud sunt do minim qui. Officia nulla consectetur anim nulla consequat aliqua aliqua Lorem. Fugiat anim velit est nulla ex mollit id nostrud dolore. Laboris amet voluptate esse officia aliquip eu consectetur pariatur qui dolor. Nulla aliquip commodo cupidatat nisi ullamco amet do sit. Sunt cillum nisi reprehenderit sunt occaecat cupidatat ut Lorem pariatur est proident.",
                Price = 32.61,
                Discount = 0,
                DiscountPercentage = 10,
                Amount = 244,
                ExperitionDate = DateTime.ParseExact("2023-07-14", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "b33e92fd-58c3-4e4c-a6df-8150cb7ae3ae",
                Name = "Apex",
                Description =
                    "Dolor tempor officia dolore veniam ea irure dolore esse proident Lorem sunt pariatur sunt consectetur. Magna pariatur excepteur velit ad eu minim do duis pariatur consectetur laborum quis. Sit sit amet reprehenderit reprehenderit excepteur minim ea cupidatat sunt laborum. Duis occaecat fugiat minim sunt id eu eu mollit est culpa amet cupidatat. Nisi magna Lorem ipsum deserunt amet officia labore eu pariatur voluptate ea dolor exercitation proident. Dolore sit nostrud tempor adipisicing velit aute esse in fugiat. Velit enim fugiat excepteur ad.",
                Price = 63.76,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 33,
                ExperitionDate = DateTime.ParseExact("2023-07-09", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "fb5dc2fc-1c32-4024-881c-d7ac57d8f00f",
                Name = "Rodeocean",
                Description =
                    "Cillum velit veniam voluptate minim consectetur consequat fugiat adipisicing incididunt deserunt. Dolore culpa enim qui excepteur deserunt dolore in aute. Laboris id ipsum ipsum consequat minim ipsum amet aute quis velit. Et quis ad ex eu ipsum reprehenderit magna. Ea dolore est duis ea aute aute minim in sint ut ullamco ea esse. Nulla exercitation dolore quis incididunt exercitation ea veniam mollit cupidatat excepteur. Minim fugiat tempor commodo officia voluptate Lorem est excepteur nostrud reprehenderit aliquip elit eu esse.",
                Price = 99.28,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 170,
                ExperitionDate = DateTime.ParseExact("2023-06-23", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "16344425-ac2b-4af2-abf8-17323b6afa07",
                Name = "Zanity",
                Description =
                    "Adipisicing excepteur pariatur aliqua ullamco id aliquip ad enim nostrud est deserunt anim ut. In magna voluptate irure eiusmod do tempor do do exercitation irure. Laborum voluptate nulla veniam elit id proident enim esse aute. Aliqua et ea magna magna voluptate consectetur ipsum culpa qui pariatur deserunt cupidatat. Eiusmod qui voluptate magna proident fugiat tempor deserunt veniam esse velit pariatur Lorem. Commodo quis duis eu aute ipsum non cillum non consequat eu tempor. Aliqua dolor anim id et ad mollit anim anim.",
                Price = 84.79,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 203,
                ExperitionDate = DateTime.ParseExact("2023-07-02", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "6c3cc07a-644c-49f4-80e1-a29af75efe24",
                Name = "Quonata",
                Description =
                    "Occaecat cillum laborum occaecat magna tempor do. Labore Lorem qui non nulla minim fugiat nulla esse. Culpa ipsum dolor laborum fugiat pariatur velit incididunt sint. Magna et ex amet reprehenderit aliqua aliqua adipisicing consequat ipsum sit. Qui dolor sit minim ut reprehenderit elit excepteur non laboris reprehenderit aliquip. Quis sint ad ex mollit aute id minim exercitation fugiat est irure. Dolor in Lorem mollit cillum ut voluptate ad tempor voluptate ullamco.",
                Price = 14.85,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 63,
                ExperitionDate = DateTime.ParseExact("2023-07-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "18285642-5ad6-4e03-82a9-1b3cfc80ca77",
                Name = "Besto",
                Description =
                    "Consequat proident voluptate fugiat occaecat nisi ex et incididunt mollit amet tempor. Commodo elit aliquip laboris ullamco. Ea aliqua cupidatat ut eu nulla do consectetur est eiusmod ut. Dolor veniam commodo commodo consectetur mollit veniam magna culpa commodo et labore in. Velit magna veniam aliquip elit nisi do aute incididunt cillum consectetur. In ipsum aliquip deserunt exercitation velit aliquip ea laborum duis cillum ea incididunt. Mollit in sint incididunt eiusmod exercitation consectetur magna aliqua cupidatat nisi veniam dolore labore.",
                Price = 73.31,
                Discount = 0,
                DiscountPercentage = 25,
                Amount = 190,
                ExperitionDate = DateTime.ParseExact("2023-07-28", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "1866ec5a-addc-4129-93f7-b8ef3cebbe6d",
                Name = "Zilch",
                Description =
                    "Ullamco aliqua enim culpa ea. Velit culpa ad magna ullamco laborum laboris do qui magna officia. Deserunt nisi officia et consectetur officia nostrud non officia et enim cillum. Nostrud do officia irure laboris deserunt eu nulla ut. Deserunt eiusmod ipsum nostrud in labore. Dolore fugiat veniam consectetur excepteur mollit et. Officia adipisicing consectetur ipsum duis sint ullamco.",
                Price = 80.45,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 20,
                ExperitionDate = DateTime.ParseExact("2023-07-16", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "12a8e26e-5164-4330-99d5-abbbb574eb29",
                Name = "Aquasseur",
                Description =
                    "Do deserunt do eu ad veniam ex elit ut labore irure laborum incididunt fugiat. Ut sit labore tempor dolor consequat ex cillum Lorem labore enim do id in. Ullamco quis excepteur excepteur do culpa enim tempor aliquip nisi magna pariatur tempor aliquip. Eu dolore magna esse cupidatat pariatur qui minim qui occaecat cillum reprehenderit excepteur non. Id occaecat elit ad qui veniam amet. Ut cupidatat Lorem excepteur esse pariatur est fugiat minim ipsum eu dolore. Aliqua do elit nostrud nulla ea anim.",
                Price = 51.67,
                Discount = 0,
                DiscountPercentage = 10,
                Amount = 44,
                ExperitionDate = DateTime.ParseExact("2023-07-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "264583d4-54b9-49d7-a20e-9c5df529567d",
                Name = "Comtract",
                Description =
                    "Anim est laborum culpa aliquip mollit do ex consequat. Adipisicing sit deserunt reprehenderit elit labore dolore quis. Laboris ea velit do Lorem cupidatat eiusmod incididunt dolore quis amet eu proident eiusmod exercitation. Laboris enim enim ex excepteur sit. Nostrud voluptate duis sit irure. Ad aute Lorem ad pariatur irure reprehenderit. Adipisicing occaecat consequat ea ex adipisicing cupidatat excepteur labore cillum aliquip culpa aliqua ea.",
                Price = 95.35,
                Discount = 0,
                DiscountPercentage = 5,
                Amount = 231,
                ExperitionDate = DateTime.ParseExact("2023-07-02", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "bf76c775-f74e-43fb-818d-3c3ee56da821",
                Name = "Furnitech",
                Description =
                    "Enim deserunt id adipisicing ad tempor excepteur. Commodo elit eu exercitation nostrud officia. Est sunt aliquip deserunt culpa. Sit sunt esse nisi Lorem et aute adipisicing. Culpa incididunt labore culpa id non labore dolor culpa ullamco nostrud qui voluptate. Et duis voluptate quis duis fugiat velit qui duis eu pariatur esse. Non id dolor cillum veniam sit nulla laboris consequat.",
                Price = 19.1,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 118,
                ExperitionDate = DateTime.ParseExact("2023-07-25", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "b30a9735-8a23-4b7d-b72d-989951837cc2",
                Name = "Extro",
                Description =
                    "Culpa culpa officia cillum aute enim ex occaecat reprehenderit labore reprehenderit quis ut id. Ea adipisicing ex ad tempor est ea est nostrud elit deserunt quis nostrud velit nostrud. Cillum veniam pariatur commodo consectetur mollit labore officia non proident amet. Occaecat officia consequat Lorem ut nulla fugiat ullamco anim deserunt. Sint consequat magna sint sint laboris ea incididunt quis. Aliqua elit duis Lorem incididunt consectetur. Duis reprehenderit ullamco proident ex ea duis aliqua elit laboris aliqua est Lorem sunt in.",
                Price = 74.55,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 3,
                ExperitionDate = DateTime.ParseExact("2023-06-28", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "e82119fe-843d-40cb-8af8-6425a61ec23b",
                Name = "Assistix",
                Description =
                    "Esse laborum excepteur cillum duis minim enim ex minim cillum. Eiusmod nulla sit aliquip labore esse proident elit. Adipisicing adipisicing mollit deserunt ex est aliquip nulla nisi. Consequat eiusmod id exercitation pariatur. Ipsum do irure deserunt dolore consequat consequat magna non fugiat amet laboris anim. Irure id qui quis id officia proident quis amet laboris quis adipisicing reprehenderit. Minim minim Lorem ipsum occaecat.",
                Price = 34.7,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 84,
                ExperitionDate = DateTime.ParseExact("2023-07-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "238d8979-1cec-46b1-8c36-bd36158f2b98",
                Name = "Cedward",
                Description =
                    "Dolor nisi ullamco deserunt aliqua commodo reprehenderit amet ipsum. Consequat nostrud proident tempor ut exercitation et sunt Lorem irure cupidatat nulla ea deserunt nisi. Ipsum pariatur sit aute aliqua eiusmod ea sit exercitation. Do incididunt consectetur elit reprehenderit dolor est laborum. Do magna reprehenderit adipisicing veniam enim fugiat minim. Eiusmod laborum mollit laboris excepteur eu do do excepteur ut esse quis ea ex. Elit enim est sint irure ipsum duis nostrud est elit.",
                Price = 36.84,
                Discount = 0,
                DiscountPercentage = 10,
                Amount = 72,
                ExperitionDate = DateTime.ParseExact("2023-07-03", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "e486b4f8-449a-4824-9b27-c489d527cae7",
                Name = "Trollery",
                Description =
                    "Dolor eu fugiat id ut minim adipisicing ea do amet. Fugiat quis ut sit ea exercitation aliqua sunt ad ea occaecat sunt. Est quis id ea ipsum cupidatat aliquip occaecat. Dolor sunt duis fugiat nulla eu aute exercitation. Pariatur nisi ex pariatur velit irure. Elit ex commodo consectetur culpa id aute id commodo mollit culpa. Sint consectetur deserunt sit velit esse.",
                Price = 12.14,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 92,
                ExperitionDate = DateTime.ParseExact("2023-06-29", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "c9c55c40-d5da-438c-a8c9-8c72b28db013",
                Name = "Cognicode",
                Description =
                    "Nisi nisi nisi fugiat excepteur laboris proident ex. Officia nulla elit ut voluptate aliqua nisi ullamco. Cupidatat tempor laboris culpa officia est et do magna proident mollit. Consectetur magna proident ut ullamco eiusmod consequat enim do in commodo adipisicing. Aliqua ex est laboris irure elit officia sit reprehenderit deserunt ut consequat ea. Do aute consequat laborum commodo laboris commodo esse et ullamco exercitation velit esse exercitation. Consectetur labore tempor qui excepteur veniam eiusmod veniam adipisicing voluptate laboris est ullamco duis.",
                Price = 9.68,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 53,
                ExperitionDate = DateTime.ParseExact("2023-07-13", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "760509b0-74f3-4f0a-9118-8a74d15f8033",
                Name = "Fiberox",
                Description =
                    "Irure Lorem laboris pariatur in laborum proident nisi laborum occaecat consequat excepteur. Ut ipsum deserunt adipisicing ex nisi veniam adipisicing duis enim elit velit proident proident. Aliqua tempor est laboris dolor dolor nisi commodo id pariatur incididunt reprehenderit. Commodo nisi Lorem veniam nostrud amet id. Mollit consectetur adipisicing culpa proident nulla reprehenderit ex nulla id incididunt exercitation duis proident. Sit qui consectetur commodo incididunt irure mollit. Nisi magna nulla Lorem duis adipisicing.",
                Price = 45.67,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 94,
                ExperitionDate = DateTime.ParseExact("2023-07-16", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "0000ff68-26cf-473e-a2f3-50c0fefef85d",
                Name = "Rooforia",
                Description =
                    "Nulla enim in nostrud magna qui in esse Lorem est eiusmod. Occaecat officia Lorem do mollit nisi elit duis anim aliquip. Laborum elit consequat commodo est cillum cillum occaecat. Sunt proident eiusmod officia ad mollit ullamco minim laboris fugiat. Sit magna quis irure do laborum est tempor esse consectetur. Enim excepteur et do excepteur. Fugiat mollit nostrud id in.",
                Price = 44.6,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 41,
                ExperitionDate = DateTime.ParseExact("2023-06-27", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "8a54106a-71ba-4add-a62a-5cd7abcc768f",
                Name = "Biotica",
                Description =
                    "Ullamco est eiusmod id pariatur officia tempor. Consequat minim aliquip veniam proident amet excepteur. Do magna eiusmod quis tempor tempor elit id do irure excepteur. Lorem commodo labore elit aliquip duis nulla minim. Occaecat labore dolor ipsum fugiat voluptate dolor proident. Duis duis tempor minim anim amet nisi. Laboris ipsum dolore amet labore deserunt nulla amet incididunt pariatur.",
                Price = 41.88,
                Discount = 0,
                DiscountPercentage = 25,
                Amount = 69,
                ExperitionDate = DateTime.ParseExact("2023-07-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "edbd13c6-fabe-452a-b8d1-4690eb7d3bce",
                Name = "Firewax",
                Description =
                    "Reprehenderit aute sint irure excepteur velit deserunt nisi. Aliquip ut ea culpa reprehenderit culpa eiusmod magna aliqua mollit labore reprehenderit in laborum eu. Sint enim do mollit ullamco sit qui excepteur laborum reprehenderit. Excepteur veniam quis aliquip et aute consequat ut pariatur aute pariatur deserunt anim nulla. Proident occaecat sunt nulla ea Lorem non dolor minim ipsum laborum ipsum ad dolor tempor. Elit duis consequat reprehenderit adipisicing pariatur adipisicing nostrud aliqua incididunt commodo deserunt nisi. Consequat tempor exercitation sunt cupidatat aliqua commodo enim consequat commodo duis ex fugiat consequat qui.",
                Price = 87.01,
                Discount = 0,
                DiscountPercentage = 50,
                Amount = 173,
                ExperitionDate = DateTime.ParseExact("2023-07-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "858aeeaa-4513-4106-9663-123d5c98669a",
                Name = "Isostream",
                Description =
                    "Laboris est aliqua nulla laboris cupidatat ut proident deserunt sint laboris aute ipsum ipsum id. Reprehenderit do amet in veniam. Cillum proident cupidatat officia veniam deserunt fugiat enim magna quis culpa dolore. Culpa sunt ex nulla anim. Sunt officia labore ad minim anim minim est aute voluptate aliqua officia amet ullamco do. Sunt elit esse non dolore. Ea anim officia nisi duis aute amet.",
                Price = 65.2,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 192,
                ExperitionDate = DateTime.ParseExact("2023-07-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "9586c00f-d1aa-4933-9847-218d2e768143",
                Name = "Lovepad",
                Description =
                    "Reprehenderit eiusmod duis enim eiusmod anim duis cillum aliquip deserunt do. Commodo exercitation id aliquip eiusmod aute enim fugiat. Labore nulla cillum sunt officia. Ut occaecat minim duis aliquip consequat irure laborum ea elit do excepteur non. Eu tempor ad elit amet occaecat nulla. Nisi incididunt adipisicing enim Lorem. Lorem veniam magna id tempor nisi consequat nulla nisi consectetur aliquip.",
                Price = 25.92,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 38,
                ExperitionDate = DateTime.ParseExact("2023-07-20", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "fa378ced-5ca4-4852-9bb7-3e4415a7ef29",
                Name = "Miraclis",
                Description =
                    "Duis sunt sint magna tempor consequat dolor ex consequat est. Velit velit irure est esse anim sint sint eu laborum dolore. Sunt incididunt fugiat quis culpa commodo nostrud velit nostrud. Dolore ullamco culpa in eu mollit eu ipsum esse duis. Dolor officia duis cupidatat enim consequat esse ex quis reprehenderit minim et incididunt. Magna eu ut pariatur tempor consectetur eu veniam et nulla cillum incididunt. Ullamco mollit proident tempor consectetur occaecat.",
                Price = 35.62,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 184,
                ExperitionDate = DateTime.ParseExact("2023-07-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "66816d79-5f11-4f54-b514-81252053a92b",
                Name = "Mangelica",
                Description =
                    "Anim anim occaecat eiusmod nisi consequat ad consectetur laborum dolore id mollit. Veniam consectetur dolor veniam irure. Adipisicing exercitation officia culpa ullamco in irure do enim. Cillum deserunt laborum aliquip quis Lorem id aliquip dolor nisi. In cillum excepteur non adipisicing culpa ullamco. Sint cillum ex ex non ex. Nulla aliqua irure minim quis eiusmod ullamco sunt enim anim.",
                Price = 61,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 188,
                ExperitionDate = DateTime.ParseExact("2023-07-12", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "dee01c37-5d8d-4d4b-834d-99c024318ce4",
                Name = "Zillactic",
                Description =
                    "Amet quis incididunt commodo reprehenderit tempor irure aliquip magna veniam tempor proident. Do ipsum aute pariatur elit. Proident in ad fugiat proident anim dolore eiusmod ad culpa. Aliquip dolor anim aliqua in nostrud commodo nisi sit consectetur commodo do ex. Incididunt fugiat minim est sint minim enim. Ea veniam consectetur veniam sunt in dolore mollit aliquip duis cupidatat sint dolor laborum. Voluptate cillum excepteur dolor esse qui aute mollit occaecat ad.",
                Price = 1.21,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 59,
                ExperitionDate = DateTime.ParseExact("2023-07-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "cfa06f5d-41f5-436d-842b-73126f37c66b",
                Name = "Zytrax",
                Description =
                    "Ipsum fugiat aliquip qui do officia nulla irure ipsum velit eiusmod. Consectetur et ullamco in ex fugiat minim qui amet sit exercitation dolore. Consequat est minim magna in eiusmod magna dolore deserunt nostrud elit duis commodo labore aute. Exercitation sit do occaecat dolore et reprehenderit anim. Aliqua culpa id sunt cupidatat enim amet commodo commodo exercitation. Lorem elit aliqua magna non do deserunt. Exercitation tempor minim ullamco amet reprehenderit culpa incididunt ea eiusmod elit adipisicing consectetur.",
                Price = 60.46,
                Discount = 0,
                DiscountPercentage = 0,
                Amount = 87,
                ExperitionDate = DateTime.ParseExact("2023-07-06", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            }, new Product
            {
                Id = "da7836f1-c46d-4a83-90c1-05adda640062",
                Name = "Interodeo",
                Description =
                    "Excepteur exercitation culpa ea cupidatat ad esse eiusmod minim. Incididunt Lorem deserunt ad do anim aliqua nulla reprehenderit in sint culpa excepteur tempor quis. Eu et non voluptate minim nulla cupidatat labore amet. Occaecat magna nulla non veniam. Pariatur excepteur irure fugiat proident consectetur qui est irure eiusmod minim quis in. Fugiat qui cillum sint minim aliqua laborum pariatur incididunt. Sint non elit ullamco et officia incididunt ad.",
                Price = 98.74,
                Discount = 0,
                DiscountPercentage = 5,
                Amount = 241,
                ExperitionDate = DateTime.ParseExact("2023-06-24", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                ProductionDate = DateTime.ParseExact("2023-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Barcode = ""
            });
    }
}