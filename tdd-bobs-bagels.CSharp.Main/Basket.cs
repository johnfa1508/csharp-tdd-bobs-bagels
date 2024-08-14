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
        
        public string Add(string bagelName)
        {
            if (_basketCapacity <= 0)
            {
                return $"There is no space for {bagelName}";
            } else
            {
                _bagels.Add(bagelName);
                return $"Successfully added {bagelName}";
            }  
        }

        public string Remove(string bagelName)
        {
            if (!_bagels.Contains(bagelName)) {
                return $"{bagelName} does not exist.";
            } else
            {
                _bagels.Remove(bagelName);
                return $"{bagelName} successfully removed.";
            }
        }

        public List<string> Bagels { get { return _bagels; } }
        public int BasketCapacity { get { return BasketCapacity; } set { _basketCapacity = value; } }
    }
}
