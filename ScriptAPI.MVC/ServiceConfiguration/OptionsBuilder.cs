namespace ScriptAPI.MVC.ServiceConfiguration
{
    public class OptionsBuilder
    {
        public string HostContextName { get; set; } = "Host";

        public Options Build() => new Options(HostContextName);
    }
}
