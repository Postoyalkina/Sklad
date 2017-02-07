namespace WindowsFormsApplication3try
{
    partial class Form1
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
            this.AddP = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ShopBox = new System.Windows.Forms.TextBox();
            this.CoastBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SortN = new System.Windows.Forms.Button();
            this.SortSh = new System.Windows.Forms.Button();
            this.SortP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TextSearh = new System.Windows.Forms.TextBox();
            this.InfBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddP
            // 
            this.AddP.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddP.Location = new System.Drawing.Point(12, 90);
            this.AddP.Name = "AddP";
            this.AddP.Size = new System.Drawing.Size(211, 57);
            this.AddP.TabIndex = 0;
            this.AddP.Text = "Добавить продукт";
            this.AddP.UseVisualStyleBackColor = false;
            this.AddP.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(129, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(94, 20);
            this.NameBox.TabIndex = 1;
            // 
            // ShopBox
            // 
            this.ShopBox.Location = new System.Drawing.Point(129, 38);
            this.ShopBox.Name = "ShopBox";
            this.ShopBox.Size = new System.Drawing.Size(94, 20);
            this.ShopBox.TabIndex = 2;
            // 
            // CoastBox
            // 
            this.CoastBox.Location = new System.Drawing.Point(129, 64);
            this.CoastBox.Name = "CoastBox";
            this.CoastBox.Size = new System.Drawing.Size(94, 20);
            this.CoastBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название магазина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цена продукта";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(229, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(372, 135);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SortN
            // 
            this.SortN.Location = new System.Drawing.Point(12, 153);
            this.SortN.Name = "SortN";
            this.SortN.Size = new System.Drawing.Size(169, 29);
            this.SortN.TabIndex = 10;
            this.SortN.Text = "Сортировать по названию";
            this.SortN.UseVisualStyleBackColor = true;
            this.SortN.Click += new System.EventHandler(this.SortN_Click);
            // 
            // SortSh
            // 
            this.SortSh.Location = new System.Drawing.Point(12, 188);
            this.SortSh.Name = "SortSh";
            this.SortSh.Size = new System.Drawing.Size(169, 29);
            this.SortSh.TabIndex = 11;
            this.SortSh.Text = "Сортировать по магазину";
            this.SortSh.UseVisualStyleBackColor = true;
            this.SortSh.Click += new System.EventHandler(this.SortSh_Click);
            // 
            // SortP
            // 
            this.SortP.Location = new System.Drawing.Point(12, 223);
            this.SortP.Name = "SortP";
            this.SortP.Size = new System.Drawing.Size(169, 29);
            this.SortP.TabIndex = 12;
            this.SortP.Text = "Сортировать по цене";
            this.SortP.UseVisualStyleBackColor = true;
            this.SortP.Click += new System.EventHandler(this.SortP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(184, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Поиск товара по:";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Search.Location = new System.Drawing.Point(187, 173);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(105, 29);
            this.Search.TabIndex = 20;
            this.Search.Text = "Номеру";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(187, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 29);
            this.button3.TabIndex = 21;
            this.button3.Text = "Названию";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextSearh
            // 
            this.TextSearh.Location = new System.Drawing.Point(445, 173);
            this.TextSearh.Name = "TextSearh";
            this.TextSearh.Size = new System.Drawing.Size(94, 20);
            this.TextSearh.TabIndex = 22;
            // 
            // InfBox1
            // 
            this.InfBox1.Location = new System.Drawing.Point(301, 220);
            this.InfBox1.Multiline = true;
            this.InfBox1.Name = "InfBox1";
            this.InfBox1.Size = new System.Drawing.Size(299, 40);
            this.InfBox1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Введите значение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(383, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Информация о товаре";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(613, 272);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InfBox1);
            this.Controls.Add(this.TextSearh);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SortP);
            this.Controls.Add(this.SortSh);
            this.Controls.Add(this.SortN);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoastBox);
            this.Controls.Add(this.ShopBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AddP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddP;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox ShopBox;
        private System.Windows.Forms.TextBox CoastBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button SortN;
        private System.Windows.Forms.Button SortSh;
        private System.Windows.Forms.Button SortP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TextSearh;
        private System.Windows.Forms.TextBox InfBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

