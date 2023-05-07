using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace Omms.Client.Utils.Xaml.Converters;

internal class ColorCodeRichTextBlockConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is string text)
        {
            var richTextBlock = new RichTextBlock();
            ColorCodeLanguage.Formatter.FormatRichTextBlock(text, new ColorCodeLanguage(), richTextBlock);

            return richTextBlock;
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
