﻿using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("please enter a number");
		int number =  int.Parse(Console.ReadLine());
		
		for(int i=1 ; i*3<number ; i++ ){
			String result = (i*3).ToString();
			Console.WriteLine(result);
		}
		Console.WriteLine("these are multipy of 3 lower than $number".Replace("$number" , number.ToString()));
        Console.ReadKey();
	}
}