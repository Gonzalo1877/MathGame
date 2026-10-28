namespace MathGame;

public class Game
{
    private const int cantidadPreguntas = 5;
    private readonly QuestionGenerator genPregunta = new QuestionGenerator();


    public void Jugar(Operation operation)
    {
        int puntaje = 0;
        
        for (int i = 0; i < cantidadPreguntas; i++)
        { 
            Question pregunta;
            int userResponse;
            
            Console.Clear();
            {
                switch (operation)
                {
                    case Operation.Suma:
                    {
                        pregunta = genPregunta.GenerateQuestion(Operation.Suma);
                            
                        Console.Write($"{pregunta.Left} + {pregunta.Right} = ");
                        

                        if ((int.TryParse(Console.ReadLine(), out userResponse) && userResponse == pregunta.Answer))
                        {
                            Console.Clear();
                            Console.WriteLine($"Pregunta correcta. Bien hecho!");
                            puntaje++;
                        } 
                        else
                        {
                            Console.WriteLine($"Respuesta incorrecta, la correcta era {pregunta.Answer}");
                            Thread.Sleep(500);
                        } 
                        
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine($"Puntaje: {puntaje}");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.ReadKey();
                        break;
                    }
                    
                    case Operation.Resta:
                    {
                        pregunta = genPregunta.GenerateQuestion(Operation.Resta);
                            
                        Console.Write($"{pregunta.Left} - {pregunta.Right} = ");
                        
                        if ((int.TryParse(Console.ReadLine(), out userResponse) && userResponse == pregunta.Answer))
                        {
                            Console.Clear();
                            Console.WriteLine($"Pregunta correcta. Bien hecho!");
                            puntaje++;
                        } 
                        else
                        {
                            Console.WriteLine($"Respuesta incorrecta, la correcta era {pregunta.Answer}");
                            Thread.Sleep(500);
                        } 
                        
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine($"Puntaje: {puntaje}");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.ReadKey();
                        break;
                    }
                    
                    case Operation.Multiplicacion:
                    {
                        pregunta = genPregunta.GenerateQuestion(Operation.Multiplicacion);
                            
                        Console.Write($"{pregunta.Left} * {pregunta.Right} = ");
                        
                        if ((int.TryParse(Console.ReadLine(), out userResponse) && userResponse == pregunta.Answer))
                        {
                            Console.Clear();
                            Console.WriteLine($"Pregunta correcta. Bien hecho!");
                            puntaje++;
                        } 
                        else
                        {
                            Console.WriteLine($"Respuesta incorrecta, la correcta era {pregunta.Answer}");
                            Thread.Sleep(500);
                        } 
                        
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine($"Puntaje: {puntaje}");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.ReadKey();
                        break;
                    }
                    
                    case Operation.Division:
                    {
                        pregunta = genPregunta.GenerateQuestion(Operation.Division);
                            
                        Console.Write($"{pregunta.Left} / {pregunta.Right} = ");
                        
                        if ((int.TryParse(Console.ReadLine(), out userResponse) && userResponse == pregunta.Answer))
                        {
                            Console.Clear();
                            Console.WriteLine($"Pregunta correcta. Bien hecho!");
                            puntaje++;
                        } 
                        else
                        {
                            Console.WriteLine($"Respuesta incorrecta, la correcta era {pregunta.Answer}");
                            Thread.Sleep(500);
                        } 
                        
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine($"Puntaje: {puntaje}");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.ReadKey();
                        break;
                    }
                    
                    default: throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
                }
            }
        }
    }
}
