﻿namespace TheInterceptor
{
    public interface IInterceptor
    {
        void ExecuteBefore(CallContext context);
        void ExecuteAfter(CallContext context, object result);
    }
}
