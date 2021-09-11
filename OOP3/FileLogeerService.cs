using System;

namespace OOP3
{
    class FileLogeerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }

}
