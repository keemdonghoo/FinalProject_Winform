﻿namespace FinalProject_Winform
{
	partial class OrderForm
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
			panel2 = new Panel();
			label1 = new Label();
			panel1 = new Panel();
			btn_ChartForm = new Button();
			btn_OrderForm = new Button();
			btn_StockForm = new Button();
			btn_TestForm = new Button();
			btn_ProcessForm = new Button();
			btn_LOTForm = new Button();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			panel4 = new Panel();
			txtOrderCount = new TextBox();
			dateTimePicker2 = new DateTimePicker();
			dateTimePicker1 = new DateTimePicker();
			label7 = new Label();
			label6 = new Label();
			comboBox1 = new ComboBox();
			label5 = new Label();
			label4 = new Label();
			button2 = new Button();
			panel3 = new Panel();
			textBox1 = new TextBox();
			label10 = new Label();
			txtAccount = new TextBox();
			label2 = new Label();
			tabPage2 = new TabPage();
			panel5 = new Panel();
			button4 = new Button();
			button3 = new Button();
			dateTimePicker4 = new DateTimePicker();
			label9 = new Label();
			dateTimePicker3 = new DateTimePicker();
			label8 = new Label();
			dataGridView1 = new DataGridView();
			txtOrderName = new TextBox();
			label3 = new Label();
			order_item = new DataGridViewTextBoxColumn();
			order_count = new DataGridViewTextBoxColumn();
			order_start = new DataGridViewTextBoxColumn();
			order_end = new DataGridViewTextBoxColumn();
			order_send = new DataGridViewTextBoxColumn();
			order_account = new DataGridViewTextBoxColumn();
			order_status = new DataGridViewTextBoxColumn();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			tabPage2.SuspendLayout();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(52, 152, 219);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1264, 88);
			panel2.TabIndex = 5;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(550, 18);
			label1.Name = "label1";
			label1.Size = new Size(109, 50);
			label1.TabIndex = 0;
			label1.Text = "주 문";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(180, 210, 230);
			panel1.Controls.Add(btn_ChartForm);
			panel1.Controls.Add(btn_OrderForm);
			panel1.Controls.Add(btn_StockForm);
			panel1.Controls.Add(btn_TestForm);
			panel1.Controls.Add(btn_ProcessForm);
			panel1.Controls.Add(btn_LOTForm);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(160, 761);
			panel1.TabIndex = 4;
			// 
			// btn_ChartForm
			// 
			btn_ChartForm.FlatAppearance.BorderColor = Color.Gray;
			btn_ChartForm.FlatAppearance.BorderSize = 2;
			btn_ChartForm.FlatStyle = FlatStyle.Flat;
			btn_ChartForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
			btn_ChartForm.Location = new Point(-4, 580);
			btn_ChartForm.Name = "btn_ChartForm";
			btn_ChartForm.Size = new Size(168, 104);
			btn_ChartForm.TabIndex = 6;
			btn_ChartForm.Text = "현황판";
			btn_ChartForm.TextAlign = ContentAlignment.MiddleLeft;
			btn_ChartForm.UseVisualStyleBackColor = true;
			btn_ChartForm.Click += Button_Click;
			// 
			// btn_OrderForm
			// 
			btn_OrderForm.FlatAppearance.BorderColor = Color.Gray;
			btn_OrderForm.FlatAppearance.BorderSize = 2;
			btn_OrderForm.FlatStyle = FlatStyle.Flat;
			btn_OrderForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
			btn_OrderForm.Location = new Point(-4, 480);
			btn_OrderForm.Name = "btn_OrderForm";
			btn_OrderForm.Size = new Size(168, 104);
			btn_OrderForm.TabIndex = 7;
			btn_OrderForm.Text = "주문";
			btn_OrderForm.TextAlign = ContentAlignment.MiddleLeft;
			btn_OrderForm.UseVisualStyleBackColor = true;
			btn_OrderForm.Click += Button_Click;
			// 
			// btn_StockForm
			// 
			btn_StockForm.FlatAppearance.BorderColor = Color.Gray;
			btn_StockForm.FlatAppearance.BorderSize = 2;
			btn_StockForm.FlatStyle = FlatStyle.Flat;
			btn_StockForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
			btn_StockForm.Location = new Point(-4, 380);
			btn_StockForm.Name = "btn_StockForm";
			btn_StockForm.Size = new Size(168, 104);
			btn_StockForm.TabIndex = 8;
			btn_StockForm.Text = "재고관리";
			btn_StockForm.TextAlign = ContentAlignment.MiddleLeft;
			btn_StockForm.UseVisualStyleBackColor = true;
			btn_StockForm.Click += Button_Click;
			// 
			// btn_TestForm
			// 
			btn_TestForm.FlatAppearance.BorderColor = Color.Gray;
			btn_TestForm.FlatAppearance.BorderSize = 2;
			btn_TestForm.FlatStyle = FlatStyle.Flat;
			btn_TestForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
			btn_TestForm.Location = new Point(-4, 279);
			btn_TestForm.Name = "btn_TestForm";
			btn_TestForm.Size = new Size(168, 104);
			btn_TestForm.TabIndex = 9;
			btn_TestForm.Text = "검사";
			btn_TestForm.TextAlign = ContentAlignment.MiddleLeft;
			btn_TestForm.UseVisualStyleBackColor = true;
			btn_TestForm.Click += Button_Click;
			// 
			// btn_ProcessForm
			// 
			btn_ProcessForm.FlatAppearance.BorderColor = Color.Gray;
			btn_ProcessForm.FlatAppearance.BorderSize = 2;
			btn_ProcessForm.FlatStyle = FlatStyle.Flat;
			btn_ProcessForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
			btn_ProcessForm.Location = new Point(-4, 178);
			btn_ProcessForm.Name = "btn_ProcessForm";
			btn_ProcessForm.Size = new Size(168, 104);
			btn_ProcessForm.TabIndex = 5;
			btn_ProcessForm.Text = "공정";
			btn_ProcessForm.TextAlign = ContentAlignment.MiddleLeft;
			btn_ProcessForm.UseVisualStyleBackColor = true;
			btn_ProcessForm.Click += Button_Click;
			// 
			// btn_LOTForm
			// 
			btn_LOTForm.FlatAppearance.BorderColor = Color.Gray;
			btn_LOTForm.FlatAppearance.BorderSize = 2;
			btn_LOTForm.FlatStyle = FlatStyle.Flat;
			btn_LOTForm.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
			btn_LOTForm.Location = new Point(-4, 77);
			btn_LOTForm.Name = "btn_LOTForm";
			btn_LOTForm.Size = new Size(168, 104);
			btn_LOTForm.TabIndex = 4;
			btn_LOTForm.Text = "LOT";
			btn_LOTForm.TextAlign = ContentAlignment.MiddleLeft;
			btn_LOTForm.UseVisualStyleBackColor = true;
			btn_LOTForm.Click += Button_Click;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Dock = DockStyle.Bottom;
			tabControl1.ItemSize = new Size(200, 40);
			tabControl1.Location = new Point(160, 90);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1104, 671);
			tabControl1.TabIndex = 6;
			// 
			// tabPage1
			// 
			tabPage1.BackColor = Color.Gainsboro;
			tabPage1.Controls.Add(panel4);
			tabPage1.Controls.Add(panel3);
			tabPage1.Location = new Point(4, 44);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1096, 623);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "주문입력";
			// 
			// panel4
			// 
			panel4.BackColor = Color.White;
			panel4.Controls.Add(txtOrderCount);
			panel4.Controls.Add(dateTimePicker2);
			panel4.Controls.Add(dateTimePicker1);
			panel4.Controls.Add(label7);
			panel4.Controls.Add(label6);
			panel4.Controls.Add(comboBox1);
			panel4.Controls.Add(label5);
			panel4.Controls.Add(label4);
			panel4.Controls.Add(button2);
			panel4.Location = new Point(6, 113);
			panel4.Name = "panel4";
			panel4.Size = new Size(1086, 502);
			panel4.TabIndex = 6;
			// 
			// txtOrderCount
			// 
			txtOrderCount.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
			txtOrderCount.Location = new Point(659, 170);
			txtOrderCount.Name = "txtOrderCount";
			txtOrderCount.Size = new Size(200, 39);
			txtOrderCount.TabIndex = 17;
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Location = new Point(659, 50);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(200, 23);
			dateTimePicker2.TabIndex = 15;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.Location = new Point(211, 50);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(200, 23);
			dateTimePicker1.TabIndex = 14;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(491, 168);
			label7.Name = "label7";
			label7.Size = new Size(125, 37);
			label7.TabIndex = 13;
			label7.Text = "주문수량";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(94, 168);
			label6.Name = "label6";
			label6.Size = new Size(71, 37);
			label6.TabIndex = 11;
			label6.Text = "품명";
			// 
			// comboBox1
			// 
			comboBox1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "라면" });
			comboBox1.Location = new Point(211, 165);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(200, 40);
			comboBox1.TabIndex = 10;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(518, 36);
			label5.Name = "label5";
			label5.Size = new Size(98, 37);
			label5.TabIndex = 9;
			label5.Text = "만기일";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(40, 36);
			label4.Name = "label4";
			label4.Size = new Size(125, 37);
			label4.TabIndex = 7;
			label4.Text = "주문일자";
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(52, 152, 219);
			button2.FlatAppearance.BorderColor = Color.White;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
			button2.Location = new Point(922, 408);
			button2.Name = "button2";
			button2.Size = new Size(132, 46);
			button2.TabIndex = 5;
			button2.Text = "추가";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// panel3
			// 
			panel3.BackColor = Color.White;
			panel3.Controls.Add(textBox1);
			panel3.Controls.Add(label10);
			panel3.Controls.Add(txtAccount);
			panel3.Controls.Add(label2);
			panel3.Location = new Point(6, 6);
			panel3.Name = "panel3";
			panel3.Size = new Size(1086, 101);
			panel3.TabIndex = 1;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
			textBox1.Location = new Point(791, 26);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(263, 39);
			textBox1.TabIndex = 5;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
			label10.Location = new Point(615, 18);
			label10.Name = "label10";
			label10.Size = new Size(125, 47);
			label10.TabIndex = 4;
			label10.Text = "주문명";
			// 
			// txtAccount
			// 
			txtAccount.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
			txtAccount.Location = new Point(181, 26);
			txtAccount.Name = "txtAccount";
			txtAccount.Size = new Size(365, 39);
			txtAccount.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(15, 21);
			label2.Name = "label2";
			label2.Size = new Size(125, 47);
			label2.TabIndex = 0;
			label2.Text = "거래처";
			// 
			// tabPage2
			// 
			tabPage2.BackColor = Color.Gainsboro;
			tabPage2.Controls.Add(panel5);
			tabPage2.Location = new Point(4, 44);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1096, 623);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "주문내역";
			// 
			// panel5
			// 
			panel5.BackColor = Color.White;
			panel5.Controls.Add(button4);
			panel5.Controls.Add(button3);
			panel5.Controls.Add(dateTimePicker4);
			panel5.Controls.Add(label9);
			panel5.Controls.Add(dateTimePicker3);
			panel5.Controls.Add(label8);
			panel5.Controls.Add(dataGridView1);
			panel5.Location = new Point(6, 9);
			panel5.Name = "panel5";
			panel5.Size = new Size(1082, 606);
			panel5.TabIndex = 1;
			// 
			// button4
			// 
			button4.BackColor = Color.FromArgb(52, 152, 219);
			button4.FlatAppearance.BorderColor = Color.White;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
			button4.Location = new Point(879, 79);
			button4.Name = "button4";
			button4.Size = new Size(184, 46);
			button4.TabIndex = 20;
			button4.Text = "날짜로 보기";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.FromArgb(52, 152, 219);
			button3.FlatAppearance.BorderColor = Color.White;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
			button3.Location = new Point(879, 20);
			button3.Name = "button3";
			button3.Size = new Size(184, 46);
			button3.TabIndex = 19;
			button3.Text = "주문 전체 보기";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// dateTimePicker4
			// 
			dateTimePicker4.Location = new Point(463, 95);
			dateTimePicker4.Name = "dateTimePicker4";
			dateTimePicker4.Size = new Size(200, 23);
			dateTimePicker4.TabIndex = 18;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label9.Location = new Point(307, 88);
			label9.Name = "label9";
			label9.Size = new Size(152, 37);
			label9.TabIndex = 17;
			label9.Text = "마감일검색";
			// 
			// dateTimePicker3
			// 
			dateTimePicker3.Location = new Point(462, 35);
			dateTimePicker3.Name = "dateTimePicker3";
			dateTimePicker3.Size = new Size(200, 23);
			dateTimePicker3.TabIndex = 16;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label8.Location = new Point(304, 25);
			label8.Name = "label8";
			label8.Size = new Size(152, 37);
			label8.TabIndex = 15;
			label8.Text = "요청일검색";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.BackgroundColor = Color.White;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { order_item, order_count, order_start, order_end, order_send, order_account, order_status });
			dataGridView1.Dock = DockStyle.Bottom;
			dataGridView1.Location = new Point(0, 157);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(1082, 449);
			dataGridView1.TabIndex = 1;
			// 
			// txtOrderName
			// 
			txtOrderName.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
			txtOrderName.Location = new Point(726, 21);
			txtOrderName.Name = "txtOrderName";
			txtOrderName.Size = new Size(265, 39);
			txtOrderName.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(581, 16);
			label3.Name = "label3";
			label3.Size = new Size(125, 47);
			label3.TabIndex = 4;
			label3.Text = "주문명";
			// 
			// order_item
			// 
			order_item.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			order_item.HeaderText = "품명";
			order_item.Name = "order_item";
			order_item.ReadOnly = true;
			order_item.Width = 90;
			// 
			// order_count
			// 
			order_count.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			order_count.HeaderText = "갯수";
			order_count.Name = "order_count";
			order_count.ReadOnly = true;
			order_count.Width = 90;
			// 
			// order_start
			// 
			order_start.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			order_start.HeaderText = "요청일";
			order_start.Name = "order_start";
			order_start.ReadOnly = true;
			// 
			// order_end
			// 
			order_end.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			order_end.HeaderText = "마감일";
			order_end.Name = "order_end";
			order_end.ReadOnly = true;
			// 
			// order_send
			// 
			order_send.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			order_send.HeaderText = "출고일";
			order_send.Name = "order_send";
			order_send.ReadOnly = true;
			// 
			// order_account
			// 
			order_account.HeaderText = "거래처";
			order_account.Name = "order_account";
			order_account.ReadOnly = true;
			// 
			// order_status
			// 
			order_status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			order_status.HeaderText = "주문 상태";
			order_status.Name = "order_status";
			order_status.ReadOnly = true;
			order_status.Width = 120;
			// 
			// OrderForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1264, 761);
			Controls.Add(tabControl1);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "OrderForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "OrderForm";
			FormClosed += OrderForm_FormClosed;
			Load += OrderForm_Load;
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			tabPage2.ResumeLayout(false);
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private Label label1;
		private Panel panel1;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private Button btn_ChartForm;
		private Button btn_OrderForm;
		private Button btn_StockForm;
		private Button btn_TestForm;
		private Button btn_ProcessForm;
		private Button btn_LOTForm;
		private Panel panel3;
		private TextBox txtAccount;
		private Label label2;
		private Panel panel4;
		private Button button2;
		private Button button3;
		private Button button4;
		private Label label5;
		private Label label4;
		private Label label7;
		private Label label8;
		private Label label9;
		private ComboBox comboBox2;

		private Label label6;
		private ComboBox comboBox1;
		private DateTimePicker dateTimePicker2;
		private DateTimePicker dateTimePicker1;
		private DateTimePicker dateTimePicker3;
		private DateTimePicker dateTimePicker4;
		private Panel panel5;
		private DataGridView dataGridView1;
		private TextBox txtOrderName;
		private Label label3;
		private TextBox txtOrderCount;
		private TextBox textBox1;
		private Label label10;
		private DataGridViewTextBoxColumn order_item;
		private DataGridViewTextBoxColumn order_count;
		private DataGridViewTextBoxColumn order_start;
		private DataGridViewTextBoxColumn order_end;
		private DataGridViewTextBoxColumn order_send;
		private DataGridViewTextBoxColumn order_account;
		private DataGridViewTextBoxColumn order_status;
	}
}