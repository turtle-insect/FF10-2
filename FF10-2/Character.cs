using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF10_2
{
	class Character
	{
		private readonly uint mAddress;

		public Character(uint address)
		{
			mAddress = address;
		}

		public uint Lv
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 33, 1); }
			set { Util.WriteNumber(mAddress + 33, 1, value, 1, 99); }
		}

		public uint Exp
		{
			get { return SaveData.Instance().ReadNumber(mAddress, 4); }
			set { Util.WriteNumber(mAddress, 4, value, 0, 9999999); }
		}

		public uint HP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 8, 4); }
			set
			{
				Util.WriteNumber(mAddress + 8, 4, value, 0, 9999);
				Util.WriteNumber(mAddress + 16, 4, value, 0, 9999);
			}
		}

		public uint MP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 12, 4); }
			set
			{
				Util.WriteNumber(mAddress + 12, 4, value, 0, 999);
				Util.WriteNumber(mAddress + 20, 4, value, 0, 999);
			}
		}

		public uint Attack
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 25, 1); }
			set { Util.WriteNumber(mAddress + 25, 1, value, 0, 255); }
		}

		public uint Deffense
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 26, 1); }
			set { Util.WriteNumber(mAddress + 26, 1, value, 0, 255); }
		}

		public uint Magic
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 27, 1); }
			set { Util.WriteNumber(mAddress + 27, 1, value, 0, 255); }
		}

		public uint MagicGuard
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 28, 1); }
			set { Util.WriteNumber(mAddress + 28, 1, value, 0, 255); }
		}

		public uint Speed
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 29, 1); }
			set { Util.WriteNumber(mAddress + 29, 1, value, 0, 255); }
		}

		public uint Hit
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 30, 1); }
			set { Util.WriteNumber(mAddress + 30, 1, value, 0, 255); }
		}

		public uint Avoidance
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 31, 1); }
			set { Util.WriteNumber(mAddress + 31, 1, value, 0, 255); }
		}

		public uint Luck
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 32, 1); }
			set { Util.WriteNumber(mAddress + 32, 1, value, 0, 255); }
		}
	}
}
