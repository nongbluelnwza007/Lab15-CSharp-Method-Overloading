using System;

class Program
{
    static void Main()
    {
        Derived_2 d2 = new Derived_2();
        Base b = (Base) d2;
        Derived_1 d1 = (Derived_1) d2;

        b.A(); // Calls Base.A() or Derived_1.A() depending on the object type
        d1.A(); // Calls Derived_1.A()
        d2.A(); // Calls Derived_2.A()
    }
}

class Base
{
    public virtual void A()
    {
        Console.WriteLine("Base.A()");
    }
}

class Derived_1 : Base
{
    public override void A() // Removed the 'sealed' modifier
    {
        Console.WriteLine("Derived_1.A()");
    }
}

class Derived_2 : Derived_1
{
    public override void A()  // Now this is valid since Derived_1.A() is not sealed anymore
    {
        Console.WriteLine("Derived_2.A()");
    }
}
