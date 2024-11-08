using System.Windows;
using System.Windows.Controls;

namespace LibraSys.Utilities
{
    class Btn : RadioButton
    {
        static Btn()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Btn), new FrameworkPropertyMetadata(typeof(Btn)));
        }
    }
}
