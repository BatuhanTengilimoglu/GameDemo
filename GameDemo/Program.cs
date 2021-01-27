using GameDemo.Business.Abstract;
using GameDemo.Business.Concrete;
using GameDemo.Business.Concrete.Platform;
using GameDemo.Business.Concrete.Sale;
using GameDemo.DataAccess.Abstract;
using GameDemo.DataAccess.Concrete.Database;
using GameDemo.DataAccess.Concrete.File;
using GameDemo.DataAccess.Validation.Abstract;
using GameDemo.DataAccess.Validation.Concrete;
using GameDemo.Entity.Abstract;
using GameDemo.Entity.Concrete;
using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        public static object ISalesService { get; private set; }

        static void Main(string[] args)
        {
            ILoggerService fileLogger = new FileLoggerService();
            ILoggerService databaseLogger = new DatabaseLoggerService();
            IValidateService mernisValidateService = new MernisValidateService();

            IEntityService userManager = new UserManager(new List<ILoggerService> { databaseLogger, fileLogger },
                new List<IValidateService> { mernisValidateService });
            IEntity batuhan = new User
            {
                NickName = "Likeafear",
                NationalityId = "12345678901",
                Name = "Batuhan",
                LastName = "Tengilimoğlu",
                YearOfBirth = 1998,
                Balance = 1000
            };
            IEntity oguzhan = new User
            {
                NickName = "Aeston",
                NationalityId = "12345678902",
                Name = "Oğuzhan",
                LastName = "Tengilimoğlu",
                YearOfBirth = 1992,
                Balance = 5000
            };
            IEntity ugur = new User
            {
                NickName = "Halfrime",
                NationalityId = "12345678903",
                Name = "Uğur",
                LastName = "Yağbasan",
                YearOfBirth = 1998,
                Balance = 800
            };
            Console.WriteLine("\n***kullanıcı ekleme silme güncelleme***");
            userManager.Add(batuhan);
            userManager.Delete(oguzhan);
            userManager.Update(ugur);

            IEntity gow = new Game()
            {
                Id = 1,
                Name = "God Of War",
                Price = 199.90,
                Publisher = "Sony Interactive Entertainment"
            };
            IEntity rdr2 = new Game()
            {
                Id = 2,
                Name = "Red Dead Redemption",
                Price = 300,
                Publisher = "Rockstar Games"
            };
            IEntity lof2 = new Game()
            {
                Id = 3,
                Name = "Last Of Us Pt2",
                Price = 369.90,
                Publisher = "Sony Interactive Entertainment"
            };
            IEntity steam_platform = new Platform()
            {
                Name = " Steam Platformunda"
            };
            IEntity epicGames_platform = new Platform()
            {
                Name = " Epic Games Platformunda"
            };

            Console.WriteLine("\n***Oyuncu tarafından oyun ekleme silme güncelleme***");

            IEntityService gameManager = new GameManager(new List<ILoggerService> { databaseLogger });
            gameManager.Add(gow);
            gameManager.Delete(rdr2);
            gameManager.Update(lof2);

            ISaleService cadilarBayramiIndirimi = new HalloweenSaleManager();
            ISaleService gunlukIndirimler = new DailySaleManager();
            ISaleService yazIndirimi = new SummerSaleManager();

            IPlatformService steam = new SteamPlatformManager(new List<ISaleService> { });
            IPlatformService epic_games = new EpicGamesPlatformManager(new List<ISaleService> { yazIndirimi, gunlukIndirimler, cadilarBayramiIndirimi });
            Console.WriteLine("\n***Satın alma ve iade etme***");

            steam.Buy(batuhan, gow);
            steam.Refund(oguzhan, rdr2);
            epic_games.Buy(ugur, rdr2);
            epic_games.Refund(batuhan, lof2);

            Console.WriteLine("\n***Platform indirimleri***");
            cadilarBayramiIndirimi.Sale(gow, steam_platform);
            gunlukIndirimler.Sale(rdr2, epicGames_platform);
            yazIndirimi.Sale(lof2, steam_platform);

            
        }
    }
}
