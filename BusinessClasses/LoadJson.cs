using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using InterfaceLayer;

namespace BusinessLayer
{
    public class LoadJson: FileloadInterface
    {
        public void Load(string filePath)
        {
           
        }

        EntityClass[] FileloadInterface.Load(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
