namespace practise
{
    internal class Program
    {
        static void CallFun(Animal[] a)
        {
            foreach(Animal i in a)
            {

                i.Eat();
                Tiger t=i as Tiger;//check the Animal ref to tiger if true "as" reurn the ref rather than return null
                if (t != null)
                {
                    t.Hunting();
                }
            }

        }
        static void Main(string[] args)
        {
            Animal[] arr = new Animal[2];
            arr[0] = new Dog();
            arr[1]=new Tiger();
            CallFun(arr);
        }
    }
}
