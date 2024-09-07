namespace B2A_C_Sharp
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
            HeightTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            WidthTextBox = new TextBox();
            CreateMonitorButton = new Button();
            MonitorPanel = new Button();
            MonitorPowerButton = new Button();
            PluginButton = new Button();
            PowerLightButton = new Button();
            GetMonitorInfoButton = new Button();
            SuspendLayout();
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(363, 42);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(234, 23);
            HeightTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 45);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Height";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(654, 49);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Width";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(751, 42);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(234, 23);
            WidthTextBox.TabIndex = 0;
            // 
            // CreateMonitorButton
            // 
            CreateMonitorButton.Location = new Point(1040, 45);
            CreateMonitorButton.Name = "CreateMonitorButton";
            CreateMonitorButton.Size = new Size(75, 23);
            CreateMonitorButton.TabIndex = 3;
            CreateMonitorButton.Text = "Create";
            CreateMonitorButton.UseVisualStyleBackColor = true;
            CreateMonitorButton.Click += CreateMonitorButton_Click;
            // 
            // MonitorPanel
            // 
            MonitorPanel.Location = new Point(512, 87);
            MonitorPanel.Name = "MonitorPanel";
            MonitorPanel.Size = new Size(473, 323);
            MonitorPanel.TabIndex = 4;
            MonitorPanel.UseVisualStyleBackColor = true;
            // 
            // MonitorPowerButton
            // 
            MonitorPowerButton.Location = new Point(910, 387);
            MonitorPowerButton.Name = "MonitorPowerButton";
            MonitorPowerButton.Size = new Size(75, 23);
            MonitorPowerButton.TabIndex = 5;
            MonitorPowerButton.Text = "Power";
            MonitorPowerButton.UseVisualStyleBackColor = true;
            MonitorPowerButton.Click += MonitorPowerButton_Click;
            // 
            // PluginButton
            // 
            PluginButton.Location = new Point(1040, 87);
            PluginButton.Name = "PluginButton";
            PluginButton.Size = new Size(181, 23);
            PluginButton.TabIndex = 6;
            PluginButton.Text = "Plugin";
            PluginButton.UseVisualStyleBackColor = true;
            PluginButton.Click += PluginButton_Click;
            // 
            // PowerLightButton
            // 
            PowerLightButton.Location = new Point(512, 387);
            PowerLightButton.Name = "PowerLightButton";
            PowerLightButton.Size = new Size(19, 23);
            PowerLightButton.TabIndex = 7;
            PowerLightButton.UseVisualStyleBackColor = true;
            // 
            // GetMonitorInfoButton
            // 
            GetMonitorInfoButton.Location = new Point(1144, 46);
            GetMonitorInfoButton.Name = "GetMonitorInfoButton";
            GetMonitorInfoButton.Size = new Size(231, 23);
            GetMonitorInfoButton.TabIndex = 8;
            GetMonitorInfoButton.Text = "Show Monito Information";
            GetMonitorInfoButton.UseVisualStyleBackColor = true;
            GetMonitorInfoButton.Click += GetMonitorInfoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 1075);
            Controls.Add(GetMonitorInfoButton);
            Controls.Add(PowerLightButton);
            Controls.Add(PluginButton);
            Controls.Add(MonitorPowerButton);
            Controls.Add(MonitorPanel);
            Controls.Add(CreateMonitorButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(WidthTextBox);
            Controls.Add(HeightTextBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox HeightTextBox;
        private Label label1;
        private Label label2;
        private TextBox WidthTextBox;
        private Button CreateMonitorButton;
        private Button MonitorPanel;
        private Button MonitorPowerButton;
        private Button PluginButton;
        private Button PowerLightButton;
        private Button GetMonitorInfoButton;
    }
}
