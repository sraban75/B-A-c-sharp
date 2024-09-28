using System.Reflection;

namespace B2A_C_Sharp
{
    public partial class Form1 : Form
    {
        public bool _monitorOnOffStatus;
        public bool _pluginStatus;

        public string _monitorManufacturedBy;
        public string _monitorManufactureLogo;
        public string _monitorManufactureLocation;
        public string _monitorModelNo;
        public string _monitorBatchNo;
        public string _monitorBrandName;
        public string _monitorBrandLogo;
        public string _monitorBrandLocation;
        public string _monitorPannelInfo;
        public string _monitorType;





        public Form1()
        {
            InitializeComponent();

            HeightTextBox.Text = "11";
            WidthTextBox.Text = "19";

        }

        private void CreateMonitorButton_Click(object sender, EventArgs e)
        {

            // Be sure, numeric values before convert
            var heightOfTheMonitor = Convert.ToInt32(HeightTextBox.Text);
            var widthOfTheMonitor = Convert.ToInt32(WidthTextBox.Text);

            //11 =(100) X 19 (160)

            var sizeOfTheMonitor = MonitorPanel.Size;
            if (heightOfTheMonitor == 11 && widthOfTheMonitor == 19)
            {
                sizeOfTheMonitor.Height = 323;
                sizeOfTheMonitor.Width = 473;

                MonitorPanel.Size = sizeOfTheMonitor;
            }

            _monitorManufacturedBy = "Samsung";
            _monitorManufactureLocation = "Korea";
            _monitorBrandName = "SAMSUNG LED";
            _monitorBrandLocation = "South Korea";
            _monitorModelNo = "L1001";
            _monitorBatchNo = "2024A1001";
            _monitorPannelInfo = "LG";
            _monitorType = "LED";

        }



        private void MonitorPowerButton_Click(object sender, EventArgs e)
        {
            //if (_MonitorOnOffStatus)
            //{
            //    _MonitorOnOffStatus = false;
            //    MonitorPanel.BackColor = Color.Gray;
            //}
            //else
            //{
            //    _MonitorOnOffStatus = true;
            //    MonitorPanel.BackColor = Color.Green;
            //}

            if (!_pluginStatus)
            {
                MessageBox.Show("Please Connect Your Monitor Power Cable!");
                return;
            }

            _monitorOnOffStatus = !_monitorOnOffStatus;
            MonitorPanel.BackColor = _monitorOnOffStatus ? Color.Green : Color.Gray;
        }



        private void PluginButton_Click(object sender, EventArgs e)
        {
            _pluginStatus = !_pluginStatus;
            if (_pluginStatus)
            {
                PluginButton.Text = "PluggedIn";
                PowerLightButton.BackColor = Color.Green;
            }
            else
            {
                PluginButton.Text = "Plugin";
                PowerLightButton.BackColor = Color.White;

                _monitorOnOffStatus = false;
                MonitorPanel.BackColor = Color.Gray;
            }




        }

        private void GetMonitorInfoButton_Click(object sender, EventArgs e)
        {
            //var info = @"Model No: " + _monitorModelNo + "\n Manufactured By: " + _monitorManufacturedBy + "\n Brand : " + _monitorBrandName + "";
            //MessageBox.Show(info);

            try
            {
                var name = MonitorNameTextBox.Text;
                var monitorObj = new Monitor();
                //monitorObj.Name = name;
                //monitorObj.SetName(name);


                //var properties = monitorObj.GetType().GetProperties();
                //var nameProp = properties.FirstOrDefault(c => c.Name == "Name");
                //nameProp.SetValue(monitorObj, "A");

                var nameField = monitorObj.GetType().GetField("_name", BindingFlags.NonPublic | BindingFlags.Instance);
                nameField.SetValue(monitorObj, "A");

                var data = monitorObj.Name;



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }



        }
    }
}
