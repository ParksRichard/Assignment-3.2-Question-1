namespace Assignment_3._2_Question_1
{
    //Create a 2D array to store integers and print them in matrix format
    //with proper formatting

    internal class Program
    {
        static void Main()
        {
            //input
            //ask for numbers? Go by example for now
            int[,] matrixthing =
               { { 2, 3, 4 },
                { 1, 4, 6 } };
            //store integers/variables

            //define array                     
            //how many numbers/variables/columns and stuff
            int rows = matrixthing.GetLength(0);
            int columns = matrixthing.GetLength(1);

            //print array using proper format
            Console.WriteLine("Check out this sample matrices.");
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                
                for (int j = 0; j < columns; j++)
                {
                    
                    Console.Write($"{matrixthing[i, j],3}");
                    //Console.Write(" |"); how to make neater?
                }
                Console.WriteLine();
                //had to look this one up becuase the lines wouldn't format properly with limited the rows to set numbers and going to next line
            }
            
        }
    }
}
