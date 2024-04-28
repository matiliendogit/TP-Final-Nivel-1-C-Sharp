namespace TPFinal;
class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.
        // A partir de dichos datos informar:
        //     a. El mayor de los números pares.
        //     b. La cantidad de números impares.
        //     c. El menor de los números primos.

        int numeros, mayorPares = 0, contaImpares = 0, menorPrimos = 0;
        bool banderaPar = false, banderaPrimo = false;

        Console.WriteLine("Ingrese un numero entero ");
        numeros = int.Parse(Console.ReadLine());

        while (numeros != 0){

            if(par(numeros)){
                if (!banderaPar){
                    mayorPares = numeros;
                    banderaPar = true;
                }else if (numeros > mayorPares)
                    mayorPares = numeros;
                }else 
                contaImpares ++;

            if (primo(numeros))
                if (!banderaPrimo){
                    menorPrimos = numeros;
                    banderaPrimo = true;
                }else if (numeros < menorPrimos){
                    menorPrimos = numeros; 
                }           
            
            Console.WriteLine("Ingrese otro numero entero o cero para terminar");
            numeros = int.Parse(Console.ReadLine());
        }

        //a:
        if (banderaPar)
            Console.WriteLine("El mayor de los numeros pares es el " + mayorPares);
        else
            Console.WriteLine("No hay numeros pares");

        //b:
        Console.WriteLine("La cantidad de numeros impares es igual a: " + contaImpares + " numeros");

        //c:
        if (banderaPrimo)
            Console.WriteLine("El menor de los numeros primos es " + menorPrimos);
        else 
            Console.WriteLine("No hay numeros primos");
      
    }

    static bool par (int nro){
        if (nro % 2 == 0)
            return true;
        else    
            return false;
    }

    static bool primo (int nro){
        int contador = 0;

        for (int x = 1; x < 10 && x < nro; x++)
        {
            if (nro % x == 0)
                contador++;
        }
        if (contador == 1)
            return true;
        else
            return false;
    }

}
