namespace Lab3.Classes
{
    public class Typeofwork : BaseModel
    {
        public string Order_number { get;  set; }
        public string Job_line_number { get;  set; }
        public string Value { get;  set; }

        public Guid WorkcatalogId { get;  set; }

        public virtual Workcatalog workcatalog { get; set; }

    }
}

