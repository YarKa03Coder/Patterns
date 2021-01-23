
namespace Patterns.Behavioral.Mediator.GUIExample
{
    partial class MainForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.TextSize = new System.Windows.Forms.NumericUpDown();
            this.TextSizeLabel = new System.Windows.Forms.Label();
            this.BoldButton = new System.Windows.Forms.RadioButton();
            this.ItalicButton = new System.Windows.Forms.RadioButton();
            this.StrikeoutButton = new System.Windows.Forms.RadioButton();
            this.UnderlineButton = new System.Windows.Forms.RadioButton();
            this.FontBox = new System.Windows.Forms.ComboBox();
            this.ReqularButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(482, 150);
            this.textBox.TabIndex = 0;
            // 
            // TextSize
            // 
            this.TextSize.Location = new System.Drawing.Point(71, 179);
            this.TextSize.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.TextSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TextSize.Name = "TextSize";
            this.TextSize.Size = new System.Drawing.Size(59, 22);
            this.TextSize.TabIndex = 1;
            this.TextSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TextSize.ValueChanged += new System.EventHandler(this.NumericButtonClicked);
            // 
            // TextSizeLabel
            // 
            this.TextSizeLabel.AutoSize = true;
            this.TextSizeLabel.Location = new System.Drawing.Point(15, 184);
            this.TextSizeLabel.Name = "TextSizeLabel";
            this.TextSizeLabel.Size = new System.Drawing.Size(35, 17);
            this.TextSizeLabel.TabIndex = 2;
            this.TextSizeLabel.Text = "Size";
            // 
            // BoldButton
            // 
            this.BoldButton.AutoSize = true;
            this.BoldButton.Location = new System.Drawing.Point(230, 182);
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(57, 21);
            this.BoldButton.TabIndex = 3;
            this.BoldButton.Text = "Bold";
            this.BoldButton.UseVisualStyleBackColor = true;
            this.BoldButton.CheckedChanged += new System.EventHandler(this.RadioButtonClicked);
            // 
            // ItalicButton
            // 
            this.ItalicButton.AutoSize = true;
            this.ItalicButton.Location = new System.Drawing.Point(230, 222);
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(57, 21);
            this.ItalicButton.TabIndex = 4;
            this.ItalicButton.Text = "Italic";
            this.ItalicButton.UseVisualStyleBackColor = true;
            this.ItalicButton.CheckedChanged += new System.EventHandler(this.RadioButtonClicked);
            // 
            // StrikeoutButton
            // 
            this.StrikeoutButton.AutoSize = true;
            this.StrikeoutButton.Location = new System.Drawing.Point(404, 184);
            this.StrikeoutButton.Name = "StrikeoutButton";
            this.StrikeoutButton.Size = new System.Drawing.Size(85, 21);
            this.StrikeoutButton.TabIndex = 5;
            this.StrikeoutButton.Text = "Strikeout";
            this.StrikeoutButton.UseVisualStyleBackColor = true;
            this.StrikeoutButton.CheckedChanged += new System.EventHandler(this.RadioButtonClicked);
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.AutoSize = true;
            this.UnderlineButton.Location = new System.Drawing.Point(404, 222);
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(90, 21);
            this.UnderlineButton.TabIndex = 6;
            this.UnderlineButton.Text = "Underline";
            this.UnderlineButton.UseVisualStyleBackColor = true;
            this.UnderlineButton.CheckedChanged += new System.EventHandler(this.RadioButtonClicked);
            // 
            // FontBox
            // 
            this.FontBox.FormattingEnabled = true;
            this.FontBox.Items.AddRange(new object[] {
            "Arial",
            "Cambria",
            "Microsoft Sans Serif",
            "Times New Roman"});
            this.FontBox.Location = new System.Drawing.Point(18, 223);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(162, 24);
            this.FontBox.TabIndex = 7;
            this.FontBox.Text = "Font";
            this.FontBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClicked);
            // 
            // ReqularButton
            // 
            this.ReqularButton.AutoSize = true;
            this.ReqularButton.Location = new System.Drawing.Point(304, 201);
            this.ReqularButton.Name = "ReqularButton";
            this.ReqularButton.Size = new System.Drawing.Size(79, 21);
            this.ReqularButton.TabIndex = 8;
            this.ReqularButton.Text = "Reqular";
            this.ReqularButton.UseVisualStyleBackColor = true;
            this.ReqularButton.CheckedChanged += new System.EventHandler(this.RadioButtonClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 269);
            this.Controls.Add(this.ReqularButton);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.UnderlineButton);
            this.Controls.Add(this.StrikeoutButton);
            this.Controls.Add(this.ItalicButton);
            this.Controls.Add(this.BoldButton);
            this.Controls.Add(this.TextSizeLabel);
            this.Controls.Add(this.TextSize);
            this.Controls.Add(this.textBox);
            this.Name = "MainForm";
            this.Text = "Mediator";
            ((System.ComponentModel.ISupportInitialize)(this.TextSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextSizeLabel;
        public System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RadioButton StrikeoutButton;
        private System.Windows.Forms.RadioButton UnderlineButton;
        private System.Windows.Forms.RadioButton ItalicButton;
        private System.Windows.Forms.RadioButton BoldButton;
        private System.Windows.Forms.RadioButton ReqularButton;
        private System.Windows.Forms.ComboBox FontBox;
        private System.Windows.Forms.NumericUpDown TextSize;
    }
}

