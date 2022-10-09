using System;

namespace builer_pattern
{
  public class DocBuilderShop
  {
    // Builder uses a complex series of steps
      public void Construct(DocumentBuilder documentBuilder)
      {
        documentBuilder.BuildHeader();
        documentBuilder.BuildBody();
        documentBuilder.BuildFooter();
      }
  }
}