using System;
using System.IO;
using System.Text;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Diagnostics;
using Sony.Vegas;
using System.Windows.Forms;

namespace fast_style_transfer_script
{
    public class EntryPoint
    {
        Vegas vegas;
        public void FromVegas(Vegas _vegas)
        {
            vegas = _vegas;
            fast_style_transfer_gui_form form = new fast_style_transfer_gui_form(_vegas);
            form.Show();
        }
    }
}
