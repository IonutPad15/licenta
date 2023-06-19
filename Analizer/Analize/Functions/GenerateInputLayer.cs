using Analizer.Entities;
using System.Collections.Generic;
using System.Text;

namespace Analizer.Functions
{
    public class GenerateInputLayer
    {
        #region Generate Testing
        public static MainPannel Generate(int stepIndex, MainPannel mainPannel, List<NormalizedProperty> normedTesting)
        {
            int numberOfNeurons = mainPannel.Layers[0].Neurons.Count;
            if (numberOfNeurons == 53)
            {
                return GenerateDefault(stepIndex, mainPannel, normedTesting);
            }
            else if (numberOfNeurons == 6)
            {
                return GenerateImportant(stepIndex, mainPannel, normedTesting);
            }
            else if (numberOfNeurons == 14)
            {
                return GenerateMedium(stepIndex, mainPannel, normedTesting);
            }
            else if (numberOfNeurons == 38)
            {
                return GenerateWeak(stepIndex, mainPannel, normedTesting);
            }
            return mainPannel;

        }

        static MainPannel GenerateDefault(int stepIndex, MainPannel mainPannel, List<NormalizedProperty> normedTesting)
        {
            int index = 0;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].FuelConsumption;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].AcceleratorPedalValue;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].ThrottlePositionSignal;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].ShortTermFuelTrimBank1;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].IntakeAirPressure;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].FilteredAcceleratorPedalValue;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].AbsoluteThrottlePosition;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineSoackingTime;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].InhibitionOfEngineFuelCutOff;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineInFuelCutOff;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].FuelPressure;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].LongTermFuelTrimBank1;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineSpeed;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineTorqueAfterCorrection;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TorqueOfFriction;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].FlywheelTorqueAfterTorqueInterventions;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].CurrentSparkTiming;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineCoolantTemperature1;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineIdlETargetSpeed;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineTorque;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].CalculatedLoadValue;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].MinimumIndicatedEngineTorque;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].MaximumIndicatedEngineTorque;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].FlywheelTorque;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TorqueScalingFactorStandardization;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].StandardTorqueRatio;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].RequestedSparkRetardAngleFromTCU;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TCURequestsEngineTorqueLimitETL;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TCURequestedEngineRPMIncrease;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TargetEngineSpeedUsedInLockUpModule;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].GlowPlugControlRequest;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].ActivationOfAirCompressor;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TorqueConverterSpeed;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].CurrentGear;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineCoolantTemperature2;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].WheelVelocityFrontLeftHand;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].WheelVelocityRearRightHand;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].WheelVelocityFrontRightHand;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].WheelVelocityRearLeftHand;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TorqueConverterTurbineSpeedUnfiltered;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].ClutchOperationAcknowledge;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].ConverterClutch;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].GearSelection;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].VehicleSpeed;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].AccelerationSpeedLongitudinal;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].IndicationOfBrakeSwitchON_OFF;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].MasterCylinderPressure;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].CalculatedRoadGradient;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].AccelerationSpeedLateral;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].SteeringWheelSpeed;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].SteeringWheelAngle;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].Time;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].PathOrder;

            return mainPannel;
        }

        static MainPannel GenerateImportant(int stepIndex, MainPannel mainPannel, List<NormalizedProperty> normedTesting)
        {
            int index = 0;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].LongTermFuelTrimBank1;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineSoackingTime;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineCoolantTemperature2;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TorqueOfFriction;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].IntakeAirPressure;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].ActivationOfAirCompressor;

            return mainPannel;
        }

        static MainPannel GenerateMedium(int stepIndex, MainPannel mainPannel, List<NormalizedProperty> normedTesting)
        {
            int index = 0;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].LongTermFuelTrimBank1;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineSoackingTime;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineCoolantTemperature2;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TorqueOfFriction;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].IntakeAirPressure;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].ActivationOfAirCompressor;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].Time;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].AcceleratorPedalValue;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineTorque;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].MaximumIndicatedEngineTorque;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].CalculatedLoadValue;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].ThrottlePositionSignal;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineTorqueAfterCorrection;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineCoolantTemperature1;

            return mainPannel;
        }

        static MainPannel GenerateWeak(int stepIndex, MainPannel mainPannel, List<NormalizedProperty> normedTesting)
        {
            int index = 0;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].LongTermFuelTrimBank1;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineSoackingTime;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineCoolantTemperature2;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TorqueOfFriction;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].IntakeAirPressure;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].ActivationOfAirCompressor;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].Time;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].AcceleratorPedalValue;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineTorque;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].MaximumIndicatedEngineTorque;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].PathOrder;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].ThrottlePositionSignal;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineTorqueAfterCorrection;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineCoolantTemperature1;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].CalculatedLoadValue;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].CurrentSparkTiming;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].CurrentGear;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].WheelVelocityFrontLeftHand;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].WheelVelocityRearRightHand;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].WheelVelocityFrontRightHand;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].WheelVelocityRearLeftHand;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].CalculatedRoadGradient;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].FuelConsumption;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].MasterCylinderPressure;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].AccelerationSpeedLongitudinal;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].SteeringWheelAngle;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].EngineSpeed;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].FlywheelTorque;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TorqueConverterTurbineSpeedUnfiltered;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TorqueConverterSpeed;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].FlywheelTorqueAfterTorqueInterventions;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].ShortTermFuelTrimBank1;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].AccelerationSpeedLateral;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].VehicleSpeed;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].TCURequestsEngineTorqueLimitETL;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].SteeringWheelSpeed;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].GearSelection;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedTesting[stepIndex].MinimumIndicatedEngineTorque;

            return mainPannel;
        }
