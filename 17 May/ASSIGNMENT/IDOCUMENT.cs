public abstract class Document
{
    public abstract void PrintContent();

    public void ShowDocumentType(string type)
    {


        Console.WriteLine(" Document Type :" + type);
    }

}
public class WordDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing Word Document");
    }

}

public class PdfDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine(" printing pdf Document");
    }
}

class Program
{
    static void Main()
    {
        Document doc;

        doc = new WordDocument();

        doc.ShowDocumentType("word");
        doc.PrintContent();


        Console.WriteLine();


        doc = new PdfDocument();

        doc.ShowDocumentType("pdf");
        doc.PrintContent();
    }
}