namespace leetCodeExamples.Solutions
{
    public class GenericsTest<T>
    {
        private T[] _data = new T[10];
        //public GenericsTest(T[] data)
        //{
        //    data = _data;
        //}

        public void AddValue(int index, T input)
        {
            _data[index] = input;

        }

        //GenericsTest<string> x = new GenericsTest<string>();
        //x.AddValue(0, "test");

        //    GenericsTest<int> x2 = new GenericsTest<int>();
        //x2.AddValue(1, 1);
    }
}
