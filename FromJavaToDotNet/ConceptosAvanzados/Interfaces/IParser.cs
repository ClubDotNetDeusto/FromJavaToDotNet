namespace FromJavaToDotNet.ConceptosAvanzados.Interfaces
{
    public interface IParser
    {
        string Descriptor { get; set; }

        string ContentReaded();
    }
}