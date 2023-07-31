using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBankingingApp
{
    public class TryingSomethingOut
    {
        private string fathersLastName;

        //public string GetFathersFirstName()
        //{
        //    return FathersLastName;
        //}
        //public void setFatherFirstName(string FathersFirstName)
        //{
        //    this.FathersLastName = FathersFirstName;
        //}

        public string FathersLastName
        {
            get
            {
                return fathersLastName;
            }
            set { fathersLastName = value; }
        }

        private int FathersAge { get; set; }

        //public TryingSomethingOut()
        //{
        //    FathersAge = 45;
        //    fathersLastName = " Fanal Test";
        //    Console.WriteLine($"Father's name is {FathersLastName} and he is {FathersAge} old");
        //}

        public virtual void MakeASound()
        {
            Console.WriteLine("main trying");
        }
    }

    public class newinherit : TryingSomethingOut
    {
        public override void MakeASound()
        {
            Console.WriteLine("Trying Sound");
        }
    }

    public class newone : TryingSomethingOut
    {
        public override void MakeASound()
        {
            Console.WriteLine("second Sound");
        }
    }

    //public void WriteMilitaryTime(DateTime date)
    //{
    //    //
    //    // Convert hours and minutes to 24-hour scale.
    //    //
    //    string value = date.ToString("HHmm");
    //    Console.WriteLine(value);
    //}
}