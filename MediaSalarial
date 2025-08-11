        float somaSalario = 0;
        float maiorSalario = 0;

        int imaiorSalrio = 0;


        for (int i = 0; i < funcionario.Length; i++)
        {
            Console.Write("Nome do funcionario " + (i+1) + ": ");
            funcionario[i] = Console.ReadLine();

            do
            {

                salario[i] = digita_Numero("Digite salario de " +
                    funcionario[i] + ": "," Valor é inválido");
                if(salario[i] < 1400)
                {
                    Console.Write("valor mmínimo do alário r$1400");
                }

            }while(salario[i] < 1400);

            somaSalario += salario[i];
            if (salario[i] > maiorSalario)
            {
                maiorSalario = salario[i];
                imaiorSalrio = i;
            }
        }

        float media = somaSalario / salario.Length;

       for(int i = 0;i < salario.Length;i++)
        {
            if (salario[i] > media)
            {
                Console.WriteLine(funcionario[i] + ", " + salario[i]);  
            }

            Console.WriteLine("maior salario: " + funcionario[imaiorSalrio] + ", " + salario[imaiorSalrio]);

            Console.ReadKey();
        }
    }



    public bool sim_ou_nao(string mensagem)
    {

        bool ok;

        Console.Write(mensagem);

        string sResp;

        do
        {

            sResp = Console.ReadLine();

        } while(sResp != "S" &&
                sResp != "N" &&
                sResp != "s" &&
                sResp != "n" &&
                sResp != "Y" &&
                sResp != "y");

        ok = (sResp == "S" || sResp == "s" ||
              sResp == "Y" || sResp == "y");

        return ok;

    }

    static float digita_Numero(string texto, string textoErro)
    {
        float retorno = 0;
        bool ok;

        do
        {

            Console.Write(texto);
            string sNum = Console.ReadLine();
            ok = float.TryParse(sNum, out retorno);
            if (!ok)
            {
                Console.WriteLine(textoErro);
            }

        }while (!ok);

        return retorno;

    }   
        
}
