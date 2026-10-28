namespace MathGame;

public class Game
{
    private const int cantidadPreguntas = 5;
    private readonly QuestionGenerator genPregunta = new QuestionGenerator();
    private Question pregunta;
    private int userResponse;

    public void Jugar(Operation operation)
    {
        int puntaje = 0;

        for (int i = 0; i < cantidadPreguntas; i++)
        { 
            Console.Clear();
            {
                switch (operation)
                {
                    case Operation.Suma:
                    {
                        pregunta = genPregunta.GenerateQuestion(Operation.Suma);
                            
                        Console.Write($"{pregunta.Left} + {pregunta.Right} = ");
                        
                        userResponse = int.TryParse(Console.ReadLine(), out userResponse) ? userResponse : 0;

                        if (userResponse == pregunta.Answer)
                        {
                            Console.Clear();
                            Console.WriteLine($"Pregunta correcta. Bien hecho!");
                            puntaje++;
                        } 
                        else
                        {
                            Console.WriteLine("Respuesta incorrecta");
                            Thread.Sleep(300);
                        } 
                        
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine($"Puntaje: {puntaje}");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.ReadKey();
                        break;
                    }
                    case Operation.Resta:  break;
                    
                    case Operation.Multiplicacion: break;
                    
                    case Operation.Division: break;
                    
                    default: throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
                }
            }
        }
    }
}
