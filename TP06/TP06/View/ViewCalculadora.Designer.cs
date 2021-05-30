
using System.Windows.Forms;
using TP06.Controller;

namespace TP06
{
    partial class ViewCalculadora
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
            this.pantalla = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(21, 25);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(187, 23);
            this.pantalla.TabIndex = 0;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(214, 25);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(58, 23);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(21, 54);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(59, 57);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNro_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(86, 54);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(58, 57);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNro_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(150, 54);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(58, 57);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNro_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(150, 117);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(58, 57);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNro_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(86, 117);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(58, 57);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNro_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(21, 117);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(59, 57);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNro_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(150, 180);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(58, 57);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNro_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(86, 180);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(58, 57);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNro_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(21, 180);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(59, 57);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNro_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(150, 243);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(58, 57);
            this.btnIgual.TabIndex = 13;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(86, 243);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(58, 57);
            this.btnPunto.TabIndex = 12;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(21, 243);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(59, 57);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNro_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(214, 243);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(58, 57);
            this.btnDivision.TabIndex = 17;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(214, 180);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(58, 57);
            this.btnProducto.TabIndex = 16;
            this.btnProducto.Text = "*";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(214, 117);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(58, 57);
            this.btnResta.TabIndex = 15;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(214, 54);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(58, 57);
            this.btnSuma.TabIndex = 14;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // ViewCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 326);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.pantalla);
            this.Name = "ViewCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;

        public TextBox Pantalla { get => pantalla; set => pantalla = value; }
        public Button BtnC { get => btnC; set => btnC = value; }
        public Button Btn7 { get => btn7; set => btn7 = value; }
        public Button Btn8 { get => btn8; set => btn8 = value; }
        public Button Btn9 { get => btn9; set => btn9 = value; }
        public Button Btn6 { get => btn6; set => btn6 = value; }
        public Button Btn5 { get => btn5; set => btn5 = value; }
        public Button Btn4 { get => btn4; set => btn4 = value; }
        public Button Btn3 { get => btn3; set => btn3 = value; }
        public Button Btn2 { get => btn2; set => btn2 = value; }
        public Button Btn1 { get => btn1; set => btn1 = value; }
        public Button BtnIgual { get => btnIgual; set => btnIgual = value; }
        public Button BtnPunto { get => btnPunto; set => btnPunto = value; }
        public Button Btn0 { get => btn0; set => btn0 = value; }
        public Button BtnDivision { get => btnDivision; set => btnDivision = value; }
        public Button BtnProducto { get => btnProducto; set => btnProducto = value; }
        public Button BtnResta { get => btnResta; set => btnResta = value; }
        public Button BtnSuma { get => btnSuma; set => btnSuma = value; }
    }
}

