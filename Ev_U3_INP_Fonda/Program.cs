using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ev_U3_INP_Fonda
{
    class Program
    {
        public static int TR = 0, TJ = 0, TA = 0;
        public static int TE = 0, TC = 0, TP = 0, TCH = 0, TMZ = 0, TPA = 0, TPU = 0;
        public static int cantidad;
        public static int opcion = 0;
        public static int subg = 0;
        public static int subb = 0;
        public static int subgol = 0;
        public static int Total = 0;
        static void gorditas()
        {
            int TH;
            int TM;
            Console.WriteLine("¿Cuantas gorditas de harina va a querer?"+ Math.Pow(2, 3));
            cantidad = Convert.ToInt16(Console.ReadLine());
            TH = cantidad * 10;
            for (int x= 1; x <= cantidad; x++)
            {
                Console.Clear();
                Console.WriteLine("Elija el guiso para sus gordita de harina ingresando el numero correspondiente:");
                Console.WriteLine("1.-Asado\n2.-Verde\n3.-Picadillo\n4.-Discada\n5.-Frijoles con queso\n6.-Arriero");
                Console.WriteLine("7.-Huevo\n8.-Chicharron\n9.-Prensado\n10.-Tinga\n11.-Mole\n12.-Asado verde");
                Console.Write("Gordita de harina " + x + ": ");
                int guiso = Convert.ToInt16(Console.ReadLine());
                if (guiso > 12)
                {
                    Console.WriteLine("Ingrese una opcion valida!");
                    Console.ReadKey();
                    x--;
                }
            }
            Console.WriteLine("¿Cuantas gorditas de maíz va a querer?");
            cantidad = Convert.ToInt16(Console.ReadLine());
            TM = cantidad * 8;
            for (int y = 1; y <= cantidad; y++)
            {
                Console.Clear();
                Console.WriteLine("Elija el guiso para sus gordita de maíz ingresando el numero correspondiente:");
                Console.WriteLine("1.-Asado\n2.-Verde\n3.-Picadillo\n4.-Discada\n5.-Frijoles con queso\n6.-Arriero");
                Console.WriteLine("7.-Huevo\n8.-Chicharron\n9.-Prensado\n10.-Tinga\n11.-Mole\n12.-Asado verde");
                Console.Write("Gordita de maíz " + y + ": ");
                int guiso = Convert.ToInt16(Console.ReadLine());
                if (guiso > 12)
                {
                    Console.WriteLine("Ingrese una opcion valida!");
                    Console.ReadKey();
                    y--;
                }                
            }
            subg += TH + TM;
            Console.Write("Disfrute sus gorditas :3\nEl subtotal de su compra de gorditas es: $" + subg + "\n");
            Console.WriteLine("Enter para continuar...");
            Console.ReadKey();
        }
        static void bebidas()
        {            
            do
            {
                Console.WriteLine("¿Que tipo de bebida prefiere?");
                Console.WriteLine("1.-Refresco\n2.-Jugos\n3.-Agua de sabor");
                opcion = Convert.ToInt16(Console.ReadLine());
                if ( opcion > 3 )
                {
                    Console.WriteLine("Ingrese una opcion valida!");
                    Console.ReadKey();
                }
                else if ( opcion == 1 )
                {
                    Console.Write("¿Cuantos Refrescos desea comprar? ");
                    cantidad = Convert.ToInt16(Console.ReadLine());
                    TR += cantidad * 10;
                    for (int x = 1; x <= cantidad; x++)
                    {
                        Console.Clear();
                        Console.WriteLine("Tenemos los siguientes refrescos:");
                        Console.WriteLine("1.-Coca-Cola\n2.-Fanta naranja\n3.-Manzanita\n4.-Sprite");
                        Console.Write("Refresco " + x + ": ");
                        int r = Convert.ToInt16(Console.ReadLine());
                        if ( r > 4)
                        {
                            Console.WriteLine("Ingrese una opcion valida!");
                            Console.ReadKey();
                            x--;
                        }
                        opcion = 0;
                    }
                    while (opcion != 1 && opcion != 2)
                    {
                        Console.Write("¿Desea comprar algun otro tipo de bebida?  (1)si  (2)no : ");
                        opcion = Convert.ToInt16(Console.ReadLine());
                        if (opcion > 2)
                        {
                            Console.WriteLine("Ingrese una opcion valida!");
                            Console.ReadKey();
                        }
                    }
                }
                else if (opcion == 2)
                {
                    Console.Write("¿Cuantos Jugos desea comprar? ");
                    cantidad = Convert.ToInt16(Console.ReadLine());
                    TJ += cantidad * 12;
                    for (int y = 1; y <= cantidad; y++)
                    {
                        Console.Clear();
                        Console.WriteLine("Tenemos los siguientes jugos:");
                        Console.WriteLine("1.-Naranja\n2.-Naranja con Zanahoria\n3.-Manzana\n4.-Guayaba");
                        Console.Write("Jugo " + y + ": ");
                        int j = Convert.ToInt16(Console.ReadLine());
                        if (j > 4)
                        {
                            Console.WriteLine("Ingrese una opcion valida!");
                            Console.ReadKey();
                            y--;
                        }
                        opcion = 0;
                    }
                    while (opcion != 1 && opcion != 2)
                    {
                        Console.Write("¿Desea comprar algun otro tipo de bebida?  (1)si  (2)no : ");
                        opcion = Convert.ToInt16(Console.ReadLine());
                        if (opcion > 2)
                        {
                            Console.WriteLine("Ingrese una opcion valida!");
                            Console.ReadKey();
                        }
                    }
                }
                else 
                {
                    Console.Write("¿Cuantas Aguas de sabor desea comprar? ");
                    cantidad = Convert.ToInt16(Console.ReadLine());
                    opcion = 0;
                    while (opcion != 1 && opcion != 2)
                    {
                        Console.Clear();
                        Console.WriteLine("¿De que tamaño quiere sus Aguas? ");
                        Console.WriteLine("1.-Un litro\n2.-Medio litro");
                        opcion = Convert.ToInt16(Console.ReadLine());                                           
                        if (opcion == 1)
                        {
                            TA += cantidad * 18;
                            for (int w = 1; w <= cantidad; w++)
                            {
                                Console.Clear();
                                Console.WriteLine("Tenemos los siguientes sabores de agua:");
                                Console.WriteLine("1.-Orchata\n2.-Jamaica\n3.-Limón\n4.-Mango");
                                Console.Write("Agua de litro " + w + ": ");
                                int a = Convert.ToInt16(Console.ReadLine());
                                if (a > 4)
                                {
                                    Console.WriteLine("Ingrese una opcion valida!");
                                    Console.ReadKey();
                                    w--;
                                }
                            }
                        }
                        else if (opcion > 2)
                        {
                            Console.WriteLine("Ingrese una opcion valida!");
                            Console.ReadKey();
                        }
                        else
                        {
                            TA += cantidad * 10;
                            for (int z = 1; z <= cantidad; z++)
                            {
                                Console.Clear();
                                Console.WriteLine("Tenemos los siguientes sabores de agua:");
                                Console.WriteLine("1.-Orchata\n2.-Jamaica\n3.-Limón\n4.-Mango");
                                Console.Write("Agua de medio litro " + z + ": ");
                                int a = Convert.ToInt16(Console.ReadLine());
                                if (a > 4)
                                {
                                    Console.WriteLine("Ingrese una opcion valida!");
                                    Console.ReadKey();
                                    z--;
                                }
                            }
                        }                      
                    }
                    opcion = 0;
                    while (opcion != 1 && opcion != 2)
                    {
                        Console.Write("¿Desea comprar algun otro tipo de bebida?  (1)si  (2)no : ");
                        opcion = Convert.ToInt16(Console.ReadLine());
                        if (opcion > 2)
                        {
                            Console.WriteLine("Ingrese una opcion valida!");
                            Console.ReadKey();
                        }
                    }
                }
            } while (opcion != 2);
            subb += TR + TJ + TA;
            Console.WriteLine("El subtotal de su compra de bebidas es: $" + subb);
            TR = 0; TJ = 0; TA = 0;
            Console.ReadKey();
        }
        static void golocinas()
        {
            while (opcion != 8)
            {
                Console.Clear();
                Console.WriteLine("¿Cual de las siguientes golocinas le gustaria comprar?");
                Console.WriteLine("1.-Empanadas\n2.-Chicles\n3.-Pastillas de menta\n4.-Chocolate\n5.-Mazapan\n6.-Paleta\n7.-Pulparindo");
                Console.Write("Ingrese el numero correspondiente al la golocina deseada: ");
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("¿Cuantas empanadas quiere?: ");
                        cantidad = Convert.ToInt16(Console.ReadLine());
                        TE += cantidad * 10;
                        Console.Clear();
                        for (int x = 1; x <= cantidad; x++)
                        {
                            Console.Clear();
                            Console.WriteLine("Tenemos empanadas de...\n1.-Fresa\n2.-Piña\n3.-Cajeta");
                            Console.Write("Empanada " + x + ": ");
                            opcion = Convert.ToInt16(Console.ReadLine());
                            if (opcion > 3)
                            {
                                Console.WriteLine("Elija una opcion valida!");
                                Console.ReadKey();
                                x--;
                            }
                        }
                        Console.WriteLine("Costo de " + TE / 10 + " empanadas = $" + TE);
                        break;
                    case 2:
                        Console.Write("¿Cuantos chicles quiere?: ");
                        cantidad = Convert.ToInt16(Console.ReadLine());
                        TC += cantidad * 2;
                        Console.WriteLine("Costo de " + TC/2 + " chicles = $" + TC);
                        break;
                    case 3:
                        Console.Write("¿Cuantas pastillas de menta quiere?: ");
                        cantidad = Convert.ToInt16(Console.ReadLine());
                        TP += cantidad * 2;
                        Console.WriteLine("Costo de " + TP/2 + " Pastillas de menta = $" + TP);
                        break;
                    case 4:
                        Console.Write("¿Cuantos chocolates quiere?: ");
                        cantidad = Convert.ToInt16(Console.ReadLine());
                        TCH += cantidad * 6;
                        Console.WriteLine("Costo de " + TCH/6 + " chocolates = $" + TCH);
                        break;
                    case 5:
                        Console.Write("¿Cuantos mazapanes quiere?: ");
                        cantidad = Convert.ToInt16(Console.ReadLine());
                        TMZ += cantidad * 5;
                        Console.WriteLine("Costo de " + TMZ/5 + " mazapanes = $" + TMZ);
                        break;
                    case 6:
                        Console.Write("¿Cuantas Paletas quiere?: ");
                        cantidad = Convert.ToInt16(Console.ReadLine());
                        TPA += cantidad * 3;
                        Console.WriteLine("Costo de " + TPA/3 + " paletas = $" + TPA);
                        break;
                    case 7:
                        Console.Write("¿Cuantos pulparindos quiere?: ");
                        cantidad = Convert.ToInt16(Console.ReadLine());
                        TPU += cantidad * 4;
                        Console.WriteLine("Costo de " + TPU/4 + " pulparindos = $" + TPU);
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida!");
                        Console.ReadKey();
                        break;
                }
                if (opcion > 7)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    opcion = 0;
                    while (opcion != 1 && opcion != 2)
                    {
                        Console.Write("¿Desea comprar alguna otra golocina?  (1)si  (2)no : ");
                        opcion = Convert.ToInt16(Console.ReadLine());
                        if (opcion > 2)
                        {
                            Console.WriteLine("Ingrese una opcion valida!");
                            Console.ReadKey();
                        }                       
                    }
                    if ( opcion == 2)
                    {
                        opcion = 8;
                    }                  
                }
            }
            subgol += TE + TC + TP + TCH + TMZ + TPA + TPU;
            Console.WriteLine("El subtotal de su compra de golocinas  es de: $" + subgol);
            TE = 0; TC = 0; TP = 0; TCH = 0; TMZ = 0; TPA = 0; TPU = 0;
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la fonda ''Messirve''");
            Console.WriteLine("A continuacion se mostrara el menu de opciones para efectuar sus compras");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadKey();
            while ( opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1.-Comprar Gorditas \n2.-Comprar Bebidas \n3.-Comprar Golosinas \n4.-Pagar cuenta ");
                Console.Write("Ingrese el numero de la opcion que desea: ");               
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        gorditas();
                        break;
                    case 2:
                        bebidas();
                        break;
                    case 3:
                        golocinas();
                        break;
                    case 4:
                        Total = subg + subb + subgol;
                           if ( Total == 0  )
                           {
                            Console.WriteLine("Usted debe realizar por lo menos una compra para poder salir de el programa!");
                            opcion = 0;
                            Console.ReadKey();
                           }
                           else
                           {
                            while (cantidad < Total)
                            {
                                Console.WriteLine("El Total de sus compras es de: $" + Total);
                                Console.Write("Con cuanto desea Pagar? $");
                                cantidad = Convert.ToInt16(Console.ReadLine());
                                int cambio = cantidad - Total;
                                if (cantidad < Total)
                                {
                                    Console.WriteLine("Debe pagar con una cantidad mayor al total de sus compras!!");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Gracias por su compra :^)\nsu cambio es de: $ " + cambio);
                                    Console.Write("Vuelva pronto y que tenga un buen dia ;^)");
                                    Console.ReadKey();
                                }
                            }
                           }                        
                        break;
                    default:
                        Console.WriteLine("aaa sos re trol\nIngrese una opcion valida porfavor!");
                        Console.ReadKey();
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("°°°°  °°°°°      °      °°°°°     °   °  °°°");
            Console.WriteLine("°     °         ° °     °          ° °   °  °");
            Console.WriteLine("°°°°  °°°°°    °°°°°    °°°°°       °    °   °");
            Console.WriteLine("   °  °       °     °   °          ° °   °  °");
            Console.WriteLine("°°°°  °°°°°  °       °  °         °   °  °°°");
            Console.ReadKey();
        }
    }
}
