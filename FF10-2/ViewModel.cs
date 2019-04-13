using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace FF10_2
{
	class ViewModel
	{
		public ObservableCollection<Character> Party { get; set; } = new ObservableCollection<Character>();
		public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();
		public ObservableCollection<Item> Accessoris { get; set; } = new ObservableCollection<Item>();

		public ViewModel()
		{
			for (uint i = 0; i < 3; i++)
			{
				Party.Add(new Character(0x820C + i * 0x80));
			}

			for (uint i = 0; i < 68; i++)
			{
				Items.Add(new Item(0x7988 + i * 2, 0x7B88 + i));
			}

			for (uint i = 0; i < 128; i++)
			{
				Accessoris.Add(new Item(0x7CC8 + i * 2, 0x7DC8 + i));
			}
		}

		public uint GIL
		{
			get { return SaveData.Instance().ReadNumber(0x7820, 4); }
			set { Util.WriteNumber(0x7820, 4, value, 0, 9999999); }
		}
	}
}
