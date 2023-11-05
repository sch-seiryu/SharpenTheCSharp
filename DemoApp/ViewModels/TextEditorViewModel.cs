using System.Collections.Generic;
using System.Collections.ObjectModel;
using DemoApp.Models;

namespace DemoApp.ViewModels
{
    public class TextEditorViewModel : ViewModelBase
    {
        public TextEditorViewModel(IEnumerable<TextItem>? texts)
        {
            if (texts != null)
            {
                Texts = new ObservableCollection<TextItem>(texts);
            }
            else
            {
                // Texts = new ObservableCollection<TextItem>(new TextItem {TextLiteral = ""});
                Texts = null;
            }
            SampleMode = true;
            EditorMode = false;
        }
        
        public ObservableCollection<TextItem> Texts { get; }
        public bool SampleMode { get; set; }
        public bool EditorMode { get; set; }
    }
}