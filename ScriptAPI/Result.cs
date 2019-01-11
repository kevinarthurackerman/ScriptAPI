namespace ScriptAPI
{
    public class Result
    {
        public object Data { get; }

        public ScriptAPIException Error { get; }

        internal Result(object data)
        {
            Data = data;
        }

        internal Result(ScriptAPIException error)
        {
            Error = error;
        }
    }
}
