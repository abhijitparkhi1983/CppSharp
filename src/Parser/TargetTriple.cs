﻿using System.Linq;

namespace CppSharp.Parser
{
    // over time we should turn this into a real class
    // like http://llvm.org/docs/doxygen/html/classllvm_1_1Triple.html
    public static class TargetTriple
    {
        public static bool IsWindows(string targetTriple)
        {
            var parts = targetTriple.Split('-');
            return parts.Contains("windows") ||
                parts.Contains("win32") || parts.Contains("win64");
        }

        public static bool IsMacOS(string targetTriple)
        {
            var parts = targetTriple.Split('-');
            return parts.Contains("apple") ||
                parts.Contains("darwin") || parts.Contains("osx");
        }
    }
    
    public static class TargetTriple1
    {
        public static bool IsWindows(string targetTriple)
        {
            var parts = targetTriple.Split('-');
            return parts.Contains("windows") ||
                parts.Contains("win32") || parts.Contains("win64");
        }

        public static bool IsMacOS(string targetTriple)
        {
            var parts = targetTriple.Split('-');
            return parts.Contains("apple") ||
                parts.Contains("darwin") || parts.Contains("osx");
        }
    }
}