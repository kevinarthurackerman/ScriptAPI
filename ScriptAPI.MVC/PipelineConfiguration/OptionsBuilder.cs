namespace ScriptAPI.MVC.PipelineConfiguration
{
    public class OptionsBuilder
    {
        public string EndpointPath { get; set; } = "/execute";

        public OptionsBuilder WithEndpointPath(string endpointPath)
        {
            EndpointPath = endpointPath;
            return this;
        }

        public Options Build() => new Options(EndpointPath);
    }
}
