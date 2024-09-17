namespace Actividad_Integradora_1._2
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
            dataGridView1 = new DataGridView();
            btnAgregarPersona = new Button();
            btnBorrarPersona = new Button();
            btnAgregarAuto = new Button();
            btnBorrarAuto = new Button();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(398, 245);
            dataGridView1.TabIndex = 0;
            // 
            // btnAgregarPersona
            // 
            btnAgregarPersona.Location = new Point(12, 263);
            btnAgregarPersona.Name = "btnAgregarPersona";
            btnAgregarPersona.Size = new Size(108, 23);
            btnAgregarPersona.TabIndex = 1;
            btnAgregarPersona.Text = "Agregar Persona";
            btnAgregarPersona.UseVisualStyleBackColor = true;
            btnAgregarPersona.Click += btnAgregar_Click;
            // 
            // btnBorrarPersona
            // 
            btnBorrarPersona.Location = new Point(12, 292);
            btnBorrarPersona.Name = "btnBorrarPersona";
            btnBorrarPersona.Size = new Size(108, 23);
            btnBorrarPersona.TabIndex = 2;
            btnBorrarPersona.Text = "Borrar Persona";
            btnBorrarPersona.UseVisualStyleBackColor = true;
            btnBorrarPersona.Click += btnBorrarPersona_Click;
            // 
            // btnAgregarAuto
            // 
            btnAgregarAuto.Location = new Point(416, 263);
            btnAgregarAuto.Name = "btnAgregarAuto";
            btnAgregarAuto.Size = new Size(108, 23);
            btnAgregarAuto.TabIndex = 3;
            btnAgregarAuto.Text = "Agregar Auto";
            btnAgregarAuto.UseVisualStyleBackColor = true;
            btnAgregarAuto.Click += btnAgregarAuto_Click;
            // 
            // btnBorrarAuto
            // 
            btnBorrarAuto.Location = new Point(416, 292);
            btnBorrarAuto.Name = "btnBorrarAuto";
            btnBorrarAuto.Size = new Size(108, 23);
            btnBorrarAuto.TabIndex = 4;
            btnBorrarAuto.Text = "Borrar Auto";
            btnBorrarAuto.UseVisualStyleBackColor = true;
            btnBorrarAuto.Click += btnBorrarAuto_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(416, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(398, 245);
            dataGridView2.TabIndex = 5;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(820, 12);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.Size = new Size(398, 245);
            dataGridView3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 427);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(btnBorrarAuto);
            Controls.Add(btnAgregarAuto);
            Controls.Add(btnBorrarPersona);
            Controls.Add(btnAgregarPersona);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregarPersona;
        private Button btnBorrarPersona;
        private Button btnAgregarAuto;
        private Button btnBorrarAuto;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
    }
}
