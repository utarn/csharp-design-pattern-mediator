using System;

namespace pattern_mediator
{
    public class ArticleDialogBox
    {
        private ListBox _articleListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;
        public ArticleDialogBox()
        {
            _articleListBox = new ListBox();
            _articleListBox.AddEventHandler(articleChanged);
            // _articleListBox.AddEventHandler(() =>
            // {

            // });
            _titleTextBox = new TextBox();
            _titleTextBox.AddEventHandler(titleChanged);
            _saveButton = new Button();
        }

        public void SimulateChanges()
        {
            _articleListBox.Selection = "Article 1";
            // _titleTextBox.Text = "";
            Console.WriteLine("Listbox : " + _articleListBox.Selection);
            Console.WriteLine("Textbox : " + _titleTextBox.Text);
            Console.WriteLine("Button : " + _saveButton.IsEnabled);
        }

        // public override void OnChanged(UIControl control)
        // {
        //     if (control == _articleListBox)
        //     {
        //         articleChanged();
        //     }
        //     else if (control == _titleTextBox)
        //     {
        //         titleChanged();
        //     }

        // }

        private void articleChanged()
        {
            _titleTextBox.Text = _articleListBox.Selection;
            _saveButton.IsEnabled = true;
        }

        private void titleChanged()
        {
            var content = _titleTextBox.Text;
            var isEmpty = string.IsNullOrEmpty(content);
            _saveButton.IsEnabled = !isEmpty;
        }
    }
}