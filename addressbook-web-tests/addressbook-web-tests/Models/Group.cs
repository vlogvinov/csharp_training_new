using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
	public class Group : IEquatable<Group>
	{
		private string name;
		private string header;
		private string footer;

		public Group(string name)
		{
			this.name = name;
		}

		public Group(string name, string header, string footer)
		{
			this.name = name;
			this.header = header;
			this.footer = footer;
		}

		public string Name
		{ 
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

		public string Header
		{
			get
			{
				return header;
			}
			set
			{
				header = value;
			}
		}

		public string Footer
		{
			get
			{
				return footer;
			}
			set
			{
				footer = value;
			}
		}

		public bool Equals(Group other)
		{
			if (Object.ReferenceEquals(other, null))
			{
				return false;
			}
			if (Object.ReferenceEquals(this, other))
			{
				return true;
			}

			return Name == other.Name;
		}

		public int GetHashCode()
		{
			return Name.GetHashCode();
		}
	}
}
