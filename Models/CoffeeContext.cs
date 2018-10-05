using System.Data.Entity;

namespace Aprel.Models
{
    public class CoffeeContext : DbContext
    {

        public DbSet<CoffeeMachine> Coffeemachines { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Napitok> Napitki { get; set; }
        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<CoffeemachinesClass> CoffeemachinesClasses { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<string> Comments { get; set; }

    }


    public class CoffeeDBInitializer : DropCreateDatabaseAlways<CoffeeContext>
    {
        protected override void Seed(CoffeeContext db)
        {


            db.Coffeemachines.Add(new CoffeeMachine { Id = 1, ItemType = ItemType.White, Name = "PICCOLO БЕЛАЯ ", Price = 3990, Image = "/Images/Machines/Machines01/Machine1Small.jpg", Image1 = "/Images/Machines/Machines01/Machine11.jpg", Image2 = "/Images/Machines/Machines01/Machine12.jpg", Image3 = "/Images/Machines/Machines01/Machine13.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 2, ItemType = ItemType.Red, Name = "MELODY III КРАСНАЯ ", Price = 7990, Image = "/Images/Machines/Machines02/Machine2Small.jpg", Image1 = "/Images/Machines/Machines02/Machine21.jpg", Image2 = "/Images/Machines/Machines02/Machine22.jpg", Image3 = "/Images/Machines/Machines02/Machine23.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 3, ItemType = ItemType.Red, Name = "PICCOLO КРАСНАЯ ", Price = 3990, Image = "/Images/Machines/Machines03/Machine3Small.jpg", Image1 = "/Images/Machines/Machines03/Machine31.jpg", Image2 = "/Images/Machines/Machines03/Machine32.jpg", Image3 = "/Images/Machines/Machines03/Machine33.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 4, ItemType = ItemType.Black, Name = "MELODY III ЧЕРНАЯ ", Price = 3990, Image = "/Images/Machines/Machines04/Machine4Small.jpg", Image1 = "/Images/Machines/Machines04/Machine41.jpg", Image2 = "/Images/Machines/Machines04/Machine42.jpg", Image3 = "/Images/Machines/Machines04/Machine43.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 5, ItemType = ItemType.Black, Name = "PICCOLO СЕРАЯ ", Price = 3990, Image = "/Images/Machines/Machines05/Machine5Small.jpg", Image1 = "/Images/Machines/Machines05/Machine51.jpg", Image2 = "/Images/Machines/Machines05/Machine52.jpg", Image3 = "/Images/Machines/Machines05/Machine53.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 6, ItemType = ItemType.White, Name = "MELODY III КРЕМОВАЯ ", Price = 7990, Image = "/Images/Machines/Machines06/Machine6Small.jpg", Image1 = "/Images/Machines/Machines06/Machine61.jpg", Image2 = "/Images/Machines/Machines06/Machine62.jpg", Image3 = "/Images/Machines/Machines06/Machine63.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 7, ItemType = ItemType.Black, Name = "PICCOLO ЧЕРНАЯ ", Price = 3990, Image = "/Images/Machines/Machines07/Machine7Small.jpg", Image1 = "/Images/Machines/Machines07/Machine71.jpg", Image2 = "/Images/Machines/Machines07/Machine72.jpg", Image3 = "/Images/Machines/Machines07/Machine73.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 8, ItemType = ItemType.Red, Name = "CIRCOLO КРАСНАЯ ", Price = 6490, Image = "/Images/Machines/Machines08/Machine8Small.jpg", Image1 = "/Images/Machines/Machines08/Machine81.jpg", Image2 = "/Images/Machines/Machines08/Machine82.jpg", Image3 = "/Images/Machines/Machines08/Machine83.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 9, ItemType = ItemType.Red, Name = "OBLO КРАСНАЯ ", Price = 3990, Image = "/Images/Machines/Machines09/Machine9Small.jpg", Image1 = "/Images/Machines/Machines09/Machine91.jpg", Image2 = "/Images/Machines/Machines09/Machine92.jpg", Image3 = "/Images/Machines/Machines09/Machine93.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 10, ItemType = ItemType.Black, Name = "OBLO ЧЕРНАЯ", Price = 3990, Image = "/Images/Machines/Machines10/Machine10Small.jpg", Image1 = "/Images/Machines/Machines10/Machine101.jpg", Image2 = "/Images/Machines/Machines10/Machine102.jpg", Image3 = "/Images/Machines/Machines10/Machine103.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 11, ItemType = ItemType.White, Name = "OBLO БЕЛАЯ ", Price = 3990, Image = "/Images/Machines/Machines11/Machine11Small.jpg", Image1 = "/Images/Machines/Machines11/Machine111.jpg", Image2 = "/Images/Machines/Machines11/Machine112.jpg", Image3 = "/Images/Machines/Machines11/Machine113.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 12, ItemType = ItemType.White, Name = "MINI ME БЕЛАЯ ", Price = 8990, Image = "/Images/Machines/Machines12/Machine12Small.jpg", Image1 = "/Images/Machines/Machines12/Machine121.jpg", Image2 = "/Images/Machines/Machines12/Machine122.jpg", Image3 = "/Images/Machines/Machines12/Machine123.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 13, ItemType = ItemType.Red, Name = "GENIO 2 КРАСНАЯ ", Price = 6990, Image = "/Images/Machines/Machines13/Machine13Small.jpg", Image1 = "/Images/Machines/Machines13/Machine131.jpg", Image2 = "/Images/Machines/Machines13/Machine132.jpg", Image3 = "/Images/Machines/Machines13/Machine133.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 14, ItemType = ItemType.White, Name = "GENIO 2 BILLY THE ARTIST ", Price = 11990, Image = "/Images/Machines/Machines14/Machine14Small.jpg", Image1 = "/Images/Machines/Machines14/Machine141.jpg", Image2 = "/Images/Machines/Machines14/Machine142.jpg", Image3 = "/Images/Machines/Machines14/Machine143.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 15, ItemType = ItemType.Black, Name = "DROP СЕРАЯ ", Price = 13990, Image = "/Images/Machines/Machines15/Machine15Small.jpg", Image1 = "/Images/Machines/Machines15/Machine151.jpg", Image2 = "/Images/Machines/Machines15/Machine152.jpg", Image3 = "/Images/Machines/Machines15/Machine153.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 16, ItemType = ItemType.Black, Name = "ПРИВЕТСТВЕННЫЙ НАБОР PICCOLO ", Price = 3990, Image = "/Images/Machines/Machines16/Machine16Small.jpg", Image1 = "/Images/Machines/Machines16/Machine161.jpg", Image2 = "/Images/Machines/Machines16/Machine162.jpg", Image3 = "/Images/Machines/Machines16/Machine163.jpg" });
            db.Coffeemachines.Add(new CoffeeMachine { Id = 17, ItemType = ItemType.Red, Name = "ПРИВЕТСТВЕННЫЙ НАБОР OBLO ", Price = 3990, Image = "/Images/Machines/Machines17/Machine17Small.jpg", Image1 = "/Images/Machines/Machines17/Machine171.jpg", Image2 = "/Images/Machines/Machines17/Machine172.jpg", Image3 = "/Images/Machines/Machines17/Machine173.jpg" });

            
            db.Napitki.Add(new Napitok { Id = 0, ItemType = ItemType.CoffeeBlack, Name = "АМЕРИКАНО", Price = 419, Image = "/Images/Napitki/Napitok01/Napitok1Small.jpg", Image1 = "/Images/Napitki/Napitok01/Napitok11.jpg", Image2 = "/Images/Napitki/Napitok01/Napitok12.jpg", Image3 = "/Images/Napitki/Napitok01/Napitok13.jpg" });
            db.Napitki.Add(new Napitok { Id = 1, ItemType = ItemType.CoffeeBlack, Name = "ПРЕЛЮДИО", Price = 419, Image = "/Images/Napitki/Napitok02/Napitok2Small.jpg", Image1 = "/Images/Napitki/Napitok02/Napitok21.jpg", Image2 = "/Images/Napitki/Napitok02/Napitok22.jpg", Image3 = "/Images/Napitki/Napitok02/Napitok23.jpg" });
            db.Napitki.Add(new Napitok { Id = 2, ItemType = ItemType.CoffeeBlack, Name = "ПРЕЛЮДИО ИНТЕНСО", Price = 419, Image = "/Images/Napitki/Napitok03/Napitok3Small.jpg", Image1 = "/Images/Napitki/Napitok03/Napitok31.jpg", Image2 = "/Images/Napitki/Napitok03/Napitok32.jpg", Image3 = "/Images/Napitki/Napitok03/Napitok33.jpg" });
            db.Napitki.Add(new Napitok { Id = 3, ItemType = ItemType.CoffeeMilk, Name = "ЛАТТЕ МАКИАТО", Price = 379, Image = "/Images/Napitki/Napitok04/Napitok4Small.jpg", Image1 = "/Images/Napitki/Napitok04/Napitok41.jpg", Image2 = "/Images/Napitki/Napitok04/Napitok42.jpg", Image3 = "/Images/Napitki/Napitok04/Napitok43.jpg" });
            db.Napitki.Add(new Napitok { Id = 4, ItemType = ItemType.CoffeeMilk, Name = "CATUAI DO BRASIL", Price = 379, Image = "/Images/Napitki/Napitok05/Napitok5Small.jpg", Image1 = "/Images/Napitki/Napitok05/Napitok51.jpg", Image2 = "/Images/Napitki/Napitok05/Napitok52.jpg", Image3 = "/Images/Napitki/Napitok05/Napitok53.jpg" });
            db.Napitki.Add(new Napitok { Id = 5, ItemType = ItemType.CoffeeBlack, Name = "ЛУНГО", Price = 379, Image = "/Images/Napitki/Napitok06/Napitok6Small.jpg", Image1 = "/Images/Napitki/Napitok06/Napitok61.jpg", Image2 = "/Images/Napitki/Napitok06/Napitok62.jpg", Image3 = "/Images/Napitki/Napitok06/Napitok63.jpg" });
            db.Napitki.Add(new Napitok { Id = 6, ItemType = ItemType.CoffeeBlack, Name = "ГРАНДЕ", Price = 379, Image = "/Images/Napitki/Napitok07/Napitok7Small.jpg", Image1 = "/Images/Napitki/Napitok07/Napitok71.jpg", Image2 = "/Images/Napitki/Napitok07/Napitok72.jpg", Image3 = "/Images/Napitki/Napitok07/Napitok73.jpg" });
            db.Napitki.Add(new Napitok { Id = 7, ItemType = ItemType.CoffeeBlack, Name = "ГРАНДЕ ИНТЕНСО", Price = 379, Image = "/Images/Napitki/Napitok08/Napitok8Small.jpg", Image1 = "/Images/Napitki/Napitok08/Napitok81.jpg", Image2 = "/Images/Napitki/Napitok08/Napitok82.jpg", Image3 = "/Images/Napitki/Napitok08/Napitok83.jpg" });
            db.Napitki.Add(new Napitok { Id = 8, ItemType = ItemType.CoffeeMilk, Name = "ЭСПРЕССО", Price = 379, Image = "/Images/Napitki/Napitok09/Napitok9Small.jpg", Image1 = "/Images/Napitki/Napitok09/Napitok91.jpg", Image2 = "/Images/Napitki/Napitok09/Napitok92.jpg", Image3 = "/Images/Napitki/Napitok09/Napitok93.jpg" });
            db.Napitki.Add(new Napitok { Id = 9, ItemType = ItemType.CoffeeMilk, Name = "ЭСПРЕССО СО ВКУСОМ КАРАМЕЛИ", Price = 111, Image = "/Images/Napitki/Napitok10/Napitok10Small.jpg", Image1 = "/Images/Napitki/Napitok10/Napitok101.jpg", Image2 = "/Images/Napitki/Napitok10/Napitok102.jpg", Image3 = "/Images/Napitki/Napitok10/Napitok103.jpg" });
            db.Napitki.Add(new Napitok { Id = 10, ItemType = ItemType.CoffeeMilk, Name = "ЭСПРЕССО ИНТЕНСО", Price = 379, Image = "/Images/Napitki/Napitok11/Napitok11Small.jpg", Image1 = "/Images/Napitki/Napitok11/Napitok111.jpg", Image2 = "/Images/Napitki/Napitok11/Napitok112.jpg", Image3 = "/Images/Napitki/Napitok11/Napitok113.jpg" });
            db.Napitki.Add(new Napitok { Id = 11, ItemType = ItemType.CoffeeMilk, Name = "РИСТРЕТТО", Price = 379, Image = "/Images/Napitki/Napitok12/Napitok12Small.jpg", Image1 = "/Images/Napitki/Napitok12/Napitok121.jpg", Image2 = "/Images/Napitki/Napitok12/Napitok122.jpg", Image3 = "/Images/Napitki/Napitok12/Napitok123.jpg" });
            db.Napitki.Add(new Napitok { Id = 12, ItemType = ItemType.CoffeeBlack, Name = "БАРИСТА", Price = 379, Image = "/Images/Napitki/Napitok13/Napitok13Small.jpg", Image1 = "/Images/Napitki/Napitok13/Napitok131.jpg", Image2 = "/Images/Napitki/Napitok13/Napitok132.jpg", Image3 = "/Images/Napitki/Napitok13/Napitok133.jpg" });
            db.Napitki.Add(new Napitok { Id = 13, ItemType = ItemType.CoffeeMilk, Name = "МОККО", Price = 379, Image = "/Images/Napitki/Napitok14/Napitok14Small.jpg", Image1 = "/Images/Napitki/Napitok14/Napitok141.jpg", Image2 = "/Images/Napitki/Napitok14/Napitok142.jpg", Image3 = "/Images/Napitki/Napitok14/Napitok143.jpg" });
            db.Napitki.Add(new Napitok { Id = 14, ItemType = ItemType.Chokolate, Name = "НЕСКВИК", Price = 379, Image = "/Images/Napitki/Napitok15/Napitok15Small.jpg", Image1 = "/Images/Napitki/Napitok15/Napitok151.jpg", Image2 = "/Images/Napitki/Napitok15/Napitok152.jpg", Image3 = "/Images/Napitki/Napitok15/Napitok153.jpg" });

            db.Accessories.Add(new Accessory { Id = 0, ItemType = ItemType.Cups, Name = "НАБОР ЧАШЕК ДЛЯ ЛУНГО   «ICONIC»      ", Price = 1428, Image = "/Images/Accessories/Accessor1/Accessor1Small.jpg", Image1 = "/Images/Accessories/Accessor1/Accessor1.jpg", Image2 = "/Images/Accessories/Accessor1/Accessor11.jpg", Image3 = "/Images/Accessories/Accessor1/Accessor12.jpg" });
            db.Accessories.Add(new Accessory { Id = 1, ItemType = ItemType.Cups, Name = "НАБОР ЧАШЕК ДЛЯ КАПУЧИНО «ICONIC»     ", Price = 1747, Image = "/Images/Accessories/Accessor2/Accessor2Small.jpg", Image1 = "/Images/Accessories/Accessor2/Accessor21.jpg", Image2 = "/Images/Accessories/Accessor2/Accessor22.jpg", Image3 = "/Images/Accessories/Accessor2/Accessor23.jpg" });
            db.Accessories.Add(new Accessory { Id = 2, ItemType = ItemType.Glasses, Name = "ПРОЗРАЧНЫЕ СТЕКЛЯННЫЕ СТАКАНЫ ДЛЯ КОФЕ ", Price = 1202, Image = "/Images/Accessories/Accessor3/Accessor3Small.jpg", Image1 = "/Images/Accessories/Accessor3/Accessor31.jpg", Image2 = "/Images/Accessories/Accessor3/Accessor32.jpg", Image3 = "/Images/Accessories/Accessor3/Accessor33.jpg" });
            db.Accessories.Add(new Accessory { Id = 3, ItemType = ItemType.Cups, Name = "НАБОР ЧАШЕК ДЛЯ ЭСПРЕССО «FUNKY»       ", Price = 1308, Image = "/Images/Accessories/Accessor4/Accessor4Small.jpg", Image1 = "/Images/Accessories/Accessor4/Accessor41.jpg", Image2 = "/Images/Accessories/Accessor4/Accessor42.jpg", Image3 = "/Images/Accessories/Accessor4/Accessor43.jpg" });
            db.Accessories.Add(new Accessory { Id = 4, ItemType = ItemType.Cups, Name = "НАБОР ЧАШЕК ДЛЯ КАПУЧИНО «FUNKY»       ", Price = 1747, Image = "/Images/Accessories/Accessor5/Accessor5Small.jpg", Image1 = "/Images/Accessories/Accessor5/Accessor51.jpg", Image2 = "/Images/Accessories/Accessor5/Accessor52.jpg", Image3 = "/Images/Accessories/Accessor5/Accessor53.jpg" });
            db.Accessories.Add(new Accessory { Id = 5, ItemType = ItemType.Spoons, Name = "НАБОР МАЛЕНЬКИХ ЛОЖЕК ДЛЯ ЭСПРЕССО     ", Price = 1074, Image = "/Images/Accessories/Accessor6/Accessor6Small.jpg", Image1 = "/Images/Accessories/Accessor6/Accessor61.jpg", Image2 = "/Images/Accessories/Accessor6/Accessor62.jpg", Image3 = "/Images/Accessories/Accessor6/Accessor63.jpg" });
            db.Accessories.Add(new Accessory { Id = 6, ItemType = ItemType.Spoons, Name = "НАБОР МАЛЕНЬКИХ ЛОЖЕЧЕК ДЛЯ ЛУНГО      ", Price = 1173, Image = "/Images/Accessories/Accessor7/Accessor7Small.jpg", Image1 = "/Images/Accessories/Accessor7/Accessor71.jpg", Image2 = "/Images/Accessories/Accessor7/Accessor72.jpg", Image3 = "/Images/Accessories/Accessor7/Accessor73.jpg" });
            db.Accessories.Add(new Accessory { Id = 7, ItemType = ItemType.Spoons, Name = "НАБОР ЛОЖЕК ДЛЯ ЛАТТЕ МАКИАТО          ", Price = 1299, Image = "/Images/Accessories/Accessor8/Accessor8Small.jpg", Image1 = "/Images/Accessories/Accessor8/Accessor81.jpg", Image2 = "/Images/Accessories/Accessor8/Accessor82.jpg", Image3 = "/Images/Accessories/Accessor8/Accessor83.jpg" });
            db.Accessories.Add(new Accessory { Id = 8, ItemType = ItemType.Spoons, Name = "НАБОР СРЕДНИХ КОФЕЙНЫХ ЛОЖЕК           ", Price = 305, Image = "/Images/Accessories/Accessor9/Accessor9Small.jpg", Image1 = "/Images/Accessories/Accessor9/Accessor91.jpg", Image2 = "/Images/Accessories/Accessor9/Accessor92.jpg", Image3 = "/Images/Accessories/Accessor9/Accessor93.jpg" });



            db.CoffeemachinesClasses.Add(new CoffeemachinesClass { Id = 0, Name = "PICCOLO", Price = 305, Image = "/Images/Machines/Machines01/Machine12.jpg", Image1 = "/Images/Machines/Machines01/Machine11.jpg", Image2 = "/Images/Machines/Machines01/Machine12.jpg", Image3 = "/Images/Machines/Machines01/Machine13.jpg" });

            db.CoffeemachinesClasses.Add(new CoffeemachinesClass { Name = "MELODY 2", Image = "/Images/MELODY_2.jpg" });
            db.CoffeemachinesClasses.Add(new CoffeemachinesClass { Name = "MELODY 3 FS", Image = "/Images/MELODY_3_FS.jpg" });
            db.CoffeemachinesClasses.Add(new CoffeemachinesClass { Name = "GENIO 2", Image = "/Images/GENIO_2.jpg" });
            db.CoffeemachinesClasses.Add(new CoffeemachinesClass { Name = "MINI-ME", Image = "/Images/MINI-ME.jpg" });
            db.CoffeemachinesClasses.Add(new CoffeemachinesClass { Name = "MELODY 3", Image = "/Images/MELODY_3.jpg" });
            db.CoffeemachinesClasses.Add(new CoffeemachinesClass { Name = "CIRCOLO_FS", Image = "/Images/CIRCOLO_FS.jpg" });






            base.Seed(db);
        }

    }

}