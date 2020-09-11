namespace template
{
    public class OracleTxtCon: ConnectionTemplate
    {
        public override void SetDBDriver()
        {
            System.Console.WriteLine("Setting Oracle DB drivers...");
        }

        public override void SetCredentials()
        {
            System.Console.WriteLine("Setting credentials for Oracle DB...");
        }

        public override void SetData()
        {
            System.Console.WriteLine("Setting up data from TXT file...");
        }
    }
}