using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GlobalUsingFeatures.File
{
    internal static class WriteToFile
    {
        public static void OldUsingDeclaration()
        {
            // Declare the variable outside the using statement
            FileStream stream = new FileStream(@"C:\Users\Vikas\Desktop\File\file1.txt", FileMode.Create);

            // Use the variable within the using statement
            using (stream)
            {
                // Use 'stream' here
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine("Writing using old syntax.");
                }
            }

            // 'stream' is disposed of automatically after the using block
        }

        public static void NewUsingDeclaration()
        {
            // Declare and initialize the variable within the using statement
            using var stream = new FileStream(@"C:\Users\Vikas\Desktop\File\file2.txt", FileMode.Create);

            // Use 'stream' here
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine("Writing using new syntax.");
            }

            // 'stream' is disposed of automatically after the using block
        }
    }
}
