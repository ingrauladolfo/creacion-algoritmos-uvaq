/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package listas_doble_ligadas;

/**
 *
 * @author cylin
 */
public class Main {
    public static void main(String[] args){
        ListaGenerica lg=new ListaGenerica();
        lg.insertar (1, 11);
        lg.insertar (2, 10);
        lg.insertar (3, 9);
        lg.insertar (4, 8);
        lg.insertar (5, 7);
        lg.insertar (6, 6);
        lg.insertar (7, 5);
        lg.insertar (8, 4);
        lg.insertar (9, 3);
        lg.insertar (10, 2);
        lg.insertar (11, 1);
        lg.imprimir ();
        System.out.println ("Luego de Borrar el primero");
        lg.borrar (1);
        lg.imprimir ();
        System.out.println ("Luego de Extraer el segundo");
        lg.extraer (2);
        lg.imprimir ();
        System.out.println ("Luego de Intercambiar el primero con el tercero");
        lg.intercambiar(1, 11);
        lg.intercambiar(2,
                10);
        lg.intercambiar(3, 9);
        lg.intercambiar(4, 8);
        lg.intercambiar(5, 7);
        System.out.println("Resultado de la lista:");
        lg.imprimir();
        if (lg.existe(10)) 
            System.out.println("Se encuentra el 10 en la lista");
        else
            System.out.println("No se encuentra el 10 en la lista");
        System.out.println("La posición del mayor es:"+lg.posMayor());
        if (lg.ordenada())
            System.out.println("La lista está ordenada de menor a mayor");
        else
            System.out.println("La lista no está ordenada de menor a mayor");
    }
}