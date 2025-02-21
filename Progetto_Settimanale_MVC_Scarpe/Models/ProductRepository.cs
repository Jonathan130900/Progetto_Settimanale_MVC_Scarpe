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
                Description = "A lightweight mesh upper and padded heel make these adidas Gamecourt 2.0 shoes your perfect tennis partner. ",
                CoverImage = "https://i.ebayimg.com/images/g/qy0AAOSwwwdiwVWi/s-l1600.webp",
                AdditionalImage1 = "https://i.ebayimg.com/images/g/cHEAAOSwSONiwVWj/s-l1600.webp",
                AdditionalImage2 = "https://i.ebayimg.com/images/g/oJwAAOSwIqliwVWj/s-l1600.webp"
            }
        };
    }
}
