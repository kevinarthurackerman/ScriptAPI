using ScriptAPI.Procedures;

namespace ScriptAPI.TestWebApp.Procs
{
    public class AddProc : IFunctionProcedure<int, int, int>
    {
        public int Do(int a, int b) => a + b;
    }
}
