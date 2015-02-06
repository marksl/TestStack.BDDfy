using System;
using System.Security;
using System.Threading;

namespace TestStack.BDDfy.Processors
{
    public static class AsyncTestRunner
    {        
        public static void Run(Func<object> performStep)
        {
            var oldSyncContext = SynchronizationContext.Current;
            try
            {
                var asyncSyncContext = new AsyncTestSyncContext();
                SetSynchronizationContext(asyncSyncContext);
                performStep();
                
                {
                    var ex = asyncSyncContext.WaitForCompletion();
                    if (ex != null)
                    {
                        ExceptionProcessor.PreserveStackTrace(ex);
                        throw ex;
                    }
                }
            }
            finally
            {
                SetSynchronizationContext(oldSyncContext);
            }
        }

        [SecuritySafeCritical]
        private static void SetSynchronizationContext(SynchronizationContext context)
        {
            SynchronizationContext.SetSynchronizationContext(context);
        }
    }
}