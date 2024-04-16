using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceP;
using clIMath;
using clArray;
using cISort;

namespace les7_16_04_24
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Завдання 1
			//Створіть інтерфейс IOutput.У ньому мають бути два методи:
			//■ void Show() — відображає інформацію;
			//■ void Show(string info) — відображає інформацію та інформаційне повідомлення,
			//зазначене у параметрі info.
			//Створіть клас Array(масив цілого типу) із необхідними методами.
			//Цей клас має імплементувати інтерфейс IOutput.
			//Метод Show() — відображає на екран елементи масиву.
			//Метод Show(string info) — відображає на екрані елементи масиву та
			//інформаційне повідомлення, зазначене у параметрі info.
			//Напишіть код для тестування отриманої функціональності.

			IOutput[] arrays = new IOutput[] {
				new clArray.ClassArray(1, 2, 3, 4, 5, 6)				
			};
            
            foreach (var array in arrays)
			{
                array.Show();
				Console.WriteLine();
				array.Show("This is additional information.");				
			}


			//Завдання 2
			//Створіть інтерфейс IMath.У ньому мають бути чотири методи:
			//■ int Max() — повертає максимум;
			//■ int Min() — повертає мінімум;
			//■ float Avg() — повертає середньоарифметичне;
			//■ bool Search(int valueToSearch) — шукає valueSearch
			//всередині контейнера даних.Повертає true, якщо значення знайдено.
			//Повертає false, якщо значення не знайдено. Клас, створений у першому завданні Array,
			//має імплементувати інтерфейс IMath.
			//Метод Max — повертає максимум серед елементів масиву.
			//Метод Min — повертає мінімум серед елементів масиву.
			//Метод Avg — повертає середньоарифметичне серед елементів масиву.
			//Метод Search — шукає значення всередині масиву. Повертає true, якщо значення знайдено.
			//Повертає false, якщо значення не знайдено. Напишіть код для тестування
			//отриманої функціональності

			Console.WriteLine();
			IMath mathArr = new ClassArray(3, 7, 1, 9, 4); 

			int maxNumber = ((ClassArray)mathArr).Max();
			int minNumber = ((ClassArray)mathArr).Min();
			float avgNumber = ((ClassArray)mathArr).Avg();
			int num = 1;

			((IOutput)mathArr).Show();

			Console.WriteLine($"\nMaximum number in the array: {maxNumber}");
			Console.WriteLine($"\nMinimum number in the array: {minNumber}");
			Console.WriteLine($"\nAverage in the array: {avgNumber}");           
            Console.WriteLine($"\nNumber {num} find in array: {mathArr.Search(num)} \n");

			//Завдання 3
			//Створіть інтерфейс ISort.У ньому мають бути три методи:
			//■ void SortAsc() — сортування за зростанням;
			//■ void SortDesc() — сортування за зменшенням;
			//■ void SortByParam(bool isAsc) — сортування залежно від переданого параметра.

			//Якщо isAsc дорівнює true, сортуємо за зростанням.
			//Якщо isAsc дорівнює false, сортуємо за зменшенням.
			//Клас, створений у першому завданні Array, має імплементувати інтерфейс ISort.
			//Метод SortAsc — сортує масив за зростанням.
			//Метод SortDesc — сортує масив за спаданням.
			//Спосіб SortByParam — сортує масив залежно від переданого параметра.
			//Якщо isAsc дорівнює true, сортуємо за зростанням.Якщо isAsc дорівнює false, сортуємо за зменшенням.

			Console.WriteLine();
			ISort sortArr = new ClassArray(5, 3, 1, 8, 10, 2, 11);
			bool isAsc = false;

			sortArr.SortAsc();
			sortArr.SortDesc();
			sortArr.SortByParam(isAsc);

		}
	}
}
