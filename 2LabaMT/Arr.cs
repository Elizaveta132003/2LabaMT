using System.Diagnostics;

namespace _2LabaMT
{
	public class Arr
	{
		private IdValue[] values;
		private int _length;
		private int c1 = 2;
		private int c2 = 3;

		public Arr(int length)
		{
			this._length = length;
			values = new IdValue[_length];
		}

		public void Add(IdValue value)
		{
			var str = value.GetHashCode();
			int key = Math.Abs(str % _length);
			var flag = true;

			while (flag)
			{
				if (values.Length <= key || (values.Count(v => v != null) + 100) > values.Length)
				{
					_length *= 2;
					Array.Resize(ref values, _length);
				}
				else
				{

					var isContain = values[key] == null;

					if (isContain)
					{
						values[key] = value;
						flag = false;
					}
					else
					{
						key = SquareCollision(key);
					}
				}
			}
		}
		private int SquareCollision(int key)
		{
			int i = 0;

			while (i < _length)
			{
				int newhash = Math.Abs((key + c1 * i + c2 * i * i) % _length);

				if (values[newhash] == null)
					return newhash;
				i++;
			}
			throw new Exception();
		}

		public (bool, long) Find(string identity)
		{
			var str = new IdValue(identity).GetHashCode();
			int key = Math.Abs(str.GetHashCode() % _length);

			var stopwatch = new Stopwatch();
			stopwatch.Start();
			long freq = Stopwatch.Frequency;

			int i = 0;

			while (i < _length)
			{
				int newKey = (key + i) % _length;

				if (values[newKey] != null && values[newKey].String == identity)
				{
					stopwatch.Stop();
					var timeHash = stopwatch.ElapsedTicks;
					return (true, timeHash);
				}

				i++;
			}

			Add(new IdValue(identity));
			stopwatch.Stop();

			var timeHashh = stopwatch.ElapsedTicks;
			return (false, timeHashh);

		}

	}
}
