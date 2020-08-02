using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    class Card
    {
        private
            int CardNum;
            bool IsCardOnADeck; //false is card not on deck
        public
        Card()
            {
            this -> CardNum = 0;
            this -> IsCardOnADeck = true;
        }
        void SetCardNum( int numerical_arg){}
        void SetCardStatus(bool boolean_arg ){}
        int GetCardNum(){}
        bool GetCardStatus(){}
    }
}
