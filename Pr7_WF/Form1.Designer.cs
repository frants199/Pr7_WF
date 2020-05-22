namespace Pr7_WF
{
	partial class Pr7
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tasks = new System.Windows.Forms.TabControl();
			this.task1_page = new System.Windows.Forms.TabPage();
			this.task2_page = new System.Windows.Forms.TabPage();
			this.text1_label = new System.Windows.Forms.Label();
			this.text1_box = new System.Windows.Forms.RichTextBox();
			this.result1_label = new System.Windows.Forms.Label();
			this.result1_box = new System.Windows.Forms.RichTextBox();
			this.result2_box = new System.Windows.Forms.RichTextBox();
			this.rasult2_labenl = new System.Windows.Forms.Label();
			this.text2_box = new System.Windows.Forms.RichTextBox();
			this.text2_label = new System.Windows.Forms.Label();
			this.tasks.SuspendLayout();
			this.task1_page.SuspendLayout();
			this.task2_page.SuspendLayout();
			this.SuspendLayout();
			// 
			// tasks
			// 
			this.tasks.Controls.Add(this.task1_page);
			this.tasks.Controls.Add(this.task2_page);
			this.tasks.Location = new System.Drawing.Point(12, 12);
			this.tasks.Name = "tasks";
			this.tasks.SelectedIndex = 0;
			this.tasks.Size = new System.Drawing.Size(281, 166);
			this.tasks.TabIndex = 0;
			// 
			// task1_page
			// 
			this.task1_page.Controls.Add(this.result1_box);
			this.task1_page.Controls.Add(this.result1_label);
			this.task1_page.Controls.Add(this.text1_box);
			this.task1_page.Controls.Add(this.text1_label);
			this.task1_page.Location = new System.Drawing.Point(4, 25);
			this.task1_page.Name = "task1_page";
			this.task1_page.Padding = new System.Windows.Forms.Padding(3);
			this.task1_page.Size = new System.Drawing.Size(273, 137);
			this.task1_page.TabIndex = 0;
			this.task1_page.Text = "Задание 1";
			this.task1_page.UseVisualStyleBackColor = true;
			// 
			// task2_page
			// 
			this.task2_page.Controls.Add(this.result2_box);
			this.task2_page.Controls.Add(this.rasult2_labenl);
			this.task2_page.Controls.Add(this.text2_box);
			this.task2_page.Controls.Add(this.text2_label);
			this.task2_page.Location = new System.Drawing.Point(4, 25);
			this.task2_page.Name = "task2_page";
			this.task2_page.Padding = new System.Windows.Forms.Padding(3);
			this.task2_page.Size = new System.Drawing.Size(273, 137);
			this.task2_page.TabIndex = 1;
			this.task2_page.Text = "Задание 2";
			this.task2_page.UseVisualStyleBackColor = true;
			// 
			// text1_label
			// 
			this.text1_label.AutoSize = true;
			this.text1_label.Location = new System.Drawing.Point(6, 9);
			this.text1_label.Name = "text1_label";
			this.text1_label.Size = new System.Drawing.Size(50, 17);
			this.text1_label.TabIndex = 0;
			this.text1_label.Text = "Текст:";
			// 
			// text1_box
			// 
			this.text1_box.Location = new System.Drawing.Point(62, 6);
			this.text1_box.Name = "text1_box";
			this.text1_box.Size = new System.Drawing.Size(205, 55);
			this.text1_box.TabIndex = 1;
			this.text1_box.Text = "";
			this.text1_box.TextChanged += new System.EventHandler(this.text1_box_TextChanged);
			// 
			// result1_label
			// 
			this.result1_label.AutoSize = true;
			this.result1_label.Location = new System.Drawing.Point(6, 68);
			this.result1_label.Name = "result1_label";
			this.result1_label.Size = new System.Drawing.Size(80, 17);
			this.result1_label.TabIndex = 2;
			this.result1_label.Text = "Результат:";
			// 
			// result1_box
			// 
			this.result1_box.Location = new System.Drawing.Point(92, 65);
			this.result1_box.Name = "result1_box";
			this.result1_box.Size = new System.Drawing.Size(175, 66);
			this.result1_box.TabIndex = 3;
			this.result1_box.Text = "";
			// 
			// result2_box
			// 
			this.result2_box.Location = new System.Drawing.Point(92, 65);
			this.result2_box.Name = "result2_box";
			this.result2_box.Size = new System.Drawing.Size(175, 66);
			this.result2_box.TabIndex = 7;
			this.result2_box.Text = "";
			// 
			// rasult2_labenl
			// 
			this.rasult2_labenl.AutoSize = true;
			this.rasult2_labenl.Location = new System.Drawing.Point(6, 68);
			this.rasult2_labenl.Name = "rasult2_labenl";
			this.rasult2_labenl.Size = new System.Drawing.Size(80, 17);
			this.rasult2_labenl.TabIndex = 6;
			this.rasult2_labenl.Text = "Результат:";
			// 
			// text2_box
			// 
			this.text2_box.Location = new System.Drawing.Point(62, 6);
			this.text2_box.Name = "text2_box";
			this.text2_box.Size = new System.Drawing.Size(205, 55);
			this.text2_box.TabIndex = 5;
			this.text2_box.Text = "";
			this.text2_box.TextChanged += new System.EventHandler(this.text2_box_TextChanged);
			// 
			// text2_label
			// 
			this.text2_label.AutoSize = true;
			this.text2_label.Location = new System.Drawing.Point(6, 9);
			this.text2_label.Name = "text2_label";
			this.text2_label.Size = new System.Drawing.Size(50, 17);
			this.text2_label.TabIndex = 4;
			this.text2_label.Text = "Текст:";
			// 
			// Pr7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 186);
			this.Controls.Add(this.tasks);
			this.Name = "Pr7";
			this.Text = "Практика 7";
			this.tasks.ResumeLayout(false);
			this.task1_page.ResumeLayout(false);
			this.task1_page.PerformLayout();
			this.task2_page.ResumeLayout(false);
			this.task2_page.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tasks;
		private System.Windows.Forms.TabPage task1_page;
		private System.Windows.Forms.TabPage task2_page;
		private System.Windows.Forms.RichTextBox result1_box;
		private System.Windows.Forms.Label result1_label;
		private System.Windows.Forms.RichTextBox text1_box;
		private System.Windows.Forms.Label text1_label;
		private System.Windows.Forms.RichTextBox result2_box;
		private System.Windows.Forms.Label rasult2_labenl;
		private System.Windows.Forms.RichTextBox text2_box;
		private System.Windows.Forms.Label text2_label;
	}
}

