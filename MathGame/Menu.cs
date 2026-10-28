namespace MathGame;

public class Menu
{
    public void MostrarMenu()
    {
        bool juegoActivo = true;
        
            do
            {
                Console.Clear();
                Console.WriteLine($"Hola! Hoy es {DateTime.Now}");
                Console.WriteLine("****************");
                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Ver historial de partidas (local)");
                Console.WriteLine("3. Salir");
                Console.WriteLine("****************\n");
                
                int opt = int.TryParse(Console.ReadLine(), out  opt) ? opt : -1;
                
                    switch (opt)
                    {
                        case 1: break;
                    
                        case 2: break; 
                        
                        default: 
                            Console.WriteLine("Opcion no valida. Limpiando Pantalla");
                            break;
                    }
            }
            while (juegoActivo);
    }
}