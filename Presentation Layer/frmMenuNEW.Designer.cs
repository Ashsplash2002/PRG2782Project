namespace PRG2782Project.Presentation_Layer
{
    partial class frmMenuNEW
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnModule = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnlogout);
            this.groupBox1.Controls.Add(this.btnModule);
            this.groupBox1.Controls.Add(this.btnStudent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 444);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(266, 53);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT ";
            this.btnExit.UseVisualStyleBackColor = false;
            //this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(0, 292);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(260, 55);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            //this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnModule
            // 
            this.btnModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModule.Location = new System.Drawing.Point(0, 182);
            this.btnModule.Name = "btnModule";
            this.btnModule.Size = new System.Drawing.Size(266, 61);
            this.btnModule.TabIndex = 1;
            this.btnModule.Text = "Go To Module Form";
            this.btnModule.UseVisualStyleBackColor = false;
            //this.btnModule.Click += new System.EventHandler(this.btnModule_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(0, 78);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(266, 57);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Go To Student Form";
            this.btnStudent.UseVisualStyleBackColor = false;
            //this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 95);
            this.label1.TabIndex = 3;
            this.label1.Text = "BELGIUM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 95);
            this.label2.TabIndex = 4;
            this.label2.Text = "CAMPUS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Form";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnModule;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}