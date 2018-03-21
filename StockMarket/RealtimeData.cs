using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
	class RealtimeData : StockMarket
	{
		private List<company> companies = new List<company>();

		public void addCompany(String symbol, String name, double price)
		{
			company newCompany = new company(symbol, name, price, this);
			companies.Add(newCompany);
		}

		public List<company> getCompanies()
		{
			return companies;
		}
	}
}
