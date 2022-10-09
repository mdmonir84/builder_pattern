using System;
using System.Collections.Generic;

namespace builer_pattern
{
  public class Document
  {
      private string _DocumentType;
      private Dictionary<string, string> _elements = new Dictionary<string, string>();
      
      // Constructor
      public Document(string DocumentType)
      {
          this._DocumentType = DocumentType;
      }
      
      // Indexer
      public string this[string key]
      {
          get { return _elements[key]; }
          set { _elements[key] = value; }
      }
      
      // Method to print document
      public void Show()
      {
          Console.WriteLine("\n---------------------------");
          Console.WriteLine("Document Type: {0}", _DocumentType);
          Console.WriteLine(_elements["header"]);
          Console.WriteLine(_elements["body"]);
          Console.WriteLine(_elements["footer"]);
      }
  }
}