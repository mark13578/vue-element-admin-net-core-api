//namespace JMWebAPI.Common.Base
//{
//    public interface IBaseEnum
//    {
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;

namespace JMWebAPI.Common.Base
{
    /// <summary>
    /// 枚举通用接口
    /// </summary>
    /// <typeparam name="T">枚举的类型</typeparam>
    public interface IBaseEnum<T>
    {
        T GetValue();
        string GetLabel();

        /// <summary>
        /// 根据值获取枚举
        /// </summary>
        /// <typeparam name="E">枚举类型</typeparam>
        /// <param name="value">值</param>
        /// <returns>枚举</returns>
        static E GetEnumByValue<E>(object value) where E : Enum, IBaseEnum<T>
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            return Enum.GetValues(typeof(E)).Cast<E>().FirstOrDefault(e => EqualityComparer<T>.Default.Equals(e.GetValue(), (T)value));
        }

        /// <summary>
        /// 根据值获取文本标签
        /// </summary>
        /// <typeparam name="E">枚举类型</typeparam>
        /// <param name="value">值</param>
        /// <returns>文本标签</returns>
        static string GetLabelByValue<E>(object value) where E : Enum, IBaseEnum<T>
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            var matchEnum = Enum.GetValues(typeof(E)).Cast<E>().FirstOrDefault(e => EqualityComparer<T>.Default.Equals(e.GetValue(), (T)value));
            return matchEnum?.GetLabel();
        }

        /// <summary>
        /// 根据文本标签获取值
        /// </summary>
        /// <typeparam name="E">枚举类型</typeparam>
        /// <param name="label">文本标签</param>
        /// <returns>值</returns>
        static T GetValueByLabel<E>(string label) where E : Enum, IBaseEnum<T>
        {
            if (label == null) throw new ArgumentNullException(nameof(label));
            var matchEnum = Enum.GetValues(typeof(E)).Cast<E>().FirstOrDefault(e => e.GetLabel() == label);
            return matchEnum != null ? matchEnum.GetValue() : default;
        }
    }
}
