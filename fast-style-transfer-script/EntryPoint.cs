/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using Sony.Vegas;
using System.Windows.Forms;

namespace fast_style_transfer_script
{
    public class EntryPoint
    {
        public void FromVegas(Vegas vegas)
        {
            fast_style_transfer_gui_form form = new fast_style_transfer_gui_form();
            form.Show();
        }
    }
}
