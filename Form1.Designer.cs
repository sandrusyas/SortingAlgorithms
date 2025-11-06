namespace SortNumbers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown_SelectQuantity = new NumericUpDown();
            comboBox_SelectAlgorithm = new ComboBox();
            button_MakeArray = new Button();
            button_Sort = new Button();
            panel_ShowProcess = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox_NumbersBefore = new TextBox();
            textBox_NumbersAfter = new TextBox();
            button_Clear = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_SelectQuantity).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown_SelectQuantity
            // 
            numericUpDown_SelectQuantity.Location = new Point(35, 38);
            numericUpDown_SelectQuantity.Name = "numericUpDown_SelectQuantity";
            numericUpDown_SelectQuantity.Size = new Size(150, 27);
            numericUpDown_SelectQuantity.TabIndex = 0;
            numericUpDown_SelectQuantity.ValueChanged += NumericUpDown_SelectQuantity_ValueChanged;
            // 
            // comboBox_SelectAlgorithm
            // 
            comboBox_SelectAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_SelectAlgorithm.FormattingEnabled = true;
            comboBox_SelectAlgorithm.Items.AddRange(new object[] { "Bubble sort", "Selection sort", "Shuttle sort" });
            comboBox_SelectAlgorithm.Location = new Point(249, 38);
            comboBox_SelectAlgorithm.Name = "comboBox_SelectAlgorithm";
            comboBox_SelectAlgorithm.Size = new Size(151, 28);
            comboBox_SelectAlgorithm.TabIndex = 1;
            comboBox_SelectAlgorithm.SelectedIndexChanged += ComboBox_SelectAlgorithm_SelectedIndexChanged;
            // 
            // button_MakeArray
            // 
            button_MakeArray.Location = new Point(35, 140);
            button_MakeArray.Name = "button_MakeArray";
            button_MakeArray.Size = new Size(157, 29);
            button_MakeArray.TabIndex = 2;
            button_MakeArray.Text = "Generate array";
            button_MakeArray.UseVisualStyleBackColor = true;
            button_MakeArray.Click += button_MakeArray_Click;
            // 
            // button_Sort
            // 
            button_Sort.Location = new Point(205, 140);
            button_Sort.Name = "button_Sort";
            button_Sort.Size = new Size(94, 29);
            button_Sort.TabIndex = 3;
            button_Sort.Text = "Sort";
            button_Sort.UseVisualStyleBackColor = true;
            button_Sort.Click += button_Sort_Click;
            // 
            // panel_ShowProcess
            // 
            panel_ShowProcess.Location = new Point(34, 175);
            panel_ShowProcess.Name = "panel_ShowProcess";
            panel_ShowProcess.Size = new Size(1026, 293);
            panel_ShowProcess.TabIndex = 4;
            panel_ShowProcess.BackColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 5;
            label1.Text = "Вкажіть розмір вибірки:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 9);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 6;
            label2.Text = "Оберіть алгоритм";
            // 
            // textBox_NumbersBefore
            // 
            textBox_NumbersBefore.Location = new Point(35, 102);
            textBox_NumbersBefore.Name = "textBox_NumbersBefore";
            textBox_NumbersBefore.Size = new Size(758, 27);
            textBox_NumbersBefore.TabIndex = 7;
            // 
            // textBox_NumbersAfter
            // 
            textBox_NumbersAfter.Location = new Point(34, 485);
            textBox_NumbersAfter.Name = "textBox_NumbersAfter";
            textBox_NumbersAfter.ReadOnly = true;
            textBox_NumbersAfter.Size = new Size(759, 27);
            textBox_NumbersAfter.TabIndex = 8;
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(306, 140);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(94, 29);
            button_Clear.TabIndex = 9;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 79);
            label3.Name = "label3";
            label3.Size = new Size(264, 20);
            label3.TabIndex = 10;
            label3.Text = "Вкажіть набір чисел для сортування:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 534);
            Controls.Add(label3);
            Controls.Add(button_Clear);
            Controls.Add(textBox_NumbersAfter);
            Controls.Add(textBox_NumbersBefore);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel_ShowProcess);
            Controls.Add(button_Sort);
            Controls.Add(button_MakeArray);
            Controls.Add(comboBox_SelectAlgorithm);
            Controls.Add(numericUpDown_SelectQuantity);
            Name = "Form1";
            Text = "Алгоритми сортування";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_SelectQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown_SelectQuantity;
        private ComboBox comboBox_SelectAlgorithm;
        private Button button_MakeArray;
        private Button button_Sort;
        private Panel panel_ShowProcess;
        private Label label1;
        private Label label2;
        private TextBox textBox_NumbersBefore;
        private TextBox textBox_NumbersAfter;
        private Button button_Clear;
        private Label label3;
    }
}
