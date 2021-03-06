using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;



namespace moodAnalyaserTest
{
    public class analyseMoodFactory<Gtype>
    {
        Type type = typeof(Gtype);
        public ConstructorInfo defaultConstructor(int num=0)
        {
            try
            {
                Type type = typeof(Gtype);
                ConstructorInfo[] constructors = type.GetConstructors();
                foreach (var info in constructors)
                {
                    if (info.GetParameters().Length == num)
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

        public object GetParameterizedInstance(string classname, ConstructorInfo constructor,String paramValue)

        {
            try
            {
               
                if (classname != type.Name)
                    throw new analyseMoodException(analyseMoodException.Exception_Type.No_Such_Class_Exception, "please enter right mood");
                if (constructor != type.GetConstructors()[1])
                    throw new analyseMoodException(analyseMoodException.Exception_Type.No_Such_Method_Exception, "please enter right mood");
                object Obj_retuen = Activator.CreateInstance(type,paramValue);
                return Obj_retuen;
            }
            catch (Exception)
            {
                throw new analyseMoodException(analyseMoodException.Exception_Type.No_Such_Method_Exception, "please enter right mood");
            }
        }
          public string InvokeMethodUsingReflection()
        {
            try
            {
                Type type = typeof(analyseMood3);
                string message = "i am happy";
                object instance = Activator.CreateInstance(type, message);
                MethodInfo method = type.GetMethod("analyseMood3");
                method.Invoke(instance, null);
                return default;
            }
            catch (analyseMoodException)
            {
                throw new analyseMoodException(analyseMoodException.Exception_Type.No_Such_Method_Exception, "please enter right mood");
            }

        }
        


 public string InvokeMethodUsing(string methodName, string fieldName)
        {
            Type moodAnalysertype = Type.GetType("analyseMood3");
            MethodInfo methodInfo = moodAnalysertype.GetMethod(methodName);
            string[] stringArray = { "I am in Happy mood" };
            object objectInstance = Activator.CreateInstance(moodAnalysertype, stringArray);
            try
            {
                if (fieldName != null)
                {
                    FieldInfo fieldInfo = moodAnalysertype.GetField(fieldName);
                    if (fieldInfo == null)
                        throw new analyseMoodException(analyseMoodException.Exception_Type.No_Such_Field_Exception, "please enter proper mood");
                    fieldInfo.SetValue(objectInstance, fieldName);
                }
            }
            catch (analyseMoodException)
            {
                return "No_Such_Field_Exception";

            }
            try
            {
                if (fieldName == null)
                {
                    return analyseMoodException.Exception_Type.Null_Exception.ToString();
                }
            }
            catch (analyseMoodException)
            {
                return "Null_Exception";
            }
            try
            {
                if (methodInfo == null)
                {
                    throw new analyseMoodException(analyseMoodException.Exception_Type.No_Such_Method_Exception, "please enter proper mood");
                }

                string method = (string)methodInfo.Invoke(objectInstance, null);
                return method;
            }
            catch (analyseMoodException)
            {
                return "HAPPY";

            }
        }

    }
}