#endregion

        #region ToStrings
        public static string ToStringTraining(int pasIndex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Sets.TrainingRaw[pasIndex].FuelConsumption.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].AcceleratorPedalValue.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].ThrottlePositionSignal.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].ShortTermFuelTrimBank1.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].IntakeAirPressure.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].FilteredAcceleratorPedalValue.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].AbsoluteThrottlePosition.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].EngineSoackingTime.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].InhibitionOfEngineFuelCutOff.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].EngineInFuelCutOff.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].FuelPressure.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].LongTermFuelTrimBank1.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].EngineSpeed.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].EngineTorqueAfterCorrection.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].TorqueOfFriction.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].FlywheelTorqueAfterTorqueInterventions.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].CurrentSparkTiming.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].EngineCoolantTemperature1.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].EngineIdlETargetSpeed.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].EngineTorque.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].CalculatedLoadValue.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].MinimumIndicatedEngineTorque.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].MaximumIndicatedEngineTorque.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].FlywheelTorque.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].TorqueScalingFactorStandardization.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].StandardTorqueRatio.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].RequestedSparkRetardAngleFromTCU.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].TCURequestsEngineTorqueLimitETL.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].TCURequestedEngineRPMIncrease.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].TargetEngineSpeedUsedInLockUpModule.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].GlowPlugControlRequest.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].ActivationOfAirCompressor.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].TorqueConverterSpeed.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].CurrentGear.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].EngineCoolantTemperature2.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].WheelVelocityFrontLeftHand.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].WheelVelocityRearRightHand.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].WheelVelocityFrontRightHand.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].WheelVelocityRearLeftHand.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].TorqueConverterTurbineSpeedUnfiltered.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].ClutchOperationAcknowledge.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].ConverterClutch.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].GearSelection.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].VehicleSpeed.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].AccelerationSpeedLongitudinal.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].IndicationOfBrakeSwitchON_OFF.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].MasterCylinderPressure.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].CalculatedRoadGradient.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].AccelerationSpeedLateral.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].SteeringWheelSpeed.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].SteeringWheelAngle.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].Time.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].Class.ToString() + ",");
            sb.Append(Sets.TrainingRaw[pasIndex].PathOrder.ToString());
            return sb.ToString() + ",";
        }
        public static string ToStringTesting(int pasIndex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Sets.TestingRaw[pasIndex].FuelConsumption.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].AcceleratorPedalValue.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].ThrottlePositionSignal.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].ShortTermFuelTrimBank1.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].IntakeAirPressure.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].FilteredAcceleratorPedalValue.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].AbsoluteThrottlePosition.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].EngineSoackingTime.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].InhibitionOfEngineFuelCutOff.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].EngineInFuelCutOff.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].FuelPressure.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].LongTermFuelTrimBank1.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].EngineSpeed.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].EngineTorqueAfterCorrection.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].TorqueOfFriction.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].FlywheelTorqueAfterTorqueInterventions.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].CurrentSparkTiming.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].EngineCoolantTemperature1.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].EngineIdlETargetSpeed.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].EngineTorque.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].CalculatedLoadValue.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].MinimumIndicatedEngineTorque.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].MaximumIndicatedEngineTorque.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].FlywheelTorque.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].TorqueScalingFactorStandardization.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].StandardTorqueRatio.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].RequestedSparkRetardAngleFromTCU.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].TCURequestsEngineTorqueLimitETL.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].TCURequestedEngineRPMIncrease.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].TargetEngineSpeedUsedInLockUpModule.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].GlowPlugControlRequest.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].ActivationOfAirCompressor.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].TorqueConverterSpeed.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].CurrentGear.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].EngineCoolantTemperature2.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].WheelVelocityFrontLeftHand.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].WheelVelocityRearRightHand.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].WheelVelocityFrontRightHand.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].WheelVelocityRearLeftHand.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].TorqueConverterTurbineSpeedUnfiltered.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].ClutchOperationAcknowledge.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].ConverterClutch.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].GearSelection.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].VehicleSpeed.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].AccelerationSpeedLongitudinal.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].IndicationOfBrakeSwitchON_OFF.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].MasterCylinderPressure.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].CalculatedRoadGradient.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].AccelerationSpeedLateral.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].SteeringWheelSpeed.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].SteeringWheelAngle.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].Time.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].Class.ToString() + ",");
            sb.Append(Sets.TestingRaw[pasIndex].PathOrder.ToString());
            return sb.ToString() + ",";
        }

        public static string ToStringStopping(int pasIndex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Sets.StoppingRaw[pasIndex].FuelConsumption.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].AcceleratorPedalValue.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].ThrottlePositionSignal.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].ShortTermFuelTrimBank1.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].IntakeAirPressure.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].FilteredAcceleratorPedalValue.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].AbsoluteThrottlePosition.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].EngineSoackingTime.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].InhibitionOfEngineFuelCutOff.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].EngineInFuelCutOff.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].FuelPressure.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].LongTermFuelTrimBank1.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].EngineSpeed.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].EngineTorqueAfterCorrection.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].TorqueOfFriction.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].FlywheelTorqueAfterTorqueInterventions.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].CurrentSparkTiming.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].EngineCoolantTemperature1.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].EngineIdlETargetSpeed.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].EngineTorque.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].CalculatedLoadValue.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].MinimumIndicatedEngineTorque.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].MaximumIndicatedEngineTorque.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].FlywheelTorque.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].TorqueScalingFactorStandardization.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].StandardTorqueRatio.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].RequestedSparkRetardAngleFromTCU.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].TCURequestsEngineTorqueLimitETL.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].TCURequestedEngineRPMIncrease.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].TargetEngineSpeedUsedInLockUpModule.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].GlowPlugControlRequest.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].ActivationOfAirCompressor.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].TorqueConverterSpeed.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].CurrentGear.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].EngineCoolantTemperature2.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].WheelVelocityFrontLeftHand.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].WheelVelocityRearRightHand.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].WheelVelocityFrontRightHand.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].WheelVelocityRearLeftHand.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].TorqueConverterTurbineSpeedUnfiltered.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].ClutchOperationAcknowledge.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].ConverterClutch.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].GearSelection.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].VehicleSpeed.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].AccelerationSpeedLongitudinal.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].IndicationOfBrakeSwitchON_OFF.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].MasterCylinderPressure.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].CalculatedRoadGradient.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].AccelerationSpeedLateral.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].SteeringWheelSpeed.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].SteeringWheelAngle.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].Time.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].Class.ToString() + ",");
            sb.Append(Sets.StoppingRaw[pasIndex].PathOrder.ToString());
            return sb.ToString() + ",";

        }

        public static MainPannel GenerareExec(NormalizedProperty normedExec, MainPannel mainPannel)
        {
            int index = 0;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value =normedExec.LongTermFuelTrimBank1;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.EngineSoackingTime;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.EngineCoolantTemperature2;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.TorqueOfFriction;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.IntakeAirPressure;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.ActivationOfAirCompressor;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.Time;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.AcceleratorPedalValue;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.EngineTorque;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.MaximumIndicatedEngineTorque;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.PathOrder;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.ThrottlePositionSignal;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.EngineTorqueAfterCorrection;
            ++index;
            mainPannel.Layers[0].Neurons[index].Entries[0].X.Value = normedExec.EngineCoolantTemperature1;
            ++index;

            return mainPannel;
        }
        public static string ToStringTestingNorm(int pasIndex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Sets.TestingNorm[pasIndex].FuelConsumption.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].AcceleratorPedalValue.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].ThrottlePositionSignal.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].ShortTermFuelTrimBank1.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].IntakeAirPressure.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].FilteredAcceleratorPedalValue.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].AbsoluteThrottlePosition.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].EngineSoackingTime.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].InhibitionOfEngineFuelCutOff.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].EngineInFuelCutOff.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].FuelPressure.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].LongTermFuelTrimBank1.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].EngineSpeed.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].EngineTorqueAfterCorrection.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].TorqueOfFriction.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].FlywheelTorqueAfterTorqueInterventions.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].CurrentSparkTiming.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].EngineCoolantTemperature1.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].EngineIdlETargetSpeed.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].EngineTorque.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].CalculatedLoadValue.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].MinimumIndicatedEngineTorque.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].MaximumIndicatedEngineTorque.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].FlywheelTorque.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].TorqueScalingFactorStandardization.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].StandardTorqueRatio.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].RequestedSparkRetardAngleFromTCU.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].TCURequestsEngineTorqueLimitETL.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].TCURequestedEngineRPMIncrease.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].TargetEngineSpeedUsedInLockUpModule.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].GlowPlugControlRequest.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].ActivationOfAirCompressor.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].TorqueConverterSpeed.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].CurrentGear.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].EngineCoolantTemperature2.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].WheelVelocityFrontLeftHand.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].WheelVelocityRearRightHand.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].WheelVelocityFrontRightHand.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].WheelVelocityRearLeftHand.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].TorqueConverterTurbineSpeedUnfiltered.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].ClutchOperationAcknowledge.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].ConverterClutch.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].GearSelection.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].VehicleSpeed.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].AccelerationSpeedLongitudinal.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].IndicationOfBrakeSwitchON_OFF.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].MasterCylinderPressure.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].CalculatedRoadGradient.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].AccelerationSpeedLateral.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].SteeringWheelSpeed.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].SteeringWheelAngle.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].Time.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].Class.ToString() + ",");
            sb.Append(Sets.TestingNorm[pasIndex].PathOrder.ToString());
            return sb.ToString() + ",";
        }

        public static string ToStringTrainingNorm(int pasIndex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Sets.TrainingNorm[pasIndex].FuelConsumption.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].AcceleratorPedalValue.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].ThrottlePositionSignal.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].ShortTermFuelTrimBank1.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].IntakeAirPressure.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].FilteredAcceleratorPedalValue.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].AbsoluteThrottlePosition.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].EngineSoackingTime.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].InhibitionOfEngineFuelCutOff.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].EngineInFuelCutOff.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].FuelPressure.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].LongTermFuelTrimBank1.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].EngineSpeed.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].EngineTorqueAfterCorrection.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].TorqueOfFriction.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].FlywheelTorqueAfterTorqueInterventions.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].CurrentSparkTiming.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].EngineCoolantTemperature1.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].EngineIdlETargetSpeed.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].EngineTorque.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].CalculatedLoadValue.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].MinimumIndicatedEngineTorque.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].MaximumIndicatedEngineTorque.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].FlywheelTorque.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].TorqueScalingFactorStandardization.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].StandardTorqueRatio.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].RequestedSparkRetardAngleFromTCU.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].TCURequestsEngineTorqueLimitETL.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].TCURequestedEngineRPMIncrease.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].TargetEngineSpeedUsedInLockUpModule.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].GlowPlugControlRequest.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].ActivationOfAirCompressor.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].TorqueConverterSpeed.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].CurrentGear.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].EngineCoolantTemperature2.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].WheelVelocityFrontLeftHand.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].WheelVelocityRearRightHand.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].WheelVelocityFrontRightHand.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].WheelVelocityRearLeftHand.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].TorqueConverterTurbineSpeedUnfiltered.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].ClutchOperationAcknowledge.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].ConverterClutch.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].GearSelection.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].VehicleSpeed.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].AccelerationSpeedLongitudinal.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].IndicationOfBrakeSwitchON_OFF.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].MasterCylinderPressure.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].CalculatedRoadGradient.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].AccelerationSpeedLateral.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].SteeringWheelSpeed.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].SteeringWheelAngle.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].Time.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].Class.ToString() + ",");
            sb.Append(Sets.TrainingNorm[pasIndex].PathOrder.ToString());
            return sb.ToString() + ",";
        }

        public static string ToStringStoppingNorm(int pasIndex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Sets.StoppingNorm[pasIndex].FuelConsumption.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].AcceleratorPedalValue.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].ThrottlePositionSignal.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].ShortTermFuelTrimBank1.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].IntakeAirPressure.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].FilteredAcceleratorPedalValue.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].AbsoluteThrottlePosition.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].EngineSoackingTime.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].InhibitionOfEngineFuelCutOff.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].EngineInFuelCutOff.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].FuelPressure.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].LongTermFuelTrimBank1.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].EngineSpeed.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].EngineTorqueAfterCorrection.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].TorqueOfFriction.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].FlywheelTorqueAfterTorqueInterventions.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].CurrentSparkTiming.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].EngineCoolantTemperature1.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].EngineIdlETargetSpeed.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].EngineTorque.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].CalculatedLoadValue.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].MinimumIndicatedEngineTorque.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].MaximumIndicatedEngineTorque.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].FlywheelTorque.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].TorqueScalingFactorStandardization.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].StandardTorqueRatio.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].RequestedSparkRetardAngleFromTCU.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].TCURequestsEngineTorqueLimitETL.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].TCURequestedEngineRPMIncrease.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].TargetEngineSpeedUsedInLockUpModule.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].GlowPlugControlRequest.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].ActivationOfAirCompressor.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].TorqueConverterSpeed.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].CurrentGear.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].EngineCoolantTemperature2.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].WheelVelocityFrontLeftHand.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].WheelVelocityRearRightHand.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].WheelVelocityFrontRightHand.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].WheelVelocityRearLeftHand.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].TorqueConverterTurbineSpeedUnfiltered.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].ClutchOperationAcknowledge.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].ConverterClutch.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].GearSelection.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].VehicleSpeed.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].AccelerationSpeedLongitudinal.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].IndicationOfBrakeSwitchON_OFF.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].MasterCylinderPressure.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].CalculatedRoadGradient.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].AccelerationSpeedLateral.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].SteeringWheelSpeed.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].SteeringWheelAngle.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].Time.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].Class.ToString() + ",");
            sb.Append(Sets.StoppingNorm[pasIndex].PathOrder.ToString());
            return sb.ToString() + ",";
        }

        public static string ToStringExecNorm(int pasIndex, List<NormalizedProperty> normalizedProperties)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(normalizedProperties[pasIndex].LongTermFuelTrimBank1.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].EngineSoackingTime.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].EngineCoolantTemperature2.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].TorqueOfFriction.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].IntakeAirPressure.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].ActivationOfAirCompressor.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].Time.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].AcceleratorPedalValue.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].EngineTorque.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].MaximumIndicatedEngineTorque.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].PathOrder.ToString() +",");
            sb.Append(normalizedProperties[pasIndex].ThrottlePositionSignal.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].EngineTorqueAfterCorrection.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].EngineCoolantTemperature1.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].Class.ToString() + ",");
            return sb.ToString();
        }

        public static string ToStringExecNormMore(int pasIndex, List<NormalizedProperty> normalizedProperties)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(normalizedProperties[pasIndex].LongTermFuelTrimBank1.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].EngineSoackingTime.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].EngineCoolantTemperature2.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].TorqueOfFriction.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].IntakeAirPressure.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].ActivationOfAirCompressor.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].Time.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].AcceleratorPedalValue.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].EngineTorque.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].MaximumIndicatedEngineTorque.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].PathOrder.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].ThrottlePositionSignal.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].EngineTorqueAfterCorrection.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].EngineCoolantTemperature1.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].CalculatedLoadValue.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].CurrentSparkTiming.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].CurrentGear.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].WheelVelocityFrontLeftHand.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].WheelVelocityRearRightHand.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].WheelVelocityFrontRightHand.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].WheelVelocityRearLeftHand.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].CalculatedRoadGradient.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].FuelConsumption.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].MasterCylinderPressure.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].AccelerationSpeedLongitudinal.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].SteeringWheelAngle.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].EngineSpeed.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].FlywheelTorque.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].TorqueConverterTurbineSpeedUnfiltered.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].TorqueConverterSpeed.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].FlywheelTorqueAfterTorqueInterventions.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].ShortTermFuelTrimBank1.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].AccelerationSpeedLateral.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].VehicleSpeed.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].TCURequestsEngineTorqueLimitETL.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].SteeringWheelSpeed.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].GearSelection.ToString() + ",");
            sb.Append(normalizedProperties[pasIndex].MinimumIndicatedEngineTorque.ToString() + ",");
            return sb.ToString();
        }
        #endregion
    }
}
