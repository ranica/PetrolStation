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
		List<c_Ticket> c_tickets = new List<c_Ticket> ();
		static Random rand = new Random ();

        public class c_Ticket
        {
            public T Key { get; private set; }
            public string Code { get; private set; }
            public c_Ticket(T key, string code)
            {
                this.Key = key;
                this.Code = code;
            }
        }

        public class Ticket
		{
			public  T Key { get; private set; }
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


        public void Add(T key, string code)
        {
            c_tickets.Add(new c_Ticket(key, code));
        }
        /// <summary>
        /// return count list Lottey
        /// </summary>
        /// <param name="key"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public int Count()
        {
           return c_tickets.Count();
        }

        /// <summary>
        /// Compare duplicate code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool Compare(string code)
        {
            if ((0 < c_tickets.Count) && (null != c_tickets))
            {
                return   c_tickets.Exists(e => e.Code == code);
            }

            return false;
        }
        /// <summary>
        /// returns the next winner ticket
        /// </summary>
        /// <returns></returns>
        public Ticket Draw(bool removeWinner)
        {

            if (tickets.Count == 0) return null;
            //throw new Exception ("No more tickets to pick from");
            double r = rand.NextDouble() * tickets.Sum(a => a.Weight);

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
            if (removeWinner) this.tickets.Remove(winner);
            return winner;
        }

        #endregion
    }
}
