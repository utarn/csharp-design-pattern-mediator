namespace pattern_mediator
{
    public class TextBox : UIControl
    {
        private string _text;
        // Not mediator pattern, bad habit
        // private Button _saveButton;
        // public TextBox(Button saveButton) {
        //     _saveButton = saveButton;
        // }
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                NotifyEventHandlers();
            }
        }
    }
}