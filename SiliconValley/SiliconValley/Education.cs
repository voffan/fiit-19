using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconValley
{
    public enum Education
    {
        [Description("Высшее")]
        Higher,
        [Description("Среднее")]
        Secondary,
        [Description("Без образования")]
        None
    }
}
