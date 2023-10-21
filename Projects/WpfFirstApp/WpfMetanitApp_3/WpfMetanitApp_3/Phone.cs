namespace WpfMetanitApp_3
{
    public class Phone
    {
        public string Name { get; set; } = "iPhone";
        public int Price { get; set; } = 500;

        public override string ToString()
        {
            return $"Смартфон {Name}; цена: {Price}";
        }
    }
}
