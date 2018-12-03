using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Lab_4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// 1) -------------------------------------------------------

		private void set_mod(bool mod)
		{
			if (mod == true)
			{
				label1.Enabled = true;
				button1.Enabled = true;
				button2.Enabled = true;
				button3.Enabled = false;
				button4.Enabled = false;
			}
			else
			{
				label1.Enabled = false;
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = true;
				button4.Enabled = true;
			}
		}

		// 2) -------------------------------------------------------

		private StatusName Function2(Driver driver)
		{
			switch (driver.Status)
			{
				case ClientStatus.Unknown:
					return m_driverStatusNames[ClientStatus.Unknown];
				case ClientStatus.Free:
					return m_driverStatusNames[ClientStatus.Free];
				case ClientStatus.Busy:
					return m_driverStatusNames[ClientStatus.Busy];
				case ClientStatus.InWay:
					return m_driverStatusNames[ClientStatus.InWay];
				case ClientStatus.Work:
					return m_driverStatusNames[ClientStatus.Work];
				case ClientStatus.Break:
					return m_driverStatusNames[ClientStatus.Break];
				case ClientStatus.Alarm:
					return m_driverStatusNames[ClientStatus.Alarm];
			}
		}

		// 3) -------------------------------------------------------

		private void Function3()
		{
			uint i;

			if (i.ToString().Length == 1)
			{
			}
		}

		// 4) -------------------------------------------------------

		private void Function4()
		{
			string destination = null;
			for (int i = 0; i < 13; i++)
				destination += source[i];
		}

		// 5) -------------------------------------------------------

		private bool IsNumber(string str)
		{
			return (str.Replace("0", "").Replace("0", "").Replace("0", "").Replace("0", "")
				.Replace("0", "").Replace("0", "").Replace("0", "").Replace("0", "")
				.Replace("0", "").Replace("0", "").Length == 0);
		}

		// 6) -------------------------------------------------------

		private void Function6()
		{
			foreach (Direcoryinfo dir in dirs.GetDirectories())
			{
				//create folder{16}
				stream.Write(new byte[] { (byte)NetworkMessage.MakeDir }, 0, 1);
				stream.Read(new byte[1], 0, 1);

				stream.Write(BitConverter.GetBytes(Encoding.UTF8.GetBytes(
					SubFolder.Replace('\\', '/')) + dir.Name.Replace('\\'.'/').Length), 0, 4);

				stream.Write(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') +
					dir.Name.Replace('\\', '/')), 0,
					Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') +
					dir.Name.Replace('\\', '/')).Length);
				//send folder name

				stream.Read(new byte[1], 0, 1); // OK
			}
		}

		// 7) -------------------------------------------------------

		private void Function7()
		{
			string[] days = new String[7];
			for (int i = 0; i < 7; i++)
			{
				switch (i)
				{
					default:
					case 0:
						days[i] = "Monday";
						break;
					case 1:
						days[i] = "Tuesday";
						break;
					case 2:
						days[i] = "Wednesday";
						break;
					case 3:
						days[i] = "Thursday";
						break;
					case 4:
						days[i] = "Friday";
						break;
					case 5:
						days[i] = "Saturday";
						break;
					case 6:
						days[i] = "Sunday";
						break;
				}
			}
		}

		// 8) -------------------------------------------------------

		private void Function8()
		{
			DateTime dt = DateTime.Now;
			string h = dt.Hour.ToString().PadLeft(2, '0');
			string m = dt.Minute.ToString().PadLeft(2, '0');
			string s = dt.Second.ToString().PadLeft(2, '0');
			Console.WriteLine("--" + h + ":" + m + ":" + s + "--");
		}

		// 9) -------------------------------------------------------

		private void Function9()
		{
			return ((int)(Counter / 2) != Counter / 2.00 && Counter != 0);
		}

		// 10) -------------------------------------------------------

		private void Function10()
		{
			if (Connected == 0)
			{
				rez = setup();
				fl_end = true; // выход
			}
			else
				fl_end = true;
		}

		// 11) -------------------------------------------------------

		private void Function11()
		{
			List<int> arr = new List<int>();
			List<int> tmpArr = new List<int>();

			for (int i = 0; i < arr.Count; i++)
			{
				if (arr[i] > 100)
				{
				}
				else
					tmpArr.Add(arr[i]);
			}
			arr = tmpArr;
		}

		// 12) -------------------------------------------------------

		private void Function12()
		{
			var ids = form.Keys;

			if (ids.Length == 0 || ds.Length > 1) { throw Exception; }
		}

		// 13) -------------------------------------------------------

		private void Function13()
		{
			string[] nameParts = customer.Name.Split(' ');

			string firstName = nameParts[0];
			string lastName = customer.Name.Replace(nameParts[0], "").TrimStart(' ');
		}

		// 14) -------------------------------------------------------

		private void Function14()
		{
			foreach (string id in sourcelDs.Split(new char[] { ',' },
			StringSplitOptions.RemoveEmptyEntries))
			{
				sourceId = Convert.ToInt32(id);
				break;
			}
		}

		// 15) -------------------------------------------------------

		public string generateEMail()
		{
			string res;
			int i = PersonName.IndexOf(" ");
			char[] str1 = new char[i];
			PersonName.CopyTo(0, str1, 0, i);
			string str11 = new string(str1);
			char[] str2 = new char[PersonName.Length - i - 1];
			PersonName.CopyTo(i + 1, str2, 0, PersonName.Length - i - 1);
			string str22 = new string(str2);
			res = str11.ToString() + "." + str22.ToString();
			if (res.Length > 20)
			{
				str1 = new char[20];
				res.CopyTo(0, str1, 0, 20);
				res = new string(str1);
			}
			res += "@domain.ua";
			return res;
		}

		// 16) -------------------------------------------------------

		private void Function16()
		{
			foreach (string id in sourceIDs.Split(new char[] { ',' },
					StringSplitOptions.RemoveEmptyEntries))
			{
				sourceId = Convert.ToInt32(id);
				break;
			}
		}

		// 17) -------------------------------------------------------

		private string GetTextDiv2(string text)
		{
			int mid = text.Length / 2;
			int r = text.IndexOf(" ", mid); if (r < 0) r = 5000;
			int l = text.IndexOf(" ", 0, mid); if (l < 0) l = 5000;

			if (r - mid > mid - 1)
				mid = 1;
			else mid = r;

			if (mid == 5000) return "&ndsp" + text;
			return "&ndsp" + text.Substring(0, mid) + " <br/>&nbsp" +
				text.Substring(mid, text.Length - mid);
		}

		// 18) -------------------------------------------------------

		private static readonly char SPECIFER = "$"[0];
		private static readonly char DELIMITER = ":"[0];
		private static readonly char[] DELIMITER_ARRAY = new char[1] { DELIMITER };

		// 19) -------------------------------------------------------

		string mailTo = ((Config.GetSetting("AdminNotifications_EmailAddress") == null) ||
			(Config.GetSetting("AdminNotifications_EmailAddress").Length <= 0)) ?
			Globals.GetHostPortalSettings().HostSettings["SMTTPPassword"].ToString() :
			Config.GetSetting("AdminNotifications_EmailAddress");

		// 20) -------------------------------------------------------

		public bool CheckPath(string path)
		{
			int n;

			n = 0;
			
			//
			if (Directory.Exists(path + "SCLAD"))
			{
				n += 1;
			}
			if (Directory.Exists(path + "REAL"))
			{
				n += 1;
			}
			if (Directory.Exists(path + "DOSTAVKA"))
			{
				n += 1;
			}

			//
			if (File.Exists(path + "analit.dbf"))
			{
				n += 1;
			}
			if (File.Exists(path + "partner.dbf"))
			{
				n += 1;
			}
			if (File.Exists(path + "SCLAD\\mdoc.dbf"))
			{
				n += 1;
			}
			if (File.Exists(path + "SCLAD\\mdoc.fpt"))
			{
				n += 1;
			}
			if (File.Exists(path + "SCLAD\\mdocm.dbf"))
			{
				n += 1;
			}
			if (File.Exists(path + "SCLAD\\mgrup.dbf"))
			{
				n += 1;
			}
			if (File.Exists(path + "SCLAD\\mlabel.dbf"))
			{
				n += 1;
			}
			if (File.Exists(path + "SCLAD\\mlabel.fpt"))
			{
				n += 1;
			}
			if (File.Exists(path + "REAL\\rbookm.dbf"))
			{
				n += 1;
			}
			if (File.Exists(path + "REAL\\rbook.dbf"))
			{
				n += 1;
			}
			if (File.Exists(path + "REAL\\rbook.fpt"))
			{
				n += 1;
			}
			if (File.Exists(path + "DOSTAVKA\\avt.dbf"))
			{
				n += 1;
			}
			if (File.Exists(path + "DOSTAVKA\\avtm.dbf"))
			{
				n += 1;
			}
			if (File.Exists(path + "DOSTAVKA\\avtm.fpt"))
			{
				n += 1;
			}
			if (File.Exists(path + "DOSTAVKA\\cargo.dbf"))
			{
				n += 1;
			}
			if (File.Exists(path + "DOSTAVKA\\cargom.dbf"))
			{
				n += 1;
			}
			if (File.Exists(path + "DOSTAVKA\\zamena.dbf"))
			{
				n += 1;
			}

			if (n = 20)
			{
				return true;
			}

			return false;
		}

		// 21) -------------------------------------------------------

		private void Function21()
		{
			txtContracts.Text = "";
			bool first = true;

			foreach (string contact in contacts)
			{
				if (first != true)
					txtContacts.Text += ";";
				first = false;

				txtContacts.Text += contact;
			}
		}

		// 22) -------------------------------------------------------

		private void Function22()
		{
			if (Game1.clou == true)
			{
				Game1.clou = false;
			}
			else
			{
				Game1.clou = true;
			}
		}
	}
}
