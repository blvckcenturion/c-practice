using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Ingresa el numero de estudiantes a evaluar");
		int n = int.Parse(Console.ReadLine());
		int[] grades = new int[n];
		int biggest = 0;
		int smallest = 0;
		double average = 0;
		for (int i = 0; i <n;i++){
			Console.WriteLine("Ingresa la nota del estudiante " + (i+1));
			grades[i] = int.Parse(Console.ReadLine());
			if (i == 0) smallest = grades[i];
			if(grades[i] > biggest) biggest = grades[i];
			if(grades[i] < smallest) smallest = grades[i];
			average += grades[i];
		}
		average = average/n;
		Console.WriteLine(average);
		Console.WriteLine(biggest);
		Console.Write(smallest);
	}
}
