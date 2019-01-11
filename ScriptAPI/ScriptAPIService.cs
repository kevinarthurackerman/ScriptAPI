using System.IO;
using System.Threading.Tasks;
using Jint;
using ScriptAPI.HostContext;
using Jint.Runtime;
using Esprima;

namespace ScriptAPI
{
    public class ScriptAPIService
    {
        private readonly ServiceConfiguration.IOptions _options;

        private readonly Host _host;

        private readonly Engine _jintEngine = new Engine();

        public ScriptAPIService(ServiceConfiguration.IOptions options, Host host)
        {
            _options = options;
            _host = host;
        }

        public async Task<Result> ExecuteAsync(Stream script)
        {
            StreamReader reader = new StreamReader(script);
            return await ExecuteAsync(await reader.ReadToEndAsync());
        }
        
        public Task<Result> ExecuteAsync(string script)
        {
            try
            {
                var scriptResult = _jintEngine
                    .SetValue(_options.HostContextName, _host)
                    .Execute(script)
                    .GetCompletionValue()
                    .ToObject();

                return Task.FromResult(new Result(scriptResult));
            }
            catch(JavaScriptException jsEx)
            {
                var error = new ScriptAPIException(
                    jsEx.Message, 
                    jsEx.Location.Start.Line, 
                    jsEx.Location.Start.Column, 
                    jsEx.Location.End.Line, 
                    jsEx.Location.End.Column
                );

                return Task.FromResult(new Result(error));
            }
            catch(ParserException pEx)
            {
                var error = new ScriptAPIException(
                    pEx.Message,
                    pEx.LineNumber,
                    pEx.Column,
                    pEx.LineNumber,
                    pEx.Column
                );

                return Task.FromResult(new Result(error));
            }
        }
    }
}
