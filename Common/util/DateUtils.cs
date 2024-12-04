using System;
using System.Globalization;
using System.Reflection;

namespace JMWebAPI.Common.Util
{
    /// <summary>
    /// 日期工具类
    /// </summary>
    public static class DateUtils
    {
        /// <summary>
        /// 区间日期格式化为数据库日期格式
        /// <para>eg：2021-01-01 → 2021-01-01 00:00:00</para>
        /// </summary>
        /// <param name="obj">要处理的对象</param>
        /// <param name="startTimeFieldName">起始时间字段名</param>
        /// <param name="endTimeFieldName">结束时间字段名</param>
        public static void ToDatabaseFormat(object obj, string startTimeFieldName, string endTimeFieldName)
        {
            var startTimeField = obj.GetType().GetProperty(startTimeFieldName);
            var endTimeField = obj.GetType().GetProperty(endTimeFieldName);

            if (startTimeField != null)
            {
                ProcessDateTimeField(obj, startTimeField, "yyyy-MM-dd 00:00:00");
            }

            if (endTimeField != null)
            {
                ProcessDateTimeField(obj, endTimeField, "yyyy-MM-dd 23:59:59");
            }
        }

        /// <summary>
        /// 处理日期字段
        /// </summary>
        /// <param name="obj">要处理的对象</param>
        /// <param name="field">字段</param>
        /// <param name="targetPattern">目标数据库日期格式</param>
        private static void ProcessDateTimeField(object obj, PropertyInfo field, string targetPattern)
        {
            var fieldValue = field.GetValue(obj);
            if (fieldValue != null)
            {
                string pattern = "yyyy-MM-dd";
                var dateTimeFormatAttr = field.GetCustomAttribute<DateTimeFormatAttribute>();
                if (dateTimeFormatAttr != null)
                {
                    pattern = dateTimeFormatAttr.Pattern;
                }

                if (DateTime.TryParseExact(fieldValue.ToString(), pattern, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
                {
                    field.SetValue(obj, dateTime.ToString(targetPattern));
                }
            }
        }
    }

    /// <summary>
    /// 日期格式化属性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DateTimeFormatAttribute : Attribute
    {
        public string Pattern { get; }

        public DateTimeFormatAttribute(string pattern)
        {
            Pattern = pattern;
        }
    }
}
