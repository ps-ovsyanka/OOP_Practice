﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_10
{
    public interface IExecutable
    {
        string Name { get; set; } 

        void Show(); //Вывод информации (не виртуальный)

        void ShowVirtual(); //Вывод информации
    }

}
