using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeGrid.Columns;
using Steema.TeeGrid.Data.Reflection;
using Steema.TeeGrid.Header;
using Steema.TeeGrid.Renders;

namespace TeeGrid_Custom_Sorting
{
	public partial class Form1 : Form
	{
		List<Location> Locations = new List<Location>();

		public Form1()
		{
			InitializeComponent();

			AddRandomData();

			LastSorted.Ascending = true;
			teeGrid1.SortableColumns = false; //set automatic sorting to false
			teeGrid1.Header.Sortable = true;
			teeGrid1.Header.SortRender = CreateSortable();
			this.BackColor = Color.White;
			Steema.TeeGrid.Themes.GridThemes.Flat.ApplyTo(teeGrid1.Grid);
			teeGrid1.Data = new VirtualListData<Location>(Locations);
		}

		private SortableHeader CreateSortable()
		{
			SortableHeader result = new SortableHeader(teeGrid1.Header.Changed);

			result.Format.Brush.Color = Color.Red;
			result.Format.Brush.Show();

			result.CanSort += CanSortBy;
			result.SortBy += SortBy;
			result.SortState += SortState;

			return result;
		}

		private LastSorted LastSorted;

		private void SortState(object sender, SortStateEventArgs e)
		{
			if (e.Column == LastSorted.Column)
			{
				if (LastSorted.Ascending)
					e.State = Steema.TeeGrid.Header.SortState.Ascending;
				else
					e.State = Steema.TeeGrid.Header.SortState.Descending;
			}
			else
				e.State = Steema.TeeGrid.Header.SortState.None;
		}

		private void SortBy(object sender, SortableColumnEventArgs e)
		{
			SortStateEventArgs args = new SortStateEventArgs() { Column = e.Column, State = Steema.TeeGrid.Header.SortState.None };
			SortState(sender, args);

			LastSorted.Ascending = args.State != Steema.TeeGrid.Header.SortState.Ascending;

			e.SortedData = SortData(args.Column, LastSorted.Ascending);

			LastSorted.Column = args.Column;
		}

		private object SortData(Column column, bool ascending)
		{
			if (column.Header.Text == "Name")
				return ascending ? Locations.OrderBy(x => x.Name).ThenBy(x => x.Country).ToList() : Locations.OrderByDescending(x => x.Name).ThenBy(x => x.Country).ToList(); 
			else
				return ascending ? Locations.OrderBy(x => x.Country).ThenBy(x => x.Name).ToList() : Locations.OrderByDescending(x => x.Country).ThenBy(x => x.Name).ToList();
		}

		private void CanSortBy(object sender, CanSortEventArgs e)
		{
			e.CanSort = (e.Column != null) && ((e.Column.Header.Text == "Name") || (e.Column.Header.Text == "Country"));
		}

		private void AddRandomData()
		{
			Locations.Add(new Location() { Name = "New York", Country = "USA" });
			Locations.Add(new Location() { Name = "Barcelona", Country = "Catalonia" });
			Locations.Add(new Location() { Name = "Tokyo", Country = "Japan" });
			Locations.Add(new Location() { Name = "Sao Paulo", Country = "Brazil" });
			Locations.Add(new Location() { Name = "Santa Cruz", Country = "USA" });
			Locations.Add(new Location() { Name = "Oslo", Country = "Norway" });
			Locations.Add(new Location() { Name = "Canberra", Country = "Australia" });
			Locations.Add(new Location() { Name = "Delhi", Country = "India" });
			Locations.Add(new Location() { Name = "Montreal", Country = "Canada" });
			Locations.Add(new Location() { Name = "Beijing", Country = "China" });
		}
	}

	public struct LastSorted
	{
		public Column Column { get; set; }
		public bool Ascending { get; set; }
	}

	public class Location
	{
		public string Name { get; set; }
		public string Country { get; set; }
	}
}
