namespace AppCalculadora
{
    partial class FormCalculadora
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
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.btSum = new System.Windows.Forms.Button();
            this.btRest = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btNum7 = new System.Windows.Forms.Button();
            this.btNum8 = new System.Windows.Forms.Button();
            this.btNum9 = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btNum4 = new System.Windows.Forms.Button();
            this.btNum5 = new System.Windows.Forms.Button();
            this.btNum6 = new System.Windows.Forms.Button();
            this.btNum1 = new System.Windows.Forms.Button();
            this.btNum2 = new System.Windows.Forms.Button();
            this.btNum3 = new System.Windows.Forms.Button();
            this.btNum0 = new System.Windows.Forms.Button();
            this.btPunto = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPantalla
            // 
            this.txtPantalla.BackColor = System.Drawing.Color.White;
            this.txtPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.Location = new System.Drawing.Point(5, 5);
            this.txtPantalla.Multiline = true;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(258, 74);
            this.txtPantalla.TabIndex = 0;
            this.txtPantalla.Text = "0";
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPantalla.WordWrap = false;
            // 
            // btSum
            // 
            this.btSum.BackColor = System.Drawing.Color.RoyalBlue;
            this.btSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSum.ForeColor = System.Drawing.Color.White;
            this.btSum.Location = new System.Drawing.Point(5, 85);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(60, 60);
            this.btSum.TabIndex = 1;
            this.btSum.Text = "+";
            this.btSum.UseVisualStyleBackColor = false;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // btRest
            // 
            this.btRest.BackColor = System.Drawing.Color.RoyalBlue;
            this.btRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRest.ForeColor = System.Drawing.Color.White;
            this.btRest.Location = new System.Drawing.Point(71, 85);
            this.btRest.Name = "btRest";
            this.btRest.Size = new System.Drawing.Size(60, 60);
            this.btRest.TabIndex = 2;
            this.btRest.Text = "-";
            this.btRest.UseVisualStyleBackColor = false;
            this.btRest.Click += new System.EventHandler(this.btRest_Click);
            // 
            // btMult
            // 
            this.btMult.BackColor = System.Drawing.Color.RoyalBlue;
            this.btMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMult.ForeColor = System.Drawing.Color.White;
            this.btMult.Location = new System.Drawing.Point(137, 85);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(60, 60);
            this.btMult.TabIndex = 3;
            this.btMult.Text = "x";
            this.btMult.UseVisualStyleBackColor = false;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btDiv
            // 
            this.btDiv.BackColor = System.Drawing.Color.RoyalBlue;
            this.btDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.ForeColor = System.Drawing.Color.White;
            this.btDiv.Location = new System.Drawing.Point(203, 85);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(60, 60);
            this.btDiv.TabIndex = 4;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = false;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btNum7
            // 
            this.btNum7.BackColor = System.Drawing.Color.RoyalBlue;
            this.btNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNum7.ForeColor = System.Drawing.Color.White;
            this.btNum7.Location = new System.Drawing.Point(5, 151);
            this.btNum7.Name = "btNum7";
            this.btNum7.Size = new System.Drawing.Size(60, 60);
            this.btNum7.TabIndex = 5;
            this.btNum7.Text = "7";
            this.btNum7.UseVisualStyleBackColor = false;
            this.btNum7.Click += new System.EventHandler(this.btNum7_Click);
            // 
            // btNum8
            // 
            this.btNum8.BackColor = System.Drawing.Color.RoyalBlue;
            this.btNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNum8.ForeColor = System.Drawing.Color.White;
            this.btNum8.Location = new System.Drawing.Point(71, 151);
            this.btNum8.Name = "btNum8";
            this.btNum8.Size = new System.Drawing.Size(60, 60);
            this.btNum8.TabIndex = 6;
            this.btNum8.Text = "8";
            this.btNum8.UseVisualStyleBackColor = false;
            this.btNum8.Click += new System.EventHandler(this.btNum8_Click);
            // 
            // btNum9
            // 
            this.btNum9.BackColor = System.Drawing.Color.RoyalBlue;
            this.btNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNum9.ForeColor = System.Drawing.Color.White;
            this.btNum9.Location = new System.Drawing.Point(137, 151);
            this.btNum9.Name = "btNum9";
            this.btNum9.Size = new System.Drawing.Size(60, 60);
            this.btNum9.TabIndex = 7;
            this.btNum9.Text = "9";
            this.btNum9.UseVisualStyleBackColor = false;
            this.btNum9.Click += new System.EventHandler(this.btNum9_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.White;
            this.btClear.Location = new System.Drawing.Point(203, 151);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(60, 126);
            this.btClear.TabIndex = 8;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btNum4
            // 
            this.btNum4.BackColor = System.Drawing.Color.RoyalBlue;
            this.btNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNum4.ForeColor = System.Drawing.Color.White;
            this.btNum4.Location = new System.Drawing.Point(5, 217);
            this.btNum4.Name = "btNum4";
            this.btNum4.Size = new System.Drawing.Size(60, 60);
            this.btNum4.TabIndex = 9;
            this.btNum4.Text = "4";
            this.btNum4.UseVisualStyleBackColor = false;
            this.btNum4.Click += new System.EventHandler(this.btNum4_Click);
            // 
            // btNum5
            // 
            this.btNum5.BackColor = System.Drawing.Color.RoyalBlue;
            this.btNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNum5.ForeColor = System.Drawing.Color.White;
            this.btNum5.Location = new System.Drawing.Point(71, 217);
            this.btNum5.Name = "btNum5";
            this.btNum5.Size = new System.Drawing.Size(60, 60);
            this.btNum5.TabIndex = 10;
            this.btNum5.Text = "5";
            this.btNum5.UseVisualStyleBackColor = false;
            this.btNum5.Click += new System.EventHandler(this.btNum5_Click);
            // 
            // btNum6
            // 
            this.btNum6.BackColor = System.Drawing.Color.RoyalBlue;
            this.btNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNum6.ForeColor = System.Drawing.Color.White;
            this.btNum6.Location = new System.Drawing.Point(137, 217);
            this.btNum6.Name = "btNum6";
            this.btNum6.Size = new System.Drawing.Size(60, 60);
            this.btNum6.TabIndex = 11;
            this.btNum6.Text = "6";
            this.btNum6.UseVisualStyleBackColor = false;
            this.btNum6.Click += new System.EventHandler(this.btNum6_Click);
            // 
            // btNum1
            // 
            this.btNum1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNum1.ForeColor = System.Drawing.Color.White;
            this.btNum1.Location = new System.Drawing.Point(5, 283);
            this.btNum1.Name = "btNum1";
            this.btNum1.Size = new System.Drawing.Size(60, 60);
            this.btNum1.TabIndex = 13;
            this.btNum1.Text = "1";
            this.btNum1.UseVisualStyleBackColor = false;
            this.btNum1.Click += new System.EventHandler(this.btNum1_Click);
            // 
            // btNum2
            // 
            this.btNum2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNum2.ForeColor = System.Drawing.Color.White;
            this.btNum2.Location = new System.Drawing.Point(71, 283);
            this.btNum2.Name = "btNum2";
            this.btNum2.Size = new System.Drawing.Size(60, 60);
            this.btNum2.TabIndex = 14;
            this.btNum2.Text = "2";
            this.btNum2.UseVisualStyleBackColor = false;
            this.btNum2.Click += new System.EventHandler(this.btNum2_Click);
            // 
            // btNum3
            // 
            this.btNum3.BackColor = System.Drawing.Color.RoyalBlue;
            this.btNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNum3.ForeColor = System.Drawing.Color.White;
            this.btNum3.Location = new System.Drawing.Point(137, 283);
            this.btNum3.Name = "btNum3";
            this.btNum3.Size = new System.Drawing.Size(60, 60);
            this.btNum3.TabIndex = 15;
            this.btNum3.Text = "3";
            this.btNum3.UseVisualStyleBackColor = false;
            this.btNum3.Click += new System.EventHandler(this.btNum3_Click);
            // 
            // btNum0
            // 
            this.btNum0.BackColor = System.Drawing.Color.RoyalBlue;
            this.btNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNum0.ForeColor = System.Drawing.Color.White;
            this.btNum0.Location = new System.Drawing.Point(5, 349);
            this.btNum0.Name = "btNum0";
            this.btNum0.Size = new System.Drawing.Size(126, 60);
            this.btNum0.TabIndex = 17;
            this.btNum0.Text = "0";
            this.btNum0.UseVisualStyleBackColor = false;
            this.btNum0.Click += new System.EventHandler(this.btNum0_Click);
            // 
            // btPunto
            // 
            this.btPunto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPunto.ForeColor = System.Drawing.Color.White;
            this.btPunto.Location = new System.Drawing.Point(137, 349);
            this.btPunto.Name = "btPunto";
            this.btPunto.Size = new System.Drawing.Size(60, 60);
            this.btPunto.TabIndex = 18;
            this.btPunto.Text = ".";
            this.btPunto.UseVisualStyleBackColor = false;
            this.btPunto.Click += new System.EventHandler(this.btPunto_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.Color.Tomato;
            this.btIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.ForeColor = System.Drawing.Color.White;
            this.btIgual.Location = new System.Drawing.Point(203, 283);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(60, 126);
            this.btIgual.TabIndex = 20;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(5, 5);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultados.Size = new System.Drawing.Size(258, 404);
            this.txtResultados.TabIndex = 21;
            this.txtResultados.Visible = false;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 415);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btPunto);
            this.Controls.Add(this.btNum0);
            this.Controls.Add(this.btNum3);
            this.Controls.Add(this.btNum2);
            this.Controls.Add(this.btNum1);
            this.Controls.Add(this.btNum6);
            this.Controls.Add(this.btNum5);
            this.Controls.Add(this.btNum4);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btNum9);
            this.Controls.Add(this.btNum8);
            this.Controls.Add(this.btNum7);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btRest);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.txtPantalla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.Button btRest;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btNum7;
        private System.Windows.Forms.Button btNum8;
        private System.Windows.Forms.Button btNum9;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btNum4;
        private System.Windows.Forms.Button btNum5;
        private System.Windows.Forms.Button btNum6;
        private System.Windows.Forms.Button btNum1;
        private System.Windows.Forms.Button btNum2;
        private System.Windows.Forms.Button btNum3;
        private System.Windows.Forms.Button btNum0;
        private System.Windows.Forms.Button btPunto;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.TextBox txtResultados;
    }
}

