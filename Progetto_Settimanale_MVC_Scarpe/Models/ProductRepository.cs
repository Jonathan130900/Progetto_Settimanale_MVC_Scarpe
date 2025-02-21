namespace Progetto_Settimanale_MVC_Scarpe.Models
{
    public class ProductRepository
    {
        public static List<Product> Products { get; } = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "THE ROGER Pro US 7-13 Roger Federer",
                Price = 215.00m,
                Description = "THE ROGER Pro, On's first competitive tennis shoe, was co-developed with Roger Federer and combines the champion's accumulated experience with performance technology.",
                CoverImage = "https://i.ebayimg.com/images/g/8GoAAOSw4zNjvOmy/s-l1600.webp",
                AdditionalImage1 = "https://i.ebayimg.com/images/g/EqEAAOSwxlFjvOii/s-l1600.webp",
                AdditionalImage2 = "https://i.ebayimg.com/images/g/AuoAAOSwD9xjvOi~/s-l1600.webp"
            },
            new Product
            {
                Id = 2,
                Name = "Adidas GameCourt 2 FTW GW2991",
                Price = 79.00m,
                Description = "A lightweight mesh upper and padded heel make these adidas Gamecourt 2.0 shoes your perfect tennis partner.",
                CoverImage = "https://i.ebayimg.com/images/g/qy0AAOSwwwdiwVWi/s-l1600.webp",
                AdditionalImage1 = "https://i.ebayimg.com/images/g/cHEAAOSwSONiwVWj/s-l1600.webp",
                AdditionalImage2 = "https://i.ebayimg.com/images/g/oJwAAOSwIqliwVWj/s-l1600.webp"
            },
            new Product
            {
                Id = 3,
                Name = "Asics GEL RESOLUTION X",
                Price = 134.99m,
                Description = "Always featuring the iconic GEL™ cushioning, the new Asics Gel Resolution X offers even more support and stability.",
                CoverImage = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcSxvggC9ZOgpttfykJdp0uQaVLbRgqb2FXVftGxpxYrHMEB5iAf6W3bE3hx26qzvY0qis5SPYqrxB4pJIkV5gI0VLkyB-9q1T99SxxnQd9VocLAvqY639ILovXj",
                AdditionalImage1 = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcRkpvwN4CF3MjwgZ0lxY27HkzUgP_yYIAU7gK_6mW8QvRc7F-pkoL9qFWHUf63AS_iOZfKatePyetCWuQhCnKp4GLw_2pBNe7DxK5C6CCYABumSOPbH8X627Tg",
                AdditionalImage2 = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcRDEgtGozpLYvq1xzZwxbDF3qIBed9faJLkcDYTx65Wn6S4Vvb_YFp6O6OO2CWbaN0be8ASRG32Ljp-AKzz_gzriggcyqmyA7GksM1203Jsc2fIzwUe0x2ozW62"
            },
            new Product
            {
                Id = 4,
                Name = "Nike Vapor Pro 3",
                Price = 129.99m,
                Description = "Thanks to the responsive Air Zoom cushioning and the new mixed rubber, the shoe is lighter than previous Vapor models and perfect for securing the match point.",
                CoverImage = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/094c34e6-2c9d-47ae-a3f0-9c02cb6a243a/M+ZOOM+VAPOR+PRO+3+HC.png",
                AdditionalImage1 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/7169719e-af3a-43c1-89d9-c7941b9019f0/M+ZOOM+VAPOR+PRO+3+HC.png",
                AdditionalImage2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/a1d8aecd-9125-45d0-ae66-ee62a84e83f0/M+ZOOM+VAPOR+PRO+3+HC.png"
            },
            new Product
            {
                Id = 5,
                Name = "Lacoste Ag-lt Ultra",
                Price = 170.00m,
                Description = "Collaboration with Daniil Medvedev, ensuring quality and professional design.",
                CoverImage = "https://contents.mediadecathlon.com/m18699930/k$f3d2ca354834ac50475054659d75b81f/picture.jpg?format=auto&f=320x0",
                AdditionalImage1 = "https://contents.mediadecathlon.com/m18700025/k$08950c962ee7a08b2133c310e74fa44f/picture.jpg?format=auto&f=320x0",
                AdditionalImage2 = "https://contents.mediadecathlon.com/m18699988/k$5a429a4572eda2ed01fc87d717ebe083/picture.jpg?format=auto&f=320x0"
            }
        };
    }
}
