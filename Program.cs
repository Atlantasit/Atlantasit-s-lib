using System;
using System.IO;


namespace AT_lib{

    class Execution_testing{
        
        public static void Main(string[] args){
            log_output log = new log_output();

            log.write_nextLine("hi");
            log.write_nextLine("dis is a log");

            Console.ReadKey();

        }
    }
}         