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
    public int priority { get; set; }

    public Keyword(string w, Categories c)
    {
        this.cat = c;
        this.word = w;
        this.priority = 0;
    }

    public Keyword(string w, Categories c, int p)
    {
        this.cat = c;
        this.word = w;
        this.priority = p;
    }

}

