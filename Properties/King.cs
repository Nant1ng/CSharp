namespace Properties
{
    public class King
    {
        public King(string title)
        {
                Title = title;
        }

        private string? title;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = "King " + value;
            }
        }
    }
}
