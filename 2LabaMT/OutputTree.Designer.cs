namespace _2LabaMT
{
	partial class OutputTree
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			richTextBoxTree = new RichTextBox();
			label1 = new Label();
			label8 = new Label();
			SuspendLayout();
			// 
			// richTextBoxTree
			// 
			richTextBoxTree.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			richTextBoxTree.Location = new Point(12, 57);
			richTextBoxTree.Name = "richTextBoxTree";
			richTextBoxTree.Size = new Size(1335, 567);
			richTextBoxTree.TabIndex = 0;
			richTextBoxTree.Text = "";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(467, 9);
			label1.Name = "label1";
			label1.Size = new Size(381, 31);
			label1.TabIndex = 1;
			label1.Text = "Исходные данные в виде дерева";
			// 
			// label8
			// 
			label8.BorderStyle = BorderStyle.Fixed3D;
			label8.Location = new Point(-39, 40);
			label8.Name = "label8";
			label8.Size = new Size(1400, 2);
			label8.TabIndex = 14;
			// 
			// OutputTree
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1359, 636);
			Controls.Add(label8);
			Controls.Add(label1);
			Controls.Add(richTextBoxTree);
			Name = "OutputTree";
			Text = "OutputTree";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RichTextBox richTextBoxTree;
		private Label label1;
		private Label label8;
	}
}