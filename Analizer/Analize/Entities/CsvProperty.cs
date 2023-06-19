namespace Analizer
{
    [Csv]
    public class CsvProperty
    {
        public CsvProperty(double fuelConsumption, double acceleratorPedalValue , double throttlePositionSignal, double shortTermFuelTrimBank1, double intakeAirPressure,
            double filteredAcceleratorPedalValue, double absoluteThrottlePosition, double engineSoackingTime, double inhibitionOfEngineFuelCutOff,double engineInFuelCutOff ,
            double fuelPressure, double longTermFuelTrimBank1, double engineSpeed, double engineTorqueAfterCorrection, double torqueOfFriction,
            double flywheelTorqueAfterTorqueInterventions, double currentSparkTiming , double engineCoolantTemperature1, double engineIdlETargetSpeed ,
            double engineTorque , double calculatedLoadValue, double minimumIndicatedEngineTorque, double maximumIndicatedEngineTorque, double flywheelTorque,
            double torqueScalingFactorStandardization, double standardTorqueRatio, double requestedSparkRetardAngleFromTCU, double tCURequestsEngineTorqueLimitETL, 
            double tCURequestedEngineRPMIncrease, double targetEngineSpeedUsedInLockUpModule, double glowPlugControlRequest , double activationOfAirCompressor,
            double torqueConverterSpeed, double currentGear, double engineCoolantTemperature2, double wheelVelocityFrontLeftHand, double wheelVelocityRearRightHand,
            double wheelVelocityFrontRightHand, double wheelVelocityRearLeftHand , double torqueConverterTurbineSpeedUnfiltered, double clutchOperationAcknowledge,
            double converterClutch, double gearSelection, double vehicleSpeed, double accelerationSpeedLongitudinal, double indicationOfBrakeSwitchON_OFF,
            double masterCylinderPressure, double calculatedRoadGradient, double accelerationSpeedLateral, double steeringWheelSpeed, double steeringWheelAngle,
            double time, char Class, double pathOrder)
        {
            FuelConsumption = fuelConsumption;
            AcceleratorPedalValue = acceleratorPedalValue;
            ThrottlePositionSignal = throttlePositionSignal;
            ShortTermFuelTrimBank1 = shortTermFuelTrimBank1;
            IntakeAirPressure = intakeAirPressure;
            FilteredAcceleratorPedalValue = filteredAcceleratorPedalValue;
            AbsoluteThrottlePosition = absoluteThrottlePosition;
            EngineSoackingTime = engineSoackingTime;
            InhibitionOfEngineFuelCutOff = inhibitionOfEngineFuelCutOff;
            EngineInFuelCutOff = engineInFuelCutOff;
            FuelPressure = fuelPressure;
            LongTermFuelTrimBank1 = longTermFuelTrimBank1;
            EngineSpeed = engineSpeed;
            EngineTorqueAfterCorrection = engineTorqueAfterCorrection;
            TorqueOfFriction = torqueOfFriction;
            FlywheelTorqueAfterTorqueInterventions = flywheelTorqueAfterTorqueInterventions;
            CurrentSparkTiming = currentSparkTiming;
            EngineCoolantTemperature1 = engineCoolantTemperature1;
            EngineIdlETargetSpeed = engineIdlETargetSpeed;
            EngineTorque = engineTorque;
            CalculatedLoadValue = calculatedLoadValue;
            MinimumIndicatedEngineTorque = minimumIndicatedEngineTorque;
            MaximumIndicatedEngineTorque = maximumIndicatedEngineTorque;
            FlywheelTorque = flywheelTorque;
            TorqueScalingFactorStandardization = torqueScalingFactorStandardization;
            StandardTorqueRatio = standardTorqueRatio;
            RequestedSparkRetardAngleFromTCU = requestedSparkRetardAngleFromTCU;
            TCURequestsEngineTorqueLimitETL = tCURequestsEngineTorqueLimitETL;
            TCURequestedEngineRPMIncrease = tCURequestedEngineRPMIncrease;
            TargetEngineSpeedUsedInLockUpModule = targetEngineSpeedUsedInLockUpModule;
            GlowPlugControlRequest = glowPlugControlRequest;
            ActivationOfAirCompressor = activationOfAirCompressor;
            TorqueConverterSpeed = torqueConverterSpeed;
            CurrentGear = currentGear;
            EngineCoolantTemperature2 = engineCoolantTemperature2;
            WheelVelocityFrontLeftHand = wheelVelocityFrontLeftHand;
            WheelVelocityRearRightHand = wheelVelocityRearRightHand;
            WheelVelocityFrontRightHand = wheelVelocityFrontRightHand;
            WheelVelocityRearLeftHand = wheelVelocityRearLeftHand;
            TorqueConverterTurbineSpeedUnfiltered = torqueConverterTurbineSpeedUnfiltered;
            ClutchOperationAcknowledge = clutchOperationAcknowledge;
            ConverterClutch = converterClutch;
            GearSelection = gearSelection;
            VehicleSpeed = vehicleSpeed;
            AccelerationSpeedLongitudinal = accelerationSpeedLongitudinal;
            IndicationOfBrakeSwitchON_OFF = indicationOfBrakeSwitchON_OFF;
            MasterCylinderPressure = masterCylinderPressure;
            CalculatedRoadGradient = calculatedRoadGradient;
            AccelerationSpeedLateral = accelerationSpeedLateral;
            SteeringWheelSpeed = steeringWheelSpeed;
            SteeringWheelAngle = steeringWheelAngle;
            Time = time;
            this.Class = Class;
            PathOrder = pathOrder;
        }
        [ColumnName("Fuel_consumption")]
        public double FuelConsumption { get; set; }

        [ColumnName("Accelerator_Pedal_value")]
        public double AcceleratorPedalValue { get; set; }

        [ColumnName("Throttle_position_signal")]
        public double ThrottlePositionSignal { get; set; }

        [ColumnName("Short_Term_Fuel_Trim_Bank1")]
        public double ShortTermFuelTrimBank1 { get; set; }

        [ColumnName("Intake_air_pressure")]
        public double IntakeAirPressure { get; set; }

        [ColumnName("Filtered_Accelerator_Pedal_value")]
        public double FilteredAcceleratorPedalValue { get; set; }

        [ColumnName("Absolute_throttle_position")]
        public double AbsoluteThrottlePosition { get; set; }

        [ColumnName("Engine_soacking_time")]
        public double EngineSoackingTime { get; set; }

        [ColumnName("Inhibition_of_engine_fuel_cut_off")]
        public double InhibitionOfEngineFuelCutOff { get; set; }

        [ColumnName("Engine_in_fuel_cut_off")]
        public double EngineInFuelCutOff { get; set; }

        [ColumnName("Fuel_Pressure")]
        public double FuelPressure { get; set; }

        [ColumnName("Long_Term_Fuel_Trim_Bank1")]
        public double LongTermFuelTrimBank1 { get; set; }

        [ColumnName("Engine_speed")]
        public double EngineSpeed { get; set; }

        [ColumnName("Engine_torque_after_correction")]
        public double EngineTorqueAfterCorrection { get; set; }

        [ColumnName("Torque_of_friction")]
        public double TorqueOfFriction { get; set; }

        [ColumnName("Flywheel_torque_(after_torque_interventions)")]
        public double FlywheelTorqueAfterTorqueInterventions { get; set; }

        [ColumnName("Current_spark_timing")]
        public double CurrentSparkTiming { get; set; }

        [ColumnName("Engine_coolant_temperature1")]
        public double EngineCoolantTemperature1 { get; set; }

        [ColumnName("Engine_Idel_Target_Speed,Engine_torque")]
        public double EngineIdlETargetSpeed { get; set; }

        [ColumnName("Engine_torque")]
        public double EngineTorque { get; set; }

        [ColumnName("Calculated_LOAD_value")]
        public double CalculatedLoadValue { get; set; }

        [ColumnName("Minimum_indicated_engine_torque")]
        public double MinimumIndicatedEngineTorque { get; set; }

        [ColumnName("Maximum_indicated_engine_torque")]
        public double MaximumIndicatedEngineTorque { get; set; }

        [ColumnName("Flywheel_torque")]
        public double FlywheelTorque { get; set; }

        [ColumnName("Torque_scaling_factor(standardization)")]
        public double TorqueScalingFactorStandardization { get; set; }

        [ColumnName("Standard_Torque_Ratio")]
        public double StandardTorqueRatio { get; set; }

        [ColumnName("Requested_spark_retard_angle_from_TCU")]
        public double RequestedSparkRetardAngleFromTCU { get; set; }

        [ColumnName("TCU_requests_engine_torque_limit_(ETL)")]
        public double TCURequestsEngineTorqueLimitETL { get; set; }

        [ColumnName("TCU_requested_engine_RPM_increase")]
        public double TCURequestedEngineRPMIncrease { get; set; }

        [ColumnName("Target_engine_speed_used_in_lock-up_module")]
        public double TargetEngineSpeedUsedInLockUpModule { get; set; }

        [ColumnName("Glow_plug_control_request")]
        public double GlowPlugControlRequest { get; set; }

        [ColumnName("Activation_of_Air_compressor")]
        public double ActivationOfAirCompressor { get; set; }

        [ColumnName("Torque_converter_speed")]
        public double TorqueConverterSpeed { get; set; }

        [ColumnName("Current_Gear")]
        public double CurrentGear { get; set; }

        [ColumnName("Engine_coolant_temperature2")]
        public double EngineCoolantTemperature2 { get; set; }

        [ColumnName("Wheel_velocity_front_left-hand")]
        public double WheelVelocityFrontLeftHand { get; set; }

        [ColumnName("Wheel_velocity_rear_right-hand")]
        public double WheelVelocityRearRightHand { get; set; }

        [ColumnName("Wheel_velocity_front_right-hand")]
        public double WheelVelocityFrontRightHand { get; set; }

        [ColumnName("Wheel_velocity_rear_left-hand")]
        public double WheelVelocityRearLeftHand { get; set; }

        [ColumnName("Torque_converter_turbine_speed_-_Unfiltered")]
        public double TorqueConverterTurbineSpeedUnfiltered { get; set; }

        [ColumnName("Clutch_operation_acknowledge")]
        public double ClutchOperationAcknowledge { get; set; }

        [ColumnName("Converter_clutch")]
        public double ConverterClutch { get; set; }

        [ColumnName("Gear_Selection")]
        public double GearSelection { get; set; }

        [ColumnName("Vehicle_speed")]
        public double VehicleSpeed { get; set; }

        [ColumnName("Acceleration_speed_-_Longitudinal")]
        public double AccelerationSpeedLongitudinal { get; set; }

        [ColumnName("Indication_of_brake_switch_ON/OFF")]
        public double IndicationOfBrakeSwitchON_OFF { get; set; }

        [ColumnName("Master_cylinder_pressure")]
        public double MasterCylinderPressure { get; set; }

        [ColumnName("Calculated_road_gradient")]
        public double CalculatedRoadGradient { get; set; }

        [ColumnName("Acceleration_speed_-_Lateral")]
        public double AccelerationSpeedLateral { get; set; }

        [ColumnName("Steering_wheel_speed")]
        public double SteeringWheelSpeed { get; set; }

        [ColumnName("Steering_wheel_angle")]
        public double SteeringWheelAngle { get; set; }

        [ColumnName("Time(s)")]
        public double Time { get; set; }

        [ColumnName("Class")]
        public char Class { get; set; }

        [ColumnName("PathOrder")]
        public double PathOrder { get; set; }
    }
}
