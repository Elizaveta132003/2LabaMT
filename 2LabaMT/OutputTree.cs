namespace _2LabaMT
{
	public partial class OutputTree : Form
	{
		public BinaryTree tree;
		public OutputTree(BinaryTree tree)
		{
			InitializeComponent();
			this.tree = tree;
			richTextBoxTree.Text = tree.print();

		}
	}
}
