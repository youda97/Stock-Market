﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
	class SellOrder : Order
	{
		protected DateTime orderDateTime;
		protected int orderSize;
		protected Double orderPrice;

		public SellOrder(Double price, int size)
		{
			orderDateTime = DateTime.Now;
			orderSize = size;
			orderPrice = price;
		}

		// Gets or sets the price
		public Double Price
		{
			get { return orderPrice; }
			set
			{
				if (orderPrice != value)
				{
					orderPrice = value;
				}
			}
		}

		// Gets or sets the size
		public int Size
		{
			get { return orderSize; }
			set
			{
				if (orderSize != value)
				{
					orderSize = value;
				}
			}
		}

		// Get the timestamp
		public DateTime TimeStamp
		{
			get { return orderDateTime; }
			set { }
		}

	}
}
