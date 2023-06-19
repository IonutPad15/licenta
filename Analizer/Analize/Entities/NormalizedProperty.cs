namespace Analizer
{
    [NeuronValues]
    [Csv]
    public class NormalizedProperty
    {
        public NormalizedProperty()
        {

        }
        public NormalizedProperty(double fuelConsumption, double acceleratorPedalValue, double throttlePositionSignal, double shortTermFuelTrimBank1, double intakeAirPressure,
            double filteredAcceleratorPedalValue, double absoluteThrottlePosition, double engineSoackingTime, double inhibitionOfEngineFuelCutOff, double engineInFuelCutOff,
            double fuelPressure, double longTermFuelTrimBank1, double engineSpeed, double engineTorqueAfterCorrection, double torqueOfFriction,
            double flywheelTorqueAfterTorqueInterventions, double currentSparkTiming, double engineCoolantTemperature1, double engineIdlETargetSpeed,
            double engineTorque, double calculatedLoadValue, double minimumIndicatedEngineTorque, double maximumIndicatedEngineTorque, double flywheelTorque,
            double torqueScalingFactorStandardization, double standardTorqueRatio, double requestedSparkRetardAngleFromTCU, double tCURequestsEngineTorqueLimitETL,
            double tCURequestedEngineRPMIncrease, double targetEngineSpeedUsedInLockUpModule, double glowPlugControlRequest, double activationOfAirCompressor,
            double torqueConverterSpeed, double currentGear, double engineCoolantTemperature2, double wheelVelocityFrontLeftHand, double wheelVelocityRearRightHand,
            double wheelVelocityFrontRightHand, double wheelVelocityRearLeftHand, double torqueConverterTurbineSpeedUnfiltered, double clutchOperationAcknowledge,
            double converterClutch, double gearSelection, double vehicleSpeed, double accelerationSpeedLongitudinal, double indicationOfBrakeSwitchON_OFF,
            double masterCylinderPressure, double calculatedRoadGradient, double accelerationSpeedLateral, double steeringWheelSpeed, double steeringWheelAngle,
            double time, double Class, double pathOrder)
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

        public NormalizedProperty(double longTermFuelTrimBank1, double engineSoackingTime, double engineCoolantTemperature2, double torqueOfFriction, double intakeAirPressure,
            double activationOfAirCompressor, double time, double acceleratorPedalValue, double engineTorque, double maximumIndicatedEngineTorque, double pathOrder, 
            double throttlePositionSignal, double engineTorqueAfterCorrection, double engineCoolantTemperature1)
        {
            LongTermFuelTrimBank1 = longTermFuelTrimBank1;
            EngineSoackingTime = engineSoackingTime;
            EngineCoolantTemperature2 = engineCoolantTemperature2;
            TorqueOfFriction = torqueOfFriction;
            IntakeAirPressure= intakeAirPressure;
            ActivationOfAirCompressor = activationOfAirCompressor;
            Time = time;
            AcceleratorPedalValue = acceleratorPedalValue;
            EngineTorque= engineTorque;
            MaximumIndicatedEngineTorque= maximumIndicatedEngineTorque;
            PathOrder = pathOrder;
            ThrottlePositionSignal = throttlePositionSignal;
            EngineTorqueAfterCorrection = engineTorqueAfterCorrection;
            EngineCoolantTemperature1 = engineCoolantTemperature1;
        }

        public NormalizedProperty(double longTermFuelTrimBank1, double engineSoackingTime, double engineCoolantTemperature2, double torqueOfFriction, double intakeAirPressure,
            double activationOfAirCompressor, double time, double acceleratorPedalValue, double engineTorque, double maximumIndicatedEngineTorque, double pathOrder,
            double throttlePositionSignal, double engineTorqueAfterCorrection, double engineCoolantTemperature1, double calculatedLoadValue, double currentSparkTiming,
            double currentGear,double wheelVelocityFrontLeftHand, double wheelVelocityRearRightHand, double wheelVelocityFrontRightHand, double wheelVelocityRearLeftHand,
            double calculatedRoadGradient, double fuelConsumption, double masterCylinderPressure, double accelerationSpeedLongitudinal, double steeringWheelAngle,
            double engineSpeed, double flywheelTorque, double torqueConverterTurbineSpeedUnfiltered, double torqueConverterSpeed, double flywheelTorqueAfterTorqueInterventions,
            double shortTermFuelTrimBank1, double accelerationSpeedLateral, double vehicleSpeed, double tCURequestsEngineTorqueLimitETL, double steeringWheelSpeed, 
            double gearSelection, double minimumIndicatedEngineTorque)
        {
            LongTermFuelTrimBank1 = longTermFuelTrimBank1;
            EngineSoackingTime = engineSoackingTime;
            EngineCoolantTemperature2 = engineCoolantTemperature2;
            TorqueOfFriction = torqueOfFriction;
            IntakeAirPressure = intakeAirPressure;
            ActivationOfAirCompressor = activationOfAirCompressor;
            Time = time;
            AcceleratorPedalValue = acceleratorPedalValue;
            EngineTorque = engineTorque;
            MaximumIndicatedEngineTorque = maximumIndicatedEngineTorque;
            PathOrder = pathOrder;
            ThrottlePositionSignal = throttlePositionSignal;
            EngineTorqueAfterCorrection = engineTorqueAfterCorrection;
            EngineCoolantTemperature1 = engineCoolantTemperature1;
            CalculatedLoadValue = calculatedLoadValue;
            CurrentSparkTiming= currentSparkTiming;
            CurrentGear = currentGear;
            WheelVelocityFrontLeftHand= wheelVelocityFrontLeftHand;
            WheelVelocityRearRightHand = wheelVelocityRearRightHand;
            WheelVelocityFrontRightHand = wheelVelocityFrontRightHand;
            WheelVelocityRearLeftHand = wheelVelocityRearLeftHand;
            CalculatedRoadGradient= calculatedRoadGradient;
            FuelConsumption = fuelConsumption;
            MasterCylinderPressure = masterCylinderPressure;
            AccelerationSpeedLongitudinal = accelerationSpeedLongitudinal;
            SteeringWheelAngle= steeringWheelAngle;
            EngineSpeed = engineSpeed;
            FlywheelTorque = flywheelTorque;
            TorqueConverterTurbineSpeedUnfiltered = torqueConverterTurbineSpeedUnfiltered;
            TorqueConverterSpeed = torqueConverterSpeed;
            FlywheelTorqueAfterTorqueInterventions = flywheelTorqueAfterTorqueInterventions;
            ShortTermFuelTrimBank1 = shortTermFuelTrimBank1;
            AccelerationSpeedLateral = accelerationSpeedLateral;
            VehicleSpeed= vehicleSpeed;
            TCURequestsEngineTorqueLimitETL = tCURequestsEngineTorqueLimitETL;
            SteeringWheelSpeed = steeringWheelSpeed;
            GearSelection = gearSelection;
            MinimumIndicatedEngineTorque = minimumIndicatedEngineTorque;
        }
        [InputValue]
        [ColumnName("Fuel_consumption")]
        public double FuelConsumption { get; set; }

        [InputValue]
        [ColumnName("Accelerator_Pedal_value")]
        public double AcceleratorPedalValue { get; set; }

        [InputValue]
        [ColumnName("Throttle_position_signal")]
        public double ThrottlePositionSignal { get; set; }

        [InputValue]
        [ColumnName("Short_Term_Fuel_Trim_Bank1")]
        public double ShortTermFuelTrimBank1 { get; set; }

        [InputValue]
        [ColumnName("Intake_air_pressure")]
        public double IntakeAirPressure { get; set; }

        [InputValue]
        [ColumnName("Filtered_Accelerator_Pedal_value")]
        public double FilteredAcceleratorPedalValue { get; set; }

        [InputValue]
        [ColumnName("Absolute_throttle_position")]
        public double AbsoluteThrottlePosition { get; set; }

        [InputValue]
        [ColumnName("Engine_soacking_time")]
        public double EngineSoackingTime { get; set; }

        [InputValue]
        [ColumnName("Inhibition_of_engine_fuel_cut_off")]
        public double InhibitionOfEngineFuelCutOff { get; set; }

        [InputValue]
        [ColumnName("Engine_in_fuel_cut_off")]
        public double EngineInFuelCutOff { get; set; }

        [InputValue]
        [ColumnName("Fuel_Pressure")]
        public double FuelPressure { get; set; }

        [InputValue]
        [ColumnName("Long_Term_Fuel_Trim_Bank1")]
        public double LongTermFuelTrimBank1 { get; set; }

        [InputValue]
        [ColumnName("Engine_speed")]
        public double EngineSpeed { get; set; }

        [InputValue]
        [ColumnName("Engine_torque_after_correction")]
        public double EngineTorqueAfterCorrection { get; set; }

        [InputValue]
        [ColumnName("Torque_of_friction")]
        public double TorqueOfFriction { get; set; }

        [InputValue]
        [ColumnName("Flywheel_torque_(after_torque_interventions)")]
        public double FlywheelTorqueAfterTorqueInterventions { get; set; }

        [InputValue]
        [ColumnName("Current_spark_timing")]
        public double CurrentSparkTiming { get; set; }

        [InputValue]
        [ColumnName("Engine_coolant_temperature1")]
        public double EngineCoolantTemperature1 { get; set; }

        [InputValue]
        [ColumnName("Engine_Idel_Target_Speed,Engine_torque")]
        public double EngineIdlETargetSpeed { get; set; }

        [InputValue]
        [ColumnName("Engine_torque")]
        public double EngineTorque { get; set; }

        [InputValue]
        [ColumnName("Calculated_LOAD_value")]
        public double CalculatedLoadValue { get; set; }

        [InputValue]
        [ColumnName("Minimum_indicated_engine_torque")]
        public double MinimumIndicatedEngineTorque { get; set; }

        [InputValue]
        [ColumnName("Maximum_indicated_engine_torque")]
        public double MaximumIndicatedEngineTorque { get; set; }

        [InputValue]
        [ColumnName("Flywheel_torque")]
        public double FlywheelTorque { get; set; }

        [InputValue]
        [ColumnName("Torque_scaling_factor(standardization)")]
        public double TorqueScalingFactorStandardization { get; set; }

        [InputValue]
        [ColumnName("Standard_Torque_Ratio")]
        public double StandardTorqueRatio { get; set; }

        [InputValue]
        [ColumnName("Requested_spark_retard_angle_from_TCU")]
        public double RequestedSparkRetardAngleFromTCU { get; set; }

        [InputValue]
        [ColumnName("TCU_requests_engine_torque_limit_(ETL)")]
        public double TCURequestsEngineTorqueLimitETL { get; set; }

        [InputValue]
        [ColumnName("TCU_requested_engine_RPM_increase")]
        public double TCURequestedEngineRPMIncrease { get; set; }

        [InputValue]
        [ColumnName("Target_engine_speed_used_in_lock-up_module")]
        public double TargetEngineSpeedUsedInLockUpModule { get; set; }

        [InputValue]
        [ColumnName("Glow_plug_control_request")]
        public double GlowPlugControlRequest { get; set; }

        [InputValue]
        [ColumnName("Activation_of_Air_compressor")]
        public double ActivationOfAirCompressor { get; set; }

        [InputValue]
        [ColumnName("Torque_converter_speed")]
        public double TorqueConverterSpeed { get; set; }

        [InputValue]
        [ColumnName("Current_Gear")]
        public double CurrentGear { get; set; }

        [InputValue]
        [ColumnName("Engine_coolant_temperature2")]
        public double EngineCoolantTemperature2 { get; set; }

        [InputValue]
        [ColumnName("Wheel_velocity_front_left-hand")]
        public double WheelVelocityFrontLeftHand { get; set; }

        [InputValue]
        [ColumnName("Wheel_velocity_rear_right-hand")]
        public double WheelVelocityRearRightHand { get; set; }

        [InputValue]
        [ColumnName("Wheel_velocity_front_right-hand")]
        public double WheelVelocityFrontRightHand { get; set; }

        [InputValue]
        [ColumnName("Wheel_velocity_rear_left-hand")]
        public double WheelVelocityRearLeftHand { get; set; }

        [InputValue]
        [ColumnName("Torque_converter_turbine_speed_-_Unfiltered")]
        public double TorqueConverterTurbineSpeedUnfiltered { get; set; }

        [InputValue]
        [ColumnName("Clutch_operation_acknowledge")]
        public double ClutchOperationAcknowledge { get; set; }

        [InputValue]
        [ColumnName("Converter_clutch")]
        public double ConverterClutch { get; set; }

        [InputValue]
        [ColumnName("Gear_Selection")]
        public double GearSelection { get; set; }

        [InputValue]
        [ColumnName("Vehicle_speed")]
        public double VehicleSpeed { get; set; }

        [InputValue]
        [ColumnName("Acceleration_speed_-_Longitudinal")]
        public double AccelerationSpeedLongitudinal { get; set; }

        [InputValue]
        [ColumnName("Indication_of_brake_switch_ON/OFF")]
        public double IndicationOfBrakeSwitchON_OFF { get; set; }

        [InputValue]
        [ColumnName("Master_cylinder_pressure")]
        public double MasterCylinderPressure { get; set; }

        [InputValue]
        [ColumnName("Calculated_road_gradient")]
        public double CalculatedRoadGradient { get; set; }

        [InputValue]
        [ColumnName("Acceleration_speed_-_Lateral")]
        public double AccelerationSpeedLateral { get; set; }

        [InputValue]
        [ColumnName("Steering_wheel_speed")]
        public double SteeringWheelSpeed { get; set; }

        [InputValue]
        [ColumnName("Steering_wheel_angle")]
        public double SteeringWheelAngle { get; set; }

        [InputValue]
        [ColumnName("Time(s)")]
        public double Time { get; set; }

        [OutputValue]
        [ColumnName("Class")]
        public double Class { get; set; }

        [InputValue]
        [ColumnName("PathOrder")]
        public double PathOrder { get; set; }
    }
}
