using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Helper.Lottery
{
	public class Lottery<T>
	{
		#region Prpperties

		List<Ticket> tickets = new List<Ticket> ();
		static Random rand = new Random ();
			
		public class Ticket
		{
			public T Key { get; private set; }
			public double Weight { get; private set; }
			public Ticket (T key, double weight)
			{
				this.Key = key;
				this.Weight = weight;
			}
		}
		#endregion

		#region Method		
		
		public void Add (T key, double weight)
		{
			tickets.Add (new Ticket (key, weight));
		}
		/// <summary>
		/// returns the next winner ticket
		/// </summary>
		/// <returns></returns>
		public Ticket Draw (bool removeWinner)
		{
			
			if (tickets.Count == 0) return null;
				//throw new Exception ("No more tickets to pick from");
			double r = rand.NextDouble () * tickets.Sum (a => a.Weight);

			double min = 0;
			double max = 0;
			Ticket winner = null;
			
			foreach (var ticket in tickets)
			{
				max += ticket.Weight;
				//-----------
				if (min <= r && r < max)
				{
					winner = ticket;
					break;
				}
				//-----------
				min = max;
			}
			if (winner == null) return null;
			if (removeWinner) this.tickets.Remove (winner);
			return winner;
		}
		#endregion
	}
}
