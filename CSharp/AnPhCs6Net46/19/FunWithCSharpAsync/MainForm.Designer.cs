namespace FunWithCSharpAsync
{
    partial class MainForm
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
            this.btnCallMethod = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnVoidMethodCall = new System.Windows.Forms.Button();
            this.btnMutliAwaits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCallMethod
            // 
            this.btnCallMethod.Location = new System.Drawing.Point(12, 103);
            this.btnCallMethod.Name = "btnCallMethod";
            this.btnCallMethod.Size = new System.Drawing.Size(165, 23);
            this.btnCallMethod.TabIndex = 0;
            this.btnCallMethod.Text = "btnCallMethod";
            this.btnCallMethod.UseVisualStyleBackColor = true;
            this.btnCallMethod.Click += new System.EventHandler(this.btnCallMethod_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(260, 21);
            this.txtInput.TabIndex = 1;
            // 
            // btnVoidMethodCall
            // 
            this.btnVoidMethodCall.Location = new System.Drawing.Point(12, 145);
            this.btnVoidMethodCall.Name = "btnVoidMethodCall";
            this.btnVoidMethodCall.Size = new System.Drawing.Size(165, 23);
            this.btnVoidMethodCall.TabIndex = 2;
            this.btnVoidMethodCall.Text = "btnVoidMethodCall";
            this.btnVoidMethodCall.UseVisualStyleBackColor = true;
            this.btnVoidMethodCall.Click += new System.EventHandler(this.btnVoidMethodCall_Click);
            // 
            // btnMutliAwaits
            // 
            this.btnMutliAwaits.Location = new System.Drawing.Point(12, 192);
            this.btnMutliAwaits.Name = "btnMutliAwaits";
            this.btnMutliAwaits.Size = new System.Drawing.Size(165, 23);
            this.btnMutliAwaits.TabIndex = 3;
            this.btnMutliAwaits.Text = "btnMutliAwaits";
            this.btnMutliAwaits.UseVisualStyleBackColor = true;
            this.btnMutliAwaits.Click += new System.EventHandler(this.btnMutliAwaits_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMutliAwaits);
            this.Controls.Add(this.btnVoidMethodCall);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCallMethod);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCallMethod;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnVoidMethodCall;
        private System.Windows.Forms.Button btnMutliAwaits;
    }
}

