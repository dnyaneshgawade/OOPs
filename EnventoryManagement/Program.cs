using System;

namespace EnventoryManagement
{
    class Program
    {
        const string INVENTORY_JSON= @"C:\Users\dnyan\dnyana\OOPs\EnventoryManagement\EnventoryManagementt\EnventoryManagement.json";
        static void Main(string[] args)
        {
            InventoryMain enventoryMain = new InventoryMain();
            enventoryMain.CRUD(INVENTORY_JSON);
            //enventoryMain.DisplayData(INVENTORY_JSON);
            //enventoryMain.UpdateData(INVENTORY_JSON);
            //enventoryMain.RemoveData(INVENTORY_JSON);

        }
    }
}
