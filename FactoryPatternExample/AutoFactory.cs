using FactoryPatternExample.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FactoryPatternExample
{
    public class AutoFactory
    {
        Dictionary<string, Type> autos;

        public AutoFactory()
        {
            LoadTypesICanReturn();
        }

        public IAuto CreateInstance(string carName)
        {
            Type t = GetTypeToCreate(carName);

            if (t == null)
                return new NullAuto();

            return Activator.CreateInstance(t) as IAuto;
        }

        private Type GetTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains(carName))
                {
                    return autos[auto.Key];
                }
            }
            return null;
        }

        private void LoadTypesICanReturn()
        {
            autos = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IAuto).ToString()) != null)
                {
                    autos.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}
