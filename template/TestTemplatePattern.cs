using System;

namespace template
{
    public static class TestTemplatePattern
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("For MYSQL....");
            ConnectionTemplate template = new MySqLCSVCon();
            template.Run();
            Console.WriteLine("For Oracle...");
            template = new OracleTxtCon();
            template.Run();
        }
    }
}