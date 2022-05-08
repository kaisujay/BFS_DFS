namespace BFS_DFS
{
    partial class Form1
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
            this.buttonBFS = new System.Windows.Forms.Button();
            this.buttonDFS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBFS
            // 
            this.buttonBFS.Location = new System.Drawing.Point(96, 109);
            this.buttonBFS.Name = "buttonBFS";
            this.buttonBFS.Size = new System.Drawing.Size(104, 42);
            this.buttonBFS.TabIndex = 0;
            this.buttonBFS.Text = "BFS";
            this.buttonBFS.UseVisualStyleBackColor = true;
            this.buttonBFS.Click += new System.EventHandler(this.buttonBFS_Click);
            // 
            // buttonDFS
            // 
            this.buttonDFS.Location = new System.Drawing.Point(384, 109);
            this.buttonDFS.Name = "buttonDFS";
            this.buttonDFS.Size = new System.Drawing.Size(107, 42);
            this.buttonDFS.TabIndex = 1;
            this.buttonDFS.Text = "DFS";
            this.buttonDFS.UseVisualStyleBackColor = true;
            this.buttonDFS.Click += new System.EventHandler(this.buttonDFS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDFS);
            this.Controls.Add(this.buttonBFS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBFS;
        private System.Windows.Forms.Button buttonDFS;
    }
}

