using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class TextReader
{
    public static List<string> Descriptions(string file) {
        List<string> list = new List<string>();
        TextAsset data = Resources.Load (file) as TextAsset;
        var lines = Regex.Split (data.text, @"\r\n|\n\r|\n|\r");

        for(var i=0; i < lines.Length; i++){
            list.Add(lines[i]);
        }

        return list;
    }
}
