namespace ScriptAPI
{
    public class ScriptAPIException
    {
        public string Message { get; }
        
        public int StartLine { get; }
        
        public int StartColumn { get; }
        
        public int EndLine { get; }
        
        public int EndColumn { get; }

        internal ScriptAPIException(string message, int startLine, int startColumn, int endLine, int endColumn)
        {
            Message = message;
            StartLine = startLine;
            StartColumn = startColumn;
            EndLine = endLine;
            EndColumn = endColumn;
        }
    }
}
