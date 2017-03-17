using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WSArchiver.GUI.UserControls
{
    public enum Language
    {
        ARABIC = 0,
        ENGLISH = 1
    }
    interface IMultiLingualControl
    {
        Language ControlLanguage
        {
            set;
            get;
        }
    }
}
