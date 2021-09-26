
namespace Practica240921
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(28, 103);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(146, 22);
            this.tbId.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(198, 103);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 22);
            this.tbName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(28, 171);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(142, 22);
            this.tbLastName.TabIndex = 2;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(191, 171);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(153, 22);
            this.tbAge.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(28, 80);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(87, 17);
            this.txtId.TabIndex = 4;
            this.txtId.Text = "Ingrese el ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese el apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese la edad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.Location = new System.Drawing.Point(31, 31);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(221, 17);
            this.txtInfo.TabIndex = 8;
            this.txtInfo.Text = "Ingrese los datos de el estudiante";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(368, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 35);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Ingresar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(28, 270);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(540, 228);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 547);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtInfo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

