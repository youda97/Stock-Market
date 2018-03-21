using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
	public interface StockMarketDisplay
	{
		Object concreteSub
		{
			set;
		}
		void update();
	}
}
