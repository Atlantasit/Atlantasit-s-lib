using System;
using System.IO;


namespace AT_lib{

    class key_reader{
        
        public void read_key(){
            ConsoleKeyInfo info = Console.ReadKey();

            Console.WriteLine(info);
        }
    }
}