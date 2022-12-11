using MyLib.MyNamespace;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib.MyNamespace2
{
    // 默认的class是internal, 这是项目级别内的可引用
    // 项目级别,即 Assembly, 即 .dll
    // Assembly, 一般有两种, .exe 和 .dll
    class Student
    {
        public Calculator Calculator { get; set; }
    }
}
