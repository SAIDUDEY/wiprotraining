
abstract class SmartDevice 
{
    public abstract void TurnOn();

    public void ShowStatus()
    {
        Console.WriteLine("Device Status : Active");
    }
}

interface IRemoteControl
{
    public void IncreaseVolume();
    public void DecreaseVolume();

}

class SmartLight : SmartDevice, IRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("SmartLight turned on");
        }
        public void IncreaseVolume()
        {
            Console.WriteLine("light donot support volume control");
        }
        public void DecreaseVolume()
        {
            Console.WriteLine("light donot support volume control");
        }

 }

    class SmartSpeaker : SmartDevice , IRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("Smartspeaker turned on");
        }
        public void IncreaseVolume()
        {
            Console.WriteLine("volume increased");
        }
        public void DecreaseVolume()
        {
            Console.WriteLine("volume decreased");
        }

    }

    class Program
    {
        static void Main()
        {
            SmartDevice device;

        device = new SmartLight();
        device.TurnOn();
            
        IRemoteControl remoteControl;
        remoteControl = new SmartLight();
        remoteControl.IncreaseVolume();
        remoteControl.DecreaseVolume();

        Console.WriteLine();

        device = new SmartSpeaker();
        device.TurnOn();
        remoteControl = new SmartSpeaker();
        remoteControl.IncreaseVolume();
        remoteControl.DecreaseVolume();
        }
    }