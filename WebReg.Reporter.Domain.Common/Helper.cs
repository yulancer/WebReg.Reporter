using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace WebReg.Reporter.Domain.Common
{
    public static class Helper
    {
        /// <summary>
        /// описание Enum из атрибута DisplayAttribute, если он есть.
        /// </summary>
        /// <param name="en">значение Enum</param>
        /// <returns>описание.</returns>
        public static string GetEnumDisplayDescription(this Enum en)
        {
            var ca = en.GetCustomAttribute<DisplayAttribute>();
            string name = ca?.Description ?? en.ToString();
            return name;
        }

        private static TAttribute? GetCustomAttribute<TAttribute>(this Enum enumValue)
            where TAttribute : Attribute
        {
            return enumValue.GetType().GetMember(enumValue.ToString()).First().GetCustomAttribute<TAttribute>();
        }

    }
}