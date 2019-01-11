using ScriptAPI.Procedures;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;

namespace ScriptAPI.HostContext
{
    public class Host
    {
        public dynamic Procs { get; }

        public Host(ProcedureLocator procedureLocator, ProcedureMapping procedureMapping)
        {
            IDictionary<string, object> procs = new ExpandoObject();

            foreach(var procedure in procedureMapping)
            {
                var methodInfo = procedure.Type.GetMethod("Do");
                if (methodInfo == null || !typeof(IProcedure).IsAssignableFrom(procedure.Type))
                {
                    throw new InvalidOperationException("Supplied procedures must implement IProcedure and have a 'Do' method");
                }

                var procTypeExp = Expression.Constant(procedure.Type);
                var procLocatorExp = Expression.Constant(procedureLocator);
                var procExp = Expression.Invoke(procLocatorExp, procTypeExp);
                var commandExp = Expression.Convert(procExp, procedure.Type);
                Type[] paramTypes = methodInfo.GetParameters().Select(x => x.ParameterType).ToArray();
                ParameterExpression[] paramsExp;
                Type methodDelegateType;
                if (methodInfo.ReturnType.Equals((typeof(void))))
                {
                    paramTypes = methodInfo.GetParameters()
                        .Select(x => x.ParameterType)
                        .ToArray();
                    paramsExp = paramTypes
                        .Select(x => Expression.Parameter(x))
                        .ToArray();
                    methodDelegateType = Expression.GetActionType(paramTypes);
                }
                else
                {
                    paramTypes = methodInfo.GetParameters()
                        .Select(x => x.ParameterType)
                        .Concat(new Type[] { methodInfo.ReturnType })
                        .ToArray();
                    paramsExp = paramTypes
                        .SkipLast(1)
                        .Select(x => Expression.Parameter(x))
                        .ToArray();
                    methodDelegateType = Expression.GetFuncType(paramTypes);
                }
                var procResultExp = Expression.Call(commandExp, methodInfo, paramsExp);
                var lamdba = Expression.Lambda(methodDelegateType, procResultExp, paramsExp);
                var compiledProc = lamdba.Compile();

                procs.Add(procedure.Name, compiledProc);
            }

            Procs = procs;
        }
    }
}
