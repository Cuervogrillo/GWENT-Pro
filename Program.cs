using CartaBaseDeDatos;
using System.Text.Json;

///----------- DECK 1(RELIGION)----------
// CartaLider Dios = new CartaLider ("Dios", "Siempre perdona a quienes admiten sus pecados. Aumenta 2 puntos de poder a todas las unidades de Religion.", "Religion");
// CartaUnidad Monje = new CartaUnidad ("Monje", "M", 4, "Muestra el camino del zen a las unidades de su misma fila. Aumenta 3 puntos de poder de cada una.", "Plata", "Religion");
// CartaUnidad Zeus = new CartaUnidad ("Zeus", "S", 8, "Con su rayo destruye la unidad enemiga con menos poder.", "Plata", "Religion");
// CartaUnidad Valkyria = new CartaUnidad ("Valkyria", "R", 6, "Desciende del Valhalla rapidamente para llevarse a los guerreros caidos. Roba 1 carta.", "Plata", "Religion");
// CartaUnidad Ra = new CartaUnidad ("Ra, el dios del Sol", "S", 7, "Invoca un sol insoportable que aniquila a la unidad mas poderosa del campo.", "Plata", "Religion");
// CartaUnidad Cruzado = new CartaUnidad ("Cruzado", "M,R,S", 0, "Reemplaza a otra en el campo y la devuelve a tu mano", "Plata", "Religion");
// CartaUnidad Sacerdote = new CartaUnidad ("Sacerdote", "R", 2, "Sin efecto", "Plata", "Religion");
// CartaUnidad Marte = new CartaUnidad ("Marte", "M", 3, "Sin efecto", "Plata", "Religion");
// CartaUnidad Kratos = new CartaUnidad ("Kratos, el Dios de la Guerra", "M", 10, "Sin Efecto", "Oro", "Religion");
// CartaClima Poseidon = new CartaClima ("Furia de Poseidon", "Fuerte tempestad que afecta a las unidades cuerpo a cuerpo. Resta 4 puntos de poder a dichas unidades.");
// CartaClima SolMuerto = new CartaClima ("Sol Muerto", "Ambiente Sombrio que afecta el poder de las unidades de distancia y asedio.");

StreamReader reader = new StreamReader("Cartas.txt");
string text = reader.ReadToEnd();
string[] lines = text.Split('\n');
System.Console.WriteLine(lines[5]);
