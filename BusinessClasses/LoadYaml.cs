using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;
using YamlDotNet.RepresentationModel;
using EntityLayer;

namespace BusinessLayer
{
    public class LoadYaml: FileloadInterface
    {
        public EntityClass[] Load(string filePath)
        {
            var input = new StreamReader(filePath);
            var yaml = new YamlStream();
            yaml.Load(input);
            var mapping =
                ((YamlSequenceNode)yaml.Documents[0].RootNode);
            EntityClass[] entityClass = new EntityClass[mapping.Children.Count];
            try
            {
                for (int i = 0; i < mapping.Children.Count; i++)
                {
                    entityClass[i] = new EntityClass(Convert.ToString(mapping[i]["tags"]), Convert.ToString(mapping[i]["name"]), Convert.ToString(mapping[i]["twitter"]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return entityClass;
        }
    }
}
