using DeveloperSample.ClassRefactoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperSample.ClassRefactoring
{
    //creating an Enum that can be used throughout
    public class SwallowLoad
    {
        public const int None = 0;
        public const int Coconut = 1;

        public static implicit operator SwallowLoad(int v)
        {
            if (v == None)
                return 0;
            else if (v == Coconut)
                return 1;
            else
                throw new ArgumentException("Invalid Swallow Load");
        }

    }

    public class SwallowType
    {
        public const int European = 0;
        public const int African = 1;

        public static implicit operator SwallowType(int v)
        {
            if (v == European)
                return 0;
            else if (v == African)
                return 1;
            else
                throw new ArgumentException("Invalid Swallow Type");
        }
    }

    /// <summary>
    /// The 'Swallow' interface
    /// </summary>
    public interface IFactory
    {
        public int Load { get; set; }
        void ApplyLoad(int load);
        public double GetAirspeedVelocity();
    }

    /// <summary>
    /// Concrete European Swallow class
    /// </summary>
    public class European : IFactory
    {
        public int Load { get; set; }

        public void ApplyLoad(int load)
        {
            Load = load;
        }

        public double GetAirspeedVelocity()
        {
            if (Load == SwallowLoad.None)
            {
                return 20;
            }
            if (Load == SwallowLoad.Coconut)
            {
                return 16;
            }
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Concrete African Swallow class
    /// </summary>
    public class African : IFactory
    {
        public int Load { get; set; }

        public void ApplyLoad(int load)
        {
            Load = load;
        }

        public double GetAirspeedVelocity()
        {
            if (Load == SwallowLoad.None)
            {
                return 22;
            }
            if (Load == SwallowLoad.Coconut)
            {
                return 18;
            }
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class SwallowCreator
    {
        public abstract IFactory GetSwallow(int Swallow);

    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class SwallowFactory : SwallowCreator
    {
        public override IFactory GetSwallow(int Swallow)
        {
            switch (Swallow)
            {
                case SwallowType.European: return new European();
                case SwallowType.African: return new African();
                default: throw new ArgumentException("Invalid swallow type");
            }
        }
    }

}

