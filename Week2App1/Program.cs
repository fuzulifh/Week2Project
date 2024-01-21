namespace Week2App1
{

    internal class Program
    {
        static void Main(string[] args)
        {

            float firstNumber;
            float secondNumber;

            Console.WriteLine("Please enter first Number");
            firstNumber = float.Parse(Console.ReadLine());


            Console.WriteLine("Please enter second Number");
            secondNumber = float.Parse(Console.ReadLine());

            float resultSum = firstNumber + secondNumber;
            Console.WriteLine("Sum Result:"+resultSum);
            
            float resultMinus=firstNumber - secondNumber;   
            Console.WriteLine("Minus Result:"+resultMinus);
            
            float resultMultiple=firstNumber * secondNumber;
            Console.WriteLine("Multiple Result:" +resultMultiple);
            
            float resultDivide=firstNumber / secondNumber;
            Console.WriteLine("Divide Result:" +resultDivide);

            float resultAvarage=firstNumber + secondNumber/2;
            Console.WriteLine("Avarage Result:" + resultAvarage);

            float resultSquare = (firstNumber + secondNumber)* (firstNumber + secondNumber) ;
            Console.WriteLine("Square Result:" + resultSquare);


        }
    }
}