using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PointClass pc1 = new(0, 0);
            PointClass pc2 = new(5, 9);
            double distance = 0;

            double DistanceForStruct = 0;
            PointStruct ps1 = new(0, 0, 0);
            PointStruct ps2 = new(5, 9, 0);

            Stopwatch sw = new();

            sw.Start();
            PointClass.GetDistanceClass(pc1, pc2, ref distance);
            System.Threading.Thread.Sleep(100);
            sw.Stop();

            Console.WriteLine($"Расстояние : {distance} | {sw.ElapsedMilliseconds} ");

            sw.Restart();
            PointStruct.GetDistanceStruct(ps1, ps2, DistanceForStruct);
            sw.Stop();

            long MsForStruct = sw.ElapsedMilliseconds;
            Console.WriteLine($"Расстояние : {DistanceForStruct} | {MsForStruct} ");
        }

        class PointClass
        {
            public double x1 { get; set; }
            public double y1 { get; set; }
            public double distance { get; set; }

            public PointClass(double _x1, double _y1)
            { x1 = _x1; y1 = _y1; }

            public static double GetDistanceClass(PointClass pointOne, PointClass pointTwo,
                ref double distance)
            {
                double x = pointOne.x1 - pointTwo.x1;
                double y = pointOne.y1 - pointTwo.y1;
                return distance = Math.Sqrt((x * x) + (y * y));
            }

        }



        struct PointStruct
        {

            public double x1 { get; set; }
            public double y1 { get; set; }
            public double distance { get; set; }

            public PointStruct(double _x1, double _y1, double distance)
            { x1 = _x1; y1 = _y1; this.distance = distance; }

            public static double GetDistanceStruct(PointStruct pointOne, PointStruct pointTwo, double distance)
            {
                double x = pointOne.x1 - pointTwo.x1;
                double y = pointOne.y1 - pointTwo.y1;
                return distance = Math.Sqrt((x * x) + (y * y));
            }
        }
    }
}



