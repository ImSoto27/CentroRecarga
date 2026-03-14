namespace PRESENTACION
{
    partial class AgregarRecarga
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "VN";
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(274, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(346, 109);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Vendedor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(338, 163);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Operadora";
            // 
            // comboBox2
            // 
            comboBox2.AccessibleName = "OP";
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(274, 186);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(217, 28);
            comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(338, 273);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 4;
            label3.Text = "Monto(RD$)";
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "MN";
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(287, 296);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(317, 77);
            label4.MaximumSize = new Size(150, 70);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 6;
            label4.Text = "Agregar Recargas";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(231, 367);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(438, 367);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(348, 217);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 9;
            label5.Text = "Numero";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox1.Location = new Point(287, 240);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(191, 27);
            maskedTextBox1.TabIndex = 11;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // AgregarRecarga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "AgregarRecarga";
            Text = "AgregarRecarga";
            Load += AgregarRecarga_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
    }
}