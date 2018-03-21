using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
	public interface Order
	{
		DateTime TimeStamp
		{
			get;
			set;
		}

		int Size
		{
			get;
			set;
		}

		Double Price
		{
			get;
			set;
		}
	}
}
