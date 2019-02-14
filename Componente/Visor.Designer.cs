namespace Componente
{
    partial class Visor
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.visorPrincipal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // visorPrincipal
            // 
            this.visorPrincipal.Location = new System.Drawing.Point(20, 32);
            this.visorPrincipal.Name = "visorPrincipal";
            this.visorPrincipal.Size = new System.Drawing.Size(200, 100);
            this.visorPrincipal.TabIndex = 0;
            // 
            // Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.visorPrincipal);
            this.Name = "Visor";
            this.Size = new System.Drawing.Size(248, 176);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel visorPrincipal;
    }
}
