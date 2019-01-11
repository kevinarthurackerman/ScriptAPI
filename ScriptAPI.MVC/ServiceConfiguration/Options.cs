namespace ScriptAPI.MVC.ServiceConfiguration
{
    public class Options : ScriptAPI.ServiceConfiguration.IOptions
    {
        public string HostContextName { get; }

        public Options(string hostContextName)
        {
            HostContextName = hostContextName;
        }
    }
}
