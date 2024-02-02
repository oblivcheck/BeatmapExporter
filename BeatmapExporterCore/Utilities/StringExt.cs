﻿namespace BeatmapExporterCore.Utilities
{
    public static class StringExt
    {
        public static string Trunc(this string str, int len) => string.IsNullOrEmpty(str) ? str : str.Length <= len ? str : str[..len];

        public static string RemoveFilenameCharacters(this string str) => str
            .Replace("\"", "")
            .Replace("*", "")
            .Replace("<", "")
            .Replace(">", "")
            .Replace(":", "")
            .Replace("/", "")
            .Replace("\\", "")
            .Replace("|", "")
            .Replace("?", "");

        public static string[] CommaSeparatedArg(this string str) => str.Split(",").Select(s => s.Trim()).ToArray();
    }
}
