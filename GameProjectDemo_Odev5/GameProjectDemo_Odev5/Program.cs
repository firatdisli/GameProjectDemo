using System;
using GameProjectDemo_Odev5.Entities;
using GameProjectDemo_Odev5.Abstract;
using GameProjectDemo_Odev5.Concrete;
namespace GameProjectDemo_Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Doğrulama işlemi 18 yaşından büyük olmasına göre yapılacaktır. Mersis işlemi sonraki çalışmalarda 
            //eklenecektir

            Gamer gamer1 = new Gamer();
            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            GamerManager gamerManager = new GamerManager();
            gamer1.Id = 1;
            gamer1.TCKimlikNo = "12345678901";
            gamer1.Firstname = "Firat";
            gamer1.LastName = "Dİşli";
            gamer1.YearOfBirth = 1990;

         gamerManager.GamerAdd(gamer1,  gamerCheckManager.GamerCheck(gamer1));

            Gamer gamer2 = new Gamer { Id=2,TCKimlikNo="12345678910",Firstname="Ahmet",LastName="Demir",YearOfBirth=2005};
            Gamer gamer3 = new Gamer { Id = 3, TCKimlikNo = "123564795201", Firstname = "Ayşe", LastName = "Kaya", YearOfBirth = 1995 };
            gamerManager.GamerAdd(gamer2, gamerCheckManager.GamerCheck(gamer2));

            Console.WriteLine("-------------------------");
            Game game1 = new Game { Id = 1001, GameName = "Kodlama.io", GamePrice = 150 ,CampaignPrice=150};
            Game game2 = new Game { Id = 1002, GameName = "YotubePlay", GamePrice = 120,CampaignPrice=120 };
            GameManager gameManager = new GameManager();
            gameManager.GameAdd(game1);
            gameManager.GameAdd(game2);

            Console.WriteLine("-----------------------");
            SaleMaganer saleMaganer = new SaleMaganer();
            saleMaganer.SalesConfirm(gamer1, game1);
            //Veritabanı olmadığından aslında onaylanmayan kullanıcıya satış yapıldı
            saleMaganer.SalesConfirm(gamer2, game2);


            //Bu projece eklenen Kanpanya oyun fiyatını düşürme işlemi yapacaktır. 
            //Bu nedenle Game sınıfına kanpanyalı fiyat alanı eklenecektir
            //Kanpanya başladığında ve bittiğinde kanpanyalıfiyat güncellenecektir
            //satış kanpanyalı fiyat üzerinden yapılacaktır
            //Kanpanya execute edildiğinde fiyat güncellenecektir
            Console.WriteLine("--------------------");
            Campaign campaign = new Campaign { Id = 1001, CampaignGame = "Kodlama.io", CampaingPrice = 110 };
            CanpaignManager canpaignManager = new CanpaignManager();
            canpaignManager.CampaignAdd(campaign);
            //game1 geri dönüş değeri veri tabanı olmadığı için kullanıldı
            game1= canpaignManager.CampaignExecute(game1, campaign);
            Console.WriteLine("-----------------------");
            saleMaganer.SalesConfirm(gamer3, game1);


        }
    }
}
