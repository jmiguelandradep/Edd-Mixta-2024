public class Program{
    public static void Main(string[] args)
    {
        int[] array={64,34,25,12,22,11,90,1,3,27,5};
        Console.WriteLine("Elementos Desordenados");
        mostrar(array);
        Console.WriteLine("Ordenando elementos...");
        BubleSort(array);
        Console.WriteLine("Elementos Ordenados");
        mostrar(array);
    }
    public static void mostrar(int[] array){
        foreach(int i in array){
            Console.Write(i + " | ");
        }
        Console.WriteLine();
    }
    public static void BubleSort(int[] array){
        int n= array.Length;
        //recorrer todos los elementos del array
        for(int i=0; i<n; i++)
        {
            for(int j=0;j<(n-i-1);j++)
            {
                if(array[j]>array[j+1])
                {
                    int tmp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = tmp;
                }
            }//for de j
        }//for  de i
    }

}//clase