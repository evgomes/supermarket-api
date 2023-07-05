using System.ComponentModel;

namespace Supermarket.API.Extensions
{
    public static class EnumExtensions
    {
        public static string ToDescriptionString<TEnum>(this TEnum? value) where TEnum : Enum
        {
            if(value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            var valueAsString = value.ToString();
            var valueType = value.GetType();
            var fieldInfo = valueType.GetField(valueAsString)!;
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes?[0].Description ?? valueAsString;
        }
    }
}