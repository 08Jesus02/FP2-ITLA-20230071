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
            txtCuadro = new TextBox();
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
            btnPunto = new Button();
            btnBorrarUno = new Button();
            btnBorrarTodo = new Button();
            SuspendLayout();
            // 
            // txtCuadro
            // 
            txtCuadro.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuadro.Location = new Point(12, 12);
            txtCuadro.MaxLength = 20;
            txtCuadro.Multiline = true;
            txtCuadro.Name = "txtCuadro";
            txtCuadro.RightToLeft = RightToLeft.No;
            txtCuadro.Size = new Size(309, 48);
            txtCuadro.TabIndex = 0;
            txtCuadro.Text = "0";
            txtCuadro.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(20, 222);
            btn1.Name = "btn1";
            btn1.Size = new Size(69, 69);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += agregarNumero;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(95, 147);
            btn5.Name = "btn5";
            btn5.Size = new Size(69, 69);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += agregarNumero;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(20, 147);
            btn4.Name = "btn4";
            btn4.Size = new Size(69, 69);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += agregarNumero;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(170, 222);
            btn3.Name = "btn3";
            btn3.Size = new Size(69, 69);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += agregarNumero;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(95, 222);
            btn2.Name = "btn2";
            btn2.Size = new Size(69, 69);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += agregarNumero;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(170, 147);
            btn6.Name = "btn6";
            btn6.Size = new Size(69, 69);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += agregarNumero;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(20, 72);
            btn7.Name = "btn7";
            btn7.Size = new Size(69, 69);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += agregarNumero;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(95, 72);
            btn8.Name = "btn8";
            btn8.Size = new Size(69, 69);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += agregarNumero;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(170, 72);
            btn9.Name = "btn9";
            btn9.Size = new Size(69, 69);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += agregarNumero;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRaizCuadrada.Location = new Point(245, 222);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new Size(69, 144);
            btnRaizCuadrada.TabIndex = 11;
            btnRaizCuadrada.Text = "√";
            btnRaizCuadrada.UseVisualStyleBackColor = true;
            btnRaizCuadrada.Click += btnRaizCuadrada_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(95, 297);
            btn0.Name = "btn0";
            btn0.Size = new Size(69, 69);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += agregarNumero;
            // 
            // btnCambioDeSigno
            // 
            btnCambioDeSigno.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCambioDeSigno.Location = new Point(20, 297);
            btnCambioDeSigno.Name = "btnCambioDeSigno";
            btnCambioDeSigno.Size = new Size(69, 69);
            btnCambioDeSigno.TabIndex = 14;
            btnCambioDeSigno.Text = "±";
            btnCambioDeSigno.UseVisualStyleBackColor = true;
            btnCambioDeSigno.Click += btnCambioDeSigno_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPunto.Location = new Point(170, 297);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(69, 69);
            btnPunto.TabIndex = 15;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnBorrarUno
            // 
            btnBorrarUno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrarUno.Location = new Point(245, 72);
            btnBorrarUno.Name = "btnBorrarUno";
            btnBorrarUno.Size = new Size(69, 69);
            btnBorrarUno.TabIndex = 16;
            btnBorrarUno.Text = "<-";
            btnBorrarUno.UseVisualStyleBackColor = true;
            btnBorrarUno.Click += btnBorrarUno_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrarTodo.Location = new Point(245, 147);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(69, 69);
            btnBorrarTodo.TabIndex = 17;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 378);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnBorrarUno);
            Controls.Add(btnPunto);
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
            Controls.Add(txtCuadro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCuadro;
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
        private Button btnPunto;
        private Button btnBorrarUno;
        private Button btnBorrarTodo;
    }
}