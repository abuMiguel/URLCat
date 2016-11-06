using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enums;

public class Keyword
{
    public string word { get; }
    public Categories cat { get; }

    public Keyword(string w, Categories c)
    {
        this.cat = c;
        this.word = w;
    }

}

