using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;



namespace moodAnalyaserTest
{
    public class analyseMoodFactory<Gtype>
    {
        public ConstructorInfo defaultConstructor()
        {
            try
            {
                Type type = typeof(Gtype);
                ConstructorInfo[] constructors = type.GetConstructors();
                foreach (var info in constructors)
                {
                    if (info.GetParameters().Length == 0)
                        return info;
                }

                return constructors[0];
            }

            catch (Exception)
            {
                throw new analyseMoodException(analyseMoodException.Exception_Type.No_Such_Method_Exception, "please enter proper mood");
            }
        }


        public object GetInstance(string classname,ConstructorInfo constructor)

        {
            try
            {
                Type type = typeof(Gtype);
                if (classname != type.Name)
                    throw new analyseMoodException(analyseMoodException.Exception_Type.No_Such_Class_Exception, "please enter right mood");
                if (constructor != type.GetConstructors()[0])
                    throw new analyseMoodException(analyseMoodException.Exception_Type.No_Such_Method_Exception, "please enter right mood");
                var Object_return = constructor.Invoke(new object[0]);
                Gtype Obj_retuen = Activator.CreateInstance<Gtype>();
                return Obj_retuen;
            }
            catch (Exception)
            {
                throw new analyseMoodException(analyseMoodException.Exception_Type.Error_in_obj_ceation, "please enter right mood");
            }
        }



    }
}