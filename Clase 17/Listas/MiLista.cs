using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class MiLista<T> : IEnumerable<T>
    {
        private T[] lista;

        public int DatoDeMiLista
        {
            get
            {
                return 5;
            }
            set
            {
                if (value != 5)
                {
                    throw new Exception();
                }
            }
        }

        public T this[int t]
        {
            get
            {
                return this.lista[t];
            }
        }

        public MiLista()
        {
            this.lista = new T[0];
        }

        public void Add(T elemento)
        {
            Array.Resize(ref lista, lista.Length + 1);
            this.lista[lista.Length - 1] = elemento;
        }

        public void Remove(T elemento)
        {
            if (this.lista.Length >= 1)
            {
                int length = this.lista.Length;
                for (int i = 0; i < length; i++)
                {
                    if (this.lista[i].Equals(elemento))
                    {
                        for (int j = i+1; j < length; j++)
                        {
                            this.lista[j - 1] = this.lista[j];
                        }
                        Array.Resize(ref lista, lista.Length - 1);
                        break;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.lista[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get
            {
                int retorno = 0;
                foreach (T item in this.lista)
                {
                    retorno++;
                }
                return retorno;
            }
        }
    }
}
