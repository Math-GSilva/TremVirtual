using System;
using System.Collections.Generic;

namespace Train.App
{
    public class Train
    {
        public int Position { get; private set; } = 0;
        private int _consecutiveMovements = 0;
        private string _lastDirection = string.Empty;
        private const int MaxTotalMovements = 50;
        private const int MaxConsecutiveMovements = 20;

        public void DoTask(List<string> comandos)
        {
            int movimentosTotais = 0;

            foreach (var comando in comandos)
            {
                if (movimentosTotais >= MaxTotalMovements)
                {
                    Console.WriteLine("Limite de 50 movimentos alcançado. Trem parando.");
                    break;
                }

                string direction = comando;
                if (direction != "ESQUERDA" && direction != "DIREITA")
                {
                    Console.WriteLine($"Comando inválido: {comando}. Trem ignorou este comando.");
                    continue;
                }

                if (direction == _lastDirection)
                {
                    _consecutiveMovements++;
                    if (_consecutiveMovements > MaxConsecutiveMovements)
                    {
                        Console.WriteLine("Limite de 20 movimentos consecutivos na mesma direção alcançado. Trem mudando de direção.");
                        break;
                    }
                }
                else
                {
                    _consecutiveMovements = 1;
                    _lastDirection = direction;
                }

                if (direction == "ESQUERDA" && Position == 0)
                {
                    Console.WriteLine("Não há mais caminho para a esquerda. Comando ignorado!");
                }
                else
                {
                    Position += direction == "ESQUERDA" ? -1 : 1;
                    Console.WriteLine($"Andando para {direction.ToLower()}...");
                }

                movimentosTotais++;
            }
        }
    }
}
