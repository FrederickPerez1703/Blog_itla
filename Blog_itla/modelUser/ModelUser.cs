using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog_itla.DataAcces;


namespace Blog_itla.modelUser
{
    public class ModelUser
    {
        USerDao USer = new USerDao();

        public bool Login(String User , String pass)
        {

            return USer.Login(User, pass);
        }
        public bool Registro(String Nom, String User, String pass , int edad, String direcion)
        {

            return USer.Registro(Nom, User , pass , edad , direcion);
        }
    }
}
