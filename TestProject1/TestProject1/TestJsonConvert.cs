using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    class PersonInfo
    {
        public string Name
        { get; set; }

        public int Age
        { get; set; }

        public string Gender
        { get; set; }
    }

    class Member
    {
        public string ID
        { get; set; }

        public string Division
        { get; set; }

        public PersonInfo Person
        { get; set; }
    }

    class TestJsonConvert
    {
        public TestJsonConvert()
        {
        }

        public void TestSerializeObject()
        {
            Console.WriteLine("Expected result: ");
            Console.WriteLine("{\"ID\":\"0001\",\"Division\":\"Research\",\"Person\":{\"Name\":\"Michael\",\"Age\":20,\"Gender\":\"M\"}}");

            Member member = GetTestMember();
            string memberText = JsonConvert.SerializeObject(member);
            Console.WriteLine("Actual result: ");
            Console.WriteLine(memberText);
        }

        private Member GetTestMember()
        {
            PersonInfo person = new PersonInfo() { Name = "Michael", Age = 20, Gender = "M" };
            Member member = new Member() { ID = "0001", Division = "Research", Person = person };
            return member;
        }

    }
}
