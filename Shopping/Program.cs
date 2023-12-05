

using Shopping.Domain.Models;

Book book1 = new("Bak",134,3,15,9,"Cek London");
book1.ShowInfo();
book1.Sell();
book1.ShowInfo();
book1.Sell();
book1.Sell();
book1.Sell();
Book book2 = new("lorem", 110, 2, 12, 6, "Cek London");
book2.ShowInfo();
book2.Sell();
book2.Sell();
Book.ShowProfit();
