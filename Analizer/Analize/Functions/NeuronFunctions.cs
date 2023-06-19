using Analizer.Functions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Analizer
{
    public class NeuronFunctions
    {
        #region EpochError
        public (double error, MainPannel resultPannel) EpochError(MainPannel mainPannel, List<NormalizedProperty> normedTraining, int nrSteps, int layerIndex = 0, int ignoreIndex = -1)
        {
            int nrLayers = mainPannel.Layers.Count;
            int nrOutputNeurons = mainPannel.Layers[mainPannel.Layers.Count - 1].Neurons.Count;
            double epoca = 0;
            if (nrSteps > normedTraining.Count)
            {
                throw new ArgumentException("Too Many steps");
            }

            for (int stepIndex = 0; stepIndex < nrSteps; stepIndex++)
            {
                mainPannel = GenerateInputLayer.Generate(stepIndex, mainPannel, normedTraining);
                mainPannel = DoMath(layerIndex, mainPannel);
                double error = 0;
                List<double> deltas = new List<double>();

                if (ignoreIndex == -1)
                {
                    for (int i = 0; i < nrOutputNeurons; ++i)
                    {
                        int classIndex = (int)(normedTraining[stepIndex].Class * 10);
                        double actualVsWanted = 0;
                        if (classIndex == i)
                        {
                            actualVsWanted = 1 - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
                        }
                        else
                        {
                            actualVsWanted = 0 - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
                        }

                        //double actualVsWanted = Multimi.AntrenamentNorm[stepIndex].Class - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
                        double activValue = mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Actv;
                        double delta;
                        if (mainPannel.Layers[nrLayers - 1].LayerFunctions.ActivCode == ActivCode.Sigmoidala)
                        {
                            delta = actualVsWanted * activValue * (1 - activValue);
                        }
                        else
                        {
                            delta = actualVsWanted * (1 - activValue * activValue);
                        }
                        for (int entryIndex = 0; entryIndex < mainPannel.Layers[nrLayers - 1].Neurons[i].Entries.Count; ++entryIndex)
                        {
                            double deltaW = delta * mainPannel.Layers[nrLayers - 2].Neurons[entryIndex].NeuronValues.Actv * mainPannel.LearningRate;
                            mainPannel.Layers[nrLayers - 1].Neurons[i].Entries[entryIndex].W += deltaW;
                        }

                        deltas.Add(delta);
                        error += Math.Pow(actualVsWanted, 2);
                    }
                }
                else
                {
                    for (int i = 0; i < nrOutputNeurons; ++i)
                    {
                        int classIndex = (int)(normedTraining[stepIndex].Class * 10);
                        double actualVsWanted = 0;
                        if (i == 0)
                        {
                            if (classIndex == ignoreIndex)
                            {

                                actualVsWanted = 1 - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
                            }
                            else
                            {
                                actualVsWanted = 0 - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
                            }
                        }
                        else
                        {
                            if (classIndex != ignoreIndex)
                            {

                                actualVsWanted = 1 - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
                            }
                            else
                            {
                                actualVsWanted = 0 - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
                            }
                        }

                        //double actualVsWanted = Multimi.AntrenamentNorm[stepIndex].Class - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
                        double activValue = mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Actv;
                        double delta;
                        if (mainPannel.Layers[nrLayers - 1].LayerFunctions.ActivCode == ActivCode.Sigmoidala)
                        {
                            delta = actualVsWanted * activValue * (1 - activValue);
                        }
                        else
                        {
                            delta = actualVsWanted * (1 - activValue * activValue);
                        }
                        for (int entryIndex = 0; entryIndex < mainPannel.Layers[nrLayers - 1].Neurons[i].Entries.Count; ++entryIndex)
                        {
                            double deltaW = delta * mainPannel.Layers[nrLayers - 2].Neurons[entryIndex].NeuronValues.Actv * mainPannel.LearningRate;
                            mainPannel.Layers[nrLayers - 1].Neurons[i].Entries[entryIndex].W += deltaW;
                        }

                        deltas.Add(delta);
                        error += Math.Pow(actualVsWanted, 2);
                    }
                }

                bool isDelta1 = true;
                List<double> deltas2 = new List<double>();

                for (int iLayer = nrLayers - 2; iLayer >= 1; --iLayer)
                {
                    if (isDelta1)
                    {
                        deltas2 = new List<double>();
                        for (int neuronIndex = 0; neuronIndex < mainPannel.Layers[iLayer].Neurons.Count; ++neuronIndex)
                        {
                            double delta = 0;
                            for (int deltaIndex = 0; deltaIndex < deltas.Count; ++deltaIndex)
                            {
                                delta += deltas[deltaIndex] * mainPannel.Layers[iLayer + 1].Neurons[deltaIndex].Entries[neuronIndex].W;
                            }
                            double activValue = mainPannel.Layers[iLayer].Neurons[neuronIndex].NeuronValues.Actv;
                            if (mainPannel.Layers[iLayer].LayerFunctions.ActivCode == ActivCode.Tanh)
                            {
                                delta *= (1 - activValue * activValue);
                            }
                            else
                            {
                                delta *= activValue * (1 - activValue);
                            }
                            deltas2.Add(delta);

                            for (int entryIndex = 0; entryIndex < mainPannel.Layers[iLayer].Neurons[neuronIndex].Entries.Count; ++entryIndex)
                            {
                                double deltaW = delta * mainPannel.Layers[iLayer - 1].Neurons[entryIndex].NeuronValues.Out.Value * mainPannel.LearningRate;
                                mainPannel.Layers[iLayer].Neurons[neuronIndex].Entries[entryIndex].W += deltaW;
                            }

                        }
                        isDelta1 = false;
                    }
                    else
                    {
                        deltas = new List<double>();
                        for (int neuronIndex = 0; neuronIndex < mainPannel.Layers[iLayer].Neurons.Count; ++neuronIndex)
                        {
                            double delta = 0;
                            for (int deltaIndex = 0; deltaIndex < deltas2.Count; ++deltaIndex)
                            {
                                delta += deltas2[deltaIndex] * mainPannel.Layers[iLayer + 1].Neurons[deltaIndex].Entries[neuronIndex].W;
                            }
                            double activValue = mainPannel.Layers[iLayer].Neurons[neuronIndex].NeuronValues.Actv;
                            if (mainPannel.Layers[iLayer].LayerFunctions.ActivCode == ActivCode.Tanh)
                            {
                                delta *= (1 - activValue * activValue);
                            }
                            else
                            {
                                delta *= activValue * (1 - activValue);
                            }
                            deltas.Add(delta);

                            for (int entryIndex = 0; entryIndex < mainPannel.Layers[iLayer].Neurons[neuronIndex].Entries.Count; ++entryIndex)
                            {
                                double deltaW = delta * mainPannel.Layers[iLayer - 1].Neurons[entryIndex].NeuronValues.Out.Value * mainPannel.LearningRate;
                                mainPannel.Layers[iLayer].Neurons[neuronIndex].Entries[entryIndex].W += deltaW;
                            }

                        }
                        isDelta1 = true;
                    }

                }
                double ePas = ((double)1 / 2) * error;
                epoca += ePas;
            }
            return (((double)epoca) / nrSteps, mainPannel);
        }
        #endregion

        #region EpochErrorSecondScenario
        //public (double error, MainPannel resultPannel) EroareEpoca(MainPannel mainPannel, List<NormalizedProperty> normedTraining, int nrSteps, int layerIndex = 0, int ignoreIndex = -1)
        //{
        //    int nrLayers = mainPannel.Layers.Count;
        //    int nrOutputNeurons = mainPannel.Layers[mainPannel.Layers.Count - 1].Neurons.Count;
        //    double epoca = 0;
        //    if (nrSteps > normedTraining.Count)
        //    {
        //        throw new ArgumentException("Too Many steps");
        //    }

        //    for (int stepIndex = 0; stepIndex < nrSteps; stepIndex++)
        //    {
        //        mainPannel = GenerateInputLayer.GenerateTraining(stepIndex, mainPannel, normedTraining);
        //        mainPannel = DoMath(layerIndex, mainPannel);
        //        double error = 0;
        //        List<double> deltas = new List<double>();

        //        if (ignoreIndex == -1)
        //        {
        //            for (int i = 0; i < nrOutputNeurons; ++i)
        //            {
        //                int classIndex = (int)(normedTraining[stepIndex].Class * 10);
        //                double actualVsWanted = 0;
        //                if (classIndex == i)
        //                {
        //                    actualVsWanted = 1 - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
        //                }
        //                else
        //                {
        //                    actualVsWanted = 0 - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
        //                }

        //                //double actualVsWanted = Multimi.AntrenamentNorm[stepIndex].Class - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
        //                double activValue = mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Actv;
        //                double delta;
        //                if (mainPannel.Layers[nrLayers - 1].LayerFunctions.ActivCode == ActivCode.Sigmoidala)
        //                {
        //                    delta = actualVsWanted * activValue * (1 - activValue);
        //                }
        //                else
        //                {
        //                    delta = actualVsWanted * (1 - activValue * activValue);
        //                }
        //                for (int entryIndex = 0; entryIndex < mainPannel.Layers[nrLayers - 1].Neurons[i].Entries.Count; ++entryIndex)
        //                {
        //                    double deltaW = delta * mainPannel.Layers[nrLayers - 2].Neurons[entryIndex].NeuronValues.Actv * mainPannel.LearningRate;
        //                    mainPannel.Layers[nrLayers - 1].Neurons[i].Entries[entryIndex].W += deltaW;
        //                }

        //                deltas.Add(delta);
        //                error += Math.Pow(actualVsWanted, 2);
        //            }
        //        }
        //        else
        //        {
        //            for (int i = 0; i < nrOutputNeurons; ++i)
        //            {
        //                int classIndex = (int)(normedTraining[stepIndex].Class * 10);
        //                double actualVsWanted = 0;
        //                if (i != ignoreIndex)
        //                {
        //                    if (classIndex == i)
        //                    {
        //                        actualVsWanted = 1 - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
        //                    }
        //                    else
        //                    {
        //                        actualVsWanted = 0 - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
        //                    }
        //                }
        //                else
        //                {
        //                    actualVsWanted = 0;
        //                }

        //                //double actualVsWanted = Multimi.AntrenamentNorm[stepIndex].Class - mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
        //                double activValue = mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Actv;
        //                double delta;
        //                if (mainPannel.Layers[nrLayers - 1].LayerFunctions.ActivCode == ActivCode.Sigmoidala)
        //                {
        //                    delta = actualVsWanted * activValue * (1 - activValue);
        //                }
        //                else
        //                {
        //                    delta = actualVsWanted * (1 - activValue * activValue);
        //                }
        //                for (int entryIndex = 0; entryIndex < mainPannel.Layers[nrLayers - 1].Neurons[i].Entries.Count; ++entryIndex)
        //                {
        //                    double deltaW = delta * mainPannel.Layers[nrLayers - 2].Neurons[entryIndex].NeuronValues.Actv * mainPannel.LearningRate;
        //                    mainPannel.Layers[nrLayers - 1].Neurons[i].Entries[entryIndex].W += deltaW;
        //                }

        //                deltas.Add(delta);
        //                error += Math.Pow(actualVsWanted, 2);
        //            }
        //        }

        //        bool isDelta1 = true;
        //        List<double> deltas2 = new List<double>();

        //        for (int iLayer = nrLayers - 2; iLayer >= 1; --iLayer)
        //        {
        //            if (isDelta1)
        //            {
        //                deltas2 = new List<double>();
        //                for (int neuronIndex = 0; neuronIndex < mainPannel.Layers[iLayer].Neurons.Count; ++neuronIndex)
        //                {
        //                    double delta = 0;
        //                    for (int deltaIndex = 0; deltaIndex < deltas.Count; ++deltaIndex)
        //                    {
        //                        delta += deltas[deltaIndex] * mainPannel.Layers[iLayer + 1].Neurons[deltaIndex].Entries[neuronIndex].W;
        //                    }
        //                    double activValue = mainPannel.Layers[iLayer].Neurons[neuronIndex].NeuronValues.Actv;
        //                    if (mainPannel.Layers[iLayer].LayerFunctions.ActivCode == ActivCode.Tanh)
        //                    {
        //                        delta *= (1 - activValue * activValue);
        //                    }
        //                    else
        //                    {
        //                        delta *= activValue * (1 - activValue);
        //                    }
        //                    deltas2.Add(delta);

        //                    for (int entryIndex = 0; entryIndex < mainPannel.Layers[iLayer].Neurons[neuronIndex].Entries.Count; ++entryIndex)
        //                    {
        //                        double deltaW = delta * mainPannel.Layers[iLayer - 1].Neurons[entryIndex].NeuronValues.Out.Value * mainPannel.LearningRate;
        //                        mainPannel.Layers[iLayer].Neurons[neuronIndex].Entries[entryIndex].W += deltaW;
        //                    }

        //                }
        //                isDelta1 = false;
        //            }
        //            else
        //            {
        //                deltas = new List<double>();
        //                for (int neuronIndex = 0; neuronIndex < mainPannel.Layers[iLayer].Neurons.Count; ++neuronIndex)
        //                {
        //                    double delta = 0;
        //                    for (int deltaIndex = 0; deltaIndex < deltas2.Count; ++deltaIndex)
        //                    {
        //                        delta += deltas2[deltaIndex] * mainPannel.Layers[iLayer + 1].Neurons[deltaIndex].Entries[neuronIndex].W;
        //                    }
        //                    double activValue = mainPannel.Layers[iLayer].Neurons[neuronIndex].NeuronValues.Actv;
        //                    if (mainPannel.Layers[iLayer].LayerFunctions.ActivCode == ActivCode.Tanh)
        //                    {
        //                        delta *= (1 - activValue * activValue);
        //                    }
        //                    else
        //                    {
        //                        delta *= activValue * (1 - activValue);
        //                    }
        //                    deltas.Add(delta);

        //                    for (int entryIndex = 0; entryIndex < mainPannel.Layers[iLayer].Neurons[neuronIndex].Entries.Count; ++entryIndex)
        //                    {
        //                        double deltaW = delta * mainPannel.Layers[iLayer - 1].Neurons[entryIndex].NeuronValues.Out.Value * mainPannel.LearningRate;
        //                        mainPannel.Layers[iLayer].Neurons[neuronIndex].Entries[entryIndex].W += deltaW;
        //                    }

        //                }
        //                isDelta1 = true;
        //            }

        //        }
        //        double ePas = ((double)1 / 2) * error;
        //        epoca += ePas;
        //    }
        //    return (((double)epoca) / nrSteps, mainPannel);
        //}
        #endregion

        public MainPannel DoMath(int layerIndex, MainPannel mainPannel)
        {
            int nrLayers = mainPannel.Layers.Count;
            for (int i = layerIndex; i < nrLayers; ++i)
            {
                if (i == 0)
                {
                    foreach (var neuron in mainPannel.Layers[i].Neurons)
                    {
                        neuron.NeuronValues.Gin = neuron.Entries[0].X.Value;
                        neuron.NeuronValues.Actv = neuron.NeuronValues.Gin;
                        neuron.NeuronValues.Out.Value = neuron.NeuronValues.Gin;
                    }
                }
                else
                {
                    foreach (var neuron in mainPannel.Layers[i].Neurons)
                    {
                        neuron.NeuronValues.Gin = GlobalInput.Value(neuron.Entries, mainPannel.Layers[i].LayerFunctions.GICode);
                        neuron.NeuronValues.Actv = Activation.getValue(mainPannel.Layers[i].LayerFunctions.ActivCode,
                            neuron.NeuronValues.Gin, mainPannel.Layers[i].Teta, mainPannel.Layers[i].G, mainPannel.Layers[i].A);
                        if (mainPannel.Layers[i].LayerFunctions.IsReal == false)
                        {
                            neuron.NeuronValues.Out.Value = BinaryOutput.getValue(neuron.NeuronValues.Actv,
                                mainPannel.Layers[i].LayerFunctions.ActivCode);
                        }
                        else
                        {
                            neuron.NeuronValues.Out.Value = neuron.NeuronValues.Actv;
                        }
                    }
                }
            }

            return mainPannel;
        }

        #region Testing
        public Dictionary<int, double> Testing(MainPannel mainPannel, int steps, List<NormalizedProperty> normedTesting, int ignoreIndex = 10)
        {
            int nrLayers = mainPannel.Layers.Count;
            if (steps > normedTesting.Count)
            {
                throw new ArgumentException("too many steps!");
            }
            Dictionary<int, double> scorePerDriver = new Dictionary<int, double>()
            {
                {0, 0},
                {1, 0},
            };
            for (int stepIndex = 0; stepIndex < steps; stepIndex++)
            {
                mainPannel = GenerateInputLayer.Generate(stepIndex, mainPannel, normedTesting);
                mainPannel = DoMath(0, mainPannel);
                double classValue = normedTesting[stepIndex].Class;
                int classIndex = (int)(classValue * 10);
                mainPannel.Layers[nrLayers - 1].Neurons = SoftMax(mainPannel.Layers[nrLayers - 1].Neurons);

                if(classIndex == ignoreIndex)
                {
                    double outValue = mainPannel.Layers[nrLayers - 1].Neurons[0].NeuronValues.Out.Value;
                    if (outValue > 90)
                    {
                        scorePerDriver[0] += 1;
                    }
                }
                else
                {
                    double outValue = mainPannel.Layers[nrLayers - 1].Neurons[1].NeuronValues.Out.Value;
                    if (outValue > 90)
                    {
                        scorePerDriver[1] += 1;
                    }
                }
                
            }
            scorePerDriver[0] = (scorePerDriver[0] / normedTesting.Where(x => (int)(x.Class * 10) == ignoreIndex).Count()) * 100;
            scorePerDriver[1] = (scorePerDriver[1] / normedTesting.Where(x => (int)(x.Class * 10) != ignoreIndex).Count()) * 100;
            return scorePerDriver;
        }
        #endregion

        #region TestingSecondStage
        //public Dictionary<int, double> Testing(MainPannel mainPannel, int steps, List<NormalizedProperty> normedTesting, int ignoreIndex = 10)
        //{
        //    int nrLayers = mainPannel.Layers.Count;
        //    if (steps > normedTesting.Count)
        //    {
        //        throw new ArgumentException("too many steps!");
        //    }
        //    Dictionary<int, double> scorePerDriver = new Dictionary<int, double>()
        //    {
        //        { 0,0 },
        //        {1,0 },
        //        {2,0 },
        //        {3,0 },
        //        {4,0 },
        //        {5,0 },
        //        {6,0 },
        //        {7,0 },
        //        {8,0 },
        //        {9,0 },
        //    };
        //    for (int stepIndex = 0; stepIndex < steps; stepIndex++)
        //    {
        //        mainPannel = GenerateInputLayer.GenerateTesting(stepIndex, mainPannel, normedTesting);
        //        mainPannel = DoMath(0, mainPannel);
        //        double classValue = normedTesting[stepIndex].Class;
        //        int classIndex = (int)(classValue * 10);
        //        //double outValue = mainPannel.Layers[nrLayers - 1].Neurons[classIndex].NeuronValues.Out.Value;
        //        if (ignoreIndex < 10)
        //        {
        //            mainPannel.Layers[nrLayers - 1].Neurons[ignoreIndex].NeuronValues.Out.Value = 0;
        //        }
        //        mainPannel.Layers[nrLayers - 1].Neurons = SoftMax(mainPannel.Layers[nrLayers - 1].Neurons);
        //        double outValue = mainPannel.Layers[nrLayers - 1].Neurons[classIndex].NeuronValues.Out.Value;
        //        if (outValue > 90)
        //        {
        //            scorePerDriver[classIndex] += 1;
        //        }
        //    }
        //    for (int index = 0; index < scorePerDriver.Count; ++index)
        //    {
        //        int nrOfValues = normedTesting.Where(x => (int)(x.Class * 10) == index).Count();
        //        scorePerDriver[index] = (scorePerDriver[index] / nrOfValues) * 100;
        //    }
        //    return scorePerDriver;
        //}
        #endregion

        #region BetterTesting
        public Dictionary<int, List<double>> BetterTesting(MainPannel mainPannel, int steps, List<NormalizedProperty> normedTesting, int ignoreIndex = 10)
        {
            int nrLayers = mainPannel.Layers.Count;
            if (steps > normedTesting.Count)
            {
                throw new ArgumentException("too many steps!");
            }
            Dictionary<int, List<double>> scorePerDriver = new Dictionary<int, List<double>>()
            {
                { 0,new List<double>() },
                { 1,new List<double>() },
            };
            for (int stepIndex = 0; stepIndex < steps; stepIndex++)
            {
                mainPannel = GenerateInputLayer.Generate(stepIndex, mainPannel, normedTesting);
                mainPannel = DoMath(0, mainPannel);
                mainPannel.Layers[nrLayers - 1].Neurons = SoftMax(mainPannel.Layers[nrLayers - 1].Neurons);
                double classValue = normedTesting[stepIndex].Class;
                int classIndex = (int)(classValue * 10);
                if (classIndex == ignoreIndex)
                {
                    double outValue = mainPannel.Layers[nrLayers - 1].Neurons[0].NeuronValues.Out.Value;
                    scorePerDriver[0].Add(outValue);
                }
                else
                {
                    double outValue = mainPannel.Layers[nrLayers - 1].Neurons[1].NeuronValues.Out.Value;
                    scorePerDriver[1].Add(outValue);
                }
            }
            return scorePerDriver;
        }
        #endregion

        #region BetterTestingSecondStage
        //public Dictionary<int, List<double>> BetterTesting(MainPannel mainPannel, int steps, List<NormalizedProperty> normedTesting, int ignoreIndex = 10)
        //{
        //    int nrLayers = mainPannel.Layers.Count;
        //    if (steps > normedTesting.Count)
        //    {
        //        throw new ArgumentException("too many steps!");
        //    }
        //    Dictionary<int, List<double>> scorePerDriver = new Dictionary<int, List<double>>()
        //    {
        //        { 0,new List<double>() },
        //        { 1,new List<double>() },
        //        { 2,new List<double>() },
        //        { 3,new List<double>() },
        //        { 4,new List<double>() },
        //        { 5,new List<double>() },
        //        { 6,new List<double>() },
        //        { 7,new List<double>() },
        //        { 8,new List<double>() },
        //        { 9,new List<double>() },
        //    };
        //    for (int stepIndex = 0; stepIndex < steps; stepIndex++)
        //    {
        //        mainPannel = GenerateInputLayer.GenerateTesting(stepIndex, mainPannel, normedTesting);
        //        mainPannel = DoMath(0, mainPannel);
        //        double classValue = normedTesting[stepIndex].Class;
        //        int classIndex = (int)(classValue * 10);
        //        //double outValue = mainPannel.Layers[nrLayers - 1].Neurons[classIndex].NeuronValues.Out.Value;
        //        if (ignoreIndex < 10)
        //        {
        //            mainPannel.Layers[nrLayers - 1].Neurons[ignoreIndex].NeuronValues.Out.Value = 0;
        //        }
        //        mainPannel.Layers[nrLayers - 1].Neurons = SoftMax(mainPannel.Layers[nrLayers - 1].Neurons);
        //        double outValue = mainPannel.Layers[nrLayers - 1].Neurons[classIndex].NeuronValues.Out.Value;
        //        scorePerDriver[classIndex].Add(outValue);
        //    }
        //    return scorePerDriver;
        //}
        #endregion

        public Dictionary<int, List<double>> BetterExecution(MainPannel mainPannel, int steps, List<NormalizedProperty> normedTesting, int ignoreIndex = 10)
        {
            int nrLayers = mainPannel.Layers.Count;
            if (steps > normedTesting.Count)
            {
                throw new ArgumentException("too many steps!");
            }
            Dictionary<int, List<double>> scorePerDriver = new Dictionary<int, List<double>>()
            {
                { 0,new List<double>() },
                { 1,new List<double>() },
            };
            for (int stepIndex = 0; stepIndex < steps; stepIndex++)
            {
                mainPannel = GenerateInputLayer.Generate(stepIndex, mainPannel, normedTesting);
                mainPannel = DoMath(0, mainPannel);
                mainPannel.Layers[nrLayers - 1].Neurons = SoftMax(mainPannel.Layers[nrLayers - 1].Neurons);
                for (int i = 0; i < scorePerDriver.Count; ++i)
                {
                    double outValue = mainPannel.Layers[nrLayers - 1].Neurons[i].NeuronValues.Out.Value;
                    scorePerDriver[i].Add(outValue);
                }
            }
            return scorePerDriver;
        }

        #region Stopping

        public double Stopping(MainPannel mainPannel, int steps, List<NormalizedProperty> normedTesting, int ignoreIndex = 10)
        {
            int nrLayers = mainPannel.Layers.Count;
            int score = 0;
            if (steps > normedTesting.Count)
            {
                throw new ArgumentException("too many steps!");
            }
            for (int stepIndex = 0; stepIndex < steps; stepIndex++)
            {
                mainPannel = GenerateInputLayer.Generate(stepIndex, mainPannel, normedTesting);
                mainPannel = DoMath(0, mainPannel);
                double classValue = normedTesting[stepIndex].Class;
                int classIndex = (int)(classValue * 10);
                mainPannel.Layers[nrLayers - 1].Neurons = SoftMax(mainPannel.Layers[nrLayers - 1].Neurons);
                if (classIndex == ignoreIndex)
                {
                    double outValue = mainPannel.Layers[nrLayers - 1].Neurons[0].NeuronValues.Out.Value;
                    if (outValue > 90)
                    {
                        score++;
                    }
                }
                else
                {
                    double outValue = mainPannel.Layers[nrLayers - 1].Neurons[1].NeuronValues.Out.Value;
                    if (outValue > 90)
                    {
                        score++;
                    }
                }
                
            }
            return ((double)score / steps) * 100;
        }
        #endregion

        #region StoppingSecondStage
        //public double Stopping(MainPannel mainPannel, int steps, List<NormalizedProperty> normedTesting, int ignoreIndex = 10)
        //{
        //    int nrLayers = mainPannel.Layers.Count;
        //    int score = 0;
        //    if (steps > normedTesting.Count)
        //    {
        //        throw new ArgumentException("too many steps!");
        //    }
        //    for (int stepIndex = 0; stepIndex < steps; stepIndex++)
        //    {
        //        mainPannel = GenerateInputLayer.GenerateTesting(stepIndex, mainPannel, normedTesting);
        //        mainPannel = DoMath(0, mainPannel);
        //        double classValue = normedTesting[stepIndex].Class;
        //        int classIndex = (int)(classValue * 10);
        //        //double outValue = mainPannel.Layers[nrLayers - 1].Neurons[classIndex].NeuronValues.Out.Value;
        //        if (ignoreIndex < 10)
        //        {
        //            mainPannel.Layers[nrLayers - 1].Neurons[ignoreIndex].NeuronValues.Out.Value = 0;
        //        }
        //        mainPannel.Layers[nrLayers - 1].Neurons = SoftMax(mainPannel.Layers[nrLayers - 1].Neurons);
        //        double outValue = mainPannel.Layers[nrLayers - 1].Neurons[classIndex].NeuronValues.Out.Value;
        //        if (outValue > 90)
        //        {
        //            score++;
        //        }
        //    }
        //    return ((double)score / steps) * 100;
        //}
        #endregion

        public Dictionary<int, double> Executing(MainPannel mainPannel, int steps, List<NormalizedProperty> normedTesting, int ignoreIndex = 10)
        {
            int nrLayers = mainPannel.Layers.Count;
            Dictionary<int, double> scorePerDriver = new Dictionary<int, double>()
            {
                {0,0 },
                {1,0 },
                {2,0 },
                {3,0 },
                {4,0 },
                {5,0 },
                {6,0 },
                {7,0 },
                {8,0 },
                {9,0 },
            };
            if (steps > normedTesting.Count)
            {
                throw new ArgumentException("too many steps!");
            }
            double sum = 0;
            for (int stepIndex = 0; stepIndex < steps; stepIndex++)
            {
                mainPannel = GenerateInputLayer.Generate(stepIndex, mainPannel, normedTesting);
                mainPannel = DoMath(0, mainPannel);
                double classValue = normedTesting[stepIndex].Class;
                int classIndex = (int)(classValue * 10);
                if (ignoreIndex < 10)
                {
                    mainPannel.Layers[nrLayers - 1].Neurons[ignoreIndex].NeuronValues.Out.Value = 0;
                }
                mainPannel.Layers[nrLayers - 1].Neurons = SoftMax(mainPannel.Layers[nrLayers - 1].Neurons);
                for (int index = 0; index < scorePerDriver.Count; ++index)
                {
                    double value = mainPannel.Layers[nrLayers - 1].Neurons[index].NeuronValues.Out.Value;
                    if (value > 90)
                    {
                        scorePerDriver[index] += 1;
                    }
                }
            }
            for (int index = 0; index < scorePerDriver.Count; ++index)
            {
                scorePerDriver[index] = (scorePerDriver[index] / normedTesting.Count) * 100;
            }
            return scorePerDriver;
        }

        public Dictionary<int, double> Executing(MainPannel mainPannel, int steps, List<NormalizedProperty> normedTesting, Dictionary<int, double> threshold, int ignoreIndex = 10)
        {
            int nrLayers = mainPannel.Layers.Count;
            Dictionary<int, double> scorePerDriver = new Dictionary<int, double>()
            {
                {0,0 },
                {1,0 },
            };
            if (steps > normedTesting.Count)
            {
                throw new ArgumentException("too many steps!");
            }
            double sum = 0;
            for (int stepIndex = 0; stepIndex < steps; stepIndex++)
            {
                mainPannel = GenerateInputLayer.Generate(stepIndex, mainPannel, normedTesting);
                mainPannel = DoMath(0, mainPannel);
                double classValue = normedTesting[stepIndex].Class;
                int classIndex = (int)(classValue * 10);
                mainPannel.Layers[nrLayers - 1].Neurons = SoftMax(mainPannel.Layers[nrLayers - 1].Neurons);
                for (int index = 0; index < scorePerDriver.Count; ++index)
                {
                    //sum += mainPannel.Layers[nrLayers - 1].Neurons[index].NeuronValues.Out.Value;
                    //scorePerDriver[index] += mainPannel.Layers[nrLayers - 1].Neurons[index].NeuronValues.Out.Value;
                    double value = mainPannel.Layers[nrLayers - 1].Neurons[index].NeuronValues.Out.Value;
                    if (value > threshold[index])
                    {
                        scorePerDriver[index] += 1;
                    }
                }
            }
            for (int index = 0; index < scorePerDriver.Count; ++index)
            {
                scorePerDriver[index] = (scorePerDriver[index] / normedTesting.Count) * 100;
            }
            return scorePerDriver;
        }

        public List<Neuron> SoftMax(List<Neuron> neurons)
        {
            double sum = 0;
            foreach (Neuron neuron in neurons)
            {

                sum += neuron.NeuronValues.Out.Value;
            }
            foreach (Neuron neuron in neurons)
            {
                neuron.NeuronValues.Out.Value = (neuron.NeuronValues.Out.Value / sum) * 100;
            }

            return neurons;
        }

        public double StandardDeviation(List<double> values)
        {
            double result = 0;
            double sum = 0;
            double mean = values.Average();
            sum = values.Sum(x => Math.Pow(x - mean, 2));
            result = Math.Sqrt(sum / values.Count());
            return result;
        }
    }
}
