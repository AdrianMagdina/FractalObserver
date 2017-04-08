// programmed by Adrian Magdina in 2012
// in this file is the implementation of factory for fractal and equation creation
using System;
using System.Collections.Generic;
using System.Text;

namespace FractalObserverApplication
{
    // used fractal types
    public enum FractalTypes
    {
        None,
        NewtonFractal,
        MandelbrotFractal,
        KochSnowflake,
        PythagorasTree,
    }

    // used equation types
    public enum EquationTypes
    {
        None,
        z2,
        z3Minus1,
        z3Minusz,
        z3Minus2zPlus2,
        z2Minus1
    }

    // factory for creating fractal instances
    public class FractalFactory
    {
        #region Constructors

        public FractalFactory()
        {
            myEquationFactory = new EquationFactory();
        }

        #endregion

        #region Methods

        public IFractal CreateFractal(FractalTypes fractalTypeIn)
        {
            switch (fractalTypeIn)
            {
                case FractalTypes.NewtonFractal:
                    throw new FractalObserverException("When creating current fractal type equation type must be set in parameter!");
                case FractalTypes.MandelbrotFractal:
                    throw new FractalObserverException("When creating current fractal type equation type must be set in parameter!");
                case FractalTypes.KochSnowflake:
                    return new KochSnowflake();
                case FractalTypes.PythagorasTree:
                    return new PythagorasTree();
                default:
                    throw new FractalObserverException("Unknown fractal type!");
            }
        }

        public IFractal CreateFractal(FractalTypes fractalTypeIn, EquationTypes equationTypeIn)
        {
            IEquation aEquation = null;
            if (equationTypeIn != EquationTypes.None)
            {
                aEquation = myEquationFactory.CreateEquation(equationTypeIn);
            }

            switch (fractalTypeIn)
            {
                case FractalTypes.NewtonFractal:
                    return new NewtonFractal(aEquation);
                case FractalTypes.MandelbrotFractal:
                    return new MandelbrotSet(aEquation);
                case FractalTypes.KochSnowflake:
                    return new KochSnowflake();
                case FractalTypes.PythagorasTree:
                    return new PythagorasTree();
                default:
                    throw new FractalObserverException("Unknown fractal type!");
            }
        }

        public static IList<EquationTypes> GetAvailableEquationTypesForFractalType(FractalTypes fractalTypeIn)
        {
            List<EquationTypes> aEquationTypesList = new List<EquationTypes>();

            switch (fractalTypeIn)
            {
                case FractalTypes.NewtonFractal:
                    aEquationTypesList.Add(EquationTypes.z3Minus1);
                    aEquationTypesList.Add(EquationTypes.z3Minus2zPlus2);
                    aEquationTypesList.Add(EquationTypes.z3Minusz);
                    break;
                case FractalTypes.MandelbrotFractal:
                    aEquationTypesList.Add(EquationTypes.z2);
                    break;
                case FractalTypes.KochSnowflake:
                    break;
                case FractalTypes.PythagorasTree:
                    break;
                default:
                    throw new FractalObserverException("Unknown fractal type!");
            }

            return aEquationTypesList;
        }

        #endregion

        #region Properties

        public EquationFactory EquationFactory
        {
            get
            {
                return myEquationFactory;
            }
        }

        public static Dictionary<string, FractalTypes> AvailableFractalTypes
        {
            get
            {
                Dictionary<string, FractalTypes> aAvailableFractalTypes = new Dictionary<string, FractalTypes>();

                //adding of all known fractal types to fractal types dictionary
                aAvailableFractalTypes.Add("Newton Fractal", FractalTypes.NewtonFractal);
                aAvailableFractalTypes.Add("Mandelbrot Set", FractalTypes.MandelbrotFractal);
                aAvailableFractalTypes.Add("Koch Snowflake", FractalTypes.KochSnowflake);
                aAvailableFractalTypes.Add("Pythagoras Tree", FractalTypes.PythagorasTree);

                return aAvailableFractalTypes;
            }
        }

        #endregion

        #region Members

        private EquationFactory myEquationFactory = null;

        #endregion
    }
    
    // library for creating equations
    public class EquationFactory
    {
        #region Constructors

        public EquationFactory()
        {
        }

        #endregion

        #region Methods

        public IEquation CreateEquation(EquationTypes equationTypeIn)
        {
            switch (equationTypeIn)
            {
                case EquationTypes.z2:
                    return new EquationZ2();
                case EquationTypes.z2Minus1:
                    return new EquationZ2Minus1();
                case EquationTypes.z3Minus1:
                    return new EquationZ3Minus1();
                case EquationTypes.z3Minusz:
                    return new EquationZ3MinusZ();
                case EquationTypes.z3Minus2zPlus2:
                    return new EquationZ3Minus2zPlus2();
                default:
                    throw new FractalObserverException("Unknown Equation type :" + equationTypeIn + "!");
            }
        }

        #endregion

        #region Properties

        public static Dictionary<string, EquationTypes> AvailableEquationTypes
        {
            get
            {
                Dictionary<string, EquationTypes> aAvailableEquationTypes = new Dictionary<string, EquationTypes>();

                //adding of all known equation types to equations types dictionary
                aAvailableEquationTypes.Add("z3-1", EquationTypes.z3Minus1);
                aAvailableEquationTypes.Add("z3-z", EquationTypes.z3Minusz);
                aAvailableEquationTypes.Add("z2-1", EquationTypes.z2Minus1);
                aAvailableEquationTypes.Add("z3-2z+2", EquationTypes.z3Minus2zPlus2);
                aAvailableEquationTypes.Add("z2", EquationTypes.z2);

                return aAvailableEquationTypes;
            }
        }

        #endregion
    }
}
