using BaseDAL.Model;
using Common.Model;
using Common.Network.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GasStation.Helper
{
	/// <summary>
	/// Gate Client
	/// </summary>
	public class AntennaClient
	{
		#region Events
		public event Common.Network.Core.NetTcpClient.Connect onConnect;
		public event Common.Network.Core.NetTcpClient.Disconnect onDisconnect;
		public event Common.Network.Core.NetTcpClient.ReceiveData onReceiveData;
		public event Common.Network.Core.NetTcpClient.SendData onSendData;
		public event Common.Network.Core.NetTcpClient.Error onError;
		#endregion

		#region Variables
		private ManualResetEvent msr;
		private Thread connectorThread;
		private TimeSpan _connectorInterval;
		private NetTcpClient tcpClient;
		private int connectCount = 0;	
		#endregion

		#region Properties
		/// <summary>
		/// Connect interval
		/// </summary>		
		public TimeSpan connectorInterval
		{
			get
			{
				if (null == _connectorInterval)
					_connectorInterval = new TimeSpan (0, 0, 15);

				return _connectorInterval;
			}
			set
			{
				_connectorInterval = value;
			}
		}
				#endregion

		#region Methods
		public AntennaClient (string host, int port, int bufferSize)
		{
			msr = new ManualResetEvent (false);
			connectorInterval = new TimeSpan (0, 0, 15);			
			tcpClient = new NetTcpClient (host, port, bufferSize);

			tcpClient.onConnect			+= tcpClient_onConnect;
			tcpClient.onDisconnect		+= tcpClient_onDisconnect;
			tcpClient.onError			+= tcpClient_onError;
			tcpClient.onReceiveData		+= tcpClient_onReceiveData;
			tcpClient.onSendData		+= tcpClient_onSendData;
		}

		/// <summary>
		/// On Send data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="data"></param>
		void tcpClient_onSendData (NetTcpClient sender, CommandResult data)
		{
			if (null != onSendData)
				onSendData (sender, data);
		}

		/// <summary>
		/// OnError
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="data"></param>
		void tcpClient_onError (NetTcpClient sender, CommandResult data)
		{
			if (null != onError)
			{
				onError (sender, data);				
				connectCount ++;
			}

			///TODO : PARSE ERROR
			if (data.id == 999)
			{
				if (connectCount < 10)
				{ 
					tryToConnect ();
					if (msr.WaitOne ())
						connect ();
				}				
			}
		}

		/// <summary>
		/// OnDisConnect
		/// </summary>
		/// <param name="sender"></param>
		void tcpClient_onDisconnect (NetTcpClient sender)
		{
			if (null != onDisconnect)			
				onDisconnect (sender);
		}

		/// <summary>
		/// On Connect
		/// </summary>
		/// <param name="sender"></param>
		void tcpClient_onConnect (NetTcpClient sender)
		{
			if (null != onConnect)							
				onConnect (sender);
		}		

		/// <summary>
		/// Parse recieved data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="data"></param>
		void tcpClient_onReceiveData (Common.Network.Core.NetTcpClient sender, CommandResult data)
		{
			if (null != onReceiveData)
				onReceiveData (sender, data);			
		}

		/// <summary>
		/// Connect
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void connect ()
		{			
			tcpClient.connect ();
		}

		/// <summary>
		/// Disconnect
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void disconnect ()
		{
			tcpClient.disconnect ();
		}

		/// <summary>
		/// Write data
		/// </summary>
		/// <param name="data"></param>
		public void write (string data)
		{
			try
			{
				tcpClient.write (data, Encoding.UTF8);
			}
			catch (Exception ex)
			{
				//writeThread.Abort();
			}
		}

		/// <summary>
		/// Try to connect
		/// </summary>
		private void tryToConnect ()
		{
			msr.Reset ();

			connectorThread = new Thread (new ThreadStart (() =>
			{
				try
				{
					Thread.Sleep (connectorInterval);
					msr.Set ();
				}
				catch (Exception ex)
				{
					
				}
			}));
			connectorThread.Start ();
		}		

		#endregion
	}
}
	
		
	

