using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
		public string City { get; set; }
		public string Country { get; set; }
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

	public class Location
	{
		public string Name { get; set; }
		public string Country { get; set; }
	}

	public class SortableBindingList<T> : BindingList<T>
	{
		private bool isSortedValue;
		ListSortDirection sortDirectionValue;
		PropertyDescriptor sortPropertyValue;

		public SortableBindingList()
		{
		}

		public SortableBindingList(IList<T> list)
		{
			foreach (object o in list)
			{
				this.Add((T)o);
			}
		}

		protected override void RemoveSortCore()
		{
			//intentionally empty
		}

		protected override void ApplySortCore(PropertyDescriptor prop,
				ListSortDirection direction)
		{
			Type interfaceType = prop.PropertyType.GetInterface("IComparable");

			if (interfaceType == null && prop.PropertyType.IsValueType)
			{
				Type underlyingType = Nullable.GetUnderlyingType(prop.PropertyType);

				if (underlyingType != null)
				{
					interfaceType = underlyingType.GetInterface("IComparable");
				}
			}

			if (interfaceType != null)
			{
				sortPropertyValue = prop;
				sortDirectionValue = direction;

				IEnumerable<T> query = base.Items;

				if (direction == ListSortDirection.Ascending)
				{
					query = query.OrderBy(i => prop.GetValue(i));
				}
				else
				{
					query = query.OrderByDescending(i => prop.GetValue(i));
				}

				int newIndex = 0;
				foreach (object item in query)
				{
					this.Items[newIndex] = (T)item;
					newIndex++;
				}

				isSortedValue = true;
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
			}
			else
			{
				throw new NotSupportedException("Cannot sort by " + prop.Name +
						". This" + prop.PropertyType.ToString() +
						" does not implement IComparable");
			}
		}

		protected override PropertyDescriptor SortPropertyCore
		{
			get { return sortPropertyValue; }
		}

		protected override ListSortDirection SortDirectionCore
		{
			get { return sortDirectionValue; }
		}

		protected override bool SupportsSortingCore
		{
			get { return true; }
		}

		protected override bool IsSortedCore
		{
			get { return isSortedValue; }
		}
	}

	public static class MyData
	{
		public static void FillMyData(IList<Person> data, int count)
		{
			data.Clear();
			for (int t = 0; t < count; t++)
			{
				data.Add(RandomPerson);
			}
		}

		public static void FillMyData(IList<Car> data, int count)
		{
			for (int t = 0; t < count; t++)
			{
				data.Add(RandomCar);
			}
		}

		public static void FillMyData(IList<Address> data, int count)
		{
			for (int t = 0; t < count; t++)
			{
				data.Add(RandomAddress);
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

		private static string RandomStreet
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

		private static List<Location> _locations;

		private static Location RandomLocation
		{
			get
			{
				if(_locations == null)
				{
					_locations = new List<Location>();
					_locations.Add(new Location() { Name = "New York", Country = "USA" });
					_locations.Add(new Location() { Name = "Barcelona", Country = "Catalonia" });
					_locations.Add(new Location() { Name = "Tokyo", Country = "Japan" });
					_locations.Add(new Location() { Name = "Sao Paulo", Country = "Brazil" });
					_locations.Add(new Location() { Name = "Santa Cruz", Country = "USA" });
					_locations.Add(new Location() { Name = "Oslo", Country = "Norway" });
				}

				return _locations[Random(6)];
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
				Person person = new Person
				{
					Name = RandomName,
					Address = RandomAddress,
					BirthDate = RandomDate,
					Children = Random(5),
					Extravert = Random(10) < 5,
					Height = Math.Round((1.5 + (Random(450) * 0.001)), 2),
					Car = RandomCar
				};
				return person;
			}
		}

		private static Address RandomAddress
		{
			get
			{
				Location location = RandomLocation;
				Address address = new Address
				{
					Street = RandomStreet,
					Number = 1 + Random(1000),
					City = location.Name,
					Country = location.Country
				};
				return address;
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
