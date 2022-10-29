using System;

internal class License : AppLicenseMethods
{
    Random random = new Random();
     
    public enum AccessLevel
    {
        Pro,
        Trial,
        Common
    }

    private string key;
    private AccessLevel currentAccess;

    public License(string key)
    {
        this.key = key;
    }

    public void Print()
    {
        switch (key)
        {
            case "1":
                currentAccess = AccessLevel.Trial;
                AllowTrial();
                break;
            case "2":
                currentAccess = AccessLevel.Pro;
                AllowPro();
                break;
            case "3":
                currentAccess = AccessLevel.Common;
                AllowCommon();
                break;
            case " ":
                currentAccess = AccessLevel.Common;
                AllowCommon();
                break;
        }

    }
}
