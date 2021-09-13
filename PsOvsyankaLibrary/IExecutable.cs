using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsOvsyankaLibrary
{
    public interface IExecutable
    {
        string Name { get; set; } 

        void Show(); //Вывод информации (не виртуальный)

        void ShowVirtual(); //Вывод информации
    }

}
