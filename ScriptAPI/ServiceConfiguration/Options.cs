namespace ScriptAPI.ServiceConfiguration
{
    public class Options : IOptions
    {
        public string HostContextName { get; }

        public Options(string hostContextName)
        {
            HostContextName = hostContextName;
        }
    }
}
