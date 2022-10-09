using System;

namespace builer_pattern
{
  public abstract class DocumentBuilder
    {
        protected Document document;
        // Gets Document instance
        
        public Document Document
        {
            get { return document; }
        }
        
        // Abstract build methods
        public abstract void BuildHeader();
        public abstract void BuildBody();
        public abstract void BuildFooter();
    }
}