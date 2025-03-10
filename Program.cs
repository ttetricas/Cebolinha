        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        
        if (!string.IsNullOrEmpty(frase))
        {
            string fraseCebolinha = frase.Replace("r", "l").Replace("R", "L");
            Console.WriteLine("Cebolinha diz: " + fraseCebolinha);
        }
        else
        {
            Console.WriteLine("Você não digitou nada!");
        }
