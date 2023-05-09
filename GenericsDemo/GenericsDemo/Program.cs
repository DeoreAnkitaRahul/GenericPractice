namespace GenericsDemo
{
    class Program
    {
       
        //generics means general form and do not have return
        public static void Main(string[] args)
        {
            GenericClass<string> genericClass= new GenericClass<string>("A");
            GenericClass<int> genericCls= new GenericClass<int>(3);
            GenericClass<double> generic = new GenericClass<double>(3.3);

            genericClass.DemoData("Am");
             genericCls.DemoData(2);
            generic.DemoData(5.5);

            genericCls.DemoData(6);
            generic.DemoData(4.5);



        }
    }
}