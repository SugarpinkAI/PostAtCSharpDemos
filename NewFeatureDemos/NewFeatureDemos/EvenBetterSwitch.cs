using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace NewFeatureDemos
{
    public class EvenBetterSwitch
    {
        public enum VoltageSupport
        {
            American115,
            European230,
            Both
        }

        public enum Polarity
        {
            Positive,
            Negative
        }

        public enum MotorResponse
        {
            SpinForward,
            SpinBackward,
            Error
        }

        public enum MotorError
        {
            NoSpin,
            Burnout
        }

        public (MotorResponse, MotorError?) CheckMotorOperation(int inputVoltage, VoltageSupport supportedVoltage, Polarity polarity)
        {
            return (inputVoltage, supportedVoltage, polarity) switch
            {
                (_, VoltageSupport.American115, _) x when x.inputVoltage < 115 => (MotorResponse.Error, MotorError.NoSpin),
                (_, VoltageSupport.American115, _) x when x.inputVoltage > 115 => (MotorResponse.Error, MotorError.Burnout),

                (_, VoltageSupport.European230, _) x when x.inputVoltage < 230 => (MotorResponse.Error, MotorError.NoSpin),
                (_, VoltageSupport.European230, _) x when x.inputVoltage > 230 => (MotorResponse.Error, MotorError.Burnout),

                (_, VoltageSupport.Both, _) x when x.inputVoltage < 115 => (MotorResponse.Error, MotorError.NoSpin),
                (_, VoltageSupport.Both, _) x when x.inputVoltage > 230 => (MotorResponse.Error, MotorError.Burnout),

                (115, VoltageSupport.American115, Polarity.Positive) => (MotorResponse.SpinForward, null),
                (115, VoltageSupport.American115, Polarity.Negative) => (MotorResponse.SpinBackward, null),

                (230, VoltageSupport.American115, Polarity.Positive) => (MotorResponse.SpinForward, null),
                (230, VoltageSupport.American115, Polarity.Negative) => (MotorResponse.SpinBackward, null),

                (_, VoltageSupport.Both, Polarity.Positive) x when x.inputVoltage >= 115 && x.inputVoltage <= 230 => (MotorResponse.SpinForward, null),
                (_, VoltageSupport.Both, Polarity.Negative) x when x.inputVoltage >= 115 && x.inputVoltage <= 230 => (MotorResponse.SpinBackward, null),

                _ => throw new InvalidOperationException("Unexpected combination of inputs")
            };
        }
    }
}
