using System;

namespace builer_pattern
{
    public class HtmlBuilder : DocumentBuilder
    {
        // Constructor
        public HtmlBuilder()
        {
            document = new Document("HTML");
        }

        // Build header
        public override void BuildHeader()
        {
            document["header"] = "<!doctype html>\n<html lang='en'>\n<header> This is sample HTML header </header>";
        }
        
        // Build body
        public override void BuildBody()
        {
            document["body"] = "<body>This is sample HTML body</body>";
        }
        
        // Build footer
        public override void BuildFooter()
        {
            document["footer"] = "<footer> This is sample HTML footer </footer>";
        }
    }
}