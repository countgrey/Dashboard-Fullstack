namespace Dashboard_Fullstack.Server
{
    public class Dashboard
    {
        public string Name { get; set; }
        public string Organization { get; set; }
        public int Id { get; set; }
        public Widget[] Widgets { get; set; }
    }

    public class Widget
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public Element[] Elements { get; set; }
        public int Id { get; set; }
    }

    public class Element
    {
        public int Id { get; set; }
        public bool Private { get; set; }
        public ElementType ElementType { get; set; }
        public Data Data { get; set; }
    }

    public enum ElementType
    {
        None,
        Text,
        Chart,
        Table,
        Image,
        Dropdown,
        Checkbox,
        Radio,
        CustomHTML
    }

    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, int> Values { get; set; }
    }
}
