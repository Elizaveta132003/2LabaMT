using System.Text;

namespace _2LabaMT
{
	public class IdValue
	{
		public string String { get; set; }

		public IdValue(string @string)
		{
			String = @string;
		}

		private int ToBinary()
		{
			// Convert String Into Byte Array
			byte[] sourceData = System.Text.ASCIIEncoding.ASCII.GetBytes(String);

			// Intialize Memory Space
			StringBuilder binaryString = new StringBuilder(sourceData.Length * 8);

			// Convert Each Byte Into A Binary String
			foreach (byte thisByte in sourceData)
				binaryString.Append(Convert.ToString(thisByte, 2));

			// Return String
			return binaryString.ToString().GetHashCode();
		}
		public new int GetHashCode()
		{
			//.Remove(6);
			var str = ToBinary();
			return str;
		}


	}
}
