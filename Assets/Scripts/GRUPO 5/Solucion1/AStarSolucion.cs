using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Assets.Scripts.DataStructures;
using UnityEngine;
using Assets.Scripts;
using UnityEditor.Experimental.GraphView;

namespace Assets.Scripts.AStarSolucion
{
    public class AStartMind : AbstractPathMind
    {
        // declarar Stack de Locomotion.MoveDirection de los movimientos hasta llegar al objetivo
        private Stack<Locomotion.MoveDirection> currentPlan;

        private Node<Locomotion.MoveDirection> Search(BoardInfo board, CellInfo start, CellInfo[] goals)
        {
            
            Stack<Node> listaAbierta = new Stack<Node>();   //LISTA VACIA DE NODOS

            Node nodoInicial = start;                       //NODO INICIAL

            listaAbierta.Push(nodoInicial);                 //SE AÑADE NODO INICIAL A LA LISTA

            // mientras la lista no esté vacia
            while (listaAbierta.Any())
            {
                // mira el primer nodo de la lista
                

                // si el primer nodo es goal, returns current node
                

                // expande vecinos (calcula coste de cada uno, etc)y los añade en la lista
                

                
                // ordena lista
            }
            return null;
        }

        private float DistanciaManhattan(LinkedListNode<Locomotion.MoveDirection> a, LinkedListNode<Locomotion.MoveDirection>)
        {

        }

        public override void Repath()
        {
            // limpiar Stack 
        }

        public override Locomotion.MoveDirection GetNextMove(BoardInfo board, CellInfo currentPos, CellInfo[] goals)
        {
            // si la Stack no está vacía, hacer siguiente movimiento
            if (currentPlan.Any())
            {
                // devuelve siguiente movimient (pop the Stack)
                currentPlan.Pop();
            }

            // calcular camino, devuelve resultado de A*
            var searchResult = Search(board, currentPos, goals);

            // recorre searchResult and copia el camino a currentPlan
            while (searchResult.Parent != null)
            {
                currentPlan.Push(searchResult.ProducedBy);
                searchResult = searchResult.Parent;
            }

            // returns next move (pop Stack)
            if (currentPlan.Any())
                return currentPlan.Pop();

            return Locomotion.MoveDirection.None;

        }

        
    }
}