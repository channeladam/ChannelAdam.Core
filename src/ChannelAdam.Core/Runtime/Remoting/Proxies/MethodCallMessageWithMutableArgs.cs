//-----------------------------------------------------------------------
// <copyright file="MethodCallMessageWithMutableArgs.cs">
//     Copyright (c) 2019 Adam Craven. All rights reserved.
// </copyright>
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

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