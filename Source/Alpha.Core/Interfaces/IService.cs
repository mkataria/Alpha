using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Core.Interfaces
{
    public interface IService
    {
        void OnStart();
        void OnStop();
        void OnError();
        void Process();
    }
}
