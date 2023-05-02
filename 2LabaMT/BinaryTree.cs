using System.Diagnostics;

namespace _2LabaMT
{
	public class BinaryTree
	{
		//private BinaryTree _parent;
		private BinaryTree _left;
		private BinaryTree _right;
		private string _value;
		private List<string> listForPrint = new List<string>();

		public BinaryTree(string value)
		{
			this._value = value;
		}

		public void Add(string str)
		{
			if (str.CompareTo(this._value) < 0)
			{
				if (this._left == null)
					this._left = new BinaryTree(str);
				else if (this._left != null)
					this._left.Add(str);
			}
			else
			{
				if (this._right == null)
					this._right = new BinaryTree(str);
				else if (this._right != null)
					this._right.Add(str);
			}
		}
		private BinaryTree Find(BinaryTree tree, string identity)
		{
			if (tree == null)
				return null;
			switch (identity.CompareTo(tree._value))
			{
				case 1: return Find(tree._right, identity);
				case -1: return Find(tree._left, identity);
				case 0: return tree;
				default: return null;
			}
		}

		public (bool, long) Find(string identity)
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();
			long freq = Stopwatch.Frequency;
			var fval = Find(this, identity);
			if (fval == null)
			{
				Add(identity);
				stopwatch.Stop();
				var timeHash = stopwatch.ElapsedTicks;
				return (false, timeHash);

			}
			else
			{
				stopwatch.Stop();
				var timeHash = stopwatch.ElapsedTicks;
				return (true, timeHash);
			}
		}
		private void _print(BinaryTree node, ref string s, int level)
		{
			if (node != null)
			{
				_print(node._left, ref s, level + 1);
				for (int i = 0; i < level; i++) s += "   ";
				s += node._value + Environment.NewLine;
				_print(node._right, ref s, level + 1);
			}
		}

		public string print()
		{
			string s = "";
			listForPrint.Clear();
			_print(this, ref s, 0);
			return s;
		}
	}
}
