// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2024-09-07
// ************************************************************************
// <copyright file="InnerExtensions.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>扩展方法</summary>
// ************************************************************************
global using FeishuNetSdk.Extensions;
using System.Text.RegularExpressions;

namespace FeishuNetSdk.Extensions
{
    internal static partial class InnerExtensions
    {
        /// <summary>
        /// 合并两个字典，并覆盖相同键名的值
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="to"></param>
        /// <param name="from"></param>
        public static void Merge<TKey, TValue>(this IDictionary<TKey, TValue> to, IDictionary<TKey, TValue>? from)
        {
            ArgumentNullException.ThrowIfNull(to);
            if (from is null) return;
            foreach (var kv in from)
            {
                if (to.ContainsKey(kv.Key))
                {
                    to[kv.Key] = kv.Value;
                }
                else
                {
                    to.Add(kv.Key, kv.Value);
                }
            }
        }

        /// <summary>
        /// 是否为类型<paramref name="parentType"/>的子类或自身
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parentType">父类</param>
        /// <returns></returns>
        public static bool IsSubTypeOrEqualsOf(this Type type, Type parentType)
        {
            return parentType.IsAssignableFrom(type);
        }

        /// <summary>
        /// 判断给定的类型是否继承自<paramref name="genericType"/>泛型类型,
        /// <para>
        /// e.g.: typeof(Child&lt;&gt;).IsSubTypeOfGenericType(typeof(IParent&lt;&gt;));  result->true 
        /// </para>
        /// <para>
        /// e.g.: typeof(Child&lt;int&gt;).IsSubTypeOfGenericType(typeof(IParent&lt;&gt;));  result->true 
        /// </para>
        /// </summary>
        /// <param name="childType">子类型</param>
        /// <param name="genericType">泛型父级,例: typeof(IParent&lt;&gt;)</param>
        /// <returns></returns>
        public static bool IsSubTypeOfGenericType(this Type childType, Type genericType)
        {
            if (childType == genericType)
                return false;
            if (!genericType.IsGenericTypeDefinition)
                return false;
            var interfaceTypes = childType.GetTypeInfo().ImplementedInterfaces;

            foreach (var it in interfaceTypes)
            {
                if (it.IsGenericType && it.GetGenericTypeDefinition() == genericType)
                    return true;
            }

            if (childType.IsGenericType && childType.GetGenericTypeDefinition() == genericType)
                return true;

            var baseType = childType.BaseType;
            if (baseType is null) return false;

            return IsSubTypeOfGenericType(baseType, genericType);
        }

        /// <summary>
        /// 获取字典值,没有则返回默认值
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dic"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TValue? GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dic, TKey key)
        {
            if (key is null)
                return default;
            return dic.TryGetValue(key, out var value) ? value : default;
        }

        public static string FixDiscriminator(this string value, string propertyName = FeishuNetSdkOptions.Discriminator)
            => MatchEventV2Type().Match(value) is Match ma && ma.Success
                ? value.Insert(1, ma.Value)
                : MatchEventV1Type().Matches(value) is MatchCollection mb
                        && mb.FirstOrDefault(m => m.Groups[1].Value != "event_callback") is Match mc
                        && mc.Success
                    ? value.Insert(1, $"\"{propertyName}\":\"{mc.Groups[1].Value}\",")
                    : value;

        public static bool IsEncryptedObject(this string value, out string? encryptedString)
        {
            encryptedString = null;
            if (MatchEncryptedType().Match(value) is Match ma && ma.Success)
            {
                encryptedString = Regex.Unescape(ma.Groups[1].Value);
                return true;
            }
            return false;
        }

        [GeneratedRegex("\"event_type\"[: \t\n\r]+\"([^\"]+)\"[ \n\r\t]*,")]
        private static partial Regex MatchEventV2Type();

        [GeneratedRegex("\"type\"[: \t\n\r]+\"([^\"]+)\"")]
        private static partial Regex MatchEventV1Type();

        [GeneratedRegex("^\\{[^\"]*\"encrypt\"[: ]+\"([^\"]+)\"[^\"]*\\}$")]
        private static partial Regex MatchEncryptedType();
    }
}
