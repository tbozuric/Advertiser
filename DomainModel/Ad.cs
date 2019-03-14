namespace DomainModel
{
    public class Ad
    {
        private string _name;
        private string _content;


        public virtual int Id { get; set; }

        public virtual string Name
        {
            get => _name;
            set => _name = value;
        }

        protected Ad()
        {
        }

        public virtual string AdContent
        {
            get => _content;
            set => _content = value;
        }

        public Ad(string name, string content)
        {
            _name = name ?? throw new InvalidValueException("Name must not be empty!");
            _content = content ?? throw  new InvalidValueException("Content must not be empty!");
        }

        public override string ToString()
        {
            return _name + ", " + _content;
        }
    }
}