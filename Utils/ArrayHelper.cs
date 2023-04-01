using System;
using System.Collections.Generic;

public class ArrayHelper
{
    public List<int> getRange(List<int> source, int start, int length)
    {
        return source.GetRange(start, length);
    }
}