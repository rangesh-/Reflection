using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampelVersion1
{
    public class SampelVersion
    {


        private DateTime _objdate;
        public List<String> _cacheddatetime;

        public SampelVersion()
        {
            _cacheddatetime = new List<string>();
            RefereshCache();
        }


        public String Data
        {

            get { return _objdate.ToString("HH:MM:SS"); }

        }

        public List<string> cacheddatetime
        {

            get
            {
                if (_cacheddatetime.Count == 0 || DateTime.Now - _objdate > TimeSpan.FromSeconds(5))
                  
                    RefereshCache();

                return _cacheddatetime;
            }
        }

      
        private  void RefereshCache()
        {
            _objdate = DateTime.Now;

            _cacheddatetime.Add(DateTime.Now.ToString());
        }
    }
}
