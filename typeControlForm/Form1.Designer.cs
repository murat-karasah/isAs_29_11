
namespace typeControlForm
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
            this.getType = new System.Windows.Forms.CheckBox();
            this.btn_type_of = new System.Windows.Forms.Button();
            this.btn_is = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getType
            // 
            this.getType.AutoSize = true;
            this.getType.Location = new System.Drawing.Point(26, 12);
            this.getType.Name = "getType";
            this.getType.Size = new System.Drawing.Size(70, 17);
            this.getType.TabIndex = 0;
            this.getType.Text = "Get Type";
            this.getType.UseVisualStyleBackColor = true;
            this.getType.CheckedChanged += new System.EventHandler(this.getType_CheckedChanged);
            // 
            // btn_type_of
            // 
            this.btn_type_of.Location = new System.Drawing.Point(21, 49);
            this.btn_type_of.Name = "btn_type_of";
            this.btn_type_of.Size = new System.Drawing.Size(75, 23);
            this.btn_type_of.TabIndex = 1;
            this.btn_type_of.Text = "Type Of";
            this.btn_type_of.UseVisualStyleBackColor = true;
            this.btn_type_of.Click += new System.EventHandler(this.btn_type_of_Click);
            // 
            // btn_is
            // 
            this.btn_is.Location = new System.Drawing.Point(21, 88);
            this.btn_is.Name = "btn_is";
            this.btn_is.Size = new System.Drawing.Size(75, 23);
            this.btn_is.TabIndex = 2;
            this.btn_is.Text = "is";
            this.btn_is.UseVisualStyleBackColor = true;
            this.btn_is.Click += new System.EventHandler(this.btn_is_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 123);
            this.Controls.Add(this.btn_is);
            this.Controls.Add(this.btn_type_of);
            this.Controls.Add(this.getType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox getType;
        private System.Windows.Forms.Button btn_type_of;
        private System.Windows.Forms.Button btn_is;
    }
}

