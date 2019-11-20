using System.Collections.Generic;

namespace ABMTestXML.Entities
{
    public class Document
    {
        public string Jurisdiction {get; set;}

        public List<Reference> References {get; set;}
    }
}