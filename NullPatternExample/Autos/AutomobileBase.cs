using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPatternExample.Autos
{
    public abstract class AutomobileBase
    {
        public abstract Guid ID { get; }
        public abstract string Name { get; }
        public abstract void Start();
        public abstract void Stop();

        #region Null Object (Singleton)

        static readonly NullAutomobile nullAutomobile = new NullAutomobile();

        public static NullAutomobile NULL 
        {
            get
            {
                return nullAutomobile;
            }
        }

        public class NullAutomobile : AutomobileBase
        {
            public override Guid ID
            {
                get
                {
                    return Guid.Empty;
                }
            }

            public override string Name
            {
                get
                {
                    return string.Empty;
                }
            }

            public override void Start() { }

            public override void Stop() { }
        }

        #endregion
    }
}
