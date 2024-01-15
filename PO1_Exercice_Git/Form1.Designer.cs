namespace PO1_Exercice_Git
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
            button_Somme = new Button();
            button_PlusGrand = new Button();
            button_TestPremier = new Button();
            textBox_Nombre = new TextBox();
            SuspendLayout();
            // 
            // button_Somme
            // 
            button_Somme.Location = new Point(12, 12);
            button_Somme.Name = "button_Somme";
            button_Somme.Size = new Size(171, 29);
            button_Somme.TabIndex = 0;
            button_Somme.Text = "Somme";
            button_Somme.UseVisualStyleBackColor = true;
            button_Somme.Click += button_Somme_Click;
            // 
            // button_PlusGrand
            // 
            button_PlusGrand.Location = new Point(12, 47);
            button_PlusGrand.Name = "button_PlusGrand";
            button_PlusGrand.Size = new Size(171, 29);
            button_PlusGrand.TabIndex = 1;
            button_PlusGrand.Text = "Trouver le plus grand";
            button_PlusGrand.UseVisualStyleBackColor = true;
            button_PlusGrand.Click += button_PlusGrand_Click;
            // 
            // button_TestPremier
            // 
            button_TestPremier.Location = new Point(12, 82);
            button_TestPremier.Name = "button_TestPremier";
            button_TestPremier.Size = new Size(171, 29);
            button_TestPremier.TabIndex = 2;
            button_TestPremier.Text = "Tester si premier";
            button_TestPremier.UseVisualStyleBackColor = true;
            button_TestPremier.Click += button_TestPremier_Click;
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Location = new Point(188, 84);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(125, 27);
            textBox_Nombre.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 155);
            Controls.Add(textBox_Nombre);
            Controls.Add(button_TestPremier);
            Controls.Add(button_PlusGrand);
            Controls.Add(button_Somme);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Somme;
        private Button button_PlusGrand;
        private Button button_TestPremier;
        private TextBox textBox_Nombre;
    }
}
