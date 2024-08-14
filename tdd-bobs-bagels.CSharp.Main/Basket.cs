using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> _bagels = new List<string>();
        private int _basketCapacity = 10;
        
        public void Add(string v)
        {
            throw new NotImplementedException();
        }

        public List<string> Bagels { get { throw new NotImplementedException(); } }
        public int BasketCapacity { get { throw new NotImplementedException(); } set { _basketCapacity = value; } }
    }
}
