using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using InterfaceLayer;
using EntityLayer;
using System.Configuration;

namespace Gartner
{
    public class Program
    {
        static void Main(string[] args)
        {
            String FilePath = ConfigurationManager.AppSettings["FilePath"];
            FileloadInterface LoadFile = new LoadYaml();
            EntityClass[] entityClasses= LoadFile.Load(FilePath);
            foreach (EntityClass entityClass in entityClasses)
            {
                Console.WriteLine("importing: Name: {0}; Categories: {1} Twitter: {2}", entityClass.Name,entityClass.Tags,entityClass.Twitter) ;
            }
            Console.ReadKey();
        }
    }
}
