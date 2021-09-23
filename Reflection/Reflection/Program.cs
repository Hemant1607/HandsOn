using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly myAssembly = Assembly.LoadFile(@"C:\Users\Hemanth Kumar\source\repos\Dll files\Mobile library\bin\Debug\Mobile Library.dll");

            Console.WriteLine("Information:{0}", myAssembly.FullName);
            Type[] asm = myAssembly.GetTypes();

            //Type myType = myAssembly.GetType("Mobile Library.Mobile");

            object objectInstance = Activator.CreateInstance(asm[0]);

            Type objectType = objectInstance.GetType();


            foreach(MemberInfo objMemberInfo in objectType.GetMembers())
            {

                Console.WriteLine(objMemberInfo.Name);

            }
      
            Console.Read();
        }
    }
}
