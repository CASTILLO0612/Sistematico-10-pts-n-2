using Microsoft.VisualBasic;
class Dari
{

   static bool continuar = true;

    static void Main()
    {
        

        do
        {


            Console.WriteLine("Segundo Sistematico");
            Console.WriteLine("1.Calculo del total a pagar");
            Console.WriteLine("2.Numero de alumnos aprobados");
            Console.WriteLine("3.Programa que sume 100 numeros");
            Console.WriteLine("4.Algoritmo que calcule la suma de N numeros");
            Console.WriteLine("5.Algoritmo que pida una clave");
            Console.WriteLine("6.Algortimo que visualice la cuenta de numeros");
            Console.WriteLine("7.Problema geometrico");
            Console.WriteLine("8.Programa que calcule en forma de tabla");
            Console.WriteLine("Escoja una opcion");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    double subTotal;
                    double totalAPagar;
                    double descuento = 0;

                    Console.WriteLine("Ingrese el nombre el cliente");
                    string nombre_Client = Console.ReadLine();

                    Console.WriteLine("Ingrese la cantidad de productos");
                    int cantidadProducto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el precio el producto");
                    double precioProducto = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el tipo de Cliente");
                    string tipoClient = Console.ReadLine();


                    subTotal = cantidadProducto * precioProducto;

                    if (tipoClient.ToUpper() == "A" || cantidadProducto >= 100)
                    {

                        Console.WriteLine("El descuento es del 10% ");
                        descuento = subTotal * 10 / 100;


                    }

                    else if (tipoClient.ToUpper() == "B")

                    {

                        Console.WriteLine("El descuento es del 5%");

                        descuento = subTotal * 5 / 100;

                    }

                    else

                    {
                        Console.WriteLine(" El cliente no aplica para descuentos");

                    }

                    double impuestoAPlicado;

                    impuestoAPlicado = subTotal * 0.15;
                    subTotal = subTotal - descuento;
                    totalAPagar = subTotal + impuestoAPlicado;
                    //factura o registro de pago

                    Console.WriteLine("=====================");


                    Console.WriteLine("Nombre del cliente: " + nombre_Client + "| Tipo de cliente: " + tipoClient.ToUpper() + "| Descuento: " + descuento);
                    Console.WriteLine("El descuento es de: " + descuento);
                    Console.WriteLine("subtotal: " + subTotal + "$");

                    Console.WriteLine("impuesto: " + impuestoAPlicado + "$");

                    Console.WriteLine("total a pagar: " + totalAPagar + "$");


                    Console.WriteLine("=================================");

                    break;

                case 2:
                    Alumnos alumnos = new Alumnos();
                    bool cont = true;
                    int estudiantesReprobados = 0;
                    int estudiantesAprobados = 0;

                    do
                    {
                        alumnos.PedirDatos();
                        int notaFinal = alumnos.CalcularNotaTotal();
                        if (notaFinal < 60)
                        {
                            estudiantesReprobados++;
                        }
                        else if (notaFinal > 60)
                        {

                            estudiantesAprobados++;
                        }

                        alumnos.VerificacionNota(notaFinal);



                        bool verf = true;
                        do
                        {

                            Console.WriteLine("Desea continuar agregando estudiantes? (1 = si / 2 = no)");
                            int verificacion = int.Parse(Console.ReadLine());

                            if (verificacion == 2)
                            {
                                cont = false;
                                verf = false;
                            }
                            else if (verificacion == 1)
                            {
                                cont = true;
                                verf = false;
                            }
                            else
                            {
                                Console.WriteLine("Fuera del rango");
                                verf = true;
                            }
                        } while (verf);


                    } while (cont);

                    Console.WriteLine("El total de alumnos es de: " + (estudiantesAprobados + estudiantesReprobados));
                    Console.WriteLine("Estudiantes aprobados: " + estudiantesAprobados);
                    Console.WriteLine("Estudiantes reprobados: " + estudiantesReprobados);
                    break;

                case 3:
                     int suma = 0;
                     int inicio;

                    Console.WriteLine("Dijite el inicio para sumar los 100 numeros");
                    inicio = int.Parse(Console.ReadLine());
                    if (inicio >= 0)
                    {
                        for (int i = inicio; i < (inicio + 100); i++)
                        {
                            suma += i;

                        }
                        Console.WriteLine("La suma es = " + suma);
                    }
                    else if (inicio < 0)
                    {
                        for (int i = inicio; i > (inicio - 100); i--)
                        {
                            suma += i;
                        }
                        Console.WriteLine("La suma es = " + suma);
                    }




                    break;

                case 4:
                    int dimension;
                    Console.Write("Dijite el numero N: ");
                    dimension = int.Parse(Console.ReadLine());
                    int contador = 0;
                    int u = dimension + 1;
                    int sumando=0;

                    

                    while (contador < dimension)
                    {
                        if ((u) % 2 == 0)
                        {

                            
                            sumando += u;
                            contador++;
                            Console.WriteLine(u);
                        }
                        u++;
                    }
                    Console.WriteLine("WHILE");
                    Console.WriteLine("La suma de los " + dimension + " numeros pares despues de " + dimension + " es = " + sumando);
                    Console.WriteLine("FOR");
                    for (int i = 0; i < dimension; i++)
                    {
                        if (u % 2 == 0)
                        {
                            sumando += u;
                        }
                    }
                    Console.WriteLine("La suma de los " + dimension + " numeros pares despues de " + dimension + " es = " + sumando);

                    break;
                   
                case 5:

                    string password = "eureka";
                    int c = 0;
                    do
                    {
                      
                        Console.Write($"Dijite el password para poder ingresar (Attempt = {c+1}): ");
                        password = Console.ReadLine();
                        if (password != "eureka")
                        {
                            c++;

                            if (c == 3)
                            {
                                Console.WriteLine("Contraseña incorrecta. Agotaste tus intentos.");
                                continuar= false;
                                
                            }
                            continue;
                        }
                       
                        else
                        {
                            Console.WriteLine("Contraseña correcta.");
                            continuar = false;
                            
                        }

                    } while (continuar);

                    break;

                 

                case 6:
                    int sum2 = 0;
                    int suma_total = 0;
                    for (int i = 0; i <= 100; i++)
                    {
                        if (i % 2 == 0)
                        {
                            sum2 += i;
                        }
                        if (i % 3 == 0)
                        {
                            sum2 += i;
                        }
                        suma_total = sum2;

                    }
                    Console.WriteLine("La suma de los numeros multiplos de 2 y multiplos de 3 del 1-100 es = " + suma_total);


                    break;

                case 7:

                    Triangulo__A_B_C_ triangulo = new Triangulo__A_B_C_();

                    triangulo.PedirDatos();
                    triangulo.CalcularPerimetro();
                    triangulo.EsEquilatero();


                    break;

                case 8:
                    Console.WriteLine("Ingrese el valor de N para calcular su tabla exponencial ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("n     " + "\t " + "    n^2     " + "\t " + "    n^3     " + "\t " + "    n^4     ");

                    for (int i = 1; i < n; i++)
                    {
                        Console.WriteLine(i + " \t      " + Math.Pow(i, 2) + " \t      " + Math.Pow(i, 3) + " \t      " + Math.Pow(i, 4));
                    }

                    break;


                default:

                    break;


            }
        } while (continuar);
    }
}
class Alumnos
{
    private string nombreDelAlumno;
    private int notaExamen;
    private int notaAcumulada;
    public bool aprobado = true;

