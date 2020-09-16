using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDAQ
{
    public interface IDAQ
    {
        void Start();
        void Stop();
        void SetParam();
    }
}
