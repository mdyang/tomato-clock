namespace TomatoClock
{
    partial class StartForm
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
            this._inputMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._remainSec = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time:";
            // 
            // _inputMin
            // 
            this._inputMin.Location = new System.Drawing.Point(38, 6);
            this._inputMin.Name = "_inputMin";
            this._inputMin.Size = new System.Drawing.Size(25, 20);
            this._inputMin.TabIndex = 1;
            this._inputMin.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seconds";
            // 
            // _remainSec
            // 
            this._remainSec.AutoSize = true;
            this._remainSec.Location = new System.Drawing.Point(105, 29);
            this._remainSec.Name = "_remainSec";
            this._remainSec.Size = new System.Drawing.Size(13, 13);
            this._remainSec.TabIndex = 0;
            this._remainSec.Text = "7";
            this._remainSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Auto close in";
            // 
            // _btClose
            // 
            this._btClose.Location = new System.Drawing.Point(119, 5);
            this._btClose.Name = "_btClose";
            this._btClose.Size = new System.Drawing.Size(46, 21);
            this._btClose.TabIndex = 2;
            this._btClose.Text = "Reset";
            this._btClose.UseVisualStyleBackColor = true;
            this._btClose.Click += new System.EventHandler(this._btClose_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 51);
            this.ControlBox = false;
            this.Controls.Add(this._btClose);
            this.Controls.Add(this._inputMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._remainSec);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _inputMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _remainSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _btClose;
    }
}