using System;
using System.Collections.Generic;
using System.Text;

namespace moodAnalyaserTest
{
   public class analyseMoodException : Exception
    {
        public enum Exception_Type
        {
            Null_Exception,
            Empty_Exception,
            Invalid_Exception,
            No_Such_Method_Exception,
            No_Such_Class_Exception,
            No_Such_Field_Exception,
            Error_in_obj_ceation
           
        }

       public Exception_Type ex_ty;
        public analyseMoodException(Exception_Type exception_Type,string ex_message):base(ex_message)
        {
            this.ex_ty = exception_Type;
            
        }


    }

}
