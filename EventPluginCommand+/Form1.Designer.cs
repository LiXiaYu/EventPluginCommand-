namespace EventPluginCommand_
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPlugin = new System.Windows.Forms.ComboBox();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.Parameter1 = new System.Windows.Forms.TextBox();
            this.labelParameter1 = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelPlugin = new System.Windows.Forms.Label();
            this.labelCommand = new System.Windows.Forms.Label();
            this.comboBoxCommand = new System.Windows.Forms.ComboBox();
            this.groupBoxParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPlugin
            // 
            this.comboBoxPlugin.FormattingEnabled = true;
            this.comboBoxPlugin.Location = new System.Drawing.Point(79, 12);
            this.comboBoxPlugin.Name = "comboBoxPlugin";
            this.comboBoxPlugin.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPlugin.TabIndex = 0;
            this.comboBoxPlugin.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlugin_SelectedIndexChanged);
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.Parameter1);
            this.groupBoxParameters.Controls.Add(this.labelParameter1);
            this.groupBoxParameters.Location = new System.Drawing.Point(13, 72);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(301, 215);
            this.groupBoxParameters.TabIndex = 1;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "groupBoxParameters";
            // 
            // Parameter1
            // 
            this.Parameter1.Location = new System.Drawing.Point(87, 20);
            this.Parameter1.Name = "Parameter1";
            this.Parameter1.Size = new System.Drawing.Size(100, 21);
            this.Parameter1.TabIndex = 2;
            // 
            // labelParameter1
            // 
            this.labelParameter1.AutoSize = true;
            this.labelParameter1.Location = new System.Drawing.Point(10, 23);
            this.labelParameter1.Name = "labelParameter1";
            this.labelParameter1.Size = new System.Drawing.Size(71, 12);
            this.labelParameter1.TabIndex = 1;
            this.labelParameter1.Text = "parameter1:";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(239, 9);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // labelPlugin
            // 
            this.labelPlugin.AutoSize = true;
            this.labelPlugin.Location = new System.Drawing.Point(23, 14);
            this.labelPlugin.Name = "labelPlugin";
            this.labelPlugin.Size = new System.Drawing.Size(47, 12);
            this.labelPlugin.TabIndex = 4;
            this.labelPlugin.Text = "plugin:";
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(20, 41);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(53, 12);
            this.labelCommand.TabIndex = 6;
            this.labelCommand.Text = "command:";
            // 
            // comboBoxCommand
            // 
            this.comboBoxCommand.FormattingEnabled = true;
            this.comboBoxCommand.Location = new System.Drawing.Point(79, 38);
            this.comboBoxCommand.Name = "comboBoxCommand";
            this.comboBoxCommand.Size = new System.Drawing.Size(121, 20);
            this.comboBoxCommand.TabIndex = 5;
            this.comboBoxCommand.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommand_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 299);
            this.Controls.Add(this.labelCommand);
            this.Controls.Add(this.comboBoxCommand);
            this.Controls.Add(this.labelPlugin);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.comboBoxPlugin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPlugin;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.TextBox Parameter1;
        private System.Windows.Forms.Label labelParameter1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelPlugin;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.ComboBox comboBoxCommand;
    }
}

