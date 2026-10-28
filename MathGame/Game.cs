namespace MathGame;

public class Game
{
    private const int CantidadPreguntas = 5;
    private readonly QuestionGenerator _genPregunta = new QuestionGenerator();
    private readonly List<GamePlayed> _history = new List<GamePlayed>(); 
    public IReadOnlyList<GamePlayed> History => _history;    

    public void Jugar(Operation operation)
    {
        int puntaje = 0;
        for (int i = 0; i < CantidadPreguntas; i++)
        { 
            Question pregunta;
            int userResponse;
            
            Console.Clear();
            {
                switch (operation)
                {
                    case Operation.Suma:
                    {
                        pregunta = _genPregunta.GenerateQuestion(Operation.Suma);
                            
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
                        pregunta = _genPregunta.GenerateQuestion(Operation.Resta);
                            
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
                        pregunta = _genPregunta.GenerateQuestion(Operation.Multiplicacion);
                            
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
                        pregunta = _genPregunta.GenerateQuestion(Operation.Division);
                            
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
        
        GamePlayed juego = new GamePlayed(DateTime.Now, operation, puntaje);
        _history.Add(juego);
    }
}
