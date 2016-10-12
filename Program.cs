using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassTest; //写好了命名空间还不够，直接在这里using的话，会报错的
//需要在“项目”---“添加引用” -- “解决方案”--- “项目”中选择需要添加的命名空间

namespace ConstantTest
{
    class Program
    {
        static void ConstTest()
        {
            try
            {
                int x = ClassTemp.num_X;
                int y = ClassTemp.num_Y;
                int result = x * y;
                Console.WriteLine(ClassTemp.rightInfo + "result:" + result);
            }
            catch (Exception)
            {
                Console.WriteLine(ClassTemp.errorInfo);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static void ReadonlyTest() 
        {
            try
            {
                int x = ClassTemp.num_XR;
                int y = ClassTemp.num_YR;
                int result = x * y;
                Console.WriteLine(ClassTemp.rightInfoR + " result: " + result);
            }
            catch (Exception)
            {
                Console.WriteLine(ClassTemp.errorInfoR);
            }
            finally 
            {
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            //ConstTest();
            ReadonlyTest();
            //readonly int x = 30; 不能声明readonly类型的变量
            //const int x = 30; 可以用const来修饰变量
        }
    }
}
