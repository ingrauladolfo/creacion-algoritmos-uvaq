import javax.swing.JOptionPane;

public class Factorial_Recursivo
{
	public static int n;
	public static void main(String[] args)
	{
		n = Integer.parseInt(JOptionPane.showInputDialog("Dame un número:\n"));
		System.out.println("El número que ingresaste fue: "+n);
		System.out.println("El resultado es: "+factorial(n));
	}
	public static int factorial(int n)
	{
		if(n == 0)
		{
			return 1;
		}
		else
		{
			return n * factorial(n - 1);
		}
	}
}
