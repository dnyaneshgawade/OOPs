using System;

namespace EnventoryManagement
{
    class Program
    {
        const string INVENTORY_JSON= @"C:\Users\dnyan\dnyana\EnventoryManagement\EnventoryManagementt\EnventoryManagement.json";
        static void Main(string[] args)
        {
            EnventoryMain enventoryMain = new EnventoryMain();
            enventoryMain.DisplayData(INVENTORY_JSON);
        }
    }
}
