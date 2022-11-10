package uninter;

import java.util.Scanner;

public class Principal {
		public static Scanner teclado = new Scanner(System.in);//INPUT TECLADO
	public static void main(String[] args) {
		int res;
		System.out.println("COFRINHO:");//MENU
		System.out.println("1-Adicionar moeda"); 
		System.out.println("2-Remover moeda");
		System.out.println("3-Listar moedas");
		System.out.println("4-Calcular total convertido em Reais");
		System.out.println("0-Encerrar");
		System.out.println("Digite o número com a opção desejada: ");
		
		try {
			res=teclado.nextInt();
			while(res!=0) {//LOOP PARA DIGITAR APENAS OS NÚMERO CORRESPONDENTES
				switch(res) {//ESCOLHA PELOS NÚMEROS DO MENU
				case 1:
					Cofrinho.adicionar();
					break;
				case 2:
					Cofrinho.remover();
					break;
				case 3:
					Cofrinho.listagemMoedas();
					break;
				case 4:
					Cofrinho.totalConvertido();
					break;
				default://SE DIGITAR UM NÚMERO INVÁLIDO
					System.out.println("Opção inválida");
				}
				System.out.println("--------------------------------------------------");
				System.out.println("COFRINHO:");//CHAMADA DO MENU NOVAMENTE
				System.out.println("1-Adicionar moeda"); 
				System.out.println("2-Remover moeda");
				System.out.println("3-Listar moedas");
				System.out.println("4-Calcular total convertido em Reais");
				System.out.println("0-Encerrar");
				System.out.println("--------------------------------------------------");
				System.out.println("Digite o número com a opção desejada: ");
				res=teclado.nextInt();
			}
			if(res == 0) {//MENSAGEM DE ENCERRAMENTO
				System.out.println("Programa encerrado!");
			}
		}
		catch(Exception e) {//TRATAMENTO CASO NÃO DIGITE UM NÚMERO
			System.out.println("Ocorreu um erro, valor não numérico digitado. Programa encerrado!");
		}
	}
}
	