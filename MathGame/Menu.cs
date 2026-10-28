namespace MathGame;

public class Menu
{
    private Game Juego = new Game();
    
    public void MenuOperaciones()
    {
        bool menuActivo = true;
        do
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Volver al menu principal");
            Console.WriteLine("********************************\n");
            
            Console.Write("> ");
            int opt = int.TryParse(Console.ReadLine(), out opt) ? opt : -1;

            switch (opt)
            {
                case 1:
                {
                    Juego.Jugar(Operation.Suma);
                    break;
                }
                
                case 2: break;
                
                case 3: break;
                
                case 4: break;
                
                case 5: 
                    Console.WriteLine("Volviendo al menu principal....");
                    Thread.Sleep(500);
                    menuActivo = false;
                    break;
                
                default: 
                    Console.WriteLine("Opcion no valida. Presione una tecla para continuar.");
                    Console.ReadKey();
                    Thread.Sleep(150);
                    break;
            };
        } while (menuActivo);
            
    }
    public void MostrarMenu()
    {
        bool juegoActivo = true;
        
            do
            {
                Console.Clear();
                Console.WriteLine($"Hola! Hoy es {DateTime.Now}");
                Console.WriteLine("********************************");
                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Ver historial de partidas (local)");
                Console.WriteLine("3. Salir");
                Console.WriteLine("********************************\n");
                Console.Write("> ");
                int opt = int.TryParse(Console.ReadLine(), out  opt) ? opt : -1;
                
                    switch (opt)
                    {
                        case 1: 
                            MenuOperaciones();
                            break;
                    
                        case 2: break; 
                        
                        case 3:
                            Console.WriteLine("Saliendo...");
                            Thread.Sleep(350);
                            juegoActivo = false;
                            Console.Clear();
                            break;
                            
                        default: 
                            Console.WriteLine("Opcion no valida. Presione una tecla para continuar");
                            Console.ReadKey();
                            break;
                    }
            }
            while (juegoActivo);
    }
}