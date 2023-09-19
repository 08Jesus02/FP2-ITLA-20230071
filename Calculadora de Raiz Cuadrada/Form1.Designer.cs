namespace Calculadora_de_Raiz_Cuadrada
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
            texBox = new TextBox();
            btn1 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnRaizCuadrada = new Button();
            btn0 = new Button();
            btnCambioDeSigno = new Button();
            SuspendLayout();
            // 
            // texBox
            // 
            texBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            texBox.Location = new Point(12, 12);
            texBox.MaxLength = 20;
            texBox.Name = "texBox";
            texBox.RightToLeft = RightToLeft.No;
            texBox.Size = new Size(309, 43);
            texBox.TabIndex = 0;
            texBox.Text = "0";
            texBox.TextAlign = HorizontalAlignment.Right;
            texBox.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(16, 220);
            btn1.Name = "btn1";
            btn1.Size = new Size(69, 69);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(91, 145);
            btn5.Name = "btn5";
            btn5.Size = new Size(69, 69);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(16, 145);
            btn4.Name = "btn4";
            btn4.Size = new Size(69, 69);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(166, 220);
            btn3.Name = "btn3";
            btn3.Size = new Size(69, 69);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(91, 220);
            btn2.Name = "btn2";
            btn2.Size = new Size(69, 69);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(166, 145);
            btn6.Name = "btn6";
            btn6.Size = new Size(69, 69);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(16, 70);
            btn7.Name = "btn7";
            btn7.Size = new Size(69, 69);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(91, 70);
            btn8.Name = "btn8";
            btn8.Size = new Size(69, 69);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(166, 70);
            btn9.Name = "btn9";
            btn9.Size = new Size(69, 69);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRaizCuadrada.Location = new Point(241, 70);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new Size(69, 294);
            btnRaizCuadrada.TabIndex = 11;
            btnRaizCuadrada.Text = "√";
            btnRaizCuadrada.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(91, 295);
            btn0.Name = "btn0";
            btn0.Size = new Size(144, 69);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnCambioDeSigno
            // 
            btnCambioDeSigno.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCambioDeSigno.Location = new Point(16, 297);
            btnCambioDeSigno.Name = "btnCambioDeSigno";
            btnCambioDeSigno.Size = new Size(69, 69);
            btnCambioDeSigno.TabIndex = 14;
            btnCambioDeSigno.Text = "±";
            btnCambioDeSigno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 378);
            Controls.Add(btnCambioDeSigno);
            Controls.Add(btn0);
            Controls.Add(btnRaizCuadrada);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn1);
            Controls.Add(texBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texBox;
        private Button btn1;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnRaizCuadrada;
        private Button btn0;
        private Button btnCambioDeSigno;
    }
}