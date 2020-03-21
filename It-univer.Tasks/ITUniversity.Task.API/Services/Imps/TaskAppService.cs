using System;
using System.Collections.Generic;
using System.Text;
using ItUniversity.Application.Services;

namespace ITUniversity.Task.API.Services.Imps
{
    public class TaskAppService : ApplicationService, ITaskAppService
    {
        public void Test()
        {

        }

        public string GetTest()
        {
            return "aaaaa";
        }

        public void TestString(string str)
        {

        }

        public string GetTestString(string str)
        {
            return "aaaaa";
        }

        public void Class(Test test)
        {

        }

        public Test GetClass(Test test)
        {
            return test;
        }
    }
}
