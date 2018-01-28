using Common.Network.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TcpProject.Helper;

namespace TcpProject
{
	public partial class Form1 : Form
	{
		public Form1 ()
		{
			InitializeComponent ();

			//NetTcpClient t	= new NetTcpClient ("192.168.0.2", 1470, 1024);
			//t.onReceiveData += t_onReceiveData;
			//t.connect ();
		}

		void t_onReceiveData (NetTcpClient sender, Common.Model.CommandResult data)
		{
			string s	= Encoding.UTF8.GetString (data.model as byte[]);

			Invoke ((Action)delegate
			{
				listBox1.Items.Insert (0, s);
			});
		}

		GateClient	gClient;

		private void button1_Click (object sender, EventArgs e)
		{
			int	prt	= Int32.Parse (portTextBox.Text);

			gClient	= new GateClient (ipTextBox.Text, prt, 1024);
			gClient.onConnect		+= tcpClient_onConnect;
			gClient.onDisconnect	+= tcpClient_onDisconnect;
			gClient.onError			+= tcpClient_onError;
			gClient.onReceiveData	+= tcpClient_onReceiveData;
			gClient.onSendData		+= tcpClient_onSendData;

			gClient.connect ();
		}

		void tcpClient_onSendData (NetTcpClient sender, Common.Model.CommandResult data)
		{
			Invoke ((Action)delegate
			{
				listBox1.Items.Insert (0, sender.host + "- > Send data "  + Encoding.UTF8.GetString (data.model as byte[]));
			});
		}

		void tcpClient_onReceiveData (NetTcpClient sender, Common.Model.CommandResult data)
		{
			Invoke ((Action)delegate
			{
				listBox1.Items.Insert (0, sender.host + "- > Recieve data " + Encoding.UTF8.GetString (data.model as byte[]));
			});
		}

		void tcpClient_onError (NetTcpClient sender, Common.Model.CommandResult data)
		{
			Invoke ((Action)delegate
			{				
				listBox1.Items.Insert (0, sender.host + "- > Error : " + data.message);
			});
		}

		void tcpClient_onDisconnect (NetTcpClient sender)
		{
			Invoke ((Action)delegate
			{
				listBox1.Items.Insert (0, sender.host + "- > DisConnect");
			});
		}

		void tcpClient_onConnect (NetTcpClient sender)
		{
			Invoke ((Action)delegate
			{
				listBox1.Items.Insert (0, sender.host + "- > Connect");
			});
		}

		private void button2_Click (object sender, EventArgs e)
		{
			gClient.disconnect ();
		}

		private void button3_Click (object sender, EventArgs e)
		{
			gClient.write (dataTextBox.Text);
		}		
	}
}
