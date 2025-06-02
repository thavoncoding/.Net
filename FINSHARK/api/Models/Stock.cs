
using System.ComponentModel.DataAnnotations.Schema;
using api.Dtos.Stock;
namespace api.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public StockDto ToStockDto()
        {
            return new StockDto
            {
                Id = Id,
                Symbol = Symbol,
                CompanyName = CompanyName,
                Purchase = Purchase,
                LastDiv = LastDiv,
                Industry = Industry,
                MarketCap = MarketCap
                // If you want to include comments, you'd map them here as well
                // Comments = Comments.Select(c => c.ToCommentDto()).ToList() // Assuming you have a ToCommentDto() for Comment model
            };
        }
    }   
}
