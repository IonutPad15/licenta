using Analizer.Entities;
using Analizer.Functions;
using Analizer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Analizer
{
    public partial class Generated : Form
    {
        [XmlElement("MainPannel")]
        public MainPannel MainPannel { get; set; }
        bool _keepGoing;
        int _nrError = 0;
        double _epochError = 10;
        TextBox[] _lastErrors;
        double _maxScoreTest = 0;
        int _configIndex;
        int _nrEpoch;
        List<NormalizedProperty> _testingList;
        List<NormalizedProperty> _trainingList;
        List<NormalizedProperty> _stoppingList;
        public Generated()
        {
            InitializeComponent();
            {
                btnStart.Enabled = false;
                btnStop.Enabled = false;
            }
            _keepGoing = false;
            btnTest.Enabled = false;
            _lastErrors = new TextBox[10];
            InitializeTexts();
            this.Text = $"Generated{_configIndex}";
            _testingList = Sets.TestingNorm;
            _trainingList = Sets.TrainingNorm;
            _stoppingList = Sets.StoppingNorm;
        }

        public Generated(int configIndex)
        {
            _configIndex = configIndex;
            InitializeComponent();
            {
                btnStart.Enabled = false;
                btnStop.Enabled = false;
            }
            _keepGoing = false;
            btnTest.Enabled = false;
            btnBetterTest.Enabled = false;
            btnExec.Enabled = false;
            btnSave.Enabled = false;
            _lastErrors = new TextBox[10];
            InitializeTexts();
            this.Text = $"Generated{_configIndex}";
            _testingList = Sets.TestingNorm;
            _trainingList = Sets.TrainingNorm;
            _stoppingList = Sets.StoppingNorm;
        }
        void InitializeTexts()
        {
            for (int i = 0; i < 10; i++)
            {
                _lastErrors[i] = new TextBox();
                _lastErrors[i].ReadOnly = true;
            }
        }
        bool ReadConfig()
        {
            string configPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ConfigFile.xml");
            if (!File.Exists(configPath))
                return false;
            MainPannel = FileHandler.LoadXmlFile<MainPannel>(configPath);
            return true;

        }
        void SetTexts()
        {
            for (int i = 9; i >= 1; --i)
            {
                _lastErrors[i].Text = _lastErrors[i - 1].Text;
            }
            _lastErrors[0].Text = _epochError.ToString();
        }

        void BtnViewData_Click(object sender, EventArgs e)
        {
            SelectLot selectLot = new SelectLot();
            selectLot.ShowDialog();
        }

        async void BtnStart_Click(object sender, EventArgs e)
        {
            _keepGoing = true;
            btnConfig.Enabled = false;
            btnTest.Enabled = false;
            btnBetterTest.Enabled = false;
            btnExec.Enabled = false;
            btnSave.Enabled = false;
            await RunBrain();
            btnTest.Enabled = true;
            btnBetterTest.Enabled = true;
            btnExec.Enabled = true;
            btnSave.Enabled = true;

        }
        void SaveTheConfig()
        {
            string configPath;
            if (_configIndex == 0)
            {
                configPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"ConfigFile.xml");
            }
            else
            {
                configPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"ConfigFile{_configIndex}.xml");

            }
            FileHandler.SaveXmlFile(MainPannel, configPath);
        }

        async void DoWork()
        {
            NeuronFunctions neuronFunctions = new NeuronFunctions();
            (double epochError, MainPannel resultPannel) result = neuronFunctions.EpochError(MainPannel, _trainingList, _trainingList.Count, 0, _configIndex);
            _epochError = result.epochError;
            MainPannel = result.resultPannel;

            UpdateChart(_epochError);
            double nowTest = await EarlyBrain();
            Console.WriteLine($"Test: {nowTest}");
            if (nowTest >= _maxScoreTest)
            {

                _maxScoreTest = nowTest;
                UpdateLblTest(nowTest);
                SaveTheConfig();
            }
            ++_nrEpoch;
            ++_nrError;
            int index = 0;
            while (_keepGoing == true && _epochError > MainPannel.Error && _nrEpoch < 4000)
            {
                if (index == 4)
                {
                    //Multimi.AntrenamentNorm = RandomizeFunction.Randomize();
                    index = 0;
                }
                else
                {
                    ++index;
                }
                result = neuronFunctions.EpochError(MainPannel, _trainingList, _trainingList.Count, 0, _configIndex);
                _epochError = result.epochError;
                MainPannel = result.resultPannel;
                nowTest = await EarlyBrain();
                Console.WriteLine($"Test config{_configIndex}: {nowTest}");
                if (nowTest >= _maxScoreTest)
                {
                    _maxScoreTest = nowTest;
                    UpdateLblTest(nowTest);
                    SaveTheConfig();
                }
                UpdateChart(_epochError);
                UpdateErrors();
                ++_nrError;
                ++_nrEpoch;
            }
        }
        void UpdateLblTest(double procent)
        {
            if (lblTest.InvokeRequired)
            {
                lblTest.Invoke(new Action(() =>
                {
                    UpdateLblTest(procent);
                }
                ));
            }
            else
            {
                lblTest.Text = "Score: " + procent + "%";
            }

        }
        void UpdateErrors()
        {
            if (errorPannel.InvokeRequired)
            {
                errorPannel.Invoke(new Action(() =>
                {
                    UpdateErrors();
                }
                ));
            }
            else
            {
                SetTexts();
                errorPannel.Controls.Clear();
                errorPannel.Controls.AddRange(_lastErrors);
            }

        }
        void UpdateChart(double eroareEpoca)
        {
            if (chart1.InvokeRequired)
            {
                chart1.Invoke(new Action(() =>
                {
                    UpdateChart(eroareEpoca);
                }
                ));
            }
            else
            {
                try
                {
                    chart1.Series["Errors"].Points.AddXY(_nrError, eroareEpoca);
                }
                catch (Exception)
                {

                }
            }
        }

        async Task RunBrain()
        {
            await Task.Run(() => DoWork());
        }
        async Task<Dictionary<int, double>> TestBrain()
        {
            var result = await Task.Run(() => TestWork());
            return result;
        }
        Dictionary<int, double> TestWork()
        {
            NeuronFunctions neuronFunctions = new NeuronFunctions();
            Dictionary<int, double> result = neuronFunctions.Testing(MainPannel, _testingList.Count, _testingList, _configIndex);
            return result;
        }

        async Task<double> EarlyBrain()
        {
            var result = await Task.Run(() => EarlyWork());
            return result;
        }
        double EarlyWork()
        {
            NeuronFunctions neuronFunctions = new NeuronFunctions();
            double result = neuronFunctions.Stopping(MainPannel, _stoppingList.Count, _stoppingList, _configIndex);
            return result;
        }

        void btnConfig_Click(object sender, EventArgs e)
        {
            Configure configure = new Configure();
            DialogResult result = configure.ShowDialog();
            if (result == DialogResult.OK)
            {
                MainPannel = Configure.Network;
                btnStart.Enabled = true;
                btnStop.Enabled = true;
                btnTest.Enabled = true;
                btnBetterTest.Enabled = true;
                btnExec.Enabled = true;
                _nrError = 0;
                chart1.Series["Errors"].Points.Clear();
                _epochError = 10;
                _maxScoreTest = 0;
                btnTest.Enabled = true;
                label1.Text = $"Chosen Error: {MainPannel.Error}";
                label2.Text = $"Learning Rate: {MainPannel.LearningRate}";
            }
        }

        void BtnStop_Click(object sender, EventArgs e)
        {
            _keepGoing = false;
            btnConfig.Enabled = true;
        }

        void errorPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        async void BtnTest_Click(object sender, EventArgs e)
        {
            var result = await TestBrain();
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Driver{_configIndex + 1}: {result[0]} % (out of {_testingList.Where(x => (int)(x.Class * 10) == _configIndex).Count()} drivers)");
            stringBuilder.AppendLine($"Thieves: {result[1]} % (out of {_testingList.Where(x => (int)(x.Class * 10) != _configIndex).Count()} drivers)");
            MessageBox.Show(stringBuilder.ToString());
        }

        async void BtnLoadAI_Click(object sender, EventArgs e)
        {
            NeuronHelper neuronHelper = new NeuronHelper();
            MainPannel = neuronHelper.LoadAI(_configIndex);
            if (MainPannel == null)
            {
                MessageBox.Show("There is no config file!");
                return;
            }
            btnStart.Enabled = true;
            btnStop.Enabled = true;
            btnLoadAi.Enabled = true;
            btnBetterTest.Enabled = true;
            btnExec.Enabled = true;
            btnSave.Enabled = true;
            _nrError = 0;
            chart1.Series["Errors"].Points.Clear();
            _epochError = 10;
            btnTest.Enabled = true;
            label1.Text = $"Chosen Error: {MainPannel.Error}";
            label2.Text = $"Learning Rate: {MainPannel.LearningRate}";
            _maxScoreTest = await EarlyBrain();
            UpdateLblTest(_maxScoreTest);
            Console.WriteLine($"Test: {_maxScoreTest}");
            MessageBox.Show("Config loaded");
        }

        void BtnExec_Click(object sender, EventArgs e)
        {
            Execution execut = new Execution(_configIndex, MainPannel);
            execut.ShowDialog();
        }

        string ToStringVal()
        {
            StringBuilder sb = new StringBuilder("");
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Values.txt");
            sb.AppendLine("MainPannel:");
            sb.Append(MainPannel.ToString());


            return sb.ToString();
        }

        void btnBetterTest_Click(object sender, EventArgs e)
        {
            NeuronFunctions neuronFunctions = new NeuronFunctions();
            var result = neuronFunctions.BetterTesting(MainPannel, _testingList.Count, _testingList, _configIndex);
            TestGraph testGraph = new TestGraph(result, _configIndex);
            testGraph.Show();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            SaveTheConfig();
        }
    }
}
