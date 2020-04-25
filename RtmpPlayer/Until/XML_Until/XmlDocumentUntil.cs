using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using RtmpPlayer.Carmer;

namespace RtmpPlayer.Until.XML_Until
{
    public class XmlDocumentUntil{

        public static XmlDocument configXml = new XmlDocument();

        public static void addCamera(string titleName,string deviceName,string deviceUrl)
        {
           configXml = new XmlDocument();


            if (!checkXML())
            {
                XmlTextWriter writer = new XmlTextWriter("device.xml", null);
                //使用自动缩进便于阅读
                writer.Formatting = Formatting.Indented;
                //书写根元素
                writer.WriteStartElement("devices", titleName);
                //开始一个元素
                writer.WriteElementString("deviceName",deviceName);
                writer.WriteElementString("deviceUrl", deviceUrl);
                writer.WriteEndElement();  // 关闭元素
                                           //在节点间添加一些空格
                writer.WriteWhitespace("\n");
                //将XML写入文件并关闭writer
                writer.Close();
            }
            else
            {
                configXml.Load("device.xml");
                //XmlNode root = configXml.SelectSingleNode("liveConfig");//查找<bookstore>
                XmlElement xe1 = (XmlElement)configXml.GetElementsByTagName("devices")[0];


                XmlElement device = configXml.CreateElement("device");
                XmlElement xesub1 = configXml.CreateElement("deviceName");
                xesub1.InnerText = deviceName;//设置文本节点
                device.AppendChild(xesub1);//添加到<book>节点中

                XmlElement xesub2 = configXml.CreateElement("deviceUrl");
                xesub2.InnerText = deviceUrl;
                device.AppendChild(xesub2);
                xe1.AppendChild(device);

                configXml.Save("device.xml");
            }
            
        }

        public static bool checkXML()
        {
            if (System.IO.File.Exists("device.xml"))
            {
                return true;
            }
            else
            {

                return false;
            }

        }
        

        public static List<Carmer.Carmer> getAllList()
        {
            List<Carmer.Carmer> list = new List<Carmer.Carmer>();
            if (configXml == null) {
                configXml = new XmlDocument();
                configXml.Load("device.xml");
            }
            //XmlNode xmlnode = xmlDoc.SelectNodes("devices");
            XmlNodeList xnl = configXml.GetElementsByTagName("device");
            foreach (XmlNode xnf in xnl)
            {
                Carmer.Carmer carmer = new Carmer.Carmer();
                carmer.CarmerName = xnf.ChildNodes[0].InnerText;
                carmer.CarmerUrl = xnf.ChildNodes[1].InnerText;
                list.Add(carmer);
            }
            return list; 
        }


    }
}
