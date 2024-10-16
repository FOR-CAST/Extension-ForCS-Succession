//  Authors:  Caren Dymond, Sarah Beukema

using Landis.Utilities;

namespace Landis.Extension.Succession.ForC
{

    public interface ISufficientLight
    {
        
        byte ShadeClass{get;set;}
        double ProbabilityLight0{get;set;}
        double ProbabilityLight1{get;set;}
        double ProbabilityLight2{get;set;}
        double ProbabilityLight3{get;set;}
        double ProbabilityLight4{get;set;}
        double ProbabilityLight5{get;set;}
    }

    /// <summary>
    /// Definition of the probability of germination under different light levels for 5 shade classes.
    /// </summary>
    public class SufficientLight
        : ISufficientLight
    {
        private byte shadeClass;
        private double probabilityLight0;
        private double probabilityLight1;
        private double probabilityLight2;
        private double probabilityLight3;
        private double probabilityLight4;
        private double probabilityLight5;
        
        //---------------------------------------------------------------------

        public SufficientLight()
        {
        }
        //---------------------------------------------------------------------

        /// <summary>
        /// The shade class (between 1 and 5).
        /// </summary>
        public byte ShadeClass
        {
            get {
                return shadeClass;
            }
            set {
                    if (value > 5 || value < 1)
                        throw new InputValueException(value.ToString(),
                                                      "Value must be between 1 and 5.");
                shadeClass = value;
            }
        }

        //---------------------------------------------------------------------
        public double ProbabilityLight0
        {
            get {
                return probabilityLight0;
            }
            set {
                    if (value < 0.0 || value > 1.0)
                        throw new InputValueException(value.ToString(),
                                              "Value must be between 0 and 1");
                probabilityLight0 = value;
            }
        }
        //---------------------------------------------------------------------
        public double ProbabilityLight1
        {
            get {
                return probabilityLight1;
            }
            set {
                if (value < 0.0 || value > 1.0)
                    throw new InputValueException(value.ToString(), "Value must be between 0 and 1");
                probabilityLight1 = value;
            }
        }
        //---------------------------------------------------------------------
        public double ProbabilityLight2
        {
            get {
                return probabilityLight2;
            }
            set {
                if (value < 0.0 || value > 1.0)
                    throw new InputValueException(value.ToString(), "Value must be between 0 and 1");
                probabilityLight2 = value;
            }
        }
        //---------------------------------------------------------------------
        public double ProbabilityLight3
        {
            get {
                return probabilityLight3;
            }
            set {
                if (value < 0.0 || value > 1.0)
                    throw new InputValueException(value.ToString(), "Value must be between 0 and 1");
                probabilityLight3 = value;
            }
        }
        //---------------------------------------------------------------------
        public double ProbabilityLight4
        {
            get {
                return probabilityLight4;
            }
            set {
                if (value < 0.0 || value > 1.0)
                    throw new InputValueException(value.ToString(), "Value must be between 0 and 1");
                probabilityLight4 = value;
            }
        }
        //---------------------------------------------------------------------
        public double ProbabilityLight5
        {
            get {
                return probabilityLight5;
            }
            set {
                if (value < 0.0 || value > 1.0)
                    throw new InputValueException(value.ToString(), "Value must be between 0 and 1");
                probabilityLight5 = value;
            }
        }

    }
}
