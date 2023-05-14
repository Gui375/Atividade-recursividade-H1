//atividade 1 
//int resultado = calcularxn(3, 2); //3^2
//Console.WriteLine(resultado);   

//int calcularxn(int x, int n)
//{
//if (n == 0) return 1;                       //ponto parada
//return x * calcularxn(x, n - 1);            // recursividade
//3* calcularxn(3,2-1) 3 * 3 = 9
//3* cal8cularxn(3,(1-1) =  3 * 1 =3 
//return 1
//
//}


// ATIVIDADE 2
//int numero_Repeticao = 5;
//int[] vetor = new int[numero_Repeticao];

//for (int i = 0; i < vetor.Length; i++)
//{
//    vetor[i] = i+1;   
//}


//Console.WriteLine(CalcularSomaVetor(vetor,numero_Repeticao));

//int CalcularSomaVetor(int[] vetorB, int n)
//{
//        if (n==0) return 0; // ponto de parada
//        return vetorB[n-1]+ CalcularSomaVetor(vetor,n-1);
//}


//ATIVIDADE 3 
//int[] VETOR = new int[5];
//Console.WriteLine("Valores do vetor de 1 a 5 \n");
//    for (int i = 0; i < VETOR.Length; i++)
//    {
//        VETOR[i] = i+1;
//    }
//    foreach (var item in VETOR)
//    {
//        Console.WriteLine(item);
//    }
//int Resultado = Inverter_Vetor(VETOR, 0, 4);
//Console.WriteLine("Vetor invertido\n");
//    foreach (var item in VETOR)
//    {   
//        Console.WriteLine(item);
//    }

//int Inverter_Vetor(int[] Vetor_metodo, int começo, int fim)
//{
//    int i = Vetor_metodo[começo];
//    Vetor_metodo[começo] = Vetor_metodo[fim]; // Atribui o último elemento do vetor na primeira posição
//    Vetor_metodo[fim] = i;             // Atribui o valor armazenado na variável temporária na última posição

//    if (começo >= fim) return 0; //Ponto de parada 
//    return Inverter_Vetor(Vetor_metodo, começo + 1, fim - 1); // Recursividade
//}


//ATIVIDADE 4

//Console.WriteLine("Digite o numero para ser convertido para binario: ");
//int numero = int.Parse(Console.ReadLine());
//Console.WriteLine(Conversao(numero));
//string Conversao(int numeroBIN)
//{
//    if (numeroBIN == 0) return "";
//    int resto = numeroBIN % 2;
//    return Conversao(numeroBIN / 2) + resto.ToString();
   
//}


