using System;

namespace builer_pattern
{
    public class XmlBuilder : DocumentBuilder
    {
        // Constructor
        public XmlBuilder()
        {
            document = new Document("XML");
        }

        // Build header
        public override void BuildHeader()
        {
            document["header"] = "<!xml version='1.0' encoding='UTF-8'?>\n<Header> This is sample HTML header </Header>";
        }
        
        // Build body
        public override void BuildBody()
        {
            document["body"] = "<Body>This is sample HTML body</Body>";
        }
        
        // Build footer
        public override void BuildFooter()
        {
            document["footer"] = "<Footer> This is sample HTML footer </Footer>";
        }
    }
}