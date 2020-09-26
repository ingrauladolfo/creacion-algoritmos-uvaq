
package listas_doblemente_ligadas;

public class Listas {
    private Object dato;
    private Listas sig;
    private Listas ant;
    
    public Listas() {
        dato = null;
        sig = null;
        ant = null;
       
    }

    public void InsertarFinal(Object x) {
       int tamanio=tamaño();
       if(tamanio<=0){
            dato = x;            
            sig = new Listas();
            sig.ant=null;
       }else
        if (vacia()) {
            dato = x;
            sig.ant =sig.sig ;
            sig = new Listas();

        } else {
            sig.InsertarFinal(x);
        }
    }

    public boolean vacia() {
        return dato == null && sig == null;
    }

    public String toString() {
        String res = "[" + restosig() + "]";
        return res;
    }

    private String restosig() {
        String res = "";
        if (!vacia()) {
            res = dato.toString();
            if (!sig.vacia()) {
                res = res + ", " + sig.restosig();
            }
        }
        System.out.println(ant);
        return res;
    }

    private String restoant() {
        String res = "";
        if (!vacia()) {
            res = dato.toString();
           if (!ant.vacia()) {
                res = res + "," + sig.ant.restoant();
            
        }
        
    }
        return res;
    }
    public int tamaño() {
        if (vacia()) {
            return 0;
        }
        return 1 + sig.tamaño();
    }

    public boolean buscar(Object x) {
        if (vacia()) {
            return false;
        }
        if (dato.equals(x)) {
            return true;
        }
        return sig.buscar(x);
    }

    public Object obtener(int pos) {
        if (vacia()) {
            return null;
        }
        if (pos == 0) {
            return dato;
        }
        return sig.obtener(pos - 1);
    }

    public void modificar(int pos, Object x) {
        if (vacia() || pos < 0) {
            return;
        }
        if (pos == 0) {
            dato = x;
        } else {
            sig.modificar(pos - 1, x);
        }
    }

    public Object eliminar(Object x) {
        Object res = null;
        if (!vacia()) {
            if (dato.equals(x)) {
                res = dato;
                dato = sig.dato;
                sig = sig.sig;
            } else {
                res = sig.eliminar(x);
            }
        }
        return res;
    }
}
