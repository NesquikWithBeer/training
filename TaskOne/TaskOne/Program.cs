namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();
            app.StartApplication();
        }

        public void StartApplication()
        {
            getTriangle();
        }

        public void getTriangle()
        {
            Triangle triangle = new Triangle();
            triangle.ShowTriangle1();


        }
    }
}
