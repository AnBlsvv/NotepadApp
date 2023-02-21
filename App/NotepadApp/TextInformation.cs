using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadApp
{
	class TextInformation
	{
		public string _Label { get; set; }
		public string _LabelInfo { get; set; }

		public TextInformation(string _label, string _labelinfo)
		{
			_Label = _label;
			_LabelInfo = _labelinfo;
		}
	}
}
