using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponBar.Local_Abstract_Factory_
{
    public abstract class Login
    {
        public string A;
        public Login(string a)
        {
            A = a;
        }
    }
    class USALogin : Login
    {
        public USALogin(string a) : base(a) { }
    }
    class UkrLogin : Login
    {
        public UkrLogin(string a) : base(a) { }
    }

    //-----------------------------------------------------

    public abstract class Text1
    {
        public string A;
        public Text1(string a)
        {
            A = a;
        }
    }
    class USAText1 : Text1
    {
        public USAText1(string a) : base(a) { }
    }
    class UkrText1 : Text1
    {
        public UkrText1(string a) : base(a) { }
    }

    //--------------------------------------------------------

    public abstract class Text2
    {
        public string A;
        public Text2(string a)
        {
            A = a;
        }
    }
    class USAText2 : Text2
    {
        public USAText2(string a) : base(a) { }
    }
    class UkrText2 : Text2
    {
        public UkrText2(string a) : base(a) { }
    }

    //---------------------------------------------------------------


    public abstract class Text3
    {
        public string A;
        public Text3(string a)
        {
            A = a;
        }
    }
    class USAText3 : Text3
    {
        public USAText3(string a) : base(a) { }
    }
    class UkrText3 : Text3
    {
        public UkrText3(string a) : base(a) { }
    }

    //-----------------------------------------------------------------------------



    public abstract class Rem
    {
        public string A;
        public Rem(string a)
        {
            A = a;
        }
    }
    class USARem : Rem
    {
        public USARem(string a) : base(a) { }
    }
    class UkrRem : Rem
    {
        public UkrRem(string a) : base(a) { }
    }


    //---------------------------------------------


    public abstract class Log
    {
        public string A;
        public Log(string a)
        {
            A = a;
        }
    }
    class USALog : Log
    {
        public USALog(string a) : base(a) { }
    }
    class UkrLog : Log
    {
        public UkrLog(string a) : base(a) { }
    }

    //-----------------------------------------------------

    public abstract class Reg
    {
        public string A;
        public Reg(string a)
        {
            A = a;
        }
    }
    class USAReg : Reg
    {
        public USAReg(string a) : base(a) { }
    }
    class UkrReg : Reg
    {
        public UkrReg(string a) : base(a) { }
    }

    //------------------------------------------------------------

    public abstract class Or
    {
        public string A;
        public Or(string a)
        {
            A = a;
        }
    }
    class USAOr : Or
    {
        public USAOr(string a) : base(a) { }
    }
    class UkrOr : Or
    {
        public UkrOr(string a) : base(a) { }
    }

    //------------------------------------------------------------


    public abstract class English
    {
        public string A;
        public English(string a)
        {
            A = a;
        }
    }
    class USAEnglish : English
    {
        public USAEnglish(string a) : base(a) { }
    }
    class UkrEnglish : English
    {
        public UkrEnglish(string a) : base(a) { }
    }


    //-------------------------------------------------------------

    public abstract class Ukraine
    {
        public string A;
        public Ukraine(string a)
        {
            A = a;
        }
    }
    class USAUkraine : Ukraine
    {
        public USAUkraine(string a) : base(a) { }
    }
    class UkrUkraine : Ukraine
    {
        public UkrUkraine(string a) : base(a) { }
    }
}
