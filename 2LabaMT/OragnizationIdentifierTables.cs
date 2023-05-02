namespace _2LabaMT
{
	public partial class OragnizationIdentifierTables : Form
	{
		List<string> list = new();

		public string nameFile = "D:/3 курс/МТ/Lab2/Identity.txt";
		public Arr arr;
		public BinaryTree tree;
		public OragnizationIdentifierTables()
		{
			InitializeComponent();
			//RandWord();
			list = ReadByFile();
			AddInArray(list);
			AddInBinaryTree(list);
			Output();

		}
		private void Output()
		{
			list.ForEach(i => richTextBox1.Text += i + '\n');
			//richTextBoxTree.Text = tree.print();
		}

		public List<string> ReadByFile()
		{
			ReadByFile reader = new(nameFile);

			return reader.ReadDataByFile();
		}
		public void AddInArray(List<string> list)
		{
			arr = new(500);
			list.ForEach(i => arr.Add(new IdValue(i)));
		}
		public void AddInBinaryTree(List<string> list)
		{

			tree = new BinaryTree(list[0]);
			list.ForEach(i => tree.Add(i));
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			var identity = textBoxIdentity.Text;
			Findd(identity, arr.Find(identity), richTextBoxArray);
			Findd(identity, tree.Find(identity), richTextBoxBinaryTree);

		}

		private void Findd(string identity, (bool, long) find, RichTextBox richTextBox)
		{
			var flag = find.Item1;
			var time = find.Item2;

			if (flag)
			{
				richTextBox.Text += $"Идентификатор {identity} найден" + '\n';
				richTextBox.Text += $"Время поиска идентификатора: {time.ToString()}" + '\n';
			}
			else
			{
				richTextBox.Text += $"Идентификатор {identity} не найден" + '\n';
				richTextBox.Text += $"Время поиска идентификатора: {time.ToString()}" + '\n';

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			richTextBoxArray.Clear();
			textBoxIdentity.Clear();
			richTextBoxBinaryTree.Clear();
		}
		private void RandWord()
		{
			char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
			Random rand = new Random();
			for (int i = 1; i <= 500; i++)
			{
				// Сделайте слово.
				string word = "";
				int randint = rand.Next(2, 20);

				for (int j = 1; j <= randint; j++)
				{
					// Выбор случайного числа от 0 до 25
					// для выбора буквы из массива букв.
					int letter_num = rand.Next(0, letters.Length - 1);

					// Добавить письмо.
					word += letters[letter_num];
				}

				// Добавьте слово в список.
				using (StreamWriter writer = new StreamWriter(nameFile, true))
				{
					writer.WriteLineAsync(word);
				}
			}
		}

		private void buttonOutputTree_Click(object sender, EventArgs e)
		{
			OutputTree form = new OutputTree(tree);
			form.ShowDialog();
		}
	}
}