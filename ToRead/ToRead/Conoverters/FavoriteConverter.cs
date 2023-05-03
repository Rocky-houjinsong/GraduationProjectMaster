﻿namespace ToRead.Conoverters;

using System.Globalization;
using ToRead.Library.Misc;

/// <summary>
/// 收藏转化器
/// </summary>
/// <remarks>无需修改.</remarks>
public class FavoriteConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not bool b)
        {
            return null;
        }

        return b ? "已收藏" : "未收藏";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new DoNotCallThisException();
    }
}