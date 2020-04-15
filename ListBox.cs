namespace pattern_mediator
{
    public class ListBox
    {
        private string _selection;
        public string Selection
        {
            get
            {
                return _selection;
            }
            set
            {
                _selection = value;
            }
        }
    }
}