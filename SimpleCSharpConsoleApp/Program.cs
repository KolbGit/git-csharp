﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Gandi();
        }

        //static int Add(int x, int y)
        //{ return x + y; }

        //#region Narrowing / Widening examples
        //static void NarrowingAttempt()
        //{
        //    byte myByte = 0;
        //    int myInt = 200;

        //    // Explicitly cast the int into a byte (no loss of data).
        //    myByte = (byte)myInt;
        //    Console.WriteLine("Value of myByte: {0}", myByte);
        //}

        //static void ProcessBytes()
        //{
        //    byte b1 = 100;
        //    byte b2 = 250;

        //    // This time, tell the compiler to add CIL code
        //    // to throw an exception if overflow/underflow
        //    // takes place.
        //    try
        //    {
        //        byte sum = checked((byte)Add(b1, b2));
        //        Console.WriteLine("sum = {0}", sum);
        //    }
        //    catch (OverflowException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //static void NarrowWithConvert()
        //{
        //    byte myByte = 0;
        //    int myInt = 200;
        //    myByte = Convert.ToByte(myInt);
        //    Console.WriteLine("Value of myByte: {0}", myByte);
        //}
        //#endregion

        #region Gandi
        static void Gandi()
        {
            byte aggression = 1;

            byte democracyModifier = 2;

            aggression = (byte)(aggression - democracyModifier);

            Console.WriteLine(aggression);
        }
        #endregion
    }
}