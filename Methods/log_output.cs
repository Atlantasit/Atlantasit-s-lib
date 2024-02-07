using System;
using System.IO;

namespace AT_lib{
    class log_output
    {   
            const string log_file_path = @"\logs\";
            string log_file = log_file_path + "log [" + DateTime.Now+ "].txt";
        
        public void write_nextLine(string message){

            string newMessage = message + Environment.NewLine;
            File.WriteAllText(log_file,newMessage);

            //File.AppendAllLines(log_file, (Array) newline)
            // um lines hinzuzufuegen
        }
    }
}