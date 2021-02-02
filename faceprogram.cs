using System;
					
public class Program
{
	public static void Main()
	{
		//======================================================================
		// drawing a :-)
		//======================================================================
		
		Console.WriteLine(@"////////////////
|  ()      ()  |
|       V      |
|    --------  |
|______________|
");
		//======================================================================
		// Converting and parsing input
		//======================================================================
		
		Console.WriteLine(@"Welcome to Kilometer Converter 1000!
=============================================================
Please Enter the Kilometers you would like converted");
		string km = Console.ReadLine();
		
		Console.WriteLine("{0}km is {1}mi"+Environment.NewLine,double.Parse(km),double.Parse(km)/1.609);
		
		Console.WriteLine(@"Now its time for the Centimeter Converter 1000!
=============================================================
Please Enter the Centimeters you would like converted");
		string cm = Console.ReadLine();
		
		Console.WriteLine("{0}cm is {1}in"+Environment.NewLine,double.Parse(cm),double.Parse(cm)/2.54);
		
		//======================================================================
		// Sorting numbers
		//======================================================================
		
		int[] numbers = {0, 0, 0, 0, 0};
		
		for(int i=0;i<5;i++){
			Console.WriteLine("Please enter a value for the {0} element of the array",i+1);
			numbers[i] = int.Parse(Console.ReadLine());
		}
		
		pop_the_bubble_sort(numbers); // this function could be made better e.g. it returns a new array: int[] sorted_numbers = pop_the_bubble_sort(numbers)
		
		Console.WriteLine("Your numbers are:");
		
		foreach(var n in numbers){
			Console.Write("{0}, ",n);
		}
		
		Console.WriteLine("The greatest number is: {0}",numbers[numbers.Length-1]);
		
		//======================================================================
		// Divisible by 5 and 7
		//======================================================================
		
		Console.WriteLine("Please enter a number to be tested:");
		double test = double.Parse(Console.ReadLine());
		
		if(is_7_5(test)){
			Console.WriteLine("{0} is divisible by 7 and 5",test);
		}
		else{
			Console.WriteLine("{0} is NOT divisible by 7 and 5",test);
		}
		
		//======================================================================
		// Is the number prime
		//======================================================================
		
		Console.WriteLine("Please enter a number to be checked for primality");
		double ch = double.Parse(Console.ReadLine());
		
		Console.WriteLine("{0} {1} a prime!", ch, is_prime(ch) ? "is" : "isn't"); //found this useful format string thing
		
		//======================================================================
		// The End
		//======================================================================
		
		Console.WriteLine("======================================================");
		Console.WriteLine("Thank you for running the program! I hope you have a good day.");
	}
	
	public static bool is_prime(double prm){ //this becomes less efficient for higher numbers
		int divisors=0;
		for(var i=prm;i>0;i--){
			if(whole(prm/i)){
				divisors+=1;
			}
		}
		Console.WriteLine(divisors);
		if(divisors>2){return false;}
		return true;
	}
	
	public static bool whole(double n){
		return n % 1 == 0;
	}
	
	public static bool is_7_5(double test){
		if(test % 5 != 0){ //modulo is epic 😎
			if(test % 7 != 0){
				return false;
			}
			else {
				return false;
			}
		}
		else {
			if(test % 7 != 0){
				return false;
			}
			else {
				return true;
			}
		}
	}
	
	public static void pop_the_bubble_sort(int[] input) //goes through all adjacent pairs of numbers and tests which one is greater and puts it closer to the end of the array until the numbers are all sorted
	{
		var moved = false;
		do
		{
			moved = false;
			for (int i = 0; i < input.Length - 1; i++)
			{
				if (input[i] > input[i + 1])
				{
					var low = input[i + 1];
					input[i + 1] = input[i];
					input[i] = low;
					moved = true;
				}
			}
		} while (moved);
	}
}
