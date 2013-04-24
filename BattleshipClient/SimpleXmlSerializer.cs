using System;
using System.Xml;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BattleshipClient
{
	public static class SimpleXmlSerializer
	{
	    public static string Serialize(object item)
	    {
	        MemoryStream memStream = new MemoryStream();
	        using (XmlTextWriter textWriter = new XmlTextWriter(memStream, Encoding.Unicode))
	        {
	            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(item.GetType());
	            serializer.Serialize(textWriter, item);
	
	            memStream = textWriter.BaseStream as MemoryStream;
	        }
	        if (memStream != null)
	            return Encoding.Unicode.GetString(memStream.ToArray());
	        else
	            throw new Exception("AJAJ.");
	    }
	
	    public static T Deserialize<T>(string xmlString)
	    {
			//MessageBox.Show(xmlString);

			using (MemoryStream memStream = new MemoryStream(Encoding.Unicode.GetBytes(xmlString)))
			{
			    System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
			    return (T)serializer.Deserialize(memStream);
			}
	    }
	}
}