using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    interface ICutsomer 
    {
        public void GetDetails();
        public  void CalculateFee();
    }

    public abstract class  AbstractVsInterface : ICutsomer
    {
        public  void GetDetails()
        {

        }
        public abstract void CalculateFee();
    }

    public  class Student : AbstractVsInterface
    {
        public override void CalculateFee()
        {
            throw new NotImplementedException();
        }
       

    }


}
