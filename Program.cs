using System;
using System.IO;
using System.Text;
using System.Collections.Generic;




namespace Char_by_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "", apellido = "";
            string password = "", confirmPassword = "";
            string edad = "";
            double ahorros = 0f;
            Console.WriteLine("Introduzca el nombre");
            nombre = IntroducirNombre();
            Console.WriteLine(System.Environment.NewLine +"Introduzca el apellido");
            apellido = IntroducirNombre();
            Console.WriteLine(System.Environment.NewLine + "Introduzca la edad");
            edad = IntroducirEdad();
            Console.WriteLine(System.Environment.NewLine + "Introduzca la contraseña");
            password = IntroducirPassword();
            Console.WriteLine(System.Environment.NewLine + "Confirmar contraseña");
            confirmPassword = IntroducirPassword();

            
            if(password == confirmPassword)
            {
                Console.WriteLine(System.Environment.NewLine + "Login Succeed");
            }
            else
            {
                Console.WriteLine(System.Environment.NewLine + "Invalid Password");
            }


            Console.WriteLine(System.Environment.NewLine + "Introduzca los ahorros");
            ahorros = IntroducirAhorros();
            Console.WriteLine(System.Environment.NewLine + "Sus ahorros son: RD$ " + ahorros);


        }

        public static string IntroducirNombre()
        {
            string valorDevuelto = "";
            List<char> nombre = new List<char>();
            ConsoleKeyInfo x = new ConsoleKeyInfo();

            for (x = Console.ReadKey(true); x.Key != ConsoleKey.Enter; x = Console.ReadKey(true))
            {
                if (x.Key == ConsoleKey.Backspace)
                {
                    Stream h = Console.OpenStandardOutput();

                    using (StreamWriter g = new StreamWriter(h))
                    {
                        g.Write("\b \b");
                        if (nombre.Count != 0)
                        {
                            nombre.RemoveAt(nombre.Count - 1);
                        }



                    }

                }
                else
                {
                    if(x.Key != ConsoleKey.D0 && x.Key != ConsoleKey.D1 && x.Key != ConsoleKey.D2 && x.Key != ConsoleKey.D3 && x.Key != ConsoleKey.D4 && x.Key != ConsoleKey.D5 && x.Key != ConsoleKey.D6
                        && x.Key != ConsoleKey.D7 && x.Key != ConsoleKey.D8 && x.Key != ConsoleKey.D9)
                    {
                        Console.Write(x.KeyChar);


                        nombre.Add(x.KeyChar);
                    }
                    






                }

            }


            foreach (char z in nombre)
            {
                valorDevuelto += z;
            }

            return valorDevuelto;
        }


        public static string IntroducirPassword()
        {

            string valorDevuelto = "";
            List<char> password = new List<char>();
            ConsoleKeyInfo x = new ConsoleKeyInfo();

            for (x = Console.ReadKey(true); x.Key != ConsoleKey.Enter; x = Console.ReadKey(true))
            {
                if (x.Key == ConsoleKey.Backspace)
                {
                    Stream h = Console.OpenStandardOutput();

                    using (StreamWriter g = new StreamWriter(h))
                    {
                        g.Write("\b \b");
                        if (password.Count != 0)
                        {
                            password.RemoveAt(password.Count - 1);
                        }



                    }

                }
                else
                {
                    Console.Write('*');


                    password.Add(x.KeyChar);






                }

            }
        

            foreach (char z in password)
            {
                valorDevuelto += z;
            }
            
            return valorDevuelto;

        }


        public static string IntroducirEdad()
        {
            ConsoleKeyInfo x = new ConsoleKeyInfo();
            List<char> edadChar = new List<char>();
            string edad = "";
            for(x = Console.ReadKey(true); x.Key != ConsoleKey.Enter; x = Console.ReadKey(true))
            {
                switch (x.Key)
                {
                    case ConsoleKey.D1:
                        Console.Write(x.KeyChar);
                         edadChar.Add(x.KeyChar);
                    break;

                    case ConsoleKey.D2:
                        Console.Write(x.KeyChar);
                        edadChar.Add(x.KeyChar);
                        break;

                    case ConsoleKey.D3:
                        Console.Write(x.KeyChar);
                        edadChar.Add(x.KeyChar);
                        break;

                    case ConsoleKey.D4:
                        Console.Write(x.KeyChar);
                        edadChar.Add(x.KeyChar);
                        break;

                    case ConsoleKey.D5:
                        Console.Write(x.KeyChar);
                        edadChar.Add(x.KeyChar);
                        break;

                    case ConsoleKey.D6:
                        Console.Write(x.KeyChar);
                        edadChar.Add(x.KeyChar);
                        break;

                    case ConsoleKey.D7:
                        Console.Write(x.KeyChar);
                        edadChar.Add(x.KeyChar);
                        break;

                    case ConsoleKey.D8:
                        Console.Write(x.KeyChar);
                        edadChar.Add(x.KeyChar);
                        break;

                    case ConsoleKey.D9:
                        Console.Write(x.KeyChar);
                        edadChar.Add(x.KeyChar);
                        break;

                    case ConsoleKey.Backspace:
                        Console.Write("\b \b");
                        if(edadChar.Count != 0)
                        {
                            edadChar.RemoveAt(edadChar.Count - 1);
                        }
                       
                        break;


                }

                if(edadChar.Count == 3)
                {
                    foreach (char y in edadChar)
                    {
                        edad += y;
                    }

                    return edad;
                }
            }

            foreach (char y in edadChar)
            {
                edad += y;
            }


            return edad;
        }

        public static double IntroducirAhorros()
        {
            string ahorrosStr = "";
            double ahorros = 0f;
            int contadorPunto = 0;
            char datoAnterior = ' ';

            Stream x = Console.OpenStandardOutput();

            using(StreamWriter h = new StreamWriter(x))
            {
                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

                for(keyInfo = Console.ReadKey(true); keyInfo.Key != ConsoleKey.Enter; keyInfo = Console.ReadKey(true))
                {
                    if (keyInfo.Key == ConsoleKey.Backspace)
                    {
                        ahorrosStr.Remove(ahorrosStr.Length - 1);
                        Console.Write("\b \b");
                       
                        if(datoAnterior == '.')
                        {
                            contadorPunto = 0;
                        }
                    }
                    else
                    {
                        if (keyInfo.KeyChar == '.' && contadorPunto != 1)
                        {
                            contadorPunto = 1;
                            Console.Write('.');
                            datoAnterior = keyInfo.KeyChar;
                            ahorrosStr += keyInfo.KeyChar.ToString();
                        }

                        if (contadorPunto != 1)
                        {
                            Console.Write(keyInfo.KeyChar);
                            ahorrosStr += keyInfo.KeyChar.ToString();
                            datoAnterior = keyInfo.KeyChar;

                        }
                        else
                        {
                            if (keyInfo.KeyChar == '.')
                            {

                                // No hacer nada 
                            }
                            else
                            {
                                Console.Write(keyInfo.KeyChar);
                                ahorrosStr += keyInfo.KeyChar.ToString();
                                datoAnterior = keyInfo.KeyChar;
                            }
                        }
                    }
                }
            }
            
            ahorros = double.Parse(ahorrosStr);
            return Math.Round(ahorros, 2);
        }


    }
}
