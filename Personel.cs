public class Personel:BaseClass
{

    public int Id { get; set; }
    public string Ad { get; set; }


    public Personel(int id, string name)
    {
        this.Id = id;
        this.Ad = name;
    }
}