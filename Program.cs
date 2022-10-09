using System;
using System.Collections.Generic;

namespace builer_pattern
{
    /// <summary>
    /// Program startup class for Real-World 
    /// Builder Design Pattern.
    /// </summary>
   class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            DocumentBuilder builder;
            // Create document_builder_shop with document builders
            DocBuilderShop doc_shop = new DocBuilderShop();
                        
            // Construct and display vehicles
            builder = new XmlBuilder();
            doc_shop.Construct(builder);
            builder.Document.Show();

            // Construct and display vehicles
            builder = new HtmlBuilder();
            doc_shop.Construct(builder);
            builder.Document.Show();
            
            // Construct and display vehicles
            builder = new JsonBuilder();
            doc_shop.Construct(builder);
            builder.Document.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
