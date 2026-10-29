//Desafío de la batalla del juego de rol

// Estas son las reglas para el juego de batalla que necesita implementar en el proyecto de código:

//Debes usar la instrucción do-while o la instrucción while como un bucle de juego externo.
//El héroe y el monstruo comenzarán con 10 puntos de salud.
//Todos los ataques tendrán un valor comprendido entre 1 y 10.
//El héroe ataca primero.
//Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
//Si la salud del monstruo es mayor que 0, puede atacar al héroe.
//Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
//Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
//Imprima el ganador.

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


//Administrar la entrada de usuario durante este desafío

/* 
Cuando se usa una instrucción Console.ReadLine() para obtener la entrada de usuario, 
es habitual usar una cadena de tipo que acepta valores NULL (designada string?) para la variable de 
entrada y, a continuación, evaluar el valor especificado por el usuario. El siguiente ejemplo de código utiliza una cadena de tipo que acepta valores NULL para capturar la entrada del usuario. La iteración 
continúa mientras el valor proporcionado por el usuario es NULL:

*/

string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);


/*  La expresión booleana evaluada por la instrucción while se puede usar para asegurarse de 
que la entrada del usuario cumple un requisito especificado. Por ejemplo, si un mensaje pide al 
usuario que escriba una cadena que incluya al menos tres caracteres, se podría usar el siguiente código:  */

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);

/*   
Si desea usar la entrada Console.ReadLine() para valores numéricos, debe convertir el valor de la cadena 
en un tipo numérico.

El método int.TryParse() se puede usar para convertir un valor de cadena en un entero. 
El método usa dos parámetros, una cadena que se evaluará y el nombre de una variable de 
entero a la que se asignará un valor. Este método devuelve un valor booleano. 
El código de ejemplo siguiente muestra el uso de int.TryParse():

 */

 // capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);

/*
Si el valor de cadena asignado a readResult representa un entero válido, el valor se asignará 
a la variable de entero denominada numericValue y true se asignará a la variable booleana denominada validNumber. Si el valor asignado a readResult no representa un entero válido, a validNumber se le asignará un valor de false. 
Por ejemplo, si readResult es igual a "7", el valor 7 se asignará a numericValue.
*/

/*

Proyecto de código 1: escritura de código que valida la entrada de enteros
Estas son las condiciones que el primer proyecto de codificación debe implementar:

La solución debe incluir una iteración do-while o while.

Antes del bloque de iteración: la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor de enteros entre 5 y 10.

Dentro del bloque de iteración:

La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
La solución debe asegurarse de que la entrada es una representación válida de un entero.
Si el valor del entero no está comprendido entre 5 y 10, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor del entero entre 5 y 10.
La solución debe garantizar que el valor de enteros está comprendido entre 5 y 10 antes de salir de la iteración.
Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.


*/


string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();


////////////////


/*

El código siguiente es una posible solución para el desafío que plantea el Proyecto 1 de la unidad anterior.

El código usa una instrucción do porque el bloque de código debe ejecutarse al menos una vez. 
También PUEDE usar while para lograr el mismo resultado. Algunos desarrolladores pueden 
pensar que la lógica de while hace que el código sea más legible. 
Si es así, puede optar por implementar una instrucción while aquí.

*/

string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();

/*

El código siguiente es una posible solución para el desafío que plantea el Proyecto 2 de la unidad anterior.

El código usa una instrucción do porque el bloque de código debe ejecutarse al menos una vez. 
También PUEDE usar while para lograr el mismo resultado. Algunos desarrolladores pueden pensar que 
la lógica de while hace que el código sea más 
legible. Si es así, puede optar por implementar una instrucción while aquí.

*/

string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();

/*
El código siguiente es una posible solución para el desafío que plantea el Proyecto 3 de la unidad anterior.

El código usa una instrucción for para el bucle externo porque no se puede modificar el valor asignado a 
una variable de iteración "foreach". Para solucionarlo declare una variable de cadena adicional en el bucle }
foreach, pero si lo hace, agregará una complejidad no deseada a la lógica del código. En otras palabras, si 
se usa la instrucción de iteración foreach (string myString in myStrings) y, luego, se intenta procesar la 
variable myString, se genera un error de compilación.

El código usa una instrucción while para el bucle interno porque, dependiendo del valor de la cadena 
de datos, es posible que el bloque de código no se ejecute (si la cadena no contiene un punto). No debe 
usar una instrucción do en situaciones en las que es posible que no sea necesario ejecutar el bloque de 
iteración.

*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}