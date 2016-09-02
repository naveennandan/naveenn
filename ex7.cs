using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class floats
{
    float x;
    public floats()
    {
    }

    public floats(float x)
    {
        this.x = x;
    }
    public static floats operator +(floats f1, floats f2)
    {
        floats f3 = new floats();
        f3.x = f1.x + f2.x;
        return f3;
    }
    public static floats operator -(floats f1, floats f2)
    {
        floats f3 = new floats();
        f3.x = f1.x - f2.x;
        return f3;
    }
    public static floats operator *(floats f1, floats f2)
    {
        floats f3 = new floats();
        f3.x = f1.x * f2.x;
        return f3;
    }
    public static floats operator /(floats f1, floats f2)
    {
        floats f3 = new floats();
        f3.x = f1.x / f2.x;
        return f3;
    }
    public override string ToString()
    {
        return ("("+x+")");
    }
}
    class main
    {
        public static void Main()
        {
            floats m1=new floats(10.0f);
            floats m2=new floats(20.0f);
            floats l,m,n,o;
            l=m1+m2;
            m=m1-m2;
            n=m1*m2;
            o=m1/m2;
            Console.WriteLine("Addition="+l);
            Console.WriteLine("subraction="+m);
            Console.WriteLine("multiplication="+n);
            Console.WriteLine("divison="+o);
            Console.ReadKey();
        }
    }