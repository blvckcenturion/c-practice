using System;
					
public class Program
{
	public static void Main()
	{
		string[] names = new string[4];
		double[] firstMonth = new double[4];
		double[] secondMonth = new double[4];
		double[] thirdMonth = new double[4];
		double[] accumulatedSalaries = new double[4];
		int biggestAccumulatedSalary = 0;
		for(int i = 0; i < 4; i++){
			Console.WriteLine("======================================");
			Console.WriteLine("Ingresa el nombre del empleado #" + i);
			names[i] = Console.ReadLine();
			for(int j = 0;j<3; j++){
				Console.WriteLine("Ingresa el salario del mes #" + (j+1) + " para el empleado #"+i);
				double currentSalary = double.Parse(Console.ReadLine());
				switch(j){
					case 0:
						firstMonth[i] = currentSalary;
						break;
					case 1: 
						secondMonth[i] = currentSalary;
						break;
					default: 
						thirdMonth[i] = currentSalary;
						break;
				}
				accumulatedSalaries[i] += currentSalary;
			}
			if (accumulatedSalaries[i] > accumulatedSalaries[biggestAccumulatedSalary]) biggestAccumulatedSalary = i;
			Console.WriteLine(names[i]);
			Console.WriteLine(accumulatedSalaries[i]);
		}
		for(int i = 0; i < 4; i++){
			Console.WriteLine("======================================");
			Console.WriteLine("Empleado : " + i );
			Console.WriteLine("Nombre : " + names[i]);
			Console.WriteLine("Sueldo 1 : " + firstMonth[i]);
			Console.WriteLine("Sueldo 2 : " + secondMonth[i]);
			Console.WriteLine("Sueldo 3 : " + thirdMonth[i]);
			Console.WriteLine("Sueldo Acumulado : " + accumulatedSalaries[i]);
		}
		Console.WriteLine("======================================");
		Console.WriteLine("El empleado con el sueldo acumulado mas alto es: " + names[biggestAccumulatedSalary] + ", con un sueldo acumulado de : " + accumulatedSalaries[biggestAccumulatedSalary]);
	}
}
