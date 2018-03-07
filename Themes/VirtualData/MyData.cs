using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualData
{
	//Address, Person are class and not struct, otherwise values cannot be changed by reflection
	//https://stackoverflow.com/questions/3443274/cannot-get-propertyinfo-setvalue-to-set-the-value-on-my-object


	public class Address
	{
		public string Street { get; set; }
		public int Number { get; set; }
	}

	public class Person
	{
		public string Name { get; set; }
		public Address Address { get; set; }
		public DateTime BirthDate { get; set; }
		public int Children { get; set; }
		public bool Extravert { get; set; }
		public double Height { get; set; }
		public Car Car { get; set; }
	}

	public class Vehicle
	{
		public EnergySource Motor { get; set; }

	}

	public enum EnergySource
	{
		Petrol,
		Diesel,
		Hybrid,
		Electric,
		Manual
	}

	public enum Manufacturer
	{
		Ford,
		Volvo,
		Volkswagen,
		BMW,
		Chevrolet,
		Tata
	}



	public class Car : Vehicle
	{
		public Manufacturer Manufacturer { get; set; }
		public int kW { get; set; }
		public bool AllWheelDrive { get; set; }

	}

	public static class MyData
	{
		public static void FillMyData(List<Person> data, int count)
		{
			data.Clear();
			for (int t = 0; t < count; t++)
			{
				data.Add(RandomPerson);
			}
		}

		public static void FillMyData(List<Car> data, int count)
		{
			for (int t = 0; t < count; t++)
			{
				data.Add(RandomCar);
			}
		}

		public static void FillMyData(Car[] data, int count)
		{
			for (int t = 0; t < count; t++)
			{
				data[t] = RandomCar;
			}
		}

		private static Random _random = new Random();

		private static int Random(int count)
		{
			return _random.Next(count);
		}

		private static string RandomName
		{
			get
			{
				switch (Random(6))
				{
					case 0: return "Anna";
					case 1: return "Mike";
					case 2: return "Paula";
					case 3: return "Linda";
					case 4: return "Peter";
					default: return "Bob";
				}
			}
		}

		private static string RandomAddress
		{
			get
			{
				switch (Random(6))
				{
					case 0: return "Lamps Ave";
					case 1: return "Caps St";
					case 2: return "Plain Rd";
					case 3: return "56th St";
					case 4: return "Sand Rock St" + Environment.NewLine + "Santa Cristina by the Sea";
					default: return "Moon Ave";
				}
			}
		}


		private static DateTime RandomDate
		{
			get { return new DateTime(1980 + Random(20), 1 + Random(12), 1 + Random(28)); }
		}

		private static Person RandomPerson
		{
			get
			{
				Address address = new Address
				{
					Street = RandomAddress,
					Number = 1 + Random(1000)
				};
				Person person = new Person
				{
					Name = RandomName,
					Address = address,
					BirthDate = RandomDate,
					Children = Random(5),
					Extravert = Random(10) < 5,
					Height = Math.Round((1.5 + (Random(450) * 0.001)), 2),
					Car = RandomCar
				};
				return person;
			}
		}

		private static Car RandomCar
		{
			get
			{
				Car car = new Car
				{
					Manufacturer = (Manufacturer)Random(6),
					kW = 50 + Random(150),
					Motor = (EnergySource)Random(4),
					AllWheelDrive = Random(10) < 5
				};
				return car;
			}
		}
	}
}
