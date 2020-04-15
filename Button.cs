namespace pattern_mediator
{
    public class Button : UIControl
    {
        private bool _isEnabled;

        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }
            set
            {
                _isEnabled = value;
                NotifyEventHandlers();
            }
        }
    }
}