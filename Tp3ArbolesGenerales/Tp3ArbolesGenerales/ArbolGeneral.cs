using System;
using System.Collections.Generic;

namespace Tp3ArbolesGenerales
{
	public class ArbolGeneral<T>
	{
		

		private NodoGeneral<T> raiz;

		public ArbolGeneral(T dato) {
			this.raiz = new NodoGeneral<T>(dato);
		}
	
		private ArbolGeneral(NodoGeneral<T> nodo) {
			this.raiz = nodo;
		}
	
		private NodoGeneral<T> getRaiz() {
			return raiz;
		}
	
		public T getDatoRaiz() {
			return this.getRaiz().getDato();
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			List<ArbolGeneral<T>> temp= new List<ArbolGeneral<T>>();
			foreach (var element in this.raiz.getHijos()) {
				temp.Add(new ArbolGeneral<T>(element));
			}
			return temp;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.raiz.getHijos().Add(hijo.getRaiz());
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.raiz.getHijos().Remove(hijo.getRaiz());
		}
	
		public bool esVacio() {
			return this.raiz == null;
		}
	
		public bool esHoja() {
			return this.raiz != null && this.getHijos().Count == 0;
		}

		//modificado DLCS
		public int altura()
		{
			if (esHoja()) { return 0; }
			else
			{
				int contador_de_hijos_horizontal = 0;
				int nivel_vertical = 0;
				int altura = 1;
				List<ArbolGeneral<T>> Lista_de_hijos = getHijos();
				ArbolGeneral<T> nivel_anterior = Lista_de_hijos[0];
				ArbolGeneral <T> nodo_actual = Lista_de_hijos[contador_de_hijos_horizontal];
				while (!nodo_actual.esHoja())
				{
					Lista_de_hijos = getHijos();
					nivel_vertical++;
					nivel_anterior = nodo_actual;
					nodo_actual = Lista_de_hijos[contador_de_hijos_horizontal];

					if (altura< nivel_vertical) {
						altura = nivel_vertical;
					}

					if (nodo_actual.esHoja())
					{
						nivel_vertical--;
						contador_de_hijos_horizontal++;
						if (contador_de_hijos_horizontal < nodo_actual.getHijos().Count)
						{
							Lista_de_hijos = getHijos();
							nodo_actual = Lista_de_hijos[contador_de_hijos_horizontal];
						}
						else {
							contador_de_hijos_horizontal = contador_de_hijos_horizontal - nivel_vertical;
							nodo_actual = nivel_anterior;
						}

					}
					
				}

				return altura;
			}
		}


			public int nivel(T dato) {
			return 0;
		}
	
	}
}
