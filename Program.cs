string frase1; 
string frasecensurada;
Console.WriteLine("Me diga o que você pensa sobre o aluno que não faz a lição de casa:");
frase1 = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Eu sou uma criança educada. No seu lugar eu diria:");
frasecensurada = frase1
                    .Replace("chato", "#@$%*!&")
                    .Replace("chata", "#@$%*!&")
                    .Replace("bobo", "#@$%*!&")
                    .Replace("boba", "#@$%*!&")
                    .Replace("boboca", "#@$%*!&")
                    .Replace("bocó", "#@$%*!&")
                    .Replace("tonto", "#@$%*!&")
                    .Replace("tonta", "#@$%*!&")
                    .Replace("palerma", "#@$%*!&")
                    .Replace("paspalho", "#@$%*!&")
                    .Replace("paspalha", "#@$%*!&")
                    .Replace("tantã", "#@$%*!&")
                    .Replace("panaca", "#@$%*!&")
                    .Replace("pentelho", "#@$%*!&")
                    .Replace("pentelha", "#@$%*!&")
                    .Replace("burro", "#@$%*!&")
                    .Replace("burra", "#@$%*!&")
                    .Replace("besta", "#@$%*!&")
                    .Replace("imbecil", "#@$%*!&");

Console.WriteLine($"{frasecensurada}");
