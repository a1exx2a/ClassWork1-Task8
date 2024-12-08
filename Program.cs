namespace Task8;

class Program
{
    static void Main(string[] args)
    {
        int[] x = {10,2,3,4,5};

        int y1 = x[0];
        foreach (int i in x) {
            if (i > y1) {
                y1 = i;
            }
        
        }

        int y2 = x[0];
        foreach (int i in x){
            if (i < y2){
                y2 = i;
            }
        }


        Console.WriteLine($"Максимальное значение в массиве --> {y1}");
        Console.WriteLine($"Минимальное значение в массиве --> {y2}");
    }
}
