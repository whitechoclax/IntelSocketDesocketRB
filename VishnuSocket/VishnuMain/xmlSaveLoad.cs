using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VishnuMain
{
    class xmlSaveLoad
    {

        public void loadFromXML()
        {
             
        }

        public void savetoXML()
        {
            DataSet Ds = new DataSet();
            Ds.WriteXml("file path name here");
        }

    }
}
