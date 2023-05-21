using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendData2ndformMainform
{
    public class TextBoxState
    {
        private string _text;
        private int _caretPos;

        public TextBoxState(string text, int caretPos)
        {
            _text = text;
            _caretPos = caretPos;
        }

        public int CaretPosition
        {
            get { return _caretPos; }
            set { _caretPos = value; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
    }
}
