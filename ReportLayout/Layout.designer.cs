namespace $rootnamespace$
{
    partial class $safeitemname$
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        internal ENV.Printing.ReportSection Body;

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
            this.SuspendLayout();
            // 
            // $safeitemname$
            // 
            
            Body = new ENV.Printing.ReportSection();
            Body.ClientSize = new System.Drawing.Size(750,421);
            this.AllowDrop = false;
            this.ClientSize = new System.Drawing.Size(750, 431);
            this.Text = "$safeitemname$";
            
            Controls.Add(Body);
            this.ResumeLayout(false);

        }

        #endregion

    }
}