
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Bienvenido a la Mision Stark");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Seleccione una opción: ");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("1. Crear Archivo");
        Console.WriteLine("2. Agregar Invento");
        Console.WriteLine("3. Leer Linea Por Linea");
        Console.WriteLine("4. Leer todo el Texto");
        Console.WriteLine("5. Copiar Archivo");
        Console.WriteLine("6. Mover Archivo");
        Console.WriteLine("7. Crear Carpeta");
        Console.WriteLine("8. Verificar Existencia de Archivo");
        Console.WriteLine("9. Eliminar Archivo");
        Console.WriteLine("10. Listar Archivos");
        Console.WriteLine("11. Salir");
Console.WriteLine("----------------------------------");
Console.WriteLine("----------------------------------");
int opcion = int.Parse(Console.ReadLine());

//Todo el proyecto lo realizamos en un switch case para que sea mas facil de entender y de ejecutar.
//Ya que la tarea pasada si la realice aparte por que era más compleja.

switch (opcion)
        {
            case 1:
                void CrearArchivo() //Aca se procede a crear la función que hara el archivo.
                {
                    string path = "C:\\ProyectoP1\\MisionStark\\inventos.txt";
                    string contenido = "\n 1. Traje Mark 1 \n 2. Reactor Arc \n 3. Inteligencia Artificial JARVIS\n ";
                    File.WriteAllText(path, contenido);
                    Console.WriteLine("Archivo creado");

            try
            //Se agrega un try catch para que si hay un error en el programa no se cierre.
            {
                File.WriteAllText(path, contenido);
            }
            catch (FileNotFoundException err)
            {
                Console.WriteLine("El archivo buscado no existe, Ultron debe haberlo borrado :( ");
            }
            catch (DirectoryNotFoundException err)
            {
                Console.WriteLine("La Carpeta no existe, Ultron debe haberlo borrado :( ");
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err.Message);
            }
            Console.WriteLine("Archivo creado con exito");

        }
                CrearArchivo(); //Habia tenido problemas ya que la estaba declarando hasta abajo fuera del
                break; //lo cual hacia que el programa no lo reconociera.

    case 2:
                void AgregarInvento() //Aca se agregara el dato que ya estaba predeterminado en el pdf.
                {
                    string path = "C:\\ProyectoP1\\MisionStark\\inventos.txt";
                    string linea = "3. Drones de Combate \n ";
                    File.AppendAllLines(path, new string[] { linea });
                    Console.WriteLine("Linea agregada");
                }
                AgregarInvento();//se declara la función para que se pueda ejec.
        break;

            case 3:
                void LeerLineaPorLinea() //Se procede a realizar la función que leera el archivo linea por linea.
        {
                    string path = "C:\\ProyectoP1\\MisionStark\\inventos.txt";
                    string[] lineas = File.ReadAllLines(path);
                    foreach (string linea in lineas)
                    {
                        Console.WriteLine(linea);
                    }
                }
                LeerLineaPorLinea(); 
                break;

            case 4: 
                void LeerTodoElTexto() //Esta función tambien es util para leer archivos muy grandes como la lista que vimos en clase.
                {
                    string path = "C:\\ProyectoP1\\MisionStark\\inventos.txt";
                    string contenido = File.ReadAllText(path);
                    Console.WriteLine("contenido: ");
                    Console.WriteLine(contenido);
                }
                LeerTodoElTexto();
                break;

            case 5:
                void CopiarArchivo() //Esta función es para copiar el archivo que ya se creo.
                {
                    string pathOrigen = "C:\\ProyectoP1\\MisionStark\\inventos.txt";
                    string pathDestino = "C:\\ProyectoP1\\MisionStark\\backup\\inventos2.txt"; // aca solo se agrega la nueva direccion donde se guardara y se creaa la copia.
                    File.Copy(pathOrigen, pathDestino);
                    Console.WriteLine("Archivo copiado");
                }
                CopiarArchivo();
                break;

            case 6:
                void MoverArchivo() //Para realizar esta función se necesita que la carpeta ya exista.
                {
                    string pathOrigen = "C:\\ProyectoP1\\MisionStark\\inventos.txt";
                    string pathDestino = "C:\\ProyectoP1\\MisionStark\\ArchivosClasificados\\movidos.txt"; // y solo realizamos el .txt desde el programa.
                    File.Move(pathOrigen, pathDestino);
                    Console.WriteLine("Archivo movido exitosamente, primero Dios...");
                }
                MoverArchivo();
                break;

            case 7:
                void CrearCarpeta() //Gracias a los condicionales se puede verificar si la carpeta ya existe o no, pero en este caso
        {                           //se realizo desde el programa y esta vacia.

                    string path = "C:\\ProyectoP1\\MisionStark\\Proyectos-Ultra-Secretos";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                        Console.WriteLine("Carpeta creada");
                    }
                    else
                    {
                        Console.WriteLine("La carpeta ya existe");
                    }
                }
                CrearCarpeta();
                break;

            case 8:
                void VerificarExistencia()
                {
                    string path = "inventos.txt";
                    if (File.Exists(path))
                    {
                        Console.WriteLine("El archivo existe");
                    }
                    else
                    {
                        void CrearArchivo()
                        {
                            string path = "C:\\ProyectoP1\\MisionStark\\inventos.txt";
                            string contenido = "Archivo de prueba"; 
                            File.WriteAllText(path, contenido);
                            Console.WriteLine("Archivo creado....");

                        }
                       
                    }
                }
                VerificarExistencia();
                CrearArchivo();
                break; 

            case 9:

                void EliminarArchivo()//la función funciona eficazmente y elimina el .txt especifico.
        {
                    string Archivo = "C:\\ProyectoP1\\MisionStark\\inventos.txt";
                    File.Delete(Archivo);
                    Console.WriteLine("Archivo eliminado con eficacia");
                }
                EliminarArchivo();
                break;

            case 10: 
                void ListarArchivos()//aca se enlistan los archivos que se encuentran en la carpeta, si se elimina el archivo .txt
        {                            //solo mostrara el archivo .sln de visual studio.

            string path = "C:\\ProyectoP1\\MisionStark";
                    if (Directory.Exists(path))
                    {
                        foreach (var archivo in Directory.GetFiles(path))
                        {
                            Console.WriteLine(archivo);
                        }    
                    }
                    else
                    {
                     Console.WriteLine("No existe la carpeta");
                    }
                }
                ListarArchivos();
                break;

            case 11: //Se cierra el programa.
        Console.WriteLine("Hasta luego, Tony Stark (No me quiero ir Sr. Stark)");
                break;
        }
        //Jhony Abraham de León Pérez 0905-24-22282
   
    



