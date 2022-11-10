package uninter;

public class Dolar extends Moeda {
	Dolar(double n) {
		super(n);
	}
	@Override
	void info() {
		System.out.printf("Dólar: $%.2f\n",valor);
	}
	@Override
	void converter() {
		valorC = valor * 5.3;
	}	
}
