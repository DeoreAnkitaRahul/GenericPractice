using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class GenericClass<T>
    {
        public T data;

        public GenericClass(T data)
        {
            this.data = data;
            Console.WriteLine("Data :" +this.data);
        }
         public void DemoData(T data)
        {
            Console.WriteLine("Data : " + data);
        }

        public void DemoData<T>(T data)
        {
            Console.WriteLine("Data : " + data);
        }








    }
}
