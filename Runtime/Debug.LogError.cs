using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Iterum.Logs
{
    public static partial class Log
    {


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [HideInCallstack]
        public static void Error(string group, string e) => Send(Level.Error, group, e, ConsoleColor.DarkRed);

        #region Overloads

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [HideInCallstack]
        public static void Exception(string group, Exception e) => Send(Level.Exception, group, e.ToString(), ConsoleColor.Red);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [HideInCallstack]
        public static void Exception(Exception e) => Send(Level.Exception, null, e.ToString(), ConsoleColor.Red);

        [MethodImpl(MethodImplOptions.AggressiveInlining)][HideInCallstack] public static void Error(string group, object e) => Error(group, e.ToString());
        [MethodImpl(MethodImplOptions.AggressiveInlining)][HideInCallstack] public static void Error(string group, double e) => Error(group, e.ToString("F2"));
        [MethodImpl(MethodImplOptions.AggressiveInlining)][HideInCallstack] public static void Error(string group, float e) => Error(group, e.ToString("F2"));
        [MethodImpl(MethodImplOptions.AggressiveInlining)][HideInCallstack] public static void Error(string group, long e) => Error(group, e.ToString());
        [MethodImpl(MethodImplOptions.AggressiveInlining)][HideInCallstack] public static void Error(string group, int e) => Error(group, e.ToString());

        #endregion
    }
}
