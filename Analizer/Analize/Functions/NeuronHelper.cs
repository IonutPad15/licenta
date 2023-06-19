using System.Collections.Generic;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Analizer.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizer.Functions
{
    public class NeuronHelper
    {
        public MainPannel GenerateConfig(int nril, int nrol,int nrhl, double learningRate, double error, int nrhl1, int nrhl2 = 0, int nrhl3 = 0)
        {
            List<Neuron> neurons = new List<Neuron>();

            List<Layer> layers = new List<Layer>();

            var random = new Random();
            for (int i = 0; i < nril; ++i)
            {
                string name = "ILN" + i;
                NeuronValues neuronValues = new NeuronValues();
                List<Entry> ilentries = new List<Entry>();
                Entry entry = new Entry(0);
                ilentries.Add(entry);
                Neuron neuron = new Neuron(name, ilentries, neuronValues);
                neuron.NeuronValues.Out = new EntryOut(0);
                neurons.Add(neuron);
            }
            Layer layer = new Layer(LayerType.InputLayer, neurons);
            layers.Add(layer);
            if (nrhl >= 1)
            {
                neurons = new List<Neuron>();
                for (int i = 0; i < nrhl1; ++i)
                {
                    string name = "HL1N" + i;
                    NeuronValues neuronValues = new NeuronValues();
                    int isNegative = 0;
                    double weight = 0;
                    List<Entry> prevEntries = new List<Entry>();
                    for (int k = 0; k < nril; ++k)
                    {
                        isNegative = random.Next(2);
                        weight = random.NextDouble();
                        if (isNegative == 0)
                        {
                            weight = -weight;
                        }
                        Entry entry = new Entry(0, weight);
                        entry.X = layers[0].Neurons[k].NeuronValues.Out;
                        prevEntries.Add(entry);
                    }
                    Neuron neuron = new Neuron(name, prevEntries, neuronValues);
                    neuron.NeuronValues.Out = new EntryOut(0);
                    neurons.Add(neuron);
                }
                layer = new Layer(LayerType.HiddenLayer, neurons);
                layer.LayerFunctions.ActivCode = ActivCode.Tanh;
                layers.Add(layer);
                if (nrhl >= 2)
                {
                    neurons = new List<Neuron>();
                    for (int i = 0; i < nrhl2; ++i)
                    {
                        string name = "HL2N" + i;
                        NeuronValues neuronValues = new NeuronValues();
                        int isNegative = 0;
                        double weight = 0;
                        List<Entry> prevEntries = new List<Entry>();
                        for (int k = 0; k < nrhl1; ++k)
                        {
                            isNegative = random.Next(2);
                            weight = random.NextDouble();
                            if (isNegative == 0)
                            {
                                weight = -weight;
                            }
                            Entry entry = new Entry(0, weight);
                            entry.X = layers[1].Neurons[k].NeuronValues.Out;
                            prevEntries.Add(entry);
                        }
                        Neuron neuron = new Neuron(name, prevEntries, neuronValues);
                        neuron.NeuronValues.Out = new EntryOut(0);
                        neurons.Add(neuron);
                    }
                    layer = new Layer(LayerType.HiddenLayer, neurons);
                    layer.LayerFunctions.ActivCode = ActivCode.Tanh;
                    layers.Add(layer);
                }
                if (nrhl == 3)
                {
                    neurons = new List<Neuron>();
                    for (int i = 0; i < nrhl3; ++i)
                    {
                        string name = "HL3N" + i;
                        NeuronValues neuronValues = new NeuronValues();
                        int isNegative = 0;
                        double weight = 0;
                        List<Entry> prevEntries = new List<Entry>();
                        for (int k = 0; k < nrhl2; ++k)
                        {
                            isNegative = random.Next(2);
                            weight = random.NextDouble();
                            if (isNegative == 0)
                            {
                                weight = -weight;
                            }
                            Entry entry = new Entry(0, weight);
                            entry.X = layers[2].Neurons[k].NeuronValues.Out;
                            prevEntries.Add(entry);
                        }
                        Neuron neuron = new Neuron(name, prevEntries, neuronValues);
                        neuron.NeuronValues.Out = new EntryOut(0);
                        neurons.Add(neuron);
                    }
                    layer = new Layer(LayerType.HiddenLayer, neurons);
                    layer.LayerFunctions.ActivCode = ActivCode.Tanh;
                    layers.Add(layer);
                }
            }
            neurons = new List<Neuron>();

            for (int i = 0; i < nrol; ++i)
            {
                string name = "OLN" + i;
                NeuronValues neuronValues = new NeuronValues();
                List<Entry> prevEntries = new List<Entry>();
                int n = 0;
                if (nrhl == 3)
                {
                    n = nrhl3;
                }
                else
                    if (nrhl == 2)
                {
                    n = nrhl2;
                }
                else n = nrhl1;
                for (int k = 0; k < n; ++k)
                {
                    int isNegative = random.Next(2);
                    double weight = random.NextDouble();
                    if (isNegative == 0)
                    {
                        weight = -weight;
                    }
                    Entry entry = new Entry(0, weight);
                    entry.X = layers[nrhl].Neurons[k].NeuronValues.Out;
                    prevEntries.Add(entry);
                }
                Neuron neuron = new Neuron(name, prevEntries, neuronValues);
                neuron.NeuronValues.Out = new EntryOut(0);
                neurons.Add(neuron);
            }
            layer = new Layer(LayerType.OutputLayer, neurons);
            //layer.LayerFunctions.ActivCode = ActivCode.Tanh;
            layers.Add(layer);
            MainPannel mainPannel = new MainPannel();
            mainPannel.Layers = layers;
            mainPannel.LearningRate = learningRate;
            mainPannel.Error = error;
            return mainPannel;
        }

        public MainPannel LoadAI(int configIndex)
        {
            string configPath;
            if (configIndex == 0)
            {
                configPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ConfigFile.xml");
            }
            else
            {
                configPath  = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"ConfigFile{configIndex}.xml");
            }
            if (!File.Exists(configPath))
            {
                return null;
            }
            MainPannel mainPannel = FileHandler.LoadXmlFile<MainPannel>(configPath);
            for (int i = 1; i < mainPannel.Layers.Count; ++i)
            {
                foreach (Neuron neuron in mainPannel.Layers[i].Neurons)
                {
                    for (int j = 0; j < mainPannel.Layers[i - 1].Neurons.Count; j++)
                    {
                        neuron.Entries[j].X = mainPannel.Layers[i - 1].Neurons[j].NeuronValues.Out;
                    }
                }
            }

            return mainPannel;
        }

        public async Task LoadFromCsv()
        {
            if (Sets.TrainingRaw.Any() && Sets.TestingRaw.Any() && Sets.TestingNorm.Any() && Sets.TrainingNorm.Any())
            {
                //Generated generated = new Generated();
                //generated.ShowDialog();
                Configure configure = new Configure();
                configure.ShowDialog();
                return;
            }
            string trainingPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"DrivingDataKiaTraining.txt");
            string testingPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"DrivingDataKiaTesting.txt");
            string testingNormPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"DrivingDataKiaNormTesting.txt");
            string trainingNormPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"DrivingDataKiaNormTraining.txt");
            string stoppingPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"DrivingDataKiaStopping.txt");
            string stoppingNormPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"DrivingDataKiaNormStopping.txt");
            if (File.Exists(trainingPath))
            {
                FileStream trainingStream = File.Open(trainingPath, FileMode.Open, FileAccess.Read);
                Sets.TrainingRaw = CsvLoader.Load<CsvProperty>(trainingStream).ToList();
                trainingStream.Close();
                trainingStream = File.Open(trainingNormPath, FileMode.Open, FileAccess.Read);
                Sets.TrainingNorm = CsvLoader.Load<NormalizedProperty>(trainingStream).ToList();
                trainingStream.Close();
                if (File.Exists(testingPath))
                {
                    FileStream testingStream = File.Open(testingPath, FileMode.Open, FileAccess.Read);
                    Sets.TestingRaw = CsvLoader.Load<CsvProperty>(testingStream).ToList();
                    testingStream.Close();
                    testingStream = File.Open(testingNormPath, FileMode.Open, FileAccess.Read);
                    Sets.TestingNorm = CsvLoader.Load<NormalizedProperty>(testingStream).ToList();
                    testingStream.Close();
                }


                //Multimi.TrainingNorm = Normalizare.DoWork(Multimi.TrainingRaw);
                //Multimi.TestingNorm = Normalizare.DoWork(Multimi.TestingRaw);
                if (Sets.TestingNorm != null)
                {
                    if (File.Exists(stoppingPath))
                    {
                        FileStream testingStream = File.Open(stoppingPath, FileMode.Open, FileAccess.Read);
                        Sets.StoppingRaw = CsvLoader.Load<CsvProperty>(testingStream).ToList();
                        testingStream.Close();
                        testingStream = File.Open(stoppingNormPath, FileMode.Open, FileAccess.Read);
                        Sets.StoppingNorm = CsvLoader.Load<NormalizedProperty>(testingStream).ToList();
                        testingStream.Close();
                    }

                    //List<NormalizedProperty> forExec = Multimi.TestingNorm.OrderBy(x => x.Class).ToList();
                    //forExec.AddRange(Multimi.TrainingNorm.OrderBy(x=> x.Class).ToList());
                    //forExec.AddRange(Multimi.StoppingNorm.OrderBy(x => x.Class).ToList());
                    ////Multimi.TrainingRaw = Multimi.TrainingRaw.Where(x => x.Class != 'J').ToList();
                    ////Multimi.TestingRaw = Multimi.TestingRaw.Where(x => x.Class != 'J').ToList();
                    ////Multimi.StoppingRaw = Multimi.StoppingRaw.Where(x => x.Class != 'J').ToList();
                    ////Multimi.StoppingNorm = Multimi.StoppingNorm.Where(x => x.Class != 0.9999999).ToList();
                    ////Multimi.TrainingNorm = Multimi.TrainingNorm.Where(x => x.Class != 0.9999999).ToList();
                    ////Multimi.TestingNorm = Multimi.TestingNorm.Where(x => x.Class != 0.9999999).ToList();

                    //string execNormPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"DrivingDataKiaExecRestul.txt");
                    //string execNormMorePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"DrivingDataKiaExecMore.txt");
                    //StringBuilder sb = new StringBuilder();
                    //string firstLine = "Long_Term_Fuel_Trim_Bank1,Engine_soacking_time,Engine_coolant_temperature2,Torque_of_friction,Intake_air_pressure,Activation_of_Air_compressor,Time(s),Accelerator_Pedal_value,Engine_torque,Maximum_indicated_engine_torque,PathOrder,Throttle_position_signal,Engine_torque_after_correction,Engine_coolant_temperature1,Class";
                    //sb.AppendLine(firstLine);
                    //for (int pasIndex = 0; pasIndex < forExec.Count; pasIndex++)
                    //{
                    //    sb.AppendLine(GenerateInputLayer.ToStringExecNorm(pasIndex, forExec));
                    //}
                    //sb.AppendLine();
                    //await FileHandler.SaveFile(execNormPath, sb.ToString());
                    //firstLine = "Long_Term_Fuel_Trim_Bank1,Engine_soacking_time,Engine_coolant_temperature2,Torque_of_friction,Intake_air_pressure,Activation_of_Air_compressor,Time(s),Accelerator_Pedal_value,Engine_torque,Maximum_indicated_engine_torque,PathOrder,Throttle_position_signal,Engine_torque_after_correction,Engine_coolant_temperature1," +
                    //    "Calculated_LOAD_value,Current_spark_timing,Current_Gear,Wheel_velocity_front_left-hand,Wheel_velocity_rear_right-hand,Wheel_velocity_front_right-hand,Wheel_velocity_rear_left-hand,Calculated_road_gradient,Fuel_consumption,Master_cylinder_pressure,Acceleration_speed_-_Longitudinal,Steering_wheel_angle,Engine_speed," +
                    //    "Flywheel_torque,Torque_converter_turbine_speed_-_Unfiltered,Torque_converter_speed,Flywheel_torque_(after_torque_interventions),Short_Term_Fuel_Trim_Bank1,Acceleration_speed_-_Lateral,Vehicle_speed,TCU_requests_engine_torque_limit_(ETL),Steering_wheel_speed,Gear_Selection,Minimum_indicated_engine_torque";
                    //sb.AppendLine(firstLine);
                    //for (int pasIndex = 0; pasIndex < forExec.Count; pasIndex++)
                    //{
                    //    sb.AppendLine(GenerateInputLayer.ToStringExecNormMore(pasIndex, forExec));
                    //}
                    //sb.AppendLine();
                    //await FileHandler.SaveFile(execNormMorePath, sb.ToString());


                    //Generated generated = new Generated();
                    //generated.ShowDialog();
                    Configure configure = new Configure();
                    configure.ShowDialog();
                }
            }
            else
            {
                string allDataPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"DrivingDataKia.txt");
                FileStream fs = File.Open(allDataPath, FileMode.Open, FileAccess.Read);

                Sets.TrainingRaw = CsvLoader.Load<CsvProperty>(fs).ToList();
                fs.Close();
                var random = new Random();

                for (int i = 0; i < Sets.TrainingRaw.Count; i++)
                {
                    int index = 0;
                    var beforeProperty = Sets.TrainingRaw[i];
                    var property = Sets.TrainingRaw[i];
                    while (property.Class == beforeProperty.Class)
                    {
                        index = random.Next(Sets.TrainingRaw.Count);
                        property = Sets.TrainingRaw[index];
                    }
                    Sets.TrainingRaw[i] = property;
                    Sets.TrainingRaw[index] = beforeProperty;
                }
                Sets.TestingRaw = new List<CsvProperty>();
                Sets.StoppingRaw = new List<CsvProperty>();
                if (Sets.TrainingRaw != null)
                {
                    double procent = (double)25 / 100;
                    Sets.TrainingNorm = new List<NormalizedProperty>();
                    Sets.TestingNorm = new List<NormalizedProperty>();
                    Sets.TrainingNorm = NormalizeProperties.DoWork(Sets.TrainingRaw);
                    int testingSize = (int)(procent * Sets.TrainingRaw.Count);
                    procent = (double)5 / 100;
                    int stoppingSize = (int)(procent * Sets.TrainingRaw.Count);
                    for (int i = 0; i < testingSize; i++)
                    {
                        int index = random.Next(Sets.TrainingRaw.Count);
                        var property = Sets.TrainingRaw[index];
                        Sets.TestingRaw.Add(property);
                        Sets.TestingNorm.Add(Sets.TrainingNorm[index]);
                        Sets.TrainingRaw.Remove(property);
                        Sets.TrainingNorm.RemoveAt(index);
                    }


                    Sets.StoppingNorm = new List<NormalizedProperty>();
                    testingSize = (int)(procent * Sets.TrainingRaw.Count);
                    for (int i = 0; i < stoppingSize; i++)
                    {

                        int index = random.Next(Sets.TrainingRaw.Count);
                        var property = Sets.TrainingRaw[index];
                        Sets.StoppingRaw.Add(property);
                        Sets.StoppingNorm.Add(Sets.TrainingNorm[index]);
                        Sets.TrainingRaw.Remove(property);
                        Sets.TrainingNorm.RemoveAt(index);
                    }

                    //Multimi.TrainingRaw = Multimi.TrainingRaw.Where(x => x.Class != 'J').ToList();
                    //Multimi.TestingRaw = Multimi.TestingRaw.Where(x => x.Class != 'J').ToList();
                    //Multimi.StoppingRaw = Multimi.StoppingRaw.Where(x => x.Class != 'J').ToList();
                    //Multimi.StoppingNorm = Multimi.StoppingNorm.Where(x => x.Class != 0.9999999).ToList();
                    //Multimi.TrainingNorm = Multimi.TrainingNorm.Where(x => x.Class != 1).ToList();
                    //Multimi.TestingNorm = Multimi.TestingNorm.Where(x=> x.Class != 1).ToList();

                    StringBuilder sb = new StringBuilder();
                    string firstLine = "Fuel_consumption,Accelerator_Pedal_value,Throttle_position_signal,Short_Term_Fuel_Trim_Bank1,Intake_air_pressure,Filtered_Accelerator_Pedal_value,Absolute_throttle_position,Engine_soacking_time,Inhibition_of_engine_fuel_cut_off,Engine_in_fuel_cut_off,Fuel_Pressure,Long_Term_Fuel_Trim_Bank1," +
                        "Engine_speed,Engine_torque_after_correction,Torque_of_friction,Flywheel_torque_(after_torque_interventions),Current_spark_timing,Engine_coolant_temperature1,Engine_Idel_Target_Speed,Engine_torque,Calculated_LOAD_value,Minimum_indicated_engine_torque,Maximum_indicated_engine_torque,Flywheel_torque," +
                        "Torque_scaling_factor(standardization),Standard_Torque_Ratio,Requested_spark_retard_angle_from_TCU,TCU_requests_engine_torque_limit_(ETL),TCU_requested_engine_RPM_increase,Target_engine_speed_used_in_lock-up_module,Glow_plug_control_request,Activation_of_Air_compressor,Torque_converter_speed," +
                        "Current_Gear,Engine_coolant_temperature2,Wheel_velocity_front_left-hand,Wheel_velocity_rear_right-hand,Wheel_velocity_front_right-hand,Wheel_velocity_rear_left-hand,Torque_converter_turbine_speed_-_Unfiltered,Clutch_operation_acknowledge,Converter_clutch,Gear_Selection,Vehicle_speed,Acceleration_speed_-_Longitudinal," +
                        "Indication_of_brake_switch_ON/OFF,Master_cylinder_pressure,Calculated_road_gradient,Acceleration_speed_-_Lateral,Steering_wheel_speed,Steering_wheel_angle,Time(s),Class,PathOrder";
                    sb.AppendLine(firstLine);
                    for (int pasIndex = 0; pasIndex < Sets.TrainingRaw.Count; pasIndex++)
                    {
                        sb.AppendLine(GenerateInputLayer.ToStringTraining(pasIndex));
                    }
                    sb.AppendLine();
                    await FileHandler.SaveFile(trainingPath, sb.ToString());

                    sb = new StringBuilder();
                    sb.AppendLine(firstLine);
                    for (int pasIndex = 0; pasIndex < Sets.TestingRaw.Count; pasIndex++)
                    {
                        sb.AppendLine(GenerateInputLayer.ToStringTesting(pasIndex));
                    }
                    sb.AppendLine();
                    await FileHandler.SaveFile(testingPath, sb.ToString());

                    sb = new StringBuilder();
                    sb.AppendLine(firstLine);
                    for (int pasIndex = 0; pasIndex < Sets.StoppingRaw.Count; pasIndex++)
                    {
                        sb.AppendLine(GenerateInputLayer.ToStringStopping(pasIndex));
                    }
                    sb.AppendLine();
                    await FileHandler.SaveFile(stoppingPath, sb.ToString());

                    sb = new StringBuilder();
                    sb.AppendLine(firstLine);
                    for (int pasIndex = 0; pasIndex < Sets.StoppingRaw.Count; pasIndex++)
                    {
                        sb.AppendLine(GenerateInputLayer.ToStringStoppingNorm(pasIndex));
                    }
                    sb.AppendLine();
                    await FileHandler.SaveFile(stoppingNormPath, sb.ToString());

                    sb = new StringBuilder();
                    sb.AppendLine(firstLine);
                    for (int pasIndex = 0; pasIndex < Sets.TestingRaw.Count; pasIndex++)
                    {
                        sb.AppendLine(GenerateInputLayer.ToStringTestingNorm(pasIndex));
                    }
                    sb.AppendLine();
                    await FileHandler.SaveFile(testingNormPath, sb.ToString());

                    sb = new StringBuilder();
                    sb.AppendLine(firstLine);
                    for (int pasIndex = 0; pasIndex < Sets.TrainingNorm.Count; pasIndex++)
                    {
                        sb.AppendLine(GenerateInputLayer.ToStringTrainingNorm(pasIndex));
                    }
                    sb.AppendLine();
                    await FileHandler.SaveFile(trainingNormPath, sb.ToString());

                    if (Sets.TestingNorm != null)
                    {
                        //Generated generated = new Generated();
                        //generated.ShowDialog();
                        Configure configure = new Configure();
                        configure.ShowDialog();
                    }
                }
            }
        }
    }
}
