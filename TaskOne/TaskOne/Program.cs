using System.Drawing;

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
            //getTriangle();
            GetRectangle();
        }

        public void getTriangle()
        {
            Triangle triangle = new Triangle();
            //triangle.ShowTriangle();
            //triangle.ShowAnotherTriangle();
            triangle.ShowMasTreeTriangle();


        }

        public void GetRectangle()
        {
            Rectangle rectangle = new Rectangle();
            //rectangle.GetMessage();
            rectangle.GetArea();
        }
    }
}