    public string NombreDelAlumno { get => nombreDelAlumno; set => nombreDelAlumno = value; }
    public int NotaExamen { get => notaExamen; set => notaExamen = value; }
    public int NotaAcumulada { get => notaAcumulada; set => notaAcumulada = value; }

    public Alumnos(string nombreDelAlumno, int notaExamen, int notaAcumulada)
    {
        this.NombreDelAlumno = nombreDelAlumno;
        this.NotaExamen = notaExamen;
        this.NotaAcumulada = notaAcumulada;
    }



    public Alumnos()
    {
    }


    public void PedirDatos()
    {
        Console.WriteLine("Ingrese el nombre del alumno");
        nombreDelAlumno = Console.ReadLine();
        Console.WriteLine("Ingrese la nota del acumulado");
        notaAcumulada = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la nota del examen del alumno");
        notaExamen = int.Parse(Console.ReadLine());
    }
    public int CalcularNotaTotal()
    {
        int notaFinal = notaAcumulada + notaExamen;
        return notaFinal;
    }
    public void VerificacionNota(int notaFinal)
    {
        if (notaFinal >= 60 && notaFinal < 75)
        {
            Console.WriteLine("El alumno aprobo limpio con una nota de " + notaFinal);
        }
        else if (notaFinal > 76 && notaFinal < 89)
        {
            Console.WriteLine("El alumno aprobo satisfctoriamente con una nota de " + notaFinal);
        }
        else if (notaFinal >= 90 && notaFinal <= 100)
        {
            Console.WriteLine("El alumno aprobo con excelencias con una nota de " + notaFinal);
        }
        else
        {
            Console.WriteLine("el alumno esta reprobado");
        }
    }
}
class Triangulo__A_B_C_
    {
        double l1;
        double l2;
        double l3;
        double perimetro;



        public Triangulo__A_B_C_()
        {
        }

        public Triangulo__A_B_C_(double l1, double l2, double l3)
        {
            this.L1 = l1;
            this.L2 = l2;
            this.L3 = l3;
        }


        public double L1 { get => l1; set => l1 = value; }
        public double L2 { get => l2; set => l2 = value; }
        public double L3 { get => l3; set => l3 = value; }


        public void PedirDatos()
        {

            Console.WriteLine("Digite el primer lado");
            L1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo lado ");
            L2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el Tercer lado");
            L3 = double.Parse(Console.ReadLine());
           

        }

        public void CalcularPerimetro()
        {
           
            if (L1 > 0 && L2 > 0 && L3 > 0)
            {
                perimetro = L1 + L2 + L3;
                Console.WriteLine("El perimetro es " + perimetro);
            }
            else
            {
               Console.WriteLine("El perimetro no se puede calcular");
            }
            
            
        }
        public void EsEquilatero()
        {
            if (L1 < 0 || L2 < 0 || L3 < 0)
            {
                Console.WriteLine("Los Vectores no forman un Triángulo");
            } else
            {
                if (L1 == L2 && L1 == L3)
                {
                    Console.WriteLine("El triangulo el equilatero ");
                }
                else
                {
                    EsIsoseles();
                }
            }
           
        }
        public void EsIsoseles()
        {
            if (L1 == L2 || L1 == L3 || L2 == L3)
            {
                Console.WriteLine("El triangulo el isoseles  ");
            }
            else 
            {
                Console.WriteLine("El triangulo es escaleno ");
            }
           
        }
    }




