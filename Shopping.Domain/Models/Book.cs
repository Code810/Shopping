using Shopping.Services.Helpers;
namespace Shopping.Domain.Models
{
    public class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public int Id { get; }
        
        public Book(string name, int pagecount,int count, int salesprice, int purchaseprice,string authorname)
        {
            Name = name;
            PageCount = pagecount;
            SalesPrice=salesprice;
            PurchasePrice = purchaseprice;
            AuthorName = authorname;
            _count= count;
            _id++;
            Id = _id;
        }
        public override void Sell()
        {
            if (_count <= 0) 
            {
                Console.WriteLine(Messages.ErrorMessageCountNull);
            }
            else 
            {
                _count--;
                TotalInCome = TotalInCome + (SalesPrice - PurchasePrice);
                Console.WriteLine(Messages.AcceptedOrder);
            }
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine($" Kitabin adi:{Name}\n Yazicinin adi:{AuthorName}\n qiymeti:{SalesPrice} azn\n stokda qalan miqdari:{_count} eded");
        }

        public static void ShowProfit()
        {
            Console.WriteLine($"Elde edilen qazanc:{TotalInCome} azn");
        }
    }
}
