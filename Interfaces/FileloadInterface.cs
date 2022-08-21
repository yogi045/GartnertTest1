using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using Interfaces;

namespace InterfaceLayer
{
    public interface FileloadInterface
    {
       EntityClass[] Load(string filePath);
    }
}
