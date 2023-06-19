using Analizer.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Analizer
{
    public class NormalizeProperties
    {
        public static List<NormalizedProperty> DoWork(List<CsvProperty> rawProperties)
        {
            List<NormalizedProperty> result = new List<NormalizedProperty>();

            for (int i = 0; i < rawProperties.Count; i++)
            {
                NormalizedProperty normalizedProperty = new NormalizedProperty();
                result.Add(normalizedProperty);
            }
            //FuelConsumption

            double min = rawProperties[0].FuelConsumption;
            double max = rawProperties[0].FuelConsumption;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].FuelConsumption;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].FuelConsumption, min, max, 0, 1);
                result[i].FuelConsumption = value;
            }

            //AcceleratorPedalValue

            min = rawProperties[0].AcceleratorPedalValue;
            max = rawProperties[0].AcceleratorPedalValue;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].AcceleratorPedalValue;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].AcceleratorPedalValue, min, max, 0, 1);
                result[i].AcceleratorPedalValue = value;
            }

            //ThrottlePositionSignal

            min = rawProperties[0].ThrottlePositionSignal;
            max = rawProperties[0].ThrottlePositionSignal;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].ThrottlePositionSignal;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].ThrottlePositionSignal, min, max, 0, 1);
                result[i].ThrottlePositionSignal = value;
            }

            //ShortTermFuelTrimBank1

            min = rawProperties[0].ShortTermFuelTrimBank1;
            max = rawProperties[0].ShortTermFuelTrimBank1;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].ShortTermFuelTrimBank1;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].ShortTermFuelTrimBank1, min, max, 0, 1);
                result[i].ShortTermFuelTrimBank1 = value;
            }

            //IntakeAirPressure

            min = rawProperties[0].IntakeAirPressure;
            max = rawProperties[0].IntakeAirPressure;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].IntakeAirPressure;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].IntakeAirPressure, min, max, 0, 1);
                result[i].IntakeAirPressure = value;
            }

            //FilteredAcceleratorPedalValue

            min = rawProperties[0].FilteredAcceleratorPedalValue;
            max = rawProperties[0].FilteredAcceleratorPedalValue;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].FilteredAcceleratorPedalValue;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].FilteredAcceleratorPedalValue, min, max, 0, 1);
                result[i].FilteredAcceleratorPedalValue = value;
            }

            //AbsoluteThrottlePosition

            min = rawProperties[0].AcceleratorPedalValue;
            max = rawProperties[0].AcceleratorPedalValue;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].AcceleratorPedalValue;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].AcceleratorPedalValue, min, max, 0, 1);
                result[i].AcceleratorPedalValue = value;
            }

            //EngineSoackingTime

            min = rawProperties[0].EngineSoackingTime;
            max = rawProperties[0].EngineSoackingTime;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].EngineSoackingTime;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].EngineSoackingTime, min, max, 0, 1);
                result[i].EngineSoackingTime = value;
            }

            //InhibitionOfEngineFuelCutOff

            min = rawProperties[0].InhibitionOfEngineFuelCutOff;
            max = rawProperties[0].InhibitionOfEngineFuelCutOff;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].InhibitionOfEngineFuelCutOff;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].InhibitionOfEngineFuelCutOff, min, max, 0, 1);
                result[i].InhibitionOfEngineFuelCutOff = value;
            }

            //EngineInFuelCutOff

            min = rawProperties[0].EngineInFuelCutOff;
            max = rawProperties[0].EngineInFuelCutOff;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].EngineInFuelCutOff;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].EngineInFuelCutOff, min, max, 0, 1);
                result[i].EngineInFuelCutOff = value;
            }

            //FuelPressure

            min = rawProperties[0].FuelPressure;
            max = rawProperties[0].FuelPressure;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].FuelPressure;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].FuelPressure, min, max, 0, 1);
                result[i].FuelPressure = value;
            }

            //LongTermFuelTrimBank1

            min = rawProperties[0].LongTermFuelTrimBank1;
            max = rawProperties[0].LongTermFuelTrimBank1;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].LongTermFuelTrimBank1;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].LongTermFuelTrimBank1, min, max, 0, 1);
                result[i].LongTermFuelTrimBank1 = value;
            }

            //EngineSpeed

            min = rawProperties[0].EngineSpeed;
            max = rawProperties[0].EngineSpeed;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].EngineSpeed;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].EngineSpeed, min, max, 0, 1);
                result[i].EngineSpeed = value;
            }

            //EngineTorqueAfterCorrection

            min = rawProperties[0].EngineTorqueAfterCorrection;
            max = rawProperties[0].EngineTorqueAfterCorrection;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].EngineTorqueAfterCorrection;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].EngineTorqueAfterCorrection, min, max, 0, 1);
                result[i].EngineTorqueAfterCorrection = value;
            }

            //TorqueOfFriction

            min = rawProperties[0].TorqueOfFriction;
            max = rawProperties[0].TorqueOfFriction;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].TorqueOfFriction;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].TorqueOfFriction, min, max, 0, 1);
                result[i].TorqueOfFriction = value;
            }

            //FlywheelTorqueAfterTorqueInterventions

            min = rawProperties[0].FlywheelTorqueAfterTorqueInterventions;
            max = rawProperties[0].FlywheelTorqueAfterTorqueInterventions;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].FlywheelTorqueAfterTorqueInterventions;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].FlywheelTorqueAfterTorqueInterventions, min, max, 0, 1);
                result[i].FlywheelTorqueAfterTorqueInterventions = value;
            }

            //CurrentSparkTiming

            min = rawProperties[0].CurrentSparkTiming;
            max = rawProperties[0].CurrentSparkTiming;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].CurrentSparkTiming;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].CurrentSparkTiming, min, max, 0, 1);
                result[i].CurrentSparkTiming = value;
            }

            //EngineCoolantTemperature1

            min = rawProperties[0].EngineCoolantTemperature1;
            max = rawProperties[0].EngineCoolantTemperature1;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].EngineCoolantTemperature1;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].EngineCoolantTemperature1, min, max, 0, 1);
                result[i].EngineCoolantTemperature1 = value;
            }

            //EngineIdlETargetSpeed

            min = rawProperties[0].EngineIdlETargetSpeed;
            max = rawProperties[0].EngineIdlETargetSpeed;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].EngineIdlETargetSpeed;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].EngineIdlETargetSpeed, min, max, 0, 1);
                result[i].EngineIdlETargetSpeed = value;
            }

            //EngineTorque

            min = rawProperties[0].EngineTorque;
            max = rawProperties[0].EngineTorque;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].EngineTorque;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].EngineTorque, min, max, 0, 1);
                result[i].EngineTorque = value;
            }

            //CalculatedLoadValue

            min = rawProperties[0].CalculatedLoadValue;
            max = rawProperties[0].CalculatedLoadValue;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].CalculatedLoadValue;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].CalculatedLoadValue, min, max, 0, 1);
                result[i].CalculatedLoadValue = value;
            }

            //MinimumIndicatedEngineTorque

            min = rawProperties[0].MinimumIndicatedEngineTorque;
            max = rawProperties[0].MinimumIndicatedEngineTorque;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].MinimumIndicatedEngineTorque;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].MinimumIndicatedEngineTorque, min, max, 0, 1);
                result[i].MinimumIndicatedEngineTorque = value;
            }

            //MaximumIndicatedEngineTorque

            min = rawProperties[0].MaximumIndicatedEngineTorque;
            max = rawProperties[0].MaximumIndicatedEngineTorque;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].MaximumIndicatedEngineTorque;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].MaximumIndicatedEngineTorque, min, max, 0, 1);
                result[i].MaximumIndicatedEngineTorque = value;
            }

            //FlywheelTorque

            min = rawProperties[0].FlywheelTorque;
            max = rawProperties[0].FlywheelTorque;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].FlywheelTorque;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].FlywheelTorque, min, max, 0, 1);
                result[i].FlywheelTorque = value;
            }

            //TorqueScalingFactorStandardization

            min = rawProperties[0].TorqueScalingFactorStandardization;
            max = rawProperties[0].TorqueScalingFactorStandardization;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].TorqueScalingFactorStandardization;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].TorqueScalingFactorStandardization, min, max, 0, 1);
                result[i].TorqueScalingFactorStandardization = value;
            }

            //StandardTorqueRatio

            min = rawProperties[0].StandardTorqueRatio;
            max = rawProperties[0].StandardTorqueRatio;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].StandardTorqueRatio;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].StandardTorqueRatio, min, max, 0, 1);
                result[i].StandardTorqueRatio = value;
            }

            //RequestedSparkRetardAngleFromTCU

            min = rawProperties[0].RequestedSparkRetardAngleFromTCU;
            max = rawProperties[0].RequestedSparkRetardAngleFromTCU;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].RequestedSparkRetardAngleFromTCU;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].RequestedSparkRetardAngleFromTCU, min, max, 0, 1);
                result[i].RequestedSparkRetardAngleFromTCU = value;
            }

            //TCURequestsEngineTorqueLimitETL

            min = rawProperties[0].TCURequestsEngineTorqueLimitETL;
            max = rawProperties[0].TCURequestsEngineTorqueLimitETL;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].TCURequestsEngineTorqueLimitETL;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].TCURequestsEngineTorqueLimitETL, min, max, 0, 1);
                result[i].TCURequestsEngineTorqueLimitETL = value;
            }

            //TCURequestedEngineRPMIncrease

            min = rawProperties[0].TCURequestedEngineRPMIncrease;
            max = rawProperties[0].TCURequestedEngineRPMIncrease;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].TCURequestedEngineRPMIncrease;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].TCURequestedEngineRPMIncrease, min, max, 0, 1);
                result[i].TCURequestedEngineRPMIncrease = value;
            }

            //TargetEngineSpeedUsedInLockUpModule

            min = rawProperties[0].TargetEngineSpeedUsedInLockUpModule;
            max = rawProperties[0].TargetEngineSpeedUsedInLockUpModule;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].TargetEngineSpeedUsedInLockUpModule;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].TargetEngineSpeedUsedInLockUpModule, min, max, 0, 1);
                result[i].TargetEngineSpeedUsedInLockUpModule = value;
            }

            //GlowPlugControlRequest

            min = rawProperties[0].GlowPlugControlRequest;
            max = rawProperties[0].GlowPlugControlRequest;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].GlowPlugControlRequest;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].GlowPlugControlRequest, min, max, 0, 1);
                result[i].GlowPlugControlRequest = value;
            }

            //ActivationOfAirCompressor

            min = rawProperties[0].ActivationOfAirCompressor;
            max = rawProperties[0].ActivationOfAirCompressor;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].ActivationOfAirCompressor;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].ActivationOfAirCompressor, min, max, 0, 1);
                result[i].ActivationOfAirCompressor = value;
            }

            //TorqueConverterSpeed

            min = rawProperties[0].TorqueConverterSpeed;
            max = rawProperties[0].TorqueConverterSpeed;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].TorqueConverterSpeed;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].TorqueConverterSpeed, min, max, 0, 1);
                result[i].TorqueConverterSpeed = value;
            }

            //CurrentGear

            min = rawProperties[0].CurrentGear;
            max = rawProperties[0].CurrentGear;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].CurrentGear;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].CurrentGear, min, max, 0, 1);
                result[i].CurrentGear = value;
            }

            //EngineCoolantTemperature2

            min = rawProperties[0].EngineCoolantTemperature2;
            max = rawProperties[0].EngineCoolantTemperature2;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].EngineCoolantTemperature2;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].EngineCoolantTemperature2, min, max, 0, 1);
                result[i].EngineCoolantTemperature2 = value;
            }

            //WheelVelocityFrontLeftHand

            min = rawProperties[0].WheelVelocityFrontLeftHand;
            max = rawProperties[0].WheelVelocityFrontLeftHand;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].WheelVelocityFrontLeftHand;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].WheelVelocityFrontLeftHand, min, max, 0, 1);
                result[i].WheelVelocityFrontLeftHand = value;
            }

            //WheelVelocityRearRightHand

            min = rawProperties[0].WheelVelocityRearRightHand;
            max = rawProperties[0].WheelVelocityRearRightHand;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].WheelVelocityRearRightHand;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].WheelVelocityRearRightHand, min, max, 0, 1);
                result[i].WheelVelocityRearRightHand = value;
            }

            //WheelVelocityFrontRightHand

            min = rawProperties[0].WheelVelocityFrontRightHand;
            max = rawProperties[0].WheelVelocityFrontRightHand;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].WheelVelocityFrontRightHand;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].WheelVelocityFrontRightHand, min, max, 0, 1);
                result[i].WheelVelocityFrontRightHand = value;
            }

            //WheelVelocityRearLeftHand

            min = rawProperties[0].WheelVelocityRearLeftHand;
            max = rawProperties[0].WheelVelocityRearLeftHand;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].WheelVelocityRearLeftHand;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].WheelVelocityRearLeftHand, min, max, 0, 1);
                result[i].WheelVelocityRearLeftHand = value;
            }

            //TorqueConverterTurbineSpeedUnfiltered

            min = rawProperties[0].TorqueConverterTurbineSpeedUnfiltered;
            max = rawProperties[0].TorqueConverterTurbineSpeedUnfiltered;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].TorqueConverterTurbineSpeedUnfiltered;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].TorqueConverterTurbineSpeedUnfiltered, min, max, 0, 1);
                result[i].TorqueConverterTurbineSpeedUnfiltered = value;
            }

            //ClutchOperationAcknowledge

            min = rawProperties[0].ClutchOperationAcknowledge;
            max = rawProperties[0].ClutchOperationAcknowledge;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].ClutchOperationAcknowledge;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].ClutchOperationAcknowledge, min, max, 0, 1);
                result[i].ClutchOperationAcknowledge = value;
            }

            //ConverterClutch

            min = rawProperties[0].ConverterClutch;
            max = rawProperties[0].ConverterClutch;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].ConverterClutch;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].ConverterClutch, min, max, 0, 1);
                result[i].ConverterClutch = value;
            }

            //GearSelection

            min = rawProperties[0].GearSelection;
            max = rawProperties[0].GearSelection;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].GearSelection;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].GearSelection, min, max, 0, 1);
                result[i].GearSelection = value;
            }

            //VehicleSpeed

            min = rawProperties[0].VehicleSpeed;
            max = rawProperties[0].VehicleSpeed;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].VehicleSpeed;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].VehicleSpeed, min, max, 0, 1);
                result[i].VehicleSpeed = value;
            }

            //AccelerationSpeedLongitudinal

            min = rawProperties[0].AccelerationSpeedLongitudinal;
            max = rawProperties[0].AccelerationSpeedLongitudinal;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].AccelerationSpeedLongitudinal;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].AccelerationSpeedLongitudinal, min, max, 0, 1);
                result[i].AccelerationSpeedLongitudinal = value;
            }

            //IndicationOfBrakeSwitchON_OFF

            min = rawProperties[0].IndicationOfBrakeSwitchON_OFF;
            max = rawProperties[0].IndicationOfBrakeSwitchON_OFF;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].IndicationOfBrakeSwitchON_OFF;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].IndicationOfBrakeSwitchON_OFF, min, max, 0, 1);
                result[i].IndicationOfBrakeSwitchON_OFF = value;
            }

            //MasterCylinderPressure

            min = rawProperties[0].MasterCylinderPressure;
            max = rawProperties[0].MasterCylinderPressure;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].MasterCylinderPressure;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].MasterCylinderPressure, min, max, 0, 1);
                result[i].MasterCylinderPressure = value;
            }

            //CalculatedRoadGradient

            min = rawProperties[0].CalculatedRoadGradient;
            max = rawProperties[0].CalculatedRoadGradient;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].CalculatedRoadGradient;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].CalculatedRoadGradient, min, max, 0, 1);
                result[i].CalculatedRoadGradient = value;
            }

            //AccelerationSpeedLateral

            min = rawProperties[0].AccelerationSpeedLateral;
            max = rawProperties[0].AccelerationSpeedLateral;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].AccelerationSpeedLateral;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].AccelerationSpeedLateral, min, max, 0, 1);
                result[i].AccelerationSpeedLateral = value;
            }

            //SteeringWheelSpeed

            min = rawProperties[0].SteeringWheelSpeed;
            max = rawProperties[0].SteeringWheelSpeed;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].SteeringWheelSpeed;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].SteeringWheelSpeed, min, max, 0, 1);
                result[i].SteeringWheelSpeed = value;
            }

            //SteeringWheelAngle

            min = rawProperties[0].SteeringWheelAngle;
            max = rawProperties[0].SteeringWheelAngle;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].SteeringWheelAngle;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].SteeringWheelAngle, min, max, 0, 1);
                result[i].SteeringWheelAngle = value;
            }

            //Time

            min = rawProperties[0].Time;
            max = rawProperties[0].Time;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].Time;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].Time, min, max, 0, 1);
                result[i].Time = value;
            }

            //Class

            min = 0;
            max = 9;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double litera = rawProperties[i].Class - 65;
                double value = Normalize.Start(litera, min, max, 0, 1);
                if (value == 0) value = 0.0000001;
                if (value == 1) value = 0.9999999;
                result[i].Class = value;
            }

            //PathOrder

            min = rawProperties[0].PathOrder;
            max = rawProperties[0].PathOrder;
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = rawProperties[i].PathOrder;
                if (value < min) min = value;
                if (value > max) max = value;
            }
            for (int i = 0; i < rawProperties.Count; i++)
            {
                double value = Normalize.Start(rawProperties[i].PathOrder, min, max, 0, 1);
                result[i].PathOrder = value;
            }

            return result;

        }
    }
}
