using System;

internal class AppLicenseMethods
{
    virtual public void AllowPro()
    {
        Console.WriteLine("Платна версія");
    }
    virtual public void AllowTrial()
    {
        Console.WriteLine("Триальниий режиим");
    }

    virtual public void AllowCommon()
    {
        Console.WriteLine("Безкоштовна версія");
    }
}
