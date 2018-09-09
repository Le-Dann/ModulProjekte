using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.Vererbung.Buchkonto
{
    public class KtoException : Exception
    {
        private int _errCode;

        public int ErrCode
        {
            get { return _errCode; }
            
        }

        public string FormattedMessage()
        {
            return "";
        }

        public KtoException() : this(0, "", null)
        {

        }

        public KtoException(int errCode, string message) : this(errCode,message,null)
        {

        }

        public KtoException(string message):this(0,message,null)
        {

        }

        public KtoException(string message, Exception inner) : this(0,message,inner)
        {

        }

        public KtoException(int errCode, string message, Exception inner) : base(message,inner)
        {
            _errCode = errCode;          
        }
    }
}
