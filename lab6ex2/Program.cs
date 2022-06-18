using System;
using System;

namespace ConsoleApp2
{
    using System;

    namespace lab62
    {
        class NumarInmatriculare
        {
            private string Judet;
            private int numar;
            private string litere;
            public NumarInmatriculare(string judet, int numar, string litere)
            {
                this.Judet = Judet;
                this.numar = numar;
                this.litere = litere;
              
            }
            public string GetDescription()
            {
                return this.NumarInmatriculare;
            }
            
            public void Tipareste()
            {
                Console.WriteLine("Numar Inmatriculare este:{judet} {numar} {litere}");
            }
        }
        class Marca
        {
            private string nume;
            public Marca(string nume)
            {
                this.nume = nume;
            }
            public string GetDescription()
            {
                return this.nume;
            }
            public void Tipareste()
            {
                Console.WriteLine("Marca masina este:{nume}");
            }
            class CapacitateCilindrica
            {
                private int capacitate;
                public CapacitateCilindrica(int capacitate)
                {
                    this.capacitate = capacitate;

                }
                public int GetDescription()
                {
                    return this.capacitate;

                }
                public void Tipareste()
                {
                    Console.WriteLine("Capacitate cilindrica este:{capacitate}");
                }

                class Masina
                {
                    private Marca[] marca;
                    private NumarInmatriculare NumarInmatriculare;
                    private CapacitateCilindrica capacitateCilindrica;

                    public Masina(string Marca, int CapacitateCilindrica, string NumarInmatriculare)
                    {
                        this.marca = marca;
                        this.NumarInmatriculare = NumarInmatriculare;
                        this.capacitateCilindrica = capacitateCilindrica;
                    }
                    public void Tipareste()
                    {
                        Console.WriteLine("Masina cu marca");
                        Marca.Tipareste();
                        Console.WriteLine("Masina cu numarul de inmatriculare");
                        NumarInmatriculare.Tipareste();
                        Console.WriteLine("Masina cu o capacitate cilindrica");
                        capacitateCilindrica.Tipareste();
                    }
                }
            }
        }
    }
}