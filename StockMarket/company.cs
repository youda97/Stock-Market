using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
	class company
	{

		private String symbol;
		private String name;
		private Double openPrice;
		private Double currentPrice;
		private StockMarket market;
		private List<Order> transactions = new List<Order>();
		private List<Order> bidOrders = new List<Order>();
		private List<Order> sellOrders = new List<Order>();

		public company(String symbol, String name, double openPrice, StockMarket handledBy)
		{
			this.symbol = symbol;
			this.name = name;
			this.openPrice = openPrice;
			this.currentPrice = 0;
			this.market = handledBy;
		}



		public String Symbol
		{
			get
			{
				return symbol;
			}
			set
			{
				symbol = value;
			}
		}

		public String Name
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
		public double OpenPrice
		{
			get
			{
				return openPrice;
			}
			set
			{
				openPrice = value;
			}
		}

		public double LastSale
		{
			get { return currentPrice; }
			set
			{
				if (currentPrice != value)
				{
					currentPrice = value;
					market.Notify();
				}
			}
		}
		public int getVolume()
		{
			int shareVolume = 0;
			foreach (Order order in transactions)
			{
				shareVolume += order.Size;
			}
			return shareVolume;
		}

		public void submitBidOrder(Double price, int size)
		{
			if (sellOrders.Count > 0)
			{
				BuyOrder sale;
				foreach (SellOrder order in sellOrders)
				{
					// if same price, add it into transactions
					if (price >= order.Price)
					{
						if (order.Size == size)
						{
							sale = new BuyOrder(price, size);
							transactions.Add(sale);
							sellOrders.Remove(order);
							LastSale = price;
							break;
						}
						else if (order.Size > size)
						{
							int remainingSize = order.Size - size;
							sale = new BuyOrder(price, size);
							transactions.Add(sale);
							order.Size = remainingSize;
							LastSale = price;
							break;					
						}
						else if (order.Size < size)
						{
							int remainingSize = size - order.Size;
							sale = new BuyOrder(price, order.Size);
							transactions.Add(sale);
							sellOrders.Remove(order);

							LastSale = price;
							submitBidOrder(price, remainingSize);


							break;
						}
					}
					else
					{
						BuyOrder buyOrder = new BuyOrder(price, size);
						bidOrders.Add(buyOrder);
						var SortedBuyOrders = bidOrders.OrderByDescending(BuyOrder => BuyOrder.Price).ThenBy(BuyOrder => BuyOrder.TimeStamp).ToList();
						bidOrders = SortedBuyOrders;
						break;
					}
				}
			}
			else
			{
				BuyOrder buyOrder = new BuyOrder(price, size);
				bidOrders.Add(buyOrder);
				var SortedBuyOrders = bidOrders.OrderByDescending(BuyOrder => BuyOrder.Price).ThenBy(BuyOrder => BuyOrder.TimeStamp).ToList();
				bidOrders = SortedBuyOrders;
			}
			market.Notify();
		}

		public void submitSellOrder(Double price, int size)
		{

			if (bidOrders.Count > 0)
			{

				SellOrder sale;
				foreach (BuyOrder order in bidOrders)
				{
					// if we have buy order with the same price, add it into transactions
					if (order.Price >= price)
					{
						if (order.Size == size)
						{
							sale = new SellOrder(price, size);
							transactions.Add(sale);
							bidOrders.Remove(order);
							LastSale = price;
							break;
						}
						else if (order.Size > size)
						{
							int remainingSize = order.Size - size;
							sale = new SellOrder(price, size);
							transactions.Add(sale);
							order.Size = remainingSize;
							LastSale = price;
							break;
						}
						else if (order.Size < size)
						{
							int remainingSize = size - order.Size;
							sale = new SellOrder(price, order.Size);
							transactions.Add(sale);
							bidOrders.Remove(order);
							LastSale = price;

							submitSellOrder(price, remainingSize);

							break;                  
						}
					}
					else
					{
						SellOrder sellOrder = new SellOrder(price, size);
						sellOrders.Add(sellOrder);
						var SortedSellOrders = sellOrders.OrderBy(SellOrder => SellOrder.Price).ThenBy(SellOrder => SellOrder.TimeStamp).ToList();
						sellOrders = SortedSellOrders;
						break;
					}
				}
			}
			else
			{
				SellOrder sellOrder = new SellOrder(price, size);
				sellOrders.Add(sellOrder);
				var SortedSellOrders = sellOrders.OrderBy(SellOrder => SellOrder.Price).ThenBy(SellOrder => SellOrder.TimeStamp).ToList();
				sellOrders = SortedSellOrders;
			}
			market.Notify();


		}
		public List<Order> getBuyOrders()
		{
			return bidOrders;
		}
		public List<Order> getSellOrders()
		{
			return sellOrders;
		}
	}
}
