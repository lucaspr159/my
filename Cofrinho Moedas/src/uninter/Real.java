package uninter;

public class Real extends Moeda {
	Real(double n) {
		super(n);
		
	}
	@Override
	void info() {
		System.out.printf("Real: R$%.2f\n",valor);
	}
	@Override
	void converter() {
		valorC = valor;
	}
}
