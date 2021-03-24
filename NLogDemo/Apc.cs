namespace NLogDemo
{
    public class Apc : ItemBase
    {
        public string NameType{ get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(NameType)}={NameType}}}";
        }
    }
}