using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ScriptAPI.Procedures
{
    public class ProcedureMapping : ReadOnlyCollection<(string Name, Type Type)>
    {
        public ProcedureMapping(IList<(string Name, Type Type)> list) : base(list)
        {
        }
    }
}
