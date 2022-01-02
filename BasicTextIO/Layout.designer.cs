namespace $rootnamespace$.TextIO
{
    partial class $safeitemname$Layout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        internal ENV.IO.TextSection Body;

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
            
            Body = new ENV.IO.TextSection();
            Body.HeightInChars = 4;
            this.AllowDrop = false;
            this.WidthInChars = 80;
            this.Text = "$safeitemname$";
            
            Controls.Add(Body);
            this.ResumeLayout(false);

        }

        #endregion

    }
}