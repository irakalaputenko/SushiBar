using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponBar.Local_Abstract_Factory_
{
    public abstract class UIAbstractFactory
    {
        public abstract Login GetLogin(string A);
        public abstract Text1 GetText1(string A);
        public abstract Text2 GetText2(string A);
        public abstract Text3 GetText3(string A);
        public abstract Rem GetRem(string A);
        public abstract Log GetLog(string A);
        public abstract Reg GetReg(string A);
        public abstract Or GetOr(string A);
        public abstract English GetEnglish(string A);
        public abstract Ukraine GetUkraine(string A);
    }
    class USAApp : UIAbstractFactory
    {
        public override Login GetLogin(string A)
        {
            return new USALogin(A);
        }
        public override Text1 GetText1(string A)
        {
            return new USAText1(A);
        }
        public override Text2 GetText2(string A)
        {
            return new USAText2(A);
        }
        public override Text3 GetText3(string A)
        {
            return new USAText3(A);
        }
        public override Rem GetRem(string A)
        {
            return new USARem(A);
        }
        public override Log GetLog(string A)
        {
            return new USALog(A);
        }
        public override Reg GetReg(string A)
        {
            return new USAReg(A);
        }
        public override Or GetOr(string A)
        {
            return new USAOr(A);
        }
        public override English GetEnglish(string A)
        {
            return new USAEnglish(A);
        }
        public override Ukraine GetUkraine(string A)
        {
            return new USAUkraine(A);
        }
    }
    class UkrApp : UIAbstractFactory
    {
        public override Login GetLogin(string A)
        {
            return new UkrLogin(A);
        }
        public override Text1 GetText1(string A)
        {
            return new UkrText1(A);
        }
        public override Text2 GetText2(string A)
        {
            return new UkrText2(A);
        }
        public override Text3 GetText3(string A)
        {
            return new UkrText3(A);
        }
        public override Rem GetRem(string A)
        {
            return new UkrRem(A);
        }
        public override Log GetLog(string A)
        {
            return new UkrLog(A);
        }
        public override Reg GetReg(string A)
        {
            return new UkrReg(A);
        }
        public override Or GetOr(string A)
        {
            return new UkrOr(A);
        }
        public override English GetEnglish(string A)
        {
            return new UkrEnglish(A);
        }
        public override Ukraine GetUkraine(string A)
        {
            return new UkrUkraine(A);
        }
    }
}
