using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace grendgine_collada
{
	[Serializable]
	[XmlType(AnonymousType=true)]
	public partial class Grendgine_Collada_Curves
	{
		
	    [XmlElement(ElementName = "curve")]
		public Grendgine_Collada_Curve[] Curve;		
		
	    [XmlElement(ElementName = "extra")]
		public Grendgine_Collada_Extra[] Extra;
	}
}

