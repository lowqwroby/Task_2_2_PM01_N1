using System;
using System.Data;

namespace Variant10
{
	class Program
	{
		static void Main()
		{
			try
			{
				int year = DateTime.Now.Year;
				int month = DateTime.Now.Month;
				int day = DateTime.Now.Day;

				Console.Write("Введите количество дней: "); int n = Convert.ToInt32(Console.ReadLine());

				int[] months = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

				if(year % 4 == 0)
				{
					months[1] = 29;
				}

				while(n > 0)
				{
					day--;
					if (day <= 0)
					{
						month--;
						if (month <= 0)
						{
							year--;
							if (year % 4 == 0)
							{
								months[1] = 29;
							}
							else
							{
								months[1] = 28;
							}
							month = 12;
						}
						day = months[month - 1];
					}
					n--;
				}

				Console.WriteLine("Итоговая дата: " + day + "." + month + "." + year);
			}
			catch
			{
				Console.WriteLine("Некорректный ввод данных");
			}
		}
	}
}