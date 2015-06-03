using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alpha.Core.Interfaces;

namespace Alpha.Core.Services
{
    public abstract class ServiceBase:IService
    {
        public virtual void OnStart()
        {
            
        }

        public virtual void OnStop()
        {
            
        }

        public virtual void OnError()
        {
            
        }

        public virtual void Process()
        {
            
        }
    }
}
