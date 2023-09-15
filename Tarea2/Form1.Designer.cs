namespace FacFibMCD 
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radioButtonFactorial = new System.Windows.Forms.RadioButton();
            this.radioButtonFibonacci = new System.Windows.Forms.RadioButton();
            this.radioButtonMCD = new System.Windows.Forms.RadioButton();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.labelNumero1 = new System.Windows.Forms.Label();
            this.labelNumero2 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // radioButtonFactorial
            this.radioButtonFactorial.AutoSize = true;
            this.radioButtonFactorial.Location = new System.Drawing.Point(50, 60);
            this.radioButtonFactorial.Name = "radioButtonFactorial";
            this.radioButtonFactorial.Size = new System.Drawing.Size(65, 17);
            this.radioButtonFactorial.Text = "Factorial";
            this.radioButtonFactorial.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);

            // radioButtonFibonacci
            this.radioButtonFibonacci.AutoSize = true;
            this.radioButtonFibonacci.Location = new System.Drawing.Point(150, 60);
            this.radioButtonFibonacci.Name = "radioButtonFibonacci";
            this.radioButtonFibonacci.Size = new System.Drawing.Size(77, 17);
            this.radioButtonFibonacci.Text = "Fibonacci";
            this.radioButtonFibonacci.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);

            // radioButtonMCD
            this.radioButtonMCD.AutoSize = true;
            this.radioButtonMCD.Location = new System.Drawing.Point(250, 60);
            this.radioButtonMCD.Name = "radioButtonMCD";
            this.radioButtonMCD.Size = new System.Drawing.Size(52, 17);
            this.radioButtonMCD.Text = "MCD";
            this.radioButtonMCD.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);

            // buttonCalcular
            this.buttonCalcular.Location = new System.Drawing.Point(350, 190);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(100, 30);
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);

            // textBoxNumero
            this.textBoxNumero.Location = new System.Drawing.Point(200, 90);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);

            // labelNumero
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(50, 93);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(143, 13);
            this.labelNumero.Text = "Ingrese un número entero:";

            // textBoxNumero1
            this.textBoxNumero1.Location = new System.Drawing.Point(200, 130);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(100, 20);

            // textBoxNumero2
            this.textBoxNumero2.Location = new System.Drawing.Point(200, 170);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(100, 20);

            // labelNumero1
            this.labelNumero1.AutoSize = true;
            this.labelNumero1.Location = new System.Drawing.Point(50, 133);
            this.labelNumero1.Name = "labelNumero1";
            this.labelNumero1.Size = new System.Drawing.Size(134, 13);
            this.labelNumero1.Text = "Ingrese el primer número:";

            // labelNumero2
            this.labelNumero2.AutoSize = true;
            this.labelNumero2.Location = new System.Drawing.Point(50, 173);
            this.labelNumero2.Name = "labelNumero2";
            this.labelNumero2.Size = new System.Drawing.Size(139, 13);
            this.labelNumero2.Text = "Ingrese el segundo número:";

            // labelTitulo
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(50, 10);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(272, 20);
            this.labelTitulo.Text = "Bienvenido ¿Qué desea calcular?";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelNumero2);
            this.Controls.Add(this.labelNumero1);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.radioButtonMCD);
            this.Controls.Add(this.radioButtonFibonacci);
            this.Controls.Add(this.radioButtonFactorial);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton radioButtonFactorial;
        private System.Windows.Forms.RadioButton radioButtonFibonacci;
        private System.Windows.Forms.RadioButton radioButtonMCD;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Label labelNumero1;
        private System.Windows.Forms.Label labelNumero2;
        private System.Windows.Forms.Label labelTitulo;
    }
}
