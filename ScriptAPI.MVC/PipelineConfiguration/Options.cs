namespace ScriptAPI.MVC.PipelineConfiguration
{
    public class Options
    {
        public string EndpointPath { get; }

        public Options(string endpointPath)
        {
            EndpointPath = endpointPath;
        }
    }
}
