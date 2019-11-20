using System.Linq;
using System.Xml.Linq;
using ABMTestXML.Entities;

namespace ABMTestXML
{
    public class ReadXML
    {
        private string _pathXML;
        private XDocument doc;
        
        public ReadXML(string pathXML)
        {
            _pathXML = pathXML;
        }

        public bool Read()
        {
            try
            {
                doc = XDocument.Load(_pathXML);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetReference(string refCode)
        {
            var References = doc.Descendants("Reference");
            var result = References
                .Where(reference => reference.FirstAttribute.Value.Equals(refCode))
                .Select(reference => reference.Value);
            return result.FirstOrDefault();
        }
    }
}