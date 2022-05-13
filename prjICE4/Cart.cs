using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICE4
{
    class Cart
    {
        public DateTime warrenty;
        public double totalDelivery = 0;
        private double totalVAT = 0;
        private double total = 0;
        public int totalBB = 0;
        public int totalGrocery = 0;
        public double totalBBValue = 0;
        public double totalGroceryValue = 0;
        List<string> itemNames = new List<string>();
        List<double> itemPrices = new List<double>();
        List<double> itemVat = new List<double>();
        
        public void storeInCart(string itemName, double itemPrice, double vat)
        {
            itemNames.Add(itemName);
            itemPrices.Add(itemPrice);
            itemVat.Add(vat);
            totalVAT += vat;
            total += itemPrice;
        }
        public override string ToString()
        {
            string strOutput = "\n---------------------------------------------\n" +
                                "Warrenty of big box items expires on: " + warrenty +"\n" +
                                "---------------------------------------------\n";

            for (int x = 0; x < itemNames.Count; x++)
            {
                strOutput += itemNames[x] + "\t\tR" + itemPrices[x] + "\n";
            }
            strOutput += "-------------------------------------------\n";
            strOutput += "Total: R" + total + "\n+ VAT: R" + Math.Round(totalVAT, 2) + "\n"+
                            "\n+ Delivery Fee: R" + totalDelivery;
            strOutput += "\n-------------------------------------------\n";
            strOutput += "Grand Total: R" + Math.Round((total + totalVAT + totalDelivery), 2);
            strOutput += "\n-------------------------------------------";

            return strOutput;
        }
        public string ToString(int x)
        {
            string strOutput =  "\nMETRICS:\n--------------------------------------------\n" +
                                "Item Type: \tNumber sold: \tValue Sold: \n"+
                                "Big Box: \t" + totalBB + "\t\tR" + Math.Round(totalBBValue,2)+
                                "\nGrocery: \t" + totalGrocery + "\t\tR" + Math.Round(totalGroceryValue,2) +
                                "\n--------------------------------------------\n"+
                                "Grand Total: R" + Math.Round((totalBBValue + totalGroceryValue),2) +
                                "\n--------------------------------------------\n";
            return strOutput;
        }
    }
}
