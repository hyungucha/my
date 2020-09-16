using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFunctionGenerator
{
	public class ParamVal
    {
        public string ch;
        public string frq;
        public string amp;
        public string pulse;
    }

    public interface IFunctionGenerator
    {
        bool Connect(string path);
        void Reset();
        //void ParamSetting(ParamVal p);
        void DestroyInst();
    }
}
