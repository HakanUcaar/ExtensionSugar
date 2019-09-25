﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionSugar
{
    public static class GenericExtSugars
    {
        public static bool IsNull<T>(this T obj) 
        {
            return obj == null;
        }
        public static bool IsNotNull<T>(this T obj) 
        {
            return obj != null;
        }
        public static T With<T>(this T item, Action<T> action)
        {
            if (item.IsNotNull())
            {
                action(item);
            }
            return item;
        }

        public static bool In<T>(this T obj, params T[] args)
        {
            return args.Contains(obj);
        }
        public static bool In<T>(this T obj, String[] args)
        {
            return Array.IndexOf(args, obj) > -1;
        }
        public static bool In<T>(this T obj, IEnumerable<T> args)
        {
            return args.Contains(obj);
        }
        public static bool In<T>(this T obj, List<T> args)
        {
            return args.Contains(obj);
        }

        public static T ReturnSelf<T>(this T Input, Func<T, bool> check, T failureValue)
            where T : class
        {
            if (Input.IsNull()) return failureValue;
            try
            {
                return check(Input) ? Input : failureValue;
            }
            catch (Exception e)
            {
                return failureValue;
            }
        }
    }
}
