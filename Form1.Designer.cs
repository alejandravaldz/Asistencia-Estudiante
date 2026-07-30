namespace Asistencia_Estudiante
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
            label1 = new Label();
            cmb_Asistencia = new ComboBox();
            txt_Nombre = new TextBox();
            lbl_Nombre = new Label();
            lbl_Asistencia = new Label();
            btn_Agregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 24);
            label1.Name = "label1";
            label1.Size = new Size(239, 32);
            label1.TabIndex = 0;
            label1.Text = "Control de Asistencia";
            label1.Click += label1_Click;
            // 
            // cmb_Asistencia
            // 
            cmb_Asistencia.FormattingEnabled = true;
            cmb_Asistencia.Location = new Point(382, 283);
            cmb_Asistencia.Name = "cmb_Asistencia";
            cmb_Asistencia.Size = new Size(242, 40);
            cmb_Asistencia.TabIndex = 1;
            cmb_Asistencia.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(382, 191);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(200, 39);
            txt_Nombre.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(254, 194);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(102, 32);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Asistencia
            // 
            lbl_Asistencia.AutoSize = true;
            lbl_Asistencia.Location = new Point(254, 283);
            lbl_Asistencia.Name = "lbl_Asistencia";
            lbl_Asistencia.Size = new Size(119, 32);
            lbl_Asistencia.TabIndex = 4;
            lbl_Asistencia.Text = "Asistencia";
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(794, 180);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(150, 46);
            btn_Agregar.TabIndex = 5;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 467);
            Controls.Add(btn_Agregar);
            Controls.Add(lbl_Asistencia);
            Controls.Add(lbl_Nombre);
            Controls.Add(txt_Nombre);
            Controls.Add(cmb_Asistencia);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmb_Asistencia;
        private TextBox txt_Nombre;
        private Label lbl_Nombre;
        private Label lbl_Asistencia;
        private Button btn_Agregar;
    }
}
