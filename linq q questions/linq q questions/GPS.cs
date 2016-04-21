using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_q_questions
{
    class GpsDevice
    {
        public string Name;
        public bool IsActive;
    }

    class GpsManufacturer
    {
        public string Name;
        public GpsDevice[] Devices;
    }


}
