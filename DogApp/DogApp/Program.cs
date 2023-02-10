using System;
using System.Collections.Generic;
using System.Globalization;

namespace DogApp
{
	public class ClockDate
    {
		public int year;
		public int month;
		public int day;
		public int hour;
		public int minute;
		public int second;
		public DayOfWeek dayOfWeek;
		public DateTimeKind kind;

		public ClockDate(int year, int month, int day, int hour, int minute, int second, DayOfWeek dayOfWeek, DateTimeKind kind)
        {
			this.year = year;
			this.month = month;
			this.day = day;
			this.hour = hour;
			this.minute = minute;
			this.second = second;
			this.dayOfWeek = dayOfWeek;
			this.kind = kind;

        }

   //     public override string ToString()
   //     {
			//return $"Month: {month}, Day: {day}, Year: {year}, {hour}:{minute}:{second} {dayOfWeek} {kind}";
   //     }
    }
	class Program
	{
		
		static void Main(string[] args)
		{
			DateTime clock = new DateTime(2021, 8, 20, 17, 00, 00, (int)DayOfWeek.Friday, DateTimeKind.Local);
            Console.WriteLine("{0} {1} {2}", clock, clock.DayOfWeek, clock.Kind);
		}
	}
}
