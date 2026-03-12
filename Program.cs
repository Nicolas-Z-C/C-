using C_course.Advancedshit.Delegates;
using C_course.Advancedshit.Events;
using C_course.Advancedshit.Multithreading;
using System.IO;
namespace C_course
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            /*
            //Classes
            //Se crea una instancia de la clase que ya creamos anteriormente
             
            Se genera un error por el constructor, pues este toma parametros que no son opcinales y no se los estoy pasando
            Classe1 clase1 = new Classe1();

            Manipulando los objetos

            clase1.titulo = "Clase de biologia";
            clase1.estudiantes = 45;
            clase1.nombre = "Clase01";
            Asi tenemos un sistema de claves:valor parecido a un diccionario
            
            Classe1 clase2 = new Classe1("Clase de biologia");
            clase2.titulo = "Titulo2";
            //Constructor overload
            Classe1 clase3 = new Classe1("Biologia","Biologia1",45);

            //Object methods

            Clase2 clase1 = new Clase2("Johlver",15,"Biologia",2,5);

            //Uso del metodo

            string tamaño = clase1.Size();
            
            Console.WriteLine($"Nombre clase: {clase1.nombre}\nEstudiantes: {clase1.estudiantes}\nProfesor: {clase1.profesor}\nTemas: {clase1.temas}\nSalon: {clase1.salon}");
            Console.WriteLine($"El tamaño de esta clase es {tamaño}");
            

            //Getters & Setters
            /*Son escencialmente medidas de seguridad para nuestras clases
              evitan errores y asi mismo fallas de seguridad
            Movie pelicula1 = new Movie("Avengers","Jhon","FF"); //Se auto convertira a bajo
            Movie pelicula2 = new Movie("Cenicienta","Kafka","alto");

            Console.WriteLine(pelicula1.Rating);
            Console.WriteLine(pelicula2.Rating);
           

            //static class atributes

            Song song1 = new Song("Title","Me",15);
            Console.WriteLine(Song.songcount);
            Song song2 = new Song("Title2", "Me2", 10);
            Console.WriteLine(Song.songcount);
            song2.getsSongCount();
            

            //static methods and classes

            //Console.WriteLine(Math.Min(1,8)); //El metodo min es un metodo estatico que puede ser llamado desde la clase Math, sin nececitar un objeto como intermediario

            //Inheritance 

            Chef chef1 = new Chef();
            ItalianChef chef = new ItalianChef();

            chef1.MakeRice();
            chef.MakeRice();
            

            //Abstract keyword

            Plane plan1 = new Plane();
            Car car1 = new Car();
            //error pues se tiene abstract
            //Vehicule vehicule1 = new Vehicule();
            

            //Arrays of objects

            //Se crea el array de objetos, este solo puede contener objetos de la clase designada
            Kart[] garage = new Kart[5];

            Kart kart1 = new Kart("Red");
            Kart kart2 = new Kart("Blue");
            Kart kart3 = new Kart("Grey");

            foreach(Kart kart in garage)
            {
                Console.WriteLine(kart.color);
            }

            //Creacion con objetos anonimos

            Kart [] karts = { new Kart("Red"), new Kart("Blue"), new Kart("Grey"),};
            


            //Objects as arguments

            Car2 Carrito = new Car2();

            Console.WriteLine(Carrito.color);

            Car2.changecolor(Carrito, "Red");

            Console.WriteLine(Carrito.color);

            Car2 car2 = Car2.copy(Carrito);

            

            //ToString

            //Nos sirve para poder mostrar algo diferente a la hora de usar el metodo por medio de el sebreescribir su codio original.

            Tostring papaya = new Tostring("Chevy","2007",2005,"Red");
            Console.WriteLine(papaya.ToString());
            Console.WriteLine(papaya);
            

            //Polymorphism
            //Tener muchas formas y tipos de datos 

            Carrito carrito1 = new Carrito();
            Motico motico = new Motico();
            Avioncito avioncito = new Avioncito(); 

            //Si quisieramos crear un array con nuestros objetos tendriamos que usar la clase padre o la que tengan en comun nuestros objetos
            //En este caso seria Vehicules 

            Carrito [] garaje = new Carrito[10];

            //garaje[1] = motico; //Nos da un error pues no se puede insertar un tipo en otro

            Vehicules [] garage = {motico, carrito1,avioncito}; //Gracias al poly se puede lograr esto

            foreach(Vehicules vehicules in garage)
            {
                //Solo funciona si nuestra clase padre tiene el metodo que se esta llamando, pero al poder ser sobreescrito actuara segun lo que este en su sub clase
                vehicules.go();
            }

            //Asi mismo podemos crear objetos de carro y tratarlos como vehiculos

            Vehicules carrito2 = new Carrito(); //Valido gracias a la herencia y poli

            

            //Interfaces

            Rabbit rabbit = new Rabbit();

            rabbit.flee();

            Hawk hawk = new Hawk();

            hawk.searchForPrey();

            //A diferencia de las clases normales las interfaces permiten la herencia multiple

            Fish fish = new Fish();

            fish.searchForPrey();
            fish.flee();
            

            //Listas

            //Las listas son arrays con esteroides, pueden almacenar datos complejos y tambien crecer o reducir su tamaño

            List<string> Lista1 = new List<string>();
            //Para agregar un indice usamos el .Add

            Lista1.Add("Papa");
            Lista1.Add("Pizza");
            Lista1.Add("Perro");

            foreach(string str in Lista1)
            {
                Console.WriteLine(str);
            }

            Lista1.Remove("Pizza");

            foreach (string str in Lista1)
            {
                Console.WriteLine(str);
            }
            
            Lista1.Insert(0,"Pedro");

            Lista1.Count();
            Lista1.IndexOf("Papa");
            Lista1.LastIndexOf("Papa");
            Lista1.Contains("Papa");
            List<Vehicules> garage1 = new List<Vehicules>();

            Carrito carrito = new Carrito();

            Avioncito avioncito = new Avioncito();

            garage1.Add(avioncito);
            garage1.Add(carrito);

            Console.WriteLine(garage1[0] +" "+ garage1[1]); //Para verlos podemos cambiar el ToString o acceder a las propiedades que queramos
            

            //Auto-Implemented properties 

            //Enums 

            Console.WriteLine(Planets.Mercury);
            Console.WriteLine(Planets.Mercury +" Is the planet #"+ (int)Planets.Mercury);

            

            //Generics

            int[] intArray = {0,1,2,3};
            double[] doubleArray = {0,1,2,3};
            string[] stringArray = {"Pa","Pe","Pi","Po"};

            Generics.displayElements(intArray);
            Generics.displayElements(doubleArray);
            Generics.displayElements(stringArray);

            

            //Diccionarios

            Dictionary<int,string> PAPASLOCAS = new Dictionary<int,string>();
            PAPASLOCAS.Add(1,"Papoi");
            PAPASLOCAS[2] = "papitas";
            PAPASLOCAS.ContainsKey(2);
            PAPASLOCAS.Remove(1);

           


            //Hashsets

            HashSet<int> Notas = new HashSet<int> {1,2,3};
            
            Notas.Add(1);
            Notas.Remove(1);
            


             


            //LinkedLists

            LinkedList<int> ints = new LinkedList<int>();
            
            ints.AddFirst(1);
            ints.AddLast(2);
            ints.AddAfter(1,45);
            ints.AddBefore(2,80);


            


            //LINQ

            List<Game> games1 = new List<Game>();

            var games = new List<Game>
            {
              new Game {Title = "Game1", Genre = "Adventre" , Rating = 9.5, ReleaseYear = 1988},
              new Game {Title = "Game2", Genre = "FPS" , Rating = 8.0, ReleaseYear = 1987},
              new Game {Title = "Game3", Genre = "FPS" , Rating = 9.0, ReleaseYear = 1986},
              new Game {Title = "Game4", Genre = "SCIFI" , Rating = 2.0, ReleaseYear = 1985}  
            };

            var AllTitles = games.Select(game => game.Title); //Usamos el select para seleccionar solo el titulo de cada uno, nos ahorramos un foreach

            var AllGenres = games.Where(g => g.Genre == "SOLO");

            var ModernGames = games.Any( g => g.ReleaseYear >= 1987);

            var OrganizedGames = games.OrderBy(g => g.ReleaseYear);

            var AvgGames = games.Average(g => g.ReleaseYear);

            var OrgByGenre = games.GroupBy(g => g.Genre);

            var GOTY = games
            .Where(g => g.Rating >= 9)
            .OrderBy(g => g.ReleaseYear)
            .Select(g => $"{g.Title} - {g.ReleaseYear}");

            var page1 = games 
            .Skip(2)
            .Take(2)
            .Where(g => g.Rating > 1);

            //SQL sintax

            var FF = games
            .Where(g => g.Genre == "FPS")
            .OrderBy(g => g.Rating);

            var F1 = from game in games 
                     where game.Genre == "FPS"
                     orderby game.Rating
                     select game;

            foreach (var Title in AllTitles)
            {
                Console.WriteLine(Title);
            }

            foreach (var Genre in AllGenres)
            {
                Console.WriteLine(Genre.Title);
            }

            if (ModernGames)
            {
                Console.WriteLine(ModernGames);
            }
            
            foreach (var Release in OrganizedGames)
            {
                Console.WriteLine($"{Release.Title}  {Release.ReleaseYear}");
            }

            Console.WriteLine(AvgGames);

            foreach (var group in OrgByGenre)
            {
                Console.WriteLine($"Genre: {group.Key}");

                foreach (var game in group)
                {
                    Console.WriteLine(game.Title);
                }
            }

            foreach (var game in GOTY)
            {
                Console.WriteLine(game);
            }

            foreach (var game in page1)
            {
                Console.WriteLine($"{game.Title} - {game.Rating}");
            }

            foreach (var game in FF)
            {
                Console.WriteLine($"{game.Title} - {game.Rating} - {game.Genre}");
            }

            foreach (var game in F1)
            {
                Console.WriteLine($"{game.Title} - {game.Rating} - {game.Genre}");
            } 
            



            //Delegates

            Delegates.BinaryOp b = new Delegates.BinaryOp(SimpleMath.Add);     
            //Apunta a Add 

            Console.WriteLine(b(10,15));
            //ejemplo mas complejo
            
            Console.WriteLine("** Delegates as event enablers **\n");
            // First, make a Car object.
            CAR c1 = new CAR("SlugBug", 100, 10);
            // Now, tell the car which method to call
            // when it wants to send us messages.
            c1.RegisterWithCarEngine(new CAR.CarEngineHandler(OnCarEngineEvent));
            //esto se puede simplificar con method group conversion
            //usando esta tecnica podemos lograr que en vez de pasar una instancia del delegate podamos simplemente registrar con el nombre del methodo
            c1.RegisterWithCarEngine(OnCarEngineEvent);
            // Speed up (this will trigger the events).
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
            c1.Accelerate(20);
            }
            Console.ReadLine();
            // This is the target for incoming events.
            static void OnCarEngineEvent(string msg)
            {
            Console.WriteLine("\n*** Message From Car Object ***");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("********************\n");
            }

            

            
            //generic delegates 

            GenericDelegates.Mygen<string> mygen = GenericDelegates.StrTarget; 

            mygen("papa");




            //Action&Func

            //Action 

            Action<string,int> action = ActionFunc.ConsoleWarn; 

            action("Hola",10);

            //Func 

            Func<int,string> func = ActionFunc.IntAsString;
            string a = func(15);
            Console.WriteLine(a);



            

            //Events % Anonmeth 

            //Custom events

            Termometro termometro = new Termometro();

            void temp(object ?  sender, TemperaturaArgs args)
            {
                Console.WriteLine($"La temperatura es muy alta {args.Temperatura}");
            } 

            termometro.AlertaTemperatura += temp;

            termometro.CambiarTemperatura(90);

            termometro.CambiarTemperatura(100);

            //anons

            Advancedshit.Anonmethods.Anonmeth anonmeth = new Advancedshit.Anonmethods.Anonmeth();

            int contador = 0;
            
            Advancedshit.Anonmethods.Anonmeth.Chefmuerto += delegate (string msg)
            {
                contador++;
                Console.WriteLine(msg);  
            };

            Advancedshit.Anonmethods.Anonmeth.Chefmuerto += static delegate (string msg)
            {
                //contador++;
                Console.WriteLine(msg);  
            };

            anonmeth.Chefcocinando(40);

            //Multithreading 2

            AutoResetEvent _waitHandle = new AutoResetEvent(false);
            
            void Add(object data)
            {
                if (data is AddParams ap)
                {
                    Console.WriteLine("ID of thread in Add(): {0}",
                    Environment.CurrentManagedThreadId);
                    Console.WriteLine("{0} + {1} is {2}",
                    ap.a, ap.b, ap.a + ap.b);
                    _waitHandle.Set();
                }
            }

            Console.WriteLine("***** Adding with Thread objects *****");
            Console.WriteLine("ID of thread in Main(): {0}",
            Environment.CurrentManagedThreadId);
            AddParams ap = new AddParams(10, 10);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);
            // Wait here until you are notified!
            _waitHandle.WaitOne();
            Console.WriteLine("Other thread is done!");
            Console.ReadLine();

            //TPL 
            //Parallel class 

            string[] strings = {"1","2","3"};

            void Printer(string array)
            {
                Console.WriteLine(array);
            }

            Action<string> action = Printer; 

            void Printer2(int i)
            {
                Console.WriteLine(strings[i]);
            }

            Action<int> action1 = Printer2;

            Parallel.ForEach(strings, action);
            Parallel.For(0,strings.Length, action1);

            Parallel.For(0, strings.Length, i => Console.WriteLine(strings[i]));
            Parallel.ForEach(strings, i => Console.WriteLine(i));

            //Task
            //No interrumpe el main thread
            Task.Run(()=>
            {   
                for(int i = 0; i > 5; ++i)
                {
                    Console.WriteLine("mamachimbo");    
                }  
            });
            for(int i = 0; i > 10;i++)
            {
                Console.WriteLine("Jeffer");
            }

            Task task = new Task(() =>
            {
                Console.WriteLine("Tomas");
            });

            for(int i = 0; i > 2; i++)
            {
                task.Start();
            }

            Task.Factory.StartNew(
                () => Console.WriteLine("tomas es gay"), // ¿Qué ejecutar?
                CancellationToken.None,        // ¿Cancelable?
                TaskCreationOptions.LongRunning, // ¿Cuánto dura?
                TaskScheduler.Default          // ¿Dónde ejecutar?
            );

            //Parallel invoke

            void Suma(int a,int b)
            {
                Console.WriteLine(a+b);
            }
            void Hola()
            {
                Console.WriteLine("hola");
            }
            Action<int,int> action2 = Suma;
            Action actioner = Hola;
            Parallel.Invoke( 
                () => Console.WriteLine("Metodo1"),
                () => Console.WriteLine("Metodo2"),
                () => action2(1,2),
                actioner
            );

            Action[] actions =
            {
                () => Console.WriteLine("Metodo array"),
                () => Console.WriteLine("Metodo array 2"),
                actioner,
            };
            Parallel.Invoke(actions);

            // -------------------------------------------------------
            // CANCELLATION TOKEN - Caso 1: Verificacion manual
            // -------------------------------------------------------
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Task tareaLarga = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    // Verificamos en cada iteracion si fue cancelada
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("¡Tarea cancelada! (Verificacion manual)");
                        return;
                    }
                    Console.WriteLine($"Trabajando... paso {i}");
                    Thread.Sleep(500);
                }
            }, token);

            Thread.Sleep(1000);
            cts.Cancel();

            // -------------------------------------------------------
            // CANCELLATION TOKEN - Caso 2: ThrowIfCancellationRequested
            // Lanza excepcion automaticamente al cancelar
            // -------------------------------------------------------
            CancellationTokenSource cts2 = new CancellationTokenSource();

            Task tareaExcepcion = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    // Lanza OperationCanceledException automaticamente
                    cts2.Token.ThrowIfCancellationRequested();
                    Console.WriteLine($"Caso 2 - paso {i}");
                    Thread.Sleep(500);
                }
            }, cts2.Token);

            Thread.Sleep(1000);
            cts2.Cancel();

            // Capturamos la excepcion de cancelacion
            try
            {
                tareaExcepcion.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.InnerExceptions)
                    Console.WriteLine($"Excepcion capturada: {e.Message}");
            }

            // -------------------------------------------------------
            // CANCELLATION TOKEN - Caso 3: Timeout automatico
            // Se cancela solo despues de X milisegundos
            // -------------------------------------------------------
            CancellationTokenSource cts3 = new CancellationTokenSource(1500); // cancela en 1.5 segundos

            Task tareaTiempo = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (cts3.Token.IsCancellationRequested)
                    {
                        Console.WriteLine("Caso 3 - Cancelado por timeout!");
                        return;
                    }
                    Console.WriteLine($"Caso 3 - paso {i}");
                    Thread.Sleep(500);
                }
            }, cts3.Token);

            tareaTiempo.Wait();

            //Plinq 

            List<int> ints = new List<int> {1,2,3,4,5,6,7,8,9,5,4,8,7,5,0,1,0,10};

            CancellationTokenSource tokener = new CancellationTokenSource();
            CancellationToken token1 = tokener.Token;

            var pares = from i in ints
                        .AsParallel()
                        .WithCancellation(token1)
                        where i/2 == 0
                        select i;

            Thread.Sleep(2);
            tokener.Cancel();

            foreach (var item in pares)
            {
                Console.WriteLine(item);
            }
            
            //Async/Await

            async Task task(string name)
            {
                 await Task.Run(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Hola"+name);
                    }
                });
            }

            await task("pepe");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hola");
            }

            */

            //File I/O y serializacion de objetos
            
            DirectoryInfo info = new DirectoryInfo(@"C:\File IO & serialization");
            //Uso en otras plataformas no windows
            DirectoryInfo dir3 = new DirectoryInfo($@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}File IO & serialization");

            info.Create(); //crear directorios

            Directory.CreateDirectory(@"C:\File IO & serialization");

            FileInfo info1 = new FileInfo($@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}File IO & serialization{Path.DirectorySeparatorChar}Archivo1");

            info1.Create();
            info1.CreateText();
            info1.Open(FileMode.Open);

            //ADO.NET

            
        }
    }
}
