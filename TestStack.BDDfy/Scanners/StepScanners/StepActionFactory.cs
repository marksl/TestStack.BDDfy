using System;
using System.Reflection;

namespace TestStack.BDDfy
{
    public class StepActionFactory
    {
        public static Func<object,object> GetStepAction(MethodInfo method, object[] inputs)
        {
            return o => method.Invoke(o, inputs);
        }

        public static Func<object,object> GetStepAction<TScenario>(Action<TScenario> action)
            where TScenario : class
        {
            return o => 
            {
                action((TScenario)o);
                return null;
            };
        }

        
    }
}