using laptop;

internal class Program
{
    private static void Main(string[] args)
    {
        Laptop laptop1, laptop2;
        Predator predator;

        laptop1 = new Vivobook(new vga.Nvidia(), new processor.CoreI5());
        laptop2 = new IdeaPad(new vga.AMD(), new processor.Ryzen());
        predator = new Predator(new vga.AMD(), new processor.CoreI7());


        // Soal 1
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();
        

        // Soal 2 (error)
        // laptop1.Ngoding();
        

        // Soal 3
        Console.WriteLine($"Laptop {laptop1.vga.merk}, {laptop1.processor.merk}, {laptop1.processor.tipe}");

        // Soal 4
        predator.BermainGame();

        // Soal 5 (error pada acer.BermainGame())
        ACER acer = predator;
        // acer.BermainGame();
    }
}

namespace processor
{
    class Processor
    {
        public string merk;
        public string tipe;

        public Processor(string merk, string tipe)
        {
            this.merk = merk;
            this.tipe = tipe;
        }
    }

    class Intel : Processor
    {
        public Intel(string tipe) : base("intel", tipe) { }
    }

    class CoreI3 : Intel
    {
        public CoreI3() : base("Core i3") { }
    }

    class CoreI5 : Intel
    {
        public CoreI5() : base("Core i5") { }
    }

    class CoreI7 : Intel
    {
        public CoreI7() : base("Core i7") { }
    }

    class AMD : Processor
    {
        public AMD(string tipe) : base("AMD", tipe) { }
    }

    class Ryzen : AMD
    {
        public Ryzen() : base("RAYZEN") { }
    }

    class Athlon : AMD
    {
        public Athlon() : base("ATHLON") { }
    }
}

namespace vga
{
    class Vga
    {
        public string merk;

        public Vga(string merk)
        {
            this.merk = merk;
        }
    }

    class Nvidia : Vga
    {
        public Nvidia() : base("Nvidia") { }
    }

    class AMD : Vga
    {
        public AMD() : base("AMD") { }
    }
}


namespace laptop
{
    using processor;
    using vga;

    class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;

        public Laptop(string merk, string tipe, Vga vga, Processor processor)
        {
            this.merk = merk;
            this.tipe = tipe;
            this.vga = vga;
            this.processor = processor;
        }

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }

    class Asus : Laptop
    {
        public Asus(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor) { }
    }

    class ROG : Asus
    {
        public ROG(Vga vga, Processor processor) : base("ROG", vga, processor) { }
    }

    class Vivobook : Asus
    {
        public Vivobook(Vga vga, Processor processor) : base("Vivobook", vga, processor) { }

        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class ACER : Laptop
    {
        public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor) { }
    }

    class Swift : ACER
    {
        public Swift(Vga vga, Processor processor) : base("Swift", vga, processor) { }
    }

    class Predator : ACER
    {
        public Predator(Vga vga, Processor processor) : base("Predator", vga, processor) { }

        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }



    class Lenovo : Laptop
    {
        public Lenovo(string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor) { }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad(Vga vga, Processor processor) : base("IdeaPad", vga, processor) { }
    }

    class Legion : Lenovo
    {
        public Legion(Vga vga, Processor processor) : base("Legion", vga, processor) { }
    }
} 