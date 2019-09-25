# ExtensionSugar
Yardımcı Küçük Kod Parçaları

## Kullanışlı Örnekler
### In , SplitTo:
```Csharp
using System;
using ExtensionSugar;

namespace BosKonsolUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            SplitToExample();
            Console.ReadLine();
        }

        static void SplitToExample()
        {
            string ListB = "3,5,7";

            for (int i = 1; i < 10; i++)
            {
                if (i.ToString().In(ListB.SplitTo<string>(',')))
                {
                    Console.WriteLine("Değer Bulundu. Değer : " + i.ToString());
                }
            }
        }
    }
}
```
### With :
```Csharp
using System;
using ExtensionSugar;

namespace BosKonsolUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            WithExample();
            Console.ReadLine();
        }

        static void WithExample()
        {
            new TestClass()
            .With(tsc =>
            {
                tsc.Prop1 = "Hakan UÇAR";
                tsc.Prop2 = DateTime.Now;
                tsc.Prop3 = 12;
                tsc.Prop4 = true;

                Console.WriteLine(tsc);
                Console.WriteLine(tsc.Prop1);
                Console.WriteLine(tsc.Prop2);
                Console.WriteLine(tsc.Prop3);
                Console.WriteLine(tsc.Prop4);
            });
        }
    }

    class TestClass
    {
        public string Prop1 { get; set; }
        public DateTime Prop2 { get; set; }
        public double Prop3 { get; set; }
        public bool Prop4 { get; set; }
    }
}
```
### ReturnSelf:
```CSharp
using System;
using ExtensionSugar;

namespace BosKonsolUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnSelfExample();
            Console.ReadLine();
        }

        static void ReturnSelfExample()
        {
            var A = "hakan uçar";
            Console.WriteLine(
                    A.ReturnSelf(o => !o.IsNullOrEmpty(), "Öle bişi yok")
                );
        }
    }
}

```

## Generic Extensions
        public static bool In<T>(this T obj, params T[] args);
        public static bool In<T>(this T obj, string[] args);
        public static bool In<T>(this T obj, IEnumerable<T> args);
        public static bool In<T>(this T obj, List<T> args);
        public static bool IsNotNull<T>(this T obj);
        public static bool IsNull<T>(this T obj);
        public static T ReturnSelf<T>(this T Input, Func<T, bool> check, T failureValue) where T : class;
        public static T With<T>(this T item, Action<T> action);
        
## String Extensions
        public static string AppendPrefixIfMissing(this string val, string prefix, bool ignoreCase = true);
        public static string AppendSuffixIfMissing(this string val, string suffix, bool ignoreCase = true);
        public static string Capitalize(this string s);
        public static int CountOccurrences(this string val, string stringToMatch);
        public static string CreateHashSha256(string val);
        public static string CreateHashSha512(string val);
        public static string Decrypt(this string stringToDecrypt, string key);
        public static bool DoesNotEndWith(this string val, string suffix);
        public static bool DoesNotStartWith(this string val, string prefix);
        public static string DoubleQuotes(this string text);
        public static string Encrypt(this string stringToEncrypt, string key);
        public static bool EndsWithIgnoreCase(this string val, string suffix);
        public static string FirstCharacter(this string val);
        public static string Format(this string value, object arg0);
        public static string Format(this string value, params object[] args);
        public static int GetByteSize(this string val, Encoding encoding);
        public static string GetDefaultIfEmpty(this string myValue, string defaultValue);
        public static string GetEmptyStringIfNull(this string val);
        public static int? GetLength(string val);
        public static string GetNullIfEmptyString(this string myValue);
        public static T IfDefault<T>(this string s, T Result);
        public static bool IsAlpha(this string val);
        public static bool IsAlphaNumeric(this string val);
        public static bool IsDateTime(this string data, string dateFormat);
        public static bool IsEmailAddress(this string email);
        public static bool IsInteger(this string val);
        public static bool IsLength(this string val, int minCharLength, int maxCharLength);
        public static bool IsMaxLength(this string val, int maxCharLength);
        public static bool IsMinLength(this string val, int minCharLength);
        public static bool IsNull(this string val);
        public static bool IsNullOrEmpty(this string val);
        public static bool IsNumeric(this string val);
        public static bool IsValidIPv4(this string val);
        public static string LastCharacter(this string val);
        public static string Left(this string val, int length);
        public static string ParseStringToCsv(this string val);
        public static IDictionary<string, string> QueryStringToDictionary(this string queryString);
        public static string Quotes(this string text);
        public static string RemoveChars(this string s, params char[] chars);
        public static string RemovePrefix(this string val, string prefix, bool ignoreCase = true);
        public static string RemoveSuffix(this string val, string suffix, bool ignoreCase = true);
        public static string Replace(this string s, params char[] chars);
        public static string ReplaceLineFeeds(this string val);
        public static string Reverse(this string val);
        public static string ReverseSlash(this string val, int direction);
        public static string Right(this string val, int length);
        public static IEnumerable<T> SplitTo<T>(this string str, string[] separator) where T : IConvertible;
        public static IEnumerable<T> SplitTo<T>(this string str, params char[] separator) where T : IConvertible;
        public static IEnumerable<T> SplitTo<T>(this string str, StringSplitOptions options, params char[] separator) where T : IConvertible;
        public static bool StartsWithIgnoreCase(this string val, string prefix);
        public static string SurroundWith(this string text, string ends);
        public static bool ToBoolean(this string value);
        public static byte[] ToBytes(this string val);
        public static DateTime ToDateTime(this string s, string format = "ddMMyyyy", string cultureString = "tr-TR");
        public static DateTime ToDateTime(this string s, string format, CultureInfo culture);
        public static decimal ToDecimal(this string value);
        public static T ToEnum<T>(this string value, T defaultValue = default(T)) where T : struct;
        public static short ToInt16(this string value);
        public static int ToInt32(this string value);
        public static long ToInt64(this string value);
        [IteratorStateMachine(typeof(<ToTextElements>d__46))]
        public static IEnumerable<string> ToTextElements(this string val);
        public static string Truncate(this string s, int maxLength);

## Attribute Extensions
        public static TValue GetAttributeValue<TAttribute, TValue>(this Type type, Func<TAttribute, TValue> valueSelector) where TAttribute : Attribute;
        public static TValue GetPropAttributeValue<TAttribute, TValue>(this Type type, string MemberName, Func<TAttribute, TValue> valueSelector, bool inherit = false) where TAttribute : Attribute;
       
## Type Extensions
        public static object ChangeStrType(this string aText, Type aType);
        public static object GetDefaultValue(this Type t);
        public static bool IsDateTime(this Type aType);
        public static bool IsDouble(this Type aType);
        public static bool IsInt(this Type aType);
        public static object ToDefault(this Type targetType);
  
