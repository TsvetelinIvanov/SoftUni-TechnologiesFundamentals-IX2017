using System;

namespace _18DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNumber = Console.ReadLine();
            string dataType = string.Empty;
            bool isFit = false;

            try
            {
                sbyte sbyteNumber = sbyte.Parse(stringNumber);
                dataType += "* sbyte" + Environment.NewLine;
                isFit = true;
            }
            catch (Exception)
            {
                
            }

            try
            {
                byte byteNumber = byte.Parse(stringNumber);
                dataType += "* byte" + Environment.NewLine;
                isFit = true;
            }
            catch (Exception)
            {
                
            }

            try
            {
                short shortNumber = short.Parse(stringNumber);
                dataType += "* short" + Environment.NewLine;
                isFit = true;
            }
            catch (Exception)
            {
                
            }

            try
            {
                ushort ushortNumber = ushort.Parse(stringNumber);
                dataType += "* ushort" + Environment.NewLine;
                isFit = true;
            }
            catch (Exception)
            {
                
            }

            try
            {
                int intNumber = int.Parse(stringNumber);
                dataType += "* int" + Environment.NewLine;
                isFit = true;
            }
            catch (Exception)
            {
                
            }

            try
            {
                uint uintNumber = uint.Parse(stringNumber);
                dataType += "* uint" + Environment.NewLine;
                isFit = true;
            }
            catch (Exception)
            {
                
            }

            try
            {
                long longNumber = long.Parse(stringNumber);
                dataType += "* long";
                isFit = true;
            }
            catch (Exception)
            {
                
            }

            if (isFit)
            {
                Console.WriteLine($"{stringNumber} can fit in:");
                Console.WriteLine(dataType);
            }
            else
            {
                Console.WriteLine($"{stringNumber} can't fit in any type");
            }
        }
    }
}
