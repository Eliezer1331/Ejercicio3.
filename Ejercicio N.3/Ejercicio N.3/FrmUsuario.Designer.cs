using System;

namespace Ejercicio_N._3
{
    partial class FrmUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.RegistrarseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(96, 101);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(141, 20);
            this.NombreTextBox.TabIndex = 1;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(96, 69);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(141, 20);
            this.CodigoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(96, 135);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(141, 20);
            this.ApellidoTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña:";
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Location = new System.Drawing.Point(96, 164);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.PasswordChar = '*';
            this.ContraseñaTextBox.Size = new System.Drawing.Size(141, 20);
            this.ContraseñaTextBox.TabIndex = 7;
            // 
            // RegistrarseButton
            // 
            this.RegistrarseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RegistrarseButton.Location = new System.Drawing.Point(33, 206);
            this.RegistrarseButton.Name = "RegistrarseButton";
            this.RegistrarseButton.Size = new System.Drawing.Size(75, 23);
            this.RegistrarseButton.TabIndex = 8;
            this.RegistrarseButton.Text = "Registrarse";
            this.RegistrarseButton.UseVisualStyleBackColor = false;
            this.RegistrarseButton.Click += new System.EventHandler(this.RegistrarseButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Registrarse:";
            // 
            // FrmUsuario
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 275);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegistrarseButton);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.Button RegistrarseButton;
        private System.Windows.Forms.Label label5;
    }
}