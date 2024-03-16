using System;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int overallTotalSales = 0;
            int overallRetailSales = 0;
            int overallCorporateSales = 0;

            for (int month = 4; month <= 9; month++)
            {
                int daysInMonth = DateTime.DaysInMonth(2024, month);
                int totalSalesMonth = 0;
                int retailSalesMonth = 0;
                int corporateSalesMonth = 0;

                for (int day = 1; day <= daysInMonth; day++)
                {
                    int vehiclesSold = VehiclesSold(day);

                    if (day % 5 != 0)
                    {
                        totalSalesMonth += vehiclesSold;
                        overallTotalSales += vehiclesSold;
                        retailSalesMonth += vehiclesSold;
                        overallRetailSales += vehiclesSold;
                    }
                    else
                    {
                        totalSalesMonth += vehiclesSold;
                        corporateSalesMonth += vehiclesSold;
                        overallCorporateSales += vehiclesSold;
                    }
                }

                Console.WriteLine($"Month: {GetMonthName(month)}, Total Vehicles Sold: {totalSalesMonth}, Retail Sales: {retailSalesMonth}, Corporate Sales: {corporateSalesMonth}");
            }

            Console.WriteLine($"Overall Total Vehicles Sold between April 1st and September 30th: {overallTotalSales}");
            Console.WriteLine($"Overall Retail Sales: {overallRetailSales}");
            Console.WriteLine($"Overall Corporate Sales: {overallCorporateSales}");
        }
        static int VehiclesSold(int day)
        {
            return (int)Math.Pow((day + 1) / 2, 2);
        }

        static string GetMonthName(int month)
        {
            return new DateTime(2024, month, 1).ToString("MMMM");
        }
    }
}
