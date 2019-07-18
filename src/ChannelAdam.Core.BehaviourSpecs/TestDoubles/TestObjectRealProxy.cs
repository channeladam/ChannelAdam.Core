using ChannelAdam.Runtime.Remoting.Proxies;

namespace ChannelAdam.Core.BehaviourSpecs.TestDoubles
{
    public class TestObjectRealProxy<TObjectToProxy> : DisposableObjectRealProxy<TObjectToProxy>
    {
        #region Public Fields

        public readonly TObjectToProxy obj;

        #endregion Public Fields

        #region Public Constructors

        public TestObjectRealProxy(TObjectToProxy objectToProxy)
        {
            this.obj = objectToProxy;
        }

        #endregion Public Constructors

        #region Protected Properties

        protected override object ProxiedObject
        {
            get
            {
                return this.obj;
            }
        }

        #endregion Protected Properties
    }
}