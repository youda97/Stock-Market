using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
	class StockMarket
	{
		private List<StockMarketDisplay> observers = new List<StockMarketDisplay>();

		public void Register(StockMarketDisplay obs)
		{
			observers.Add(obs);
		}

		public void unRegister(StockMarketDisplay obs)
		{
			observers.Remove(obs);
		}

		public void Notify()
		{

			foreach (StockMarketDisplay obs in observers)
			{
				obs.update();
			}
		}

	}
}
