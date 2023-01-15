using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace VarelagerProjekt {
    internal class Program {
        static void Main(string[] args)
        {
            #region Time, Lines, CursorVisibility & Method iniciation
            TimeSpan interval5Min = TimeSpan.FromMinutes(5);
            TimeSpan interval1Sec = TimeSpan.FromSeconds(1);

            DateTime nextUpdate5Min = DateTime.Now.Add(interval5Min);
            DateTime nextUpdate1Sec = DateTime.Now.Add(interval1Sec);

            bool firstrun = true;
            Methods methods = new Methods();

            methods.HorizontalLine(70, 9);
            methods.VerticalLine(70, 9);
            methods.VerticalLine(32, 9);

            Console.CursorVisible = false;
            #endregion

            do {
                if (DateTime.Now >= nextUpdate5Min || firstrun == true) {

                    #region Temperature & Humidity

                    // Variable for temperature and humidity, both inside the warehouse,outdoor aswell as the wares that are low in stock or too high and sales.
                    DVIService.monitorSoapClient ds = new DVIService.monitorSoapClient();
                    //This Program requires a service reference: http://dvimonitor.azurewebsites.net/monitor.asmx

                    double warehouseTemp = ds.StockTemp();
                    double warehouseHumidity = ds.StockHumidity();
                    double outdoorTemp = ds.OutdoorTemp();
                    double outdoorHumidity = ds.OutdoorHumidity();

                    //Shows temperature and humidity in the warehouse and outside.
                    methods.positionText(0, 0, "Cyan", "Temperatur og fugtighed\n");

                    Console.WriteLine("Lager:");
                    methods.colorMethod("");
                    Console.WriteLine("Temp: " + warehouseTemp + "°C");
                    Console.WriteLine("Fugt: " + warehouseHumidity + "%\n");

                    methods.colorMethod("Cyan"); 
                    Console.WriteLine("Udenfor");
                    methods.colorMethod("");
                    Console.WriteLine("Temp: " + outdoorTemp + "°C");
                    Console.WriteLine("Fugt: " + outdoorHumidity + "%\n");

                    #endregion Temperature & Humidity

                    #region Warehouse Status
                    //Update regarding the warehouse status

                    methods.positionText(0, 10, "Cyan", "Lagerstatus");
                    int lineExtra = 0;

                    //Stock under minimum
                    methods.positionText(0, 12, "Cyan", "Vare under minimum");
                    methods.colorMethod("Red");
                    List<String> stockUnderMin = new List<string>();
                    stockUnderMin = ds.StockItemsUnderMin();

                    if (stockUnderMin.Count == 0)
                        Console.WriteLine("Ingen vare under minimum");
                    else {
                        for (int i = 0; i < stockUnderMin.Count; i++) {
                            Console.WriteLine(stockUnderMin.ElementAt(i));
                        }
                    }

                    lineExtra = lineExtra + stockUnderMin.Count;

                    //Stock over maximum.
                    methods.positionText(0, 14 + lineExtra, "Cyan", "Vare over maximum");
                    methods.colorMethod("Green");
                    List<String> stockOverMax = new List<string>();
                    stockOverMax = ds.StockItemsOverMax();

                    if (stockOverMax.Count == 0)
                        Console.WriteLine("Ingen vare under maksimum");
                    else {
                        for (int j = 0; j < stockOverMax.Count; j++) {
                            Console.WriteLine(stockOverMax.ElementAt(j));
                        }
                    }

                    lineExtra = lineExtra+ stockOverMax.Count;

                    //Most sold Item
                    methods.positionText(0, 16 + lineExtra, "Cyan", "Mest solgte vare");
                    methods.colorMethod("");
                    List<String> mostSoldItem = new List<string>();
                    mostSoldItem = ds.StockItemsMostSold();

                    if (stockOverMax.Count == 0)
                        Console.WriteLine("Ingen mest solgte vare :(");
                    else {
                        for (int z = 0; z < mostSoldItem.Count; z++) {
                            Console.WriteLine(mostSoldItem.ElementAt(z));
                        }
                    }

                    #endregion Lagerstatus

                    #region Dynamic Lines
                    //Draws lines based on the amount of input from earlier so it doesn't colide with other text.

                    methods.VerticalLine(70, 19 + lineExtra);
                    methods.HorizontalLine(70, 19 + lineExtra);
                    lineExtra = lineExtra + mostSoldItem.Count;
                    #endregion

                    #region RSS
                    //Creates an RRS-feed that updates every 5 minutes. The feed is from NORDJYSKE Stifttidende - news.

                    methods.colorMethod("Cyan");
                    string rssFeedUrl = "https://nordjyske.dk/rss/nyheder";
                    WebClient client = new WebClient();
                    client.Encoding = Encoding.UTF8;                        // Set the encoding to UTF8
                    string rssXml = client.DownloadString(rssFeedUrl);
                    XDocument rssDocument = XDocument.Parse(rssXml);        // Parse to an XML


                    // Choose which elements it shall pick out and write.
                    methods.positionText(0, 18 + lineExtra, "Cyan", rssDocument.Root.Element("channel").Element("title").Value);
                    Console.WriteLine("                                                                                          ");
                    Console.WriteLine("                                                                                          ");
                    Console.WriteLine("                                                                                          ");
                    methods.positionText(0, 18 + lineExtra, "Yellow", "");
                   
                    for (int x = 0; x < 3; x++) {
                        var elementet = rssDocument.Root.Element("channel").Elements("item").ElementAt(x);
                        Console.WriteLine(elementet.Element("title").Value);
                    }
                    #endregion

                    nextUpdate5Min = nextUpdate5Min.Add(interval5Min);
                }

                if (DateTime.Now >= nextUpdate1Sec || firstrun == true) 
                {
                    #region Time / Date
                    //Time and Date for different cities around the world, Copenhagen, London, & Singapore.
                    methods.positionText(35, 0, "Cyan", "Dato / Tid");

                    // Gather time and timezone for the different cities.
                    DateTime copenhagenTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time"));
                    DateTime londonTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"));
                    DateTime singaporeTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time"));

                    // Shows the date, time for the different cities.
                    methods.positionText(35, 2, "Cyan", "København:");
                    methods.positionText(35, 3, "", copenhagenTime.DayOfWeek + " " + copenhagenTime.ToString(CultureInfo.InstalledUICulture));

                    methods.positionText(35, 4, "Cyan", "London:");
                    methods.positionText(35, 5, "", londonTime.DayOfWeek + " " + londonTime.ToString(CultureInfo.InstalledUICulture));

                    methods.positionText(35, 6, "Cyan", "Singapore:");
                    methods.positionText(35, 7, "", singaporeTime.DayOfWeek + " " + singaporeTime.ToString(CultureInfo.InstalledUICulture));

                    #endregion

                    nextUpdate1Sec = nextUpdate1Sec.Add(interval1Sec);
                    firstrun = false;
                }
            } while (true);
        }
    }
}
