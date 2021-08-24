using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Games.Common.Extensions
{
    public static class CommonExtensions
    {
        /// <summary>
        /// Compare two instances of the same type by property values
        /// </summary>
        /// <typeparam name="T">Source type</typeparam>
        /// <param name="source">Source (instance) to compare </param>
        /// <param name="dest">Destination (instance) to compare </param>
        /// <param name="ignoredProperties">Linq expression of the ignored SOURCE properties,i.e: src => src.MyProperty1,src => src.MyProperty2 ...</param>
        /// <returns></returns>
        public static bool IsEqualTo<T>(this T source, T dest, params Expression<Func<T, object>>[] ignoredProperties) where T : class
        {
            var returnValue = true;
            if (dest == default(T))
            {
                returnValue = false;

            }
            else
            {
                var sourceProperties = new List<PropertyInfo>(typeof(T).GetProperties());
                var ignoredPropertyNames = new List<string>();
                foreach (var propertyExpression in ignoredProperties)
                {
                    ignoredPropertyNames.Add(propertyExpression.GetPropertyName());
                }
                if (ignoredProperties != null)
                {
                    sourceProperties = (from p in sourceProperties where !ignoredPropertyNames.Contains(p.Name) select p).ToList();

                }
                for (var i = 0; i < sourceProperties.Count; i++)
                {
                    var property = sourceProperties[i];
                    var sourceValue = property.GetValue(source);
                    var destValue = property.GetValue(dest);
                    if (!Equals(sourceValue, destValue))
                    {
                        returnValue = false;
                        break;
                    }

                }

            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyExpession"></param>
        /// <returns></returns>
        /// <exception cref="System.InvalidOperationException" ></exception>
        public static string GetPropertyName<T>(this Expression<Func<T, object>> propertyExpession)
        {
            LambdaExpression lambda = propertyExpession;
            MemberExpression memberExpression;

            if (!(lambda.Body is UnaryExpression))
            {
                memberExpression = (MemberExpression)(lambda.Body);
            }
            else
            {
                UnaryExpression unaryExpression = (UnaryExpression)(lambda.Body);
                //if (!(unaryExpression.Operand is MemberExpression))
                if (!typeof(MemberExpression).IsAssignableFrom(unaryExpression.Operand.GetType()))
                {
                    throw (new InvalidOperationException(string.Format("Invalid operand:{0}", unaryExpression.Operand.ToString())));
                }
                memberExpression = (MemberExpression)(unaryExpression.Operand);
            }

            return ((PropertyInfo)memberExpression.Member).Name;
        }

        public static void AddKeyValue(this IDictionary<string, string> source, string key, string value)
        {
            if (string.IsNullOrEmpty(key))
            {
                return;
            }
            if (source.ContainsKey(key) && !source[key].Split(", ").Contains(value))
            {
                value = $"{ source[key] }, { value }";
                source.Remove(key);
            }
            source.Add(key, value);
        }

        public static string GetScriptSanitized(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            Regex reScriptRemoval = new Regex(@"<script[^>]*>[\s\S]*?</script>");
            return reScriptRemoval.Replace(str, "").Replace("javascript:", "");
        }

        public static string GetDescription(this Enum @enum)
        {
            var attr = @enum.GetType().GetMember(@enum.ToString()).FirstOrDefault()?.GetCustomAttributes(typeof(DescriptionAttribute), true)[0] as DescriptionAttribute;
            return attr?.Description;
        }

        public static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, string sortDir = "asc")
        {
            sortDir = sortDir.ToLower();
            var mi = sortDir == "asc" ? GetMethodInfo(Queryable.OrderBy, source, keySelector)
                                      : GetMethodInfo(Queryable.OrderByDescending, source, keySelector);
            return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>( 
                Expression.Call(null, mi, new Expression[] { source.Expression, Expression.Quote(keySelector) })
            );
        }

        private static MethodInfo GetMethodInfo<T1, T2, T3>(Func<T1, T2, T3> f, T1 unused1, T2 unused2) {
            return f.Method;
        }
    }
}