namespace Dados_Karina
{
    partial class Form1
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
            this.btnLanzar1 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnLanzar100 = new System.Windows.Forms.Button();
            this.btn2Dados = new System.Windows.Forms.Button();
            this.btnLanzar200 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLanzar1
            // 
            this.btnLanzar1.Location = new System.Drawing.Point(175, 31);
            this.btnLanzar1.Name = "btnLanzar1";
            this.btnLanzar1.Size = new System.Drawing.Size(91, 23);
            this.btnLanzar1.TabIndex = 0;
            this.btnLanzar1.Text = "Lanzar dado";
            this.btnLanzar1.UseVisualStyleBackColor = true;
            this.btnLanzar1.Click += new System.EventHandler(this.btnLanzar1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 31);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(147, 206);
            this.txtResultado.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(175, 118);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar lista";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnLanzar100
            // 
            this.btnLanzar100.Location = new System.Drawing.Point(175, 60);
            this.btnLanzar100.Name = "btnLanzar100";
            this.btnLanzar100.Size = new System.Drawing.Size(91, 23);
            this.btnLanzar100.TabIndex = 3;
            this.btnLanzar100.Text = "Lanzar 100";
            this.btnLanzar100.UseVisualStyleBackColor = true;
            this.btnLanzar100.Click += new System.EventHandler(this.btnLanzar100_Click);
            // 
            // btn2Dados
            // 
            this.btn2Dados.Location = new System.Drawing.Point(175, 89);
            this.btn2Dados.Name = "btn2Dados";
            this.btn2Dados.Size = new System.Drawing.Size(91, 23);
            this.btn2Dados.TabIndex = 4;
            this.btn2Dados.Text = "Lanzar 2 dados";
            this.btn2Dados.UseVisualStyleBackColor = true;
            this.btn2Dados.Click += new System.EventHandler(this.btn2Dados_Click);
            // 
            // btnLanzar200
            // 
            this.btnLanzar200.Location = new System.Drawing.Point(175, 147);
            this.btnLanzar200.Name = "btnLanzar200";
            this.btnLanzar200.Size = new System.Drawing.Size(91, 23);
            this.btnLanzar200.TabIndex = 5;
            this.btnLanzar200.Text = "Lanzar 200";
            this.btnLanzar200.UseVisualStyleBackColor = true;
            this.btnLanzar200.Click += new System.EventHandler(this.btnLanzar200_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 259);
            this.Controls.Add(this.btnLanzar200);
            this.Controls.Add(this.btn2Dados);
            this.Controls.Add(this.btnLanzar100);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnLanzar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLanzar1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnLanzar100;
        private System.Windows.Forms.Button btn2Dados;
        private System.Windows.Forms.Button btnLanzar200;
    }
}

