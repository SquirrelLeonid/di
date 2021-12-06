﻿using System.Collections.Generic;
using System.Linq;

namespace TagCloud.Words.Filtering
{
    public class WordsFilter : IFilter
    {
        public IEnumerable<string> FilterWords(IEnumerable<string> words)
        {
            return words.Where(word => word.Length > 3);
        }
    }
}