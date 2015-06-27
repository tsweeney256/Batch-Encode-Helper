using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bench
{
    class SharedEvents
    {
        static public void DragDropTextBox(object sender, DragEventArgs e)
        {
            ((TextBox)sender).Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        static public void DragEnterSingleFile(object sender, DragEventArgs e, string extension)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (paths.Length == 1 && Path.GetExtension(paths[0]) == extension && !Directory.Exists(paths[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
