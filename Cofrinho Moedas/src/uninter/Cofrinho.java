package uninter;

import java.util.ArrayList;

public class Cofrinho {
	static private ArrayList<Moeda> listaMoedas = new ArrayList<Moeda>();//ARRAY COM AS MOEDAS ADICIONADAS
	
	public static void adicionar() {//MÉTODO ADICIONAR MOEDA
		System.out.println("Escolha a moeda que deseja adicionar:");
		System.out.println("1-Dólar: ");
		System.out.println("2-Euro: ");
		System.out.println("3-Real: ");
		
		int a=Principal.teclado.nextInt();//ESCOLHA DA MOEDA PELO SEU RESPECTIVO NÚMERO
		if(a==1) {
			System.out.println("Digite quantos dólares você vai adicionar: ");
			listaMoedas.add(new Dolar(Principal.teclado.nextDouble()));//ADICIONA A MOEDA COM SEU VALOR NO ARRAY
			System.out.println("Valor adicionado com sucesso!");
		}else if(a==2) {
			System.out.println("Digite quantos euros você vai adicionar: ");
			listaMoedas.add(new Euro(Principal.teclado.nextDouble()));
			System.out.println("Valor adicionado com sucesso!");
		}else if(a==3) {
			System.out.println("Digite quantos reais você vai adicionar: ");
			listaMoedas.add(new Real(Principal.teclado.nextDouble()));
			System.out.println("Valor adicionado com sucesso!");
		}else {
			System.out.println("Opção inválida!");
		}
	}
	
	public static void remover() {//MÉTODO REMOVER MOEDA
		System.out.println("Escolha a moeda que deseja remover:");
		System.out.println("1-Dólar: ");
		System.out.println("2-Euro: ");
		System.out.println("3-Real: ");
		
		int a=Principal.teclado.nextInt();//ESCOLHA DA MOEDA PELO SEU RESPECTIVO NÚMERO
		if(a==1) {
			System.out.println("Digite quantos dólares você vai remover: ");
			listaMoedas.remove(new Dolar(Principal.teclado.nextDouble()));//REMOVE A MOEDA COM SEU VALOR DO ARRAY
			System.out.println("Valor removido com sucesso!");
		}else if(a==2) {
			System.out.println("Digite quantos euros você vai remover: ");
			listaMoedas.remove(new Euro(Principal.teclado.nextDouble()));
			System.out.println("Valor removido com sucesso!");
		}else if(a==3) {
			System.out.println("Digite quantos reais você vai remover: ");
			listaMoedas.remove(new Real(Principal.teclado.nextDouble()));
			System.out.println("Valor removido com sucesso!");
		}else {
			System.out.println("Opção inválida!");
		}
	}
	
	public static void listagemMoedas() {//PERCORRE O ARRAY EXIBINDO O MÉTODO "INFO"
		for(Moeda o : listaMoedas) {
			o.info();
		}
	}
	
	public static void totalConvertido() {
		double total = 0;
		for(Moeda m : listaMoedas) {//PERCORRE O ARRAY ADICIONANDO O VALOR QUE JÁ FOI CONVERTIDO
			total += m.getListaMoedas();
		}
		System.out.printf("Valor total convertido em reais de: R$%.2f\n",total);
	}
	
}
