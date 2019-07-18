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

namespace ChannelAdam.Runtime.Remoting.Proxies
{
    using System.Collections;
    using System.Reflection;
    using System.Runtime.Remoting.Messaging;

    public class MethodCallMessageWithMutableArgs : IMethodCallMessage, IHasMutableArgs
    {
        #region Private Fields

        private readonly IMethodCallMessage methodCallMessage;

        #endregion Private Fields

        #region Public Constructors

        public MethodCallMessageWithMutableArgs(IMethodCallMessage methodCallMessage)
        {
            this.methodCallMessage = methodCallMessage ?? throw new System.ArgumentNullException(nameof(methodCallMessage));
            this.MutableArgs = methodCallMessage.Args;
        }

        #endregion Public Constructors

        #region Public Properties

        public int ArgCount => this.methodCallMessage.ArgCount;

        public object[] Args => this.methodCallMessage.Args;

        public bool HasVarArgs => this.methodCallMessage.HasVarArgs;

        public int InArgCount => this.methodCallMessage.InArgCount;

        public object[] InArgs => this.methodCallMessage.InArgs;

        public LogicalCallContext LogicalCallContext => this.methodCallMessage.LogicalCallContext;

        public MethodBase MethodBase => this.methodCallMessage.MethodBase;

        public string MethodName => this.methodCallMessage.MethodName;

        public object MethodSignature => this.methodCallMessage.MethodSignature;

        public object[] MutableArgs { get; set; }

        public IDictionary Properties => this.methodCallMessage.Properties;

        public string TypeName => this.methodCallMessage.TypeName;

        public string Uri => this.methodCallMessage.Uri;

        #endregion Public Properties

        #region Public Methods

        public object GetArg(int argNum)
        {
            return this.methodCallMessage.GetArg(argNum);
        }

        public string GetArgName(int index)
        {
            return this.methodCallMessage.GetArgName(index);
        }

        public object GetInArg(int argNum)
        {
            return this.methodCallMessage.GetInArg(argNum);
        }

        public string GetInArgName(int index)
        {
            return this.methodCallMessage.GetInArgName(index);
        }

        #endregion Public Methods
    }
}