using System;

namespace builer_pattern
{
    public class JsonBuilder : DocumentBuilder
    {
		// Constructor
        public JsonBuilder()
        {
            document = new Document("JSON");
        }

        // Build header
        public override void BuildHeader()
        {
            document["header"] = "'header':{\n\t 'This is sample JSON header'\n},";
        }
        
		// Build body
        public override void BuildBody()
        {
            document["body"] = "'body':{\n\t 'This is sample JSON body'\n},";
        }
        
		// Build footer
        public override void BuildFooter()
        {
            document["footer"] = "'footer':{\n\t 'This is sample JSON footer'\n}";
        }
    }
}