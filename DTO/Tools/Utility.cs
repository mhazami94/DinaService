using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DTO.Tools
{
    public static class Utility
    {
        public static string FixTextEditorOutput(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            input = Regex.Replace(input, @"<font.*?>", "").Trim();
            input = Regex.Replace(input, @"</font>", "").Trim();
            input = Regex.Replace(input, @"<b>", "<strong>").Trim();
            input = Regex.Replace(input, @"</b>", "</strong>").Trim();
            input = Regex.Replace(input, @"<br>", "").Trim();
            input = Regex.Replace(input, @"<br/>", "").Trim();
            input = Regex.Replace(input, @"<br />", "").Trim();
            input = Regex.Replace(input, @"<span[^>]*(?:\/>|>(?:\s|&nbsp;)*<\/span>)", "").Trim();
            input = Regex.Replace(input, @"<p.*?>", "<p>").Trim();
            input = Regex.Replace(input, @"<p>\s*</p>", "").Trim();
            input = Regex.Replace(input, @"<h1>", "<p>");
            input = Regex.Replace(input, @"</h1>", "</p>");
            input = Regex.Replace(input, @"<table.*?>", "<table>");
            input = Regex.Replace(input, @"<tbody.*?>", "<tbody>");
            input = Regex.Replace(input, @"<thead.*?>", "<thead>");
            input = Regex.Replace(input, @"<td.*?>", "<td>");
            input = Regex.Replace(input, @"<tr.*?>", "<tr>");


            return input;
        }
    }
}
