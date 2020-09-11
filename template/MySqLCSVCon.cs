namespace template
{
    public class MySqLCSVCon: ConnectionTemplate
    {
        public override void SetDBDriver()
        {
            System.Console.WriteLine("Setting MySQL DB drivers...");
        }

        public override void SetCredentials()
        {
            System.Console.WriteLine("Setting credentials for MySQL DB...");
        }

        public override void SetData()
        {
            System.Console.WriteLine("Setting up data from CSV file...");
        }
    }
}