using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCo.Forms
{
    public partial class Messages : UserControl
    {
        public static bool Error_Message()
        {
            if (MessageBox.Show(
                "Вы уверены, что хатите удалить этот элемент?",
                "Удаление",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                ) == DialogResult.OK)
                return true;
            else return false;
        }
    }
}
