using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2LabaMT
{
	public class ReadByFile
	{
		private string _nameFile;
		public ReadByFile(string nameFile)
		{
			_nameFile = nameFile;
		}

		public List<string> ReadDataByFile()
		{
			List<string> list = new List<string>();

			FileStream file = new(_nameFile, FileMode.Open);
			StreamReader readFile = new(file);

			while (!readFile.EndOfStream)
			{
				list.Add(readFile.ReadLine());
			}

			readFile.Close();

			return list;
		}
	}
}
