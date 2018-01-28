using BaseDAL.Model;
using Common.Network.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AntennaService.Helper
{
	/// <summary>
	/// Client Method Parser
	/// </summary>
	public class ClientMethodParser
	{
		/*
			Commands (CLIENT):
					GET_LAST_TAG
			
			Commands (SERVER):
					NEW_TAG
		*/

		#region Methods
		/// <summary>
		/// Parse Command
		/// </summary>
		/// <param name="client"></param>
		/// <param name="data"></param>
		public static void parseCmd (NetTcpClient client, CommandResult data)
		{
			if ((null != client) && (null != data) && !data.message.isNullOrEmptyOrWhiteSpaceOrLen ())
			{
				string cmd = data.message.ToLower ();

				if (cmd == "get_last_tag")
				{
					// Get last tag
				}
			}
		}

		/// <summary>
		/// Write Cmd
		/// </summary>
		/// <param name="server"></param>
		/// <param name="data"></param>
		public static void writeTag (NetTcpServer server, string tagId)
		{
			if ((null != server) && !tagId.isNullOrEmptyOrWhiteSpaceOrLen ())
			{
				string cmd	= string.Format ("[new_tag\t{0}]", tagId.Trim ());

				server.write (cmd);
			}
		}
		#endregion
	}
}
