using System;

namespace PilhaObjeto
{
    class Pilha
    {
        private int info;
        private Pilha next;

        public Pilha()
        {
            info = 0;
            next = null;
        }

        // Método PUSH (Inserir)
        public void Push(int n, ref Pilha TOPO)
        {
            this.info = n;
            this.next = TOPO;
            TOPO = this;
        }

        // Método POP (Remover) - Retorna o valor removido
        public static int Pop(ref Pilha TOPO)
        {
            if (TOPO == null)
            {
                throw new Exception("A pilha está vazia!");
            }

            int valor = TOPO.info; // Salva o valor do topo
            TOPO = TOPO.next;      // O topo passa a ser o próximo elemento
            return valor;
        }

        // Método de Listagem
        public static void Listar(Pilha TOPO)
        {
            if (TOPO == null)
            {
                Console.WriteLine("Pilha Vazia!");
                return;
            }

            Pilha aux = TOPO;
            Console.WriteLine("--- Elementos na Pilha ---");
            while (aux != null)
            {
                Console.WriteLine($"[ {aux.info} ]");
                aux = aux.next; // Percorre para o próximo
            }
            Console.WriteLine("--------------------------");
        }

        // Método Consulta (Peek) - Apenas vê o topo sem remover
        public static int Consulta(Pilha TOPO)
        {
            if (TOPO == null) throw new Exception("Pilha Vazia!");
            return TOPO.info;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pilha TOPO = null;
            int n, escolha;
            Pilha pp;

            do
            {
                Console.WriteLine("\n Menu Principal");
                Console.WriteLine("(1) - Insere um elemento (Push)");
                Console.WriteLine("(2) - Remove um elemento (Pop)");
                Console.WriteLine("(3) - Consulta o Topo");
                Console.WriteLine("(4) - Imprime a Pilha");
                Console.WriteLine("(5) - Sair");
                Console.Write("Escolha: ");

                if (!int.TryParse(Console.ReadLine(), out escolha)) continue;

                switch (escolha)
                {
                    case 1:
                        pp = new Pilha();
                        Console.Write("Entre com um numero: ");
                        n = int.Parse(Console.ReadLine());
                        pp.Push(n, ref TOPO);
                        Console.WriteLine("Inserido com sucesso!");
                        break;

                    case 2:
                        try
                        {
                            int removido = Pilha.Pop(ref TOPO);
                            Console.WriteLine($"Elemento {removido} removido do topo.");
                        }
                        catch (Exception e) { Console.WriteLine(e.Message); }
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine($"Elemento no topo: {Pilha.Consulta(TOPO)}");
                        }
                        catch (Exception e) { Console.WriteLine(e.Message); }
                        break;

                    case 4:
                        Pilha.Listar(TOPO);
                        break;
                }

                if (escolha != 5)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (escolha != 5);
        }
    }
}