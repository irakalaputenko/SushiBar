using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponBar.Local_Abstract_Factory_
{
    public class Client
    {
        public UIAbstractFactory factory;
        public Login login;
        public Text1 text1;
        public Text2 text2;
        public Text3 text3;
        public Rem rem;
        public Log log;
        public Reg reg;
        public Or or;
        public English english;
        public Ukraine ukraine;
        public Client(UIAbstractFactory uIAbstractFactory, string A, string B, string C, string D, string E, string F, string I, string K, string O, string P)
        {
            factory = uIAbstractFactory;
            login = uIAbstractFactory.GetLogin(A);
            text1 = uIAbstractFactory.GetText1(B);
            text2 = uIAbstractFactory.GetText2(C);
            text3 = uIAbstractFactory.GetText3(D);
            rem = uIAbstractFactory.GetRem(E);
            log = uIAbstractFactory.GetLog(F);
            reg = uIAbstractFactory.GetReg(I);
            or = uIAbstractFactory.GetOr(K);
            english = uIAbstractFactory.GetEnglish(O);
            ukraine = uIAbstractFactory.GetUkraine(P);

        }
    }
}
