namespace RealTimeApp.WindowsServiceApp
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.broadcasterService1 = new RealTimeApp.WindowsServiceApp.BroadcasterService();
            // 
            // broadcasterService1
            // 
            this.broadcasterService1.ExitCode = 0;
            this.broadcasterService1.ServiceName = "";

        }

        #endregion

        private BroadcasterService broadcasterService1;
    }
}