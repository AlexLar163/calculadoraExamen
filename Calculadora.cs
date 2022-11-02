using System;

﻿public class Class1
{
	private double num1;
	private double num2;

	public Calculadora()
	{
	}
	  public double Num1 { get => num1; set => num1 = value; }
    public double Num2 { get => num2; set => num2 = value; }

	public int multiplicacion()
	{
		return num1 * num2;
   }

    public int Resta()
	{
		return num1 - num2;
	}
}
