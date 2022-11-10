package uninter;

public class Euro extends Moeda {
	Euro(double n) {
		super(n);
		
	}
	@Override
	void info() {
		System.out.printf("Euro: €%.2f\n",valor);
	}
	@Override
	void converter() {
		valorC = valor * 5;
	}
}
