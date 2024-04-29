namespace Archivos_de_Acceso_Directo
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.numIndex = new System.Windows.Forms.NumericUpDown();
            this.txtInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(107, 159);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "button1";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(269, 151);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(87, 39);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "button2";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 151);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "button3";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(574, 151);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(87, 39);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "button4";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(81, 234);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(35, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "label1";
            // 
            // numIndex
            // 
            this.numIndex.Location = new System.Drawing.Point(609, 53);
            this.numIndex.Name = "numIndex";
            this.numIndex.Size = new System.Drawing.Size(120, 20);
            this.numIndex.TabIndex = 5;
            this.numIndex.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(207, 52);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(350, 20);
            this.txtInput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.numIndex);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.NumericUpDown numIndex;
        private System.Windows.Forms.TextBox txtInput;
    }
}

