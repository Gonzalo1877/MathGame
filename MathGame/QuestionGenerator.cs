namespace MathGame;

public class QuestionGenerator
{
    public Question GenerateQuestion(Operation operation)
    {

        switch (operation)
        {
            case Operation.Suma:
            {
                int num1 = Random.Shared.Next(1, 100);
                int num2 = Random.Shared.Next(1, 100);

                return new Question(num1, num2, operation);
            }

            case Operation.Resta:
            {
                int num1 = Random.Shared.Next(1, 100);
                int num2 = Random.Shared.Next(1, 100);

                return new Question(num1, num2, operation);
            }
            
            case Operation.Multiplicacion:
            {
                int num1 = Random.Shared.Next(1, 30);
                int num2 = Random.Shared.Next(1, 30);

                return new Question(num1,num2, operation);
            }

            case Operation.Division:
            { 
            int num1,num2;
                do
                {
                    num1 = Random.Shared.Next(0, 101);
                    num2 = Random.Shared.Next(2, 10);
                } while ((num1 % num2 != 0) || num1 == num2);
                
                return new Question(num1, num2, operation);
            }
            
            default: throw new ArgumentOutOfRangeException(nameof(operation));
        }

    }
}