// Calcule a velocidade, a partir da distância (Δd, em metros) e do tempo (Δt, em segundos).

double distancia;
double tempo;
double velocidade;

Console.WriteLine("--- Cálculo de Velocidade ---\n");

Console.Write("Digite a distância (em metros): ");
distancia = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o tempo (em segundos): ");
tempo = Convert.ToDouble(Console.ReadLine());

velocidade = distancia / tempo;

Console.WriteLine($"\nVelocidade: {velocidade:F2} m/s");