namespace KB9905_IgbGridRowColors_BlazorServerApp1.Data;

public class Person
{
    public int ID { get; set; }
    public String FamilyName { get; set; } = String.Empty;
    public String GivenName { get; set; } = String.Empty;
    public String Prefecture { get; set; } = String.Empty;
    public String City { get; set; } = String.Empty;

    public Person()
    {
    }
}
