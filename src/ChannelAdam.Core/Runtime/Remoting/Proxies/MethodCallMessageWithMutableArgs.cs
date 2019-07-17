using System.Collections;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace ChannelAdam.Runtime.Remoting.Proxies
{
    public class MethodCallMessageWithMutableArgs : IMethodCallMessage, IHasMutableArgs
    {
        #region Private Fields

        private readonly IMethodCallMessage _methodCallMessage;

        #endregion Private Fields

        #region Public Constructors

        public MethodCallMessageWithMutableArgs(IMethodCallMessage methodCallMessage)
        {
            _methodCallMessage = methodCallMessage;
            MutableArgs = methodCallMessage.Args;
        }

        #endregion Public Constructors

        #region Public Properties

        public int ArgCount => _methodCallMessage.ArgCount;
        public object[] Args => _methodCallMessage.Args;
        public bool HasVarArgs => _methodCallMessage.HasVarArgs;
        public int InArgCount => _methodCallMessage.InArgCount;

        public object[] InArgs => _methodCallMessage.InArgs;

        public LogicalCallContext LogicalCallContext => _methodCallMessage.LogicalCallContext;
        public MethodBase MethodBase => _methodCallMessage.MethodBase;
        public string MethodName => _methodCallMessage.MethodName;
        public object MethodSignature => _methodCallMessage.MethodSignature;
        public object[] MutableArgs { get; }
        public IDictionary Properties => _methodCallMessage.Properties;
        public string TypeName => _methodCallMessage.TypeName;
        public string Uri => _methodCallMessage.Uri;

        #endregion Public Properties

        #region Public Methods

        public object GetArg(int argNum)
        {
            return _methodCallMessage.GetArg(argNum);
        }

        public string GetArgName(int index)
        {
            return _methodCallMessage.GetArgName(index);
        }

        public object GetInArg(int argNum)
        {
            return _methodCallMessage.GetInArg(argNum);
        }

        public string GetInArgName(int index)
        {
            return _methodCallMessage.GetInArgName(index);
        }

        #endregion Public Methods
    }
}