using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Cars_Editor.Class_Manager;

namespace Cars_Editor.Serializer
{
    class MyXmlSerializer
    {

        public static string SerializeObj(object obj)
        {
            XmlSerializer formatter = new XmlSerializer(obj.GetType());

            //using (FileStream fs = new FileStream("cars.xml", FileMode.Append))
            //{
            //    formatter.Serialize(fs, obj);
            //}

            //XmlSerializer serializer = new XmlSerializer(typeof(Point));
            //using (StringWriter writer = new StringWriter(...))
            //{
            //    serializer.Serialize(writer, point);
            //    string serializedXML = writer.ToString();
            //}

            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, obj);

                stream.Position = 0;
                TextReader reader = new StreamReader(stream);
                string result = reader.ReadToEnd();
                return result;
            }
        }

        public static void SerializeArr(object[] objs)
        {
            //using (FileStream fs = new FileStream("cars.xml", FileMode.OpenOrCreate))
            //{
            //    for (int i = 0; i < objs.Length; i++)
            //    {
            //XmlSerializer formatter = new XmlSerializer(objs[].GetType());

            //        formatter.Serialize(fs, objs[i]);
            //    }
            //}

            string[] result = new string[objs.Length];
            for (int i = 0; i < objs.Length; i++)
            {
                result[i] = SerializeObj(objs[i]);
            }
            File.WriteAllLines("cars.xml", result);

        }

        private static Type getXmlType(string str, Type[] allTypes)
        {
            string type_name = "";

            int j = 0;
            while (str[j] != '>')
                j++;
            j++;

            while (str[j] != '<')
            {
                type_name += str[j];
                j++;
            }

            j = 0;
            while (type_name != allTypes[j].Name)
                j++;
            return allTypes[j];
        }

        private static Type[] getXmlTypes(Type[] allTypes)
        {
            Type[] types = new Type[0];
            string[] strs = File.ReadAllLines("cars.xml");
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Contains("<brand>"))
                {   
                    Array.Resize(ref types, types.Length + 1);
                    types[types.Length - 1] = getXmlType(strs[i], allTypes);
                }
            }
            return types;
        }

        public static object[] DeserializeArr(Type[] types)
        {
            Type[] allTypes = getXmlTypes(types);
            object[] newCars = new object[allTypes.Length];
            using (FileStream fs = new FileStream("cars.xml", FileMode.Open))
            {
                for (int i = 0; i < allTypes.Length; i++)
                {
                    XmlSerializer formatter = new XmlSerializer(allTypes[i]);

                    newCars[i] = (object)formatter.Deserialize(fs);
                }
            }

            return newCars;
        }

        //public static object DeserializeObj(string str)
        //{
            
        //}

    }

    class MyBinSerializer
    {
        public static void SerializeArr(object[] objs)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("cars.dat", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, objs);
            }
        }
        public static object[] DeserializeArr()
        {
            BinaryFormatter bf = new BinaryFormatter();
            object[] result = null;
            using (FileStream fs = new FileStream("cars.dat", FileMode.OpenOrCreate))
            {
                result = (object[])bf.Deserialize(fs);
            }
            return result;
        }
    }
}
