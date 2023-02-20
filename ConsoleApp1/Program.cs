using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Oscillator
    {

        private string Volny;
        private string OscillatorName;

        public Oscillator(string volny, string oscillatorName)
        {
            Volny = volny;
            OscillatorName = oscillatorName;
        }
        public Oscillator(string volny) : this(volny, "osc_0")
        {
            Volny = volny;
        }
        public Oscillator() : this("Nonfinded", "osc6")
        {

        }
        public string GetVolny()
            { return Volny; }
        public string GetOscillatorName()
            { return OscillatorName; }
        public void Print()
        {
            Console.WriteLine(OscillatorName + " " + Volny);
        }
    }
    public class Mainclass
    {
        static Dictionary<int, Oscillator> Oscillators = new Dictionary<int, Oscillator>();
        static void Main(string[] args)
        {
            Oscillator Test1 = new Oscillator("Sinewave", "Ocs1");
            Oscillators.Add(1, Test1);
            Oscillator Test2 = new Oscillator("Triangular", "Ocs2");
            Oscillators.Add(2, Test2);
            Oscillator Test3 = new Oscillator("Sawtooth", "Ocs3");
            Oscillators.Add(3, Test3);
            Oscillator Test4 = new Oscillator("Squarewave", "Ocs4");
            Oscillators.Add(4, Test4);
            Oscillator Test5 = new Oscillator("Pulse", "Ocs5");
            Oscillators.Add(5, Test5);
            Console.Write("Введите номер волны: ");
            int Number = int.Parse(Console.ReadLine());
            Oscillator choised = Oscillators[Number];
            if (choised != null)
            {
                choised.Print();
            }
            else { Console.WriteLine("Не найден"); }
        }
    }
}
