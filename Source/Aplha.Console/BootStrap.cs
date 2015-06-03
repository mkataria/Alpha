using Alpha.Core.Interfaces;
using Alpha.Core.Services;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace Aplha.Console
{
    public class BootStrap
    {
        public void Start()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType(typeof (IPriceReaderService),typeof(PriceReaderService));
            
            var obj = container.Resolve(typeof (IPriceReaderService)) as PriceReaderService;
            obj.OnStart();
            obj.Process();
        }
    }
}
