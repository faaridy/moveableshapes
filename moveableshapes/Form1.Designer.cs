namespace moveableshapes
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
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_ractangle = new System.Windows.Forms.Button();
            this.btn_Square = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_circle
            // 
            this.btn_circle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_circle.Location = new System.Drawing.Point(816, 12);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(94, 29);
            this.btn_circle.TabIndex = 0;
            this.btn_circle.Text = "Circle";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // btn_ractangle
            // 
            this.btn_ractangle.Location = new System.Drawing.Point(816, 47);
            this.btn_ractangle.Name = "btn_ractangle";
            this.btn_ractangle.Size = new System.Drawing.Size(94, 29);
            this.btn_ractangle.TabIndex = 1;
            this.btn_ractangle.Text = "Rectangle";
            this.btn_ractangle.UseVisualStyleBackColor = true;
            this.btn_ractangle.Click += new System.EventHandler(this.btn_ractangle_Click);
            // 
            // btn_Square
            // 
            this.btn_Square.Location = new System.Drawing.Point(816, 82);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(94, 29);
            this.btn_Square.TabIndex = 2;
            this.btn_Square.Text = "Square";
            this.btn_Square.UseVisualStyleBackColor = true;
            this.btn_Square.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(818, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Filled";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(922, 569);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_Square);
            this.Controls.Add(this.btn_ractangle);
            this.Controls.Add(this.btn_circle);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private Button btn_circle;
        private Button btn_ractangle;
        private Button btn_Square;
        private CheckBox checkBox1;
    }
}