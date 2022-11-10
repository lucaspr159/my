package uninter;

import java.util.Objects;

abstract public class Moeda {
	double valorC;//VARIÁVEL PARA O VALOR CONVERTIDO EM REAIS
	double valor;//VARIÁVEL COM VALOR DIGITADO
	
	@Override
	public int hashCode() {
		return Objects.hash(valor);
	}
	@Override
	public boolean equals(Object obj) { //COMPARA "VALOR" DENTRO DO ARRAY PARA QUE FUNCIONE O MÉTODO REMOVER
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Moeda other = (Moeda) obj;
		return Double.doubleToLongBits(valor) == Double.doubleToLongBits(other.valor);
	}
	
	Moeda(double n){
		valor = n;
	}
	
	abstract void info();//MÉTODO ABSTRATO QUE FUNCIONA EM QUALQUER MOEDA
	abstract void converter();//MÉTODO ABSTRATO QUE FUNCIONA EM QUALQUER MOEDA

	public double getListaMoedas() {//MÉTODO QUE PEGA O VALOR DO ARRAY CONVERTIDO
		converter();//MÉTODO QUE CONVERTEU CADA MOEDA
		return valorC;//VALOR EM REAIS
	}
}
