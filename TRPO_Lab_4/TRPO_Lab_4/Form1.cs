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

		private void SetMod(bool mod)
		{
			if (mod) ActivateInterface1();
			else ActivateInterface2();
		}

		private void ActivateInterface1()
		{
			NamePersonLabel.Enabled = true;
			BackButton.Enabled = true;
			EnterButton.Enabled = true;
			LeftButton.Enabled = false;
			RightButton.Enabled = false;
		}

		private void ActivateInterface2()
		{
			NamePersonLabel.Enabled = false;
			BackButton.Enabled = false;
			EnterButton.Enabled = false;
			LeftButton.Enabled = true;
			RightButton.Enabled = true;
		}

		// 2) -------------------------------------------------------

		private string Function2(Driver driver)
		{
			return m_driverStatusNames[driver.Status];
		}

		// 3) -------------------------------------------------------

		const int CHECK_LENGTH = 1;

		private void Function3()
		{
			uint number;

			//...

			if (CheckNumber(number))
			{
				//...
			}
		}

		private bool CheckNumber(uint number)
		{
			if (number.ToString().Length == CHECK_LENGTH) return true;
			else return false;
		}

		// 4) -------------------------------------------------------

		const int COUNT_DESTINATION_SOURCE = 13;

		private void Function4()
		{
			//...
			string destination = SetDestination(sources);
			//...
		}

		private string SetDestination(string[] sources)
		{
			string destination = null;

			for (int i = 0; i < COUNT_DESTINATION_SOURCE; i++)
			{
				destination += sources[i];
			}

			return destination;
		}

		// 5) -------------------------------------------------------

		private bool IsNumber(string telephone_number)
		{
			for (int number = 0; number < 10; number++)
			{
				telephone_number.Replace(number.ToString(), "");
			}

			if (telephone_number.Length == 0)
				return true;
			else return false;
		}

		// 6) -------------------------------------------------------

		private void Function6()
		{
			foreach (Direcoryinfo dir in dirs.GetDirectories())
			{
				//create folder{16}
				stream.Write(new byte[] 
				{
					(byte)NetworkMessage.MakeDir }, 0, 1
				);

				StreamRead(stream);

				byte[] encod = Encod(SubFolder, dir.Name);

				stream.Write(BitConverter.GetBytes(encod.Length), 0, 4);

				stream.Write(encod, 0, encod.Length);
				//send folder name

				StreamRead(stream); // OK
			}
		}

		private string FolderStyle(string folder)
		{
			return folder.Replace('\\', '/');
		}

		private byte[] Encod(string sub_folder, string dir_name)
		{
			return Encoding.UTF8.GetBytes(FolderStyle(sub_folder) + FolderStyle(dir_name));
		}

		private void StreamRead(Stream stream)
		{
			stream.Read(new byte[1], 0, 1);
		}

		// 7) -------------------------------------------------------

		List<string> DAYS = new List<string>
		{
			"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"
		};

		private void Function7()
		{
			string[] days = new string[DAYS.Count];

			for (int i = 0; i < DAYS.Count; i++)
			{
				days[i] = DAYS[i];
			}
		}

		// 8) -------------------------------------------------------

		private void Function8()
		{
			DateTime currentDateTime = DateTime.Now;

			ShowTime(currentDateTime);
		}

		private void ShowTime(DateTime dateTime)
		{
			string hour = dateTime.Hour.ToString().PadLeft(2, '0');
			string minute = dateTime.Minute.ToString().PadLeft(2, '0');
			string second = dateTime.Second.ToString().PadLeft(2, '0');

			Console.WriteLine("--" + hour + ":" + minute + ":" + second + "--");
		}

		// 9) -------------------------------------------------------

		private void Function9()
		{
			return CheckNumberMultipleToNumber(Counter, 2);
		}

		private bool CheckNumberMultipleToNumber(double number, int divider)
		{
			bool multiple;

			if ((int)(number / divider) != number / divider && number != 0)
				multiple = false;
			else
				multiple = true;

			return multiple;
		}

		// 10) -------------------------------------------------------

		private void Function10()
		{
			if (Connected == 0)
			{
				rez = setup();
			}

			fl_end = true;
		}

		// 11) -------------------------------------------------------

		private void Function11()
		{
			List<int> arr = new List<int>();
			List<int> tmpArr = new List<int>();

			foreach (int number in arr)
			{
				if (number <= 100)
					tmpArr.Add(number);
			}

			arr = tmpArr;
		}

		// 12) -------------------------------------------------------

		private void Function12()
		{
			var ids = form.Keys;

			if (CheckKeySingle(ids.Length)) { throw Exception; }
		}

		private bool CheckKeySingle(int length)
		{
			if (length == 0 || length > 1)
				return true;
			else return false;
		}

		// 13) -------------------------------------------------------

		private void Function13()
		{
			string firstName = GetNamePart(customer.Name, 0);
			string lastName = GetWithoutPartNamePart(customer.Name, firstName, " ");
		}

		private string GetNamePart(string name, int number_part)
		{
			string part = "";

			string[] nameParts = name.Split(' ');
			part = nameParts[number_part];

			return part;
		}

		private string GetWithoutPartNamePart(string name, string part_name, string split)
		{
			string part = "";

			part = name.Replace(part_name + split, "");

			return part;
		}

		// 14) -------------------------------------------------------

		private void Function14()
		{
			sourceId = FindId(sourceIds, 0);
		}

		private int FindId(string sourceIds, int number_id)
		{
			string[] Ids = sourcelDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

			int i = 0;
			foreach (string id in Ids)
			{
				if (i == number_id)
					return Convert.ToInt32(id);
				else i++;
			}

			return 0;
		}

		// 15) -------------------------------------------------------

		const string NAME_DOMAIN = "@domain.ua";

		public string GenerateEMail()
		{
			string nameEMail = PersonName.Replace(" ", ".");

			int length = 0;
			if (nameEMail.Length > 20)
				length = 20;
			else
				length = nameEMail.Length;

			char[] nameShort = null;

			nameEMail.CopyTo(0, nameShort, 0, length);

			string fullNameEmail = "";
			fullNameEmail += nameShort + NAME_DOMAIN;

			return fullNameEmail;
		}

		// 16) -------------------------------------------------------

		private void Function16()
		{
			sourceId = FindId(sourceIds, 0);
		}

		private int FindId(string sourceIds, int number_id)
		{
			string[] Ids = sourcelDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

			int i = 0;
			foreach (string id in Ids)
			{
				if (i == number_id)
					return Convert.ToInt32(id);
				else i++;
			}

			return 0;
		}

		// 17) -------------------------------------------------------

		private string GetTextDiv2(string text)
		{
			int midText = text.Length / 2;

			midText = IndexSpace(text, midText);

			if (midText == text.Length) return "&ndsp" + text;
			return "&ndsp" + text.Substring(0, midText) + " <br/>&nbsp" +
				text.Substring(midText, text.Length - midText);
		}

		private int IndexSpace(string text, int midText)
		{
			int rightSpace = text.IndexOf(" ", midText);
			if (rightSpace < 0) rightSpace = text.Length;

			int leftSpace = text.IndexOf(" ", 0, midText);
			if (leftSpace < 0) leftSpace = text.Length;

			int distanceBetweenRightAndMid = rightSpace - midText;
			int distanceBetweenLeftAndMid = midText - leftSpace;

			if (distanceBetweenRightAndMid > distanceBetweenLeftAndMid)
				return leftSpace;
			else return rightSpace;
		}

		// 18) -------------------------------------------------------

		private static readonly char SPECIFER = '$';
		private static readonly char DELIMITER = ':';
		private static readonly char[] DELIMITER_ARRAY = new char[] { DELIMITER };

		// 19) -------------------------------------------------------

		private const string ADMIN_EMAIL = "AdminNotifications_EmailAddress";

		private void Function19()
		{
			string answer = "";

			if ((Config.GetSetting(ADMIN_EMAIL) == null) || (Config.GetSetting(ADMIN_EMAIL).Length <= 0))
				answer = Globals.GetHostPortalSettings().HostSettings["SMTTPPassword"].ToString();
			else
				answer = Config.GetSetting(ADMIN_EMAIL);

			string mailTo = answer;
		}

		// 20) -------------------------------------------------------

		List<string> DIRECTORYES = new List<string>
		{
			"SCLAD", "REAL", "DOSTAVKA"
		};

		List<string> FILES = new List<string>
		{
			"analit.dbf", "partner.dbf", "SCLAD\\mdoc.dbf",
			"SCLAD\\mdoc.fpt", "SCLAD\\mdocm.dbf",
			"SCLAD\\mgrup.dbf", "SCLAD\\mlabel.dbf",
			"SCLAD\\mlabel.fpt", "REAL\\rbookm.dbf",
			"REAL\\rbook.dbf", "REAL\\rbook.fpt",
			"DOSTAVKA\\avt.dbf", "DOSTAVKA\\avtm.dbf",
			"DOSTAVKA\\avtm.fpt", "DOSTAVKA\\cargo.dbf",
			"DOSTAVKA\\cargom.dbf", "DOSTAVKA\\zamena.dbf"
		};

		public bool CheckPath(string path)
		{
			int n = 0;

			foreach (string directory in DIRECTORYES)
			{
				if (Directory.Exists(path + directory))
					n += 1;
			}

			foreach (string file in FILES)
			{
				if (File.Exists(path + file))
					n += 1;
			}
			
			if (n == DIRECTORYES.Count + FILES.Count)
				return true;
			else
				return false;
		}

		// 21) -------------------------------------------------------

		private void Function21()
		{
			txtContracts.Text = "";

			foreach (string contact in contacts)
			{
				txtContacts.Text += AddToTextSplit(txtContacts.Text,";") + contact;
			}
		}

		private string AddToTextSplit(string text,string split)
		{
			if (text.Length != 0)
				return split;
			else
				return "";
		}

		// 22) -------------------------------------------------------

		private void Function22()
		{
			Game1.clou = !Game1.clou;
		}
	}
}
