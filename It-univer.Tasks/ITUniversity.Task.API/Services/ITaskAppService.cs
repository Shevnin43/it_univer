using System;
using System.Collections.Generic;
using System.Text;
using ItUniversity.Application.Services;

namespace ITUniversity.Task.API.Services
{
        public interface ITaskAppService : IApplicationService
        {
            void Test();

            string GetTest();

            void TestString(string str);

            string GetTestString(string str);

            void Class(Test test);

            Test GetClass(Test test);
        }

        public class Test
        {
            public string Name { get; set; }

            public long Age { get; set; }
        }
}
