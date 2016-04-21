using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_q_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 30, 27, 15, 90, 99, 42, 75 };

            bool isMultiple = MultipleTester(numbers, 3);
            Console.WriteLine(isMultiple);

            bool isDivisible = IsDivisible(numbers, 3);
            Console.WriteLine(isDivisible);


            List<GpsManufacturer> gpsManufacturers = new List<GpsManufacturer>
                                                        {
                                                            new GpsManufacturer
                                                                {Name = "manf1",
                                                                Devices = new GpsDevice[]
                                                                {
                                                                    new GpsDevice {Name = "device1", IsActive = true},
                                                                    new GpsDevice {Name = "device2", IsActive = false}
                                                                }
                                                            },
                                                            new GpsManufacturer
                                                                {Name = "manf2",
                                                                Devices = new GpsDevice[]
                                                                {
                                                                    new GpsDevice {Name = "device1", IsActive = false},
                                                                    new GpsDevice {Name = "device2", IsActive = false}
                                                                }
                                                            },
                                                            new GpsManufacturer
                                                            {Name = "manf3"}
                                                        };

            ActiveGpsManufacturers(gpsManufacturers);
            ActiveGpsManufacturersCount(gpsManufacturers);

            Console.ReadLine();
        }

        private static bool MultipleTester(int[] numbers, int divisor)
        {
            bool isMultiple = numbers.All(number => number % divisor == 0);
            return isMultiple;
        }

        private static bool IsDivisible(int[] numbers, int divisor)
        {
            bool isDivisible =
                numbers.Any(number => number % divisor == 0);

            return isDivisible;
        }



                                                   

        public static void ActiveGpsManufacturers(List<GpsManufacturer> gpsManufacturers)
                    {
                    // Determine which manufacturers have a active device.
                    IEnumerable<string> activeManf =
                                                        from manf in gpsManufacturers // for all manufacturers
                                                        where manf.Devices != null && // they have a list of devices
                                                        // and at least one of the device is active
                                                        manf.Devices.Any(m => m.IsActive == true)
                                                        select manf.Name; // select them

                    // just for debugging
                    foreach (string name in activeManf)
                    Console.WriteLine(name);
                    }

        public static void ActiveGpsManufacturersCount(List<GpsManufacturer> gpsManufacturers)
                    {
                        // to count the number of active manufacturers
                        int activeManfCount =
                                               gpsManufacturers.Count
                                              (manf => (manf.Devices != null &&
                                               manf.Devices.Any(m => m.IsActive == true)));

                        // debugging
                        Console.WriteLine("Active Manf count: {0}", activeManfCount);
                    }
                    }
}
