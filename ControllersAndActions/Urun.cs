using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersAndActions
{
    public class Urun
    {
    }
    public class Urun2
    {
    }
    public class Otobus : Urun, IArac, ITasit
    {
        public void GazVer()
        {
            throw new NotImplementedException();
        }

        public void SolaDon()
        {
            throw new NotImplementedException();
        }

        public void SolaDon(int yon)
        {
            throw new NotImplementedException();
        }

        public int YakitTuketimi()
        {
            throw new NotImplementedException();
        }
    }
}
