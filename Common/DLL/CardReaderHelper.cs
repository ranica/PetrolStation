using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Common.DLL.Public;

namespace Common.DLL
{
	public class CardReaderHelper
	{
		#region Delegates
		public delegate void TagReadHandler(string uuid, string tagId); 
		#endregion

		#region Events
		public event TagReadHandler onTagRead;
		#endregion

		#region Methods
		/// <summary>
		/// Get Com List
		/// </summary>
		public string[] GetComList()
		{
			string[] serials = new string[32];
			PublicFunction.SearchHids(ref serials);

			return serials;
		}

		public bool connected
		{
			get
			{
				return DemoPublic.Enabel_flg;
			}
		}

		/// <summary>
		/// Connect
		/// </summary>
		/// <param name="hid"></param>
		public bool connect(string hid)
		{
			PublicFunction.SelectBaudAndCrc(57600, 0x01);

			DemoPublic.Enabel_flg   = false;
			if (PublicFunction.ConnectRLM(hid))
			{
				DemoPublic.Enabel_flg = true;
				return true;
			}

			return false;
		}

		/// <summary>
		/// Disconnect
		/// </summary>
		/// <param name="hid"></param>
		public bool disconnect()
		{
			if (PublicFunction.DisConnectRLM())
			{
				DemoPublic.Enabel_flg = false;
				return true;
			}

			return false;
		}

		/// <summary>
		/// Start Tag reading
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public bool startTagReader (byte q)
		{
			byte[] Uii = new byte[64];
			byte[] pwd = { 0x00, 0x00, 0x00, 0x00 };
			DemoPublic.Para para = new DemoPublic.Para();

			para.bank       = 0x02;
			para.addr       = 0x00;
			para.pwd        = pwd;

			para.withuii    = false;
			para.uii        = Uii;

			readerFunc ((Object)para);

			return true;
		}

		/// <summary>
		/// Reader Function
		/// </summary>
		/// <param name="obj"></param>
		private void readerFunc(object obj)
		{
			byte[] uiiLen = new byte[1];
			byte[] dataLen = new byte[2];
			byte[] Data = new byte[256];
			byte[] error = new byte[1];
			string uiiStr = "";

			DemoPublic.Para para = (DemoPublic.Para)obj;

			byte[] pwd = para.pwd;
			byte[] Uii = para.uii;
			byte bank = para.bank;
			int addr = para.addr;
			bool withuii = para.withuii;

			int uiilen = 2 * ((Uii[0] >> 3) + 1);

			if (PublicFunction.ReadDataSingleNoCnt(pwd, bank, addr, dataLen, Data, Uii, uiiLen, error))
			{
				System.Media.SystemSounds.Asterisk.Play();

				string dataStr = DemoPublic.BytesToHexString(Data, (int)((dataLen[0] << 8) + dataLen[1]));
				uiiStr = DemoPublic.BytesToHexString(Uii, uiiLen[0]);
				string  a = dataStr;
				string  b = uiiStr.Remove(0,4);

				onTagRead.Invoke (b, dataStr);
			}
		}

		/// <summary>
		/// Stop tag reader
		/// </summary>
		public void stopTagReader()
		{
			DemoPublic.LoopEnable = false;

			PublicFunction.Stop();

			if (DemoPublic.EPCThread != null)
			{
				DemoPublic.EPCThread.Abort();
			}
		}
		#endregion
	}
}
